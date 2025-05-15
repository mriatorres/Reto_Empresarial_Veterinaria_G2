using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class RegistrarOtraMascota : Form
    {
        public RegistrarOtraMascota(string idRegistrado)
        {
            // Configuración del formulario
            this.Text = "Registrar otra mascota";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Panel central
            Panel panel = new Panel();
            panel.Size = new Size(350, 200);
            panel.Location = new Point((this.Width - panel.Width) / 2, 30);
            panel.BackColor = Color.LightGray;
            this.Controls.Add(panel);

            // Etiqueta de mensaje
            Label messageLabel = new Label();
            messageLabel.Text = $"El ID de la mascota es {idRegistrado}\n¿Desea registrar otra mascota?";
            messageLabel.Font = new Font("Inter", 12);
            messageLabel.Location = new Point(20, 20);
            messageLabel.AutoSize = true;
            panel.Controls.Add(messageLabel);

            // Botón "Sí"
            Button btnSi = new Button();
            btnSi.Text = "Sí";
            btnSi.Size = new Size(100, 40);
            btnSi.BackColor = Color.FromArgb(23, 124, 116);
            btnSi.ForeColor = Color.White;
            btnSi.Location = new Point(50, 100);
            btnSi.Click += (s, e) => {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            };
            panel.Controls.Add(btnSi);

            // Botón "No"
            Button btnNo = new Button();
            btnNo.Text = "No";
            btnNo.Size = new Size(100, 40);
            btnNo.BackColor = Color.FromArgb(23, 124, 116);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(200, 100);
            btnNo.Click += (s, e) => {
                // Volver al Dashboard al presionar "No"
                this.Close();
                DashboardRecepcion dashboard = new DashboardRecepcion();
                dashboard.ShowDialog();
            };
            panel.Controls.Add(btnNo);
        }
    }
}
