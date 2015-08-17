using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace newRobotApp
{
    public partial class PortUC : UserControl
    {
        public SerialPort port;
        private string output;

        public PortUC(SerialPort port, int xOffset, int yOffset, string name)
        {
            this.Location = new System.Drawing.Point(xOffset, yOffset);
            this.Name = name;
            this.Size = new System.Drawing.Size(344, 35);
            this.TabIndex = 0;

            InitializeComponent();

            openBtn.Enabled = true;
            closeBtn.Enabled = false;
            sendBtn.Enabled = false;


            this.port = port;

            string[] bauds = { "115200", "57600", "38400", "19200", "9600" };

            foreach (string baud in bauds)
            {
                cmbBaudSelect.Items.Add(baud);
            }
            cmbBaudSelect.Text = bauds[0];
            // Nice methods to browse all available ports:
            string[] ports = SerialPort.GetPortNames();

            // Add all port names to the combo box:
            foreach (string p in ports)
            {
                cmbComSelect.Items.Add(p);
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        {
            if (port.IsOpen) 
                port.Close();
            
            port.PortName = cmbComSelect.SelectedItem.ToString();

            if (port.PortName.Contains("w"))
                port.PortName = port.PortName.Replace("w", null);

            // try to open the selected port:
            try
            {
                port.Open();
                port.ReadTimeout = 50;
                
            }
            // give a message, if the port is not available:
            catch(Exception ex)
            {
                MessageBox.Show("Serial port " + port.PortName + " cannot be opened! " + ex.ToString(), "RS232 tester", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbComSelect.SelectedText = "";
            }

            if (port.IsOpen)
            {
                openBtn.Enabled = false;
                closeBtn.Enabled = true;
                sendBtn.Enabled = true;
                cmbComSelect.Enabled = false;
                cmbBaudSelect.Enabled = false;

            }

        }

        private void closePort_Click(object sender, EventArgs e)
        {
            // Close our device
            try
            {
                port.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't close the port!" + ex.ToString());
            }

            if (!port.IsOpen)
            {
                openBtn.Enabled = true;
                closeBtn.Enabled = false;
                cmbBaudSelect.Enabled = true;
                cmbComSelect.Enabled = true;
            }

        }

        delegate void SetTextCallback(string text, Control cont);
        private void SetText(string text, Control cont)
        {
            if (cont.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else cont.Text = text;
        }

        public void SetOutputText(string text)
        {
            SetText(text, outputTextBox);       
        }

        public void SetInputText(string text)
        {
            SetText(text, inputTextbox);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine(output);
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.output = outputTextBox.Text + "\r";
            }
            catch
            {
                outputTextBox.Clear();
            }
        }

    }
}
