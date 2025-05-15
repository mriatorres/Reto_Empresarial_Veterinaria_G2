using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Veterinario
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int cornerRadius = 20; // Fixed corner radius
            GraphicsPath path = new GraphicsPath();
            // Create a rounded rectangle path (pill shape)
            path.StartFigure();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(cornerRadius, 0, this.Width - cornerRadius, 0);
            path.AddArc(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddLine(this.Width, cornerRadius, this.Width, this.Height - cornerRadius);
            path.AddArc(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddLine(this.Width - cornerRadius, this.Height, cornerRadius, this.Height);
            path.AddArc(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.AddLine(0, this.Height - cornerRadius, 0, cornerRadius);
            path.CloseFigure();
            this.Region = new Region(path);
            // Optional: Draw button background with anti aliasing for smoother look
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }
            // Draw text centered
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
