using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color ShadowColor { get; set; } = Color.FromArgb(50, 0, 0, 0); // Semi-transparent black
        public int ShadowOffset { get; set; } = 5; // Offset for the shadow

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create the rounded rectangle path
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();

                // Draw the shadow
                using (SolidBrush shadowBrush = new SolidBrush(ShadowColor))
                {
                    g.FillPath(shadowBrush, new GraphicsPath(path.PathPoints, path.PathTypes));
                }

                // Draw the panel background
                g.FillPath(Brushes.White, path); // Fill color
                g.DrawPath(Pens.White, path); // Border color
            }
        }
    }
}
