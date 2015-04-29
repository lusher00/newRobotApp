using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace newRobotApp
{
    public partial class ArtificialHorizon : UserControl
    {
        Bitmap horizon = new Bitmap(newRobotApp.Properties.Resources.horizon);
        Bitmap bezel = new Bitmap(newRobotApp.Properties.Resources.bezel);
        Bitmap heading = new Bitmap(newRobotApp.Properties.Resources.heading);
        Bitmap wings = new Bitmap(newRobotApp.Properties.Resources.wings);

        Point ptBoule = new Point(-25, -210); //Ground-Sky initial location
        Point ptHeading = new Point(-592, 150); // Heading ticks
        Point ptRotation = new Point(150, 150); // Point of rotation

        public double PitchAngle { get; set; } 

        public ArtificialHorizon(int xOffset, int yOffset, string name)
        {
            this.Location = new System.Drawing.Point(xOffset, yOffset);
            this.Name = name;
            this.Size = new System.Drawing.Size(500, 500);
            this.TabIndex = 0;

            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.ResizeRedraw, true);

            bezel.MakeTransparent(Color.Yellow); // Sets image transparency
            heading.MakeTransparent(Color.Black); // Sets image transparency
            wings.MakeTransparent(Color.Yellow); // Sets image transparency

            PitchAngle = 0.0;
        }

        public void setPitchAngle(double pitchAngle)
        {
            PitchAngle = pitchAngle;
            this.Invalidate();
            //this.Update();
        }

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Calling the base class OnPaint
            base.OnPaint(paintEvnt);

            


            // Clipping mask for Attitude Indicator
            //paintEvnt.Graphics.Clip = new Region(new Rectangle(this.Location.X, this.Location.Y, this.Location.X+300, this.Location.Y+300));
            paintEvnt.Graphics.Clip = new Region(new Rectangle(0, 0, 300, 300));
            paintEvnt.Graphics.FillRegion(Brushes.Black, paintEvnt.Graphics.Clip);


            // Make sure lines are drawn smoothly
            paintEvnt.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            // Create the graphics object
            Graphics gfx = paintEvnt.Graphics;

            // Adjust and draw horizon image
            RotateAndTranslate(paintEvnt, horizon, 0, 0, ptBoule, (double)(4 * PitchAngle), ptRotation, 1);

            RotateAndTranslate2(paintEvnt, heading, 0, 0, 0, ptHeading, (double)(4 * PitchAngle), ptRotation, 1);



            gfx.DrawImage(bezel, 0, 0); // Draw bezel image
            gfx.DrawImage(wings, 75, 125); // Draw wings image
        }

        protected void RotateAndTranslate(PaintEventArgs pe, Image img, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta)));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            //pe.Graphics.DrawImage(
            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }
        protected void RotateAndTranslate2(PaintEventArgs pe, Image img, Double yawRot, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta) + yawRot));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }
 
    }
}
