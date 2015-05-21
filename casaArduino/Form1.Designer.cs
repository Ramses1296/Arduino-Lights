namespace casaArduino
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.botonPuertos = new System.Windows.Forms.Button();
            this.comboPuertos = new System.Windows.Forms.ComboBox();
            this.comboBoxLuces = new System.Windows.Forms.ComboBox();
            this.buttonLuz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonPuertos
            // 
            this.botonPuertos.Location = new System.Drawing.Point(249, 34);
            this.botonPuertos.Name = "botonPuertos";
            this.botonPuertos.Size = new System.Drawing.Size(149, 23);
            this.botonPuertos.TabIndex = 0;
            this.botonPuertos.Text = "Traer Puertos";
            this.botonPuertos.UseVisualStyleBackColor = true;
            this.botonPuertos.Click += new System.EventHandler(this.botonPuertos_Click);
            // 
            // comboPuertos
            // 
            this.comboPuertos.FormattingEnabled = true;
            this.comboPuertos.Location = new System.Drawing.Point(38, 34);
            this.comboPuertos.Name = "comboPuertos";
            this.comboPuertos.Size = new System.Drawing.Size(181, 21);
            this.comboPuertos.TabIndex = 1;
            // 
            // comboBoxLuces
            // 
            this.comboBoxLuces.FormattingEnabled = true;
            this.comboBoxLuces.Items.AddRange(new object[] {
            "Cocina",
            "Sala",
            "Comedor",
            "Habitación 1",
            "Habitación 2",
            "Baño",
            "Jardín",
            "Entrada"});
            this.comboBoxLuces.Location = new System.Drawing.Point(38, 90);
            this.comboBoxLuces.Name = "comboBoxLuces";
            this.comboBoxLuces.Size = new System.Drawing.Size(181, 21);
            this.comboBoxLuces.TabIndex = 2;
            this.comboBoxLuces.Text = "Selecciona una habitación";
            this.comboBoxLuces.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonLuz
            // 
            this.buttonLuz.Location = new System.Drawing.Point(249, 90);
            this.buttonLuz.Name = "buttonLuz";
            this.buttonLuz.Size = new System.Drawing.Size(149, 23);
            this.buttonLuz.TabIndex = 3;
            this.buttonLuz.Text = "Encender / Apagar";
            this.buttonLuz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLuz);
            this.Controls.Add(this.comboBoxLuces);
            this.Controls.Add(this.comboPuertos);
            this.Controls.Add(this.botonPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button botonPuertos;
        private System.Windows.Forms.ComboBox comboPuertos;
        private System.Windows.Forms.ComboBox comboBoxLuces;
        private System.Windows.Forms.Button buttonLuz;
        private System.Windows.Forms.Label label1;
    }
}

