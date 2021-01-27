namespace SerialPort
{
    partial class SerialPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarPuertosbutton = new System.Windows.Forms.Button();
            this.PuertoscomboBox = new System.Windows.Forms.ComboBox();
            this.Conectarbutton = new System.Windows.Forms.Button();
            this.VelocidadcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosEnviartextBox = new System.Windows.Forms.TextBox();
            this.EnviarDatosbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosRecibidostextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CHR13checkBox = new System.Windows.Forms.CheckBox();
            this.CapturarPesobutton = new System.Windows.Forms.Button();
            this.DatosLeidostextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidad";
            // 
            // BuscarPuertosbutton
            // 
            this.BuscarPuertosbutton.Location = new System.Drawing.Point(9, 12);
            this.BuscarPuertosbutton.Name = "BuscarPuertosbutton";
            this.BuscarPuertosbutton.Size = new System.Drawing.Size(97, 23);
            this.BuscarPuertosbutton.TabIndex = 1;
            this.BuscarPuertosbutton.Text = "Buscar Puertos";
            this.BuscarPuertosbutton.UseVisualStyleBackColor = true;
            this.BuscarPuertosbutton.Click += new System.EventHandler(this.BuscarPuertosbutton_Click);
            // 
            // PuertoscomboBox
            // 
            this.PuertoscomboBox.FormattingEnabled = true;
            this.PuertoscomboBox.Location = new System.Drawing.Point(120, 42);
            this.PuertoscomboBox.Name = "PuertoscomboBox";
            this.PuertoscomboBox.Size = new System.Drawing.Size(149, 21);
            this.PuertoscomboBox.TabIndex = 2;
            // 
            // Conectarbutton
            // 
            this.Conectarbutton.Location = new System.Drawing.Point(430, 41);
            this.Conectarbutton.Name = "Conectarbutton";
            this.Conectarbutton.Size = new System.Drawing.Size(116, 23);
            this.Conectarbutton.TabIndex = 1;
            this.Conectarbutton.Text = "Conectar";
            this.Conectarbutton.UseVisualStyleBackColor = true;
            this.Conectarbutton.Click += new System.EventHandler(this.Conectarbutton_Click);
            // 
            // VelocidadcomboBox
            // 
            this.VelocidadcomboBox.FormattingEnabled = true;
            this.VelocidadcomboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "15200"});
            this.VelocidadcomboBox.Location = new System.Drawing.Point(275, 42);
            this.VelocidadcomboBox.Name = "VelocidadcomboBox";
            this.VelocidadcomboBox.Size = new System.Drawing.Size(149, 21);
            this.VelocidadcomboBox.TabIndex = 2;
            this.VelocidadcomboBox.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos a Enviar";
            // 
            // DatosEnviartextBox
            // 
            this.DatosEnviartextBox.Location = new System.Drawing.Point(120, 69);
            this.DatosEnviartextBox.Name = "DatosEnviartextBox";
            this.DatosEnviartextBox.Size = new System.Drawing.Size(149, 20);
            this.DatosEnviartextBox.TabIndex = 3;
            // 
            // EnviarDatosbutton
            // 
            this.EnviarDatosbutton.Location = new System.Drawing.Point(275, 68);
            this.EnviarDatosbutton.Name = "EnviarDatosbutton";
            this.EnviarDatosbutton.Size = new System.Drawing.Size(116, 23);
            this.EnviarDatosbutton.TabIndex = 1;
            this.EnviarDatosbutton.Text = "Enviar Datos";
            this.EnviarDatosbutton.UseVisualStyleBackColor = true;
            this.EnviarDatosbutton.Click += new System.EventHandler(this.EnviarDatosbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Puertos Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datos Recibidos";
            // 
            // DatosRecibidostextBox
            // 
            this.DatosRecibidostextBox.AcceptsReturn = true;
            this.DatosRecibidostextBox.Location = new System.Drawing.Point(9, 129);
            this.DatosRecibidostextBox.Multiline = true;
            this.DatosRecibidostextBox.Name = "DatosRecibidostextBox";
            this.DatosRecibidostextBox.Size = new System.Drawing.Size(537, 153);
            this.DatosRecibidostextBox.TabIndex = 4;
            // 
            // CHR13checkBox
            // 
            this.CHR13checkBox.AutoSize = true;
            this.CHR13checkBox.Checked = true;
            this.CHR13checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHR13checkBox.Location = new System.Drawing.Point(430, 73);
            this.CHR13checkBox.Name = "CHR13checkBox";
            this.CHR13checkBox.Size = new System.Drawing.Size(74, 17);
            this.CHR13checkBox.TabIndex = 5;
            this.CHR13checkBox.Text = "Enviar CR";
            this.CHR13checkBox.UseVisualStyleBackColor = true;
            // 
            // CapturarPesobutton
            // 
            this.CapturarPesobutton.Location = new System.Drawing.Point(430, 103);
            this.CapturarPesobutton.Name = "CapturarPesobutton";
            this.CapturarPesobutton.Size = new System.Drawing.Size(114, 23);
            this.CapturarPesobutton.TabIndex = 6;
            this.CapturarPesobutton.Text = "Capturar Peso";
            this.CapturarPesobutton.UseVisualStyleBackColor = true;
            this.CapturarPesobutton.Click += new System.EventHandler(this.CapturarPesobutton_Click);
            // 
            // DatosLeidostextBox
            // 
            this.DatosLeidostextBox.AcceptsReturn = true;
            this.DatosLeidostextBox.Location = new System.Drawing.Point(8, 288);
            this.DatosLeidostextBox.Multiline = true;
            this.DatosLeidostextBox.Name = "DatosLeidostextBox";
            this.DatosLeidostextBox.Size = new System.Drawing.Size(537, 153);
            this.DatosLeidostextBox.TabIndex = 7;
            // 
            // SerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 448);
            this.Controls.Add(this.DatosLeidostextBox);
            this.Controls.Add(this.CapturarPesobutton);
            this.Controls.Add(this.CHR13checkBox);
            this.Controls.Add(this.DatosRecibidostextBox);
            this.Controls.Add(this.DatosEnviartextBox);
            this.Controls.Add(this.VelocidadcomboBox);
            this.Controls.Add(this.PuertoscomboBox);
            this.Controls.Add(this.EnviarDatosbutton);
            this.Controls.Add(this.Conectarbutton);
            this.Controls.Add(this.BuscarPuertosbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarPuertosbutton;
        private System.Windows.Forms.ComboBox PuertoscomboBox;
        private System.Windows.Forms.Button Conectarbutton;
        private System.Windows.Forms.ComboBox VelocidadcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DatosEnviartextBox;
        private System.Windows.Forms.Button EnviarDatosbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatosRecibidostextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox CHR13checkBox;
        private System.Windows.Forms.Button CapturarPesobutton;
        private System.Windows.Forms.TextBox DatosLeidostextBox;
    }
}

