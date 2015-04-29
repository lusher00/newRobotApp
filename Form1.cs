﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections;


namespace newRobotApp
{
    public partial class Form1 : Form
    {

        SerialPort port;
        protected Thread pThreadRead;
        string InputData = String.Empty;
        string[] ParsedData = null;
        PortUC portControl;
        ParameterUC p, i, d, ang, c;
        ArtificialHorizon artificalHorizon;
        

        Queue myQueue = new Queue();
        public Form1()
        {
            port = new SerialPort();

        
            portControl = new PortUC(port, 10, 10, "portControl");
            this.Controls.Add(portControl);

            p = new ParameterUC(portControl, 10, 150, "p", 1.0);
            this.Controls.Add(p);
            i = new ParameterUC(portControl, 10, 185, "i", 0.1);
            this.Controls.Add(i);
            d = new ParameterUC(portControl, 10, 220, "d", 0.1);
            this.Controls.Add(d);
            ang = new ParameterUC(portControl, 10, 255, "ang", 0.1);
            this.Controls.Add(ang);
            c = new ParameterUC(portControl, 10, 290, "c", 0.01);
            this.Controls.Add(c);
            
            artificalHorizon = new ArtificialHorizon(400, 10, "artificalHorizon");
            this.Controls.Add(artificalHorizon);

        
            InitializeComponent();

            // This bit of code (using double buffer) reduces flicker from Refresh commands
            /*
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            */
            //////////// END "reduce flicker" code ///////

            pThreadRead = new Thread(new ThreadStart(ReadThread));
            pThreadRead.Start();
            
        }

        private void ReadThread()
        {

            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                if (port.IsOpen == true)
                {

                    try 
                    { 
                        InputData = port.ReadLine();
                        portControl.SetInputText(InputData);
                        myQueue.Enqueue(InputData);
                    }
                    catch 
                    { 
                        continue; 
                    }

                    /*
                    if (logging_checkBox.Checked)
                    {
                        try
                        {
                            fileStream.Write(uniEncoding.GetBytes(InputData), 0, uniEncoding.GetByteCount(InputData));
                        }
                        catch { }
                    }
                    */

                    ParsedData = InputData.Split(';');

                    switch (ParsedData[0])
                    {
                        case "DBG":
                            break;

                        case "PARAMS":
                            break;

                        case "UPDATE":
                            //artificalHorizon.PitchAngle = Convert.ToDouble(ParsedData[2]);
                            artificalHorizon.setPitchAngle(Convert.ToDouble(ParsedData[2]) + 90.0);
                            
                            
                            break;

                        default:
                            break;
                    }

                    Invalidate();

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pThreadRead.Abort();
            //if (port.IsOpen == true) port.Close();
        }

        
        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Calling the base class OnPaint
            base.OnPaint(paintEvnt);

           
        }
        
    }
}
