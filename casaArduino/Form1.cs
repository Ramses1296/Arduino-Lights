using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace casaArduino 
{    
    public partial class Form1 : Form
    {
        String habitacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonPuertos_Click(object sender, EventArgs e)
        {
            String[] puertos = System.IO.Ports.SerialPort.GetPortNames();

            comboPuertos.Items.Clear();
            foreach (String pto in puertos)
            {
                comboPuertos.Items.Add(pto);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            habitacion = comboBoxLuces.SelectedItem.ToString();
            label1.Text = habitacion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
