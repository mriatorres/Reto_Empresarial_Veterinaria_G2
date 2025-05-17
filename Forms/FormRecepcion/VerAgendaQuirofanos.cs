using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class VerAgendaQuirofanos : FormBaseRec
    {
        public VerAgendaQuirofanos() : base("Veterinaria La Mascota")
        {
            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Consultar disponibilidad de quirófanos";
            panelTitle.Font = new Font("Inter", 22, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 80);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Etiqueta de disponibilidad
            Label infoLabel = new Label();
            infoLabel.Text = "Disponibilidad de quirófanos";
            infoLabel.Font = new Font("Inter", 16, FontStyle.Bold);
            infoLabel.ForeColor = Color.FromArgb(23, 124, 116);
            infoLabel.Location = new Point(20, 20);
            infoLabel.AutoSize = true;
            contentPanel.Controls.Add(infoLabel);

            // Crear un calendario para la disponibilidad
            MonthCalendar calendario = new MonthCalendar();
            calendario.Location = new Point((contentPanel.Width - calendario.Width) / 2, 60);
            calendario.MaxSelectionCount = 1;
            contentPanel.Controls.Add(calendario);

            // Botón para consultar la disponibilidad de quirófanos
            Button btnConsultarDisponibilidad = new Button();
            btnConsultarDisponibilidad.Text = "Consultar disponibilidad de quirófanos";
            btnConsultarDisponibilidad.Size = new Size(380, 50);
            btnConsultarDisponibilidad.BackColor = Color.FromArgb(23, 124, 116);
            btnConsultarDisponibilidad.ForeColor = Color.White;
            btnConsultarDisponibilidad.Font = new Font("Inter", 14);
            btnConsultarDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnConsultarDisponibilidad.FlatAppearance.BorderSize = 0;
            btnConsultarDisponibilidad.Location = new Point((contentPanel.Width - btnConsultarDisponibilidad.Width) / 2, 260);
            contentPanel.Controls.Add(btnConsultarDisponibilidad);

            // Evento para el botón de consultar
            btnConsultarDisponibilidad.Click += (s, e) => MessageBox.Show("Disponibilidad de quirófanos verificada.", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> c1b130b3a22383bb3ed03181cf86479fc4ef85ec
