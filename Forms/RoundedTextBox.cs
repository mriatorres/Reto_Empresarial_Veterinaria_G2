using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms
{
    
    public class RoundedTextBox : TextBox
    {
        private int borderRadius = 20;
        private int borderSize = 4;
        private Color borderColor = Color.MediumSlateBlue;

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.White; // Set the background color to white
            this.Resize += RoundedTextBox_Resize;
        }

        private void RoundedTextBox_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Padding = new Padding(borderSize);
                    this.Invalidate();
                }
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            Rectangle rectBorder = this.ClientRectangle;
            rectBorder.Width -= 1;
            rectBorder.Height -= 1;

            using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, borderRadius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Redraw border on any paint message.
            if (m.Msg == 0xF || m.Msg == 0x133) // WM_PAINT or WM_NCPAINT
                this.Invalidate();
        }
    }


}
