using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;


namespace SerialPort
{
    public partial class SerialPort : Form
    {
        private string strBufferIn;
        private string strBufferOut;
        List<string> pesosLeidos;

        private delegate void DelegateAcceso(string acccion);

        #region "Eventos Controles"

        public SerialPort()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void BuscarPuertosbutton_Click(object sender, EventArgs e)
        {
            string[] puertosDisponibles = System.IO.Ports.SerialPort.GetPortNames();
            PuertoscomboBox.Items.Clear();

            foreach (string puerto in puertosDisponibles)
            {
                PuertoscomboBox.Items.Add(puerto);
            }

            if (PuertoscomboBox.Items.Count > 0)
            {
                PuertoscomboBox.SelectedIndex = 0;
                Conectarbutton.Enabled = true;
            }
            else
            {
                PuertoscomboBox.Text = string.Empty;
                PuertoscomboBox.Items.Clear();
                Inicializar();
            }
        }

        private void Conectarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conectarbutton.Text == "Conectar")
                {
                    serialPort1.BaudRate = int.Parse(VelocidadcomboBox.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = PuertoscomboBox.Text;

                    try
                    {
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                        serialPort1.Open();
                        Conectarbutton.Text = "Desconectar";
                        EnviarDatosbutton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} {ex.InnerException}");
                    }

                }
                else
                {
                    serialPort1.Close();
                    Conectarbutton.Text = "Conectar";
                    EnviarDatosbutton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException}");
            }
        }

        private void EnviarDatosbutton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.DiscardOutBuffer();
                strBufferOut = DatosEnviartextBox.Text + (CHR13checkBox.Checked ? "\r" : "");
                serialPort1.Write(strBufferOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException}");
            }
        }

        private void CapturarPesobutton_Click(object sender, EventArgs e)
        {
            bool swLecturasIguales = false;
            string lecturaOK = string.Empty;

            InicializarPesosLeidos();
            while (!swLecturasIguales)
            {
                string[] capturas = DatosRecibidostextBox.Text.Split(' ');
                InicializarPesosLeidos();
                foreach (string captura in capturas)
                {
                    if (captura.Length > 0)
                    {
                        int pos = captura.IndexOf("kg\r\u0003\n");
                        if (pos > 0)
                        {
                            pesosLeidos.Add(captura.Substring(0, pos));
                        }
                    }
                }

                //Verifico que todas las las lecturas sean iguales
                if (pesosLeidos.Count > 0)
                {
                    bool swIguales = true;
                    lecturaOK = pesosLeidos[0];
                    DatosLeidostextBox.Text = string.Empty;
                    foreach (var lectura in pesosLeidos)
                    {
                        DatosLeidostextBox.Text = DatosLeidostextBox.Text + lectura;
                        if (lecturaOK != lectura)
                        {
                            lecturaOK = string.Empty;
                            swIguales = false;
                        }
                    }

                    MessageBox.Show("Datos Leidos");
                    if (swIguales) swLecturasIguales = true;

                }

            }

            if (!string.IsNullOrEmpty(lecturaOK)) {
                MessageBox.Show($"Lectura: {lecturaOK}");
            }

        }


        #endregion

        #region "Metodos"

        private void InicializarPesosLeidos()
        {
            if (pesosLeidos != null) pesosLeidos.Clear();
            pesosLeidos = new List<string>();
        }

        private void Inicializar()
        {
            strBufferIn = string.Empty;
            strBufferOut = string.Empty;
            Conectarbutton.Enabled = false;
            EnviarDatosbutton.Enabled = false;
            serialPort1 = new System.IO.Ports.SerialPort();
        }


        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Enabled)
            {
                Thread.Sleep(500);
                if (serialPort1.IsOpen)
                {
                    string data = serialPort1.ReadExisting();
                    this.BeginInvoke(new DelegateAcceso(hay_DatosParaRecibir), new object[] { data });
                }
            }
        }

        private void hay_DatosParaRecibir(string accion)
        {
            DatosRecibidostextBox.Text = accion;
        }


        #endregion

    }
}
