using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms
{
    public class RoundedPanelColored : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#0E7C82");
        public int BorderThickness { get; set; } = 2;
        public Color FillColor { get; set; } = Color.White;

        public RoundedPanelColored()
        {
            this.DoubleBuffered = true;
            this.Resize += RoundedPanel_Resize;
            UpdateRegion();
        }

        private void RoundedPanel_Resize(object sender, EventArgs e)
        {
            UpdateRegion();
            this.Invalidate();
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.StartFigure();
            // Top-left arc
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Top line and top-right arc
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Right line and bottom-right arc
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Bottom line and bottom-left arc
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void UpdateRegion()
        {
            Rectangle rect = this.ClientRectangle;
            // Reduce rect size by half border thickness to make sure border fits inside
            rect.Inflate(-BorderThickness / 2, -BorderThickness / 2);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
            {
                this.Region?.Dispose(); // Dispose old region if any
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-BorderThickness / 2, -BorderThickness / 2);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(FillColor))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}

