using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace Practica8
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new SerialPort();
            ArduinoPort.PortName = "COM4";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 500;
            ArduinoPort.WriteTimeout = 500;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.btncon.Click += btncon_Click;

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato= ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }
        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);

                }
                catch { }
            else
                lblmedtemp.Text = dato;
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            btndes.Enabled = true;
            try
            {

                try
                {
                    if (!ArduinoPort.IsOpen)
                    {
                        ArduinoPort.Open();
                    }
                    if (int.TryParse(textBox1.Text, out int temperatureLimit))
                    {
                        //Convierte el valor a una cadena y luego un arreglo de bytes
                        string limString = temperatureLimit.ToString();
                        ArduinoPort.Write(limString);
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un valor numerico valiudo en el textbox del limite de la temperatura");
                    }
                    lblcon.Text = "Conexion Ok";
                    lblcon.ForeColor = System.Drawing.Color.Lime;
                }
                catch
                {
                    MessageBox.Show("Configure el puerto de comunicación correcto o desconecte");
                }

            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicación correcto o desconecte");
            }

        }

        private void btndes_Click(object sender, EventArgs e)
        {
            btncon.Enabled = true;
            btndes.Enabled = false;
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
            lblcon.Text = "Desconectado";
            lblcon.ForeColor = System.Drawing.Color.Lime;
            lblmedtemp.Text = "0.0";

        }
    }
}
