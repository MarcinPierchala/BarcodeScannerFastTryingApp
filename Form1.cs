using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerFastTryingApp
{
    public partial class Form1 : Form
    {
        SerialPort comPort = new SerialPort();
        bool comPortOpen = false;
        string selectedPortComNumber = "";
        string scannedData = "";
        string[] comNumbers = {"COM1", "COM2", "COM3", "COM4", "COM5",
                              "COM6", "COM7", "COM8", "COM9", "COM10"};
        public Form1()
        {
            InitializeComponent();
            foreach (string com in comNumbers)
            {
                this.comboBox_COM_PORT_SELECTOR.Items.Add(com);
                this.comboBox_COM_PORT_SELECTOR.SelectedIndex = -1;
            }
            
            //UserInitialization();
        }

        public void UserInitialization()
        {
            //try
            //{
                //comPort.PortName = selectedPortComNumber;
                //comPort.BaudRate = 9600;
                //comPort.Parity = Parity.None;
                //comPort.DataBits = 8;
                //comPort.StopBits = StopBits.One;

                //comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceviedHandler);

                //if (comPortOpen)
                //{
                //    try
                //    {
                //        comPort.Open();
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Wybrano nieaktywny COM PORT\nWybierz poprawny port\ni ponownie naciśnij OTWÓRZ PORT");

                //    } 
                //    this.tb_01.Text = scannedData;
                //    comPort.Close();
                //}

                //else if (!comPortOpen)
                //{
                //    comPort.Close();
                //}
                
            //}
            //catch
            //{
            //    MessageBox.Show("Nie Wybrano żadnego numeru COM PORT");
            //}
            
             
            
            
        }
        public void ButtonClicked(object sender, EventArgs e)
        {
            if (sender == button1 && !comPortOpen)
            {
                comboBox_COM_PORT_SELECTOR.Enabled = false;
                textBox_BAUD_RATE.Enabled = false;
                textBox_DATA_BITS.Enabled = false;
                textBox_PARITY.Enabled = false;
                textBox_STOP_BITS.Enabled = false;
                comPortOpen = true;
                try
                {
                    comPort.PortName = selectedPortComNumber;
                }
                catch
                {
                    MessageBox.Show("Nie Wybrano żadnego numeru COM PORT\nnaciśnij CLOSE_COM_PORT i spróbuj ponownie");
                    return;
                }
                
                comPort.BaudRate = 9600;
                comPort.Parity = Parity.None;
                comPort.DataBits = 8;
                comPort.StopBits = StopBits.One;

                comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceviedHandler);

                try
                {
                    comPort.Open();
                }
                catch
                {
                    MessageBox.Show(this, "Wybrano nieaktywny COM PORT\nWybierz poprawny port\ni ponownie naciśnij OTWÓRZ PORT");
                    return;

                }
                                
            }
            else if (sender == button2 && comPortOpen)
            {
                comboBox_COM_PORT_SELECTOR.Enabled = true;
                textBox_BAUD_RATE.Enabled = true;
                textBox_DATA_BITS.Enabled = true;
                textBox_PARITY.Enabled = true;
                textBox_STOP_BITS.Enabled = true;
                comPortOpen = false;
                comPort.Close();
            }

        }

        public void DataReceviedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort comPortSender = (SerialPort)sender;
            //comPort = (SerialPort)sender;
            System.Threading.Thread.Sleep(1000);
            scannedData = comPort.ReadExisting();
            System.Threading.Thread.Sleep(200);
            string s = "[STX]";
            string f = "[ETX]";

            foreach (char c in scannedData)
            {
                if ((int)c == 2)
                {
                    scannedData = scannedData.Replace(c.ToString(), s);
                }
                if ((int)c == 3)
                {
                    scannedData = scannedData.Replace(c.ToString(), f);
                }
            }
            var threadParameters = new System.Threading.ThreadStart(delegate { SetText(scannedData); });
            var thread2 = new System.Threading.Thread(threadParameters);
            thread2.Start();
        }

        public void SetText(string scannData)
        {
            if (tb_01.InvokeRequired)
            {
                Action addNewText = delegate { SetText(scannData); };
                tb_01.Invoke(addNewText);
            }
            else
            {
                tb_01.Text += scannedData;
            }
        }

        private void comboBox_COM_PORT_SELECTOR_index_changed(object sender, EventArgs e)
        {
            selectedPortComNumber = comboBox_COM_PORT_SELECTOR.Text;
            //UserInitialization();
        }

        private void About_click(object sender, EventArgs e)
        {
            MessageBox.Show("Fast Version 1.1\nAuthor: Marcin Pierchała\nemail: marcin.pierchala@icloud.com");
        }

        private void Manual_click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Select Com Port number and optional input other params\n2. Push OPEN_COM_PORT\n3. Scann Any Barcode\n4. After job or 2 change Serial Port settings push CLOSE_COM_PORT");
        }

        private void Exit_click(object sender, EventArgs e)
        {
            comPort.Close();
            this.Close();
        }
    }
}
