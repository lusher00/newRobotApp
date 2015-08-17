using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace newRobotApp
{
    public partial class ParameterUC : UserControl
    {
        public double value { get; set; }
        private double incrementValue;
        private SerialPort port;
        private PortUC portControl;
        private string command;

        public ParameterUC(PortUC portControl, int xOffset, int yOffset, string name, double increment)
        {
            this.Location = new System.Drawing.Point(xOffset, yOffset);
            this.Name = name;
            this.Size = new System.Drawing.Size(344, 35);
            this.TabIndex = 0;

            InitializeComponent();

            
            this.label.Text = name;
            this.command = name;

            this.portControl = portControl;
            this.port = portControl.port;
            this.incrementValue = increment;
            this.incrementTextBox.Text = increment.ToString();
            
        }

        private string buildOutput()
        {
            string output = this.command + "!;" + value.ToString() + "\r";

            return output;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            string output = buildOutput();
            if (port.IsOpen == true)
            {
                port.WriteLine(output);
                portControl.SetOutputText(output);
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                value += Convert.ToDouble(incrementTextBox.Text); 
            }
            catch 
            { 
            
            }
            SetText(value.ToString(), textBox);
            if (checkbox.Checked)
            {
                if (port.IsOpen == true)
                    port.WriteLine(buildOutput());
            }

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                value -= Convert.ToDouble(incrementTextBox.Text);
            }
            catch
            {

            }
            SetText(value.ToString(), textBox);
            if (checkbox.Checked)
            {
                if (port.IsOpen == true)
                    port.WriteLine(buildOutput());
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox.Text);
            }
            catch
            {
                textBox.Clear();
            }

        }

        private void incrementTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                incrementValue = Convert.ToDouble(incrementTextBox.Text);
            }
            catch
            {
                incrementTextBox.Clear();
            }
        }

        delegate void SetTextCallback(string text, Control cont);
        private void SetText(string text, Control cont)
        {
            if (cont.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, cont });
            }
            else cont.Text = text;
        }

        public void SetValue(string val)
        {
            value = Convert.ToDouble(val);
            SetText(val, textBox);
        }

    }
}
