using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class VerAgendaConsultorios : FormBaseRec
    {
        private MonthCalendar calendario;

        public VerAgendaConsultorios() : base("Veterinaria La Mascota")
        {
            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Consultar disponibilidad de consultorios";
            panelTitle.Font = new Font("Inter", 22, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 80);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Etiqueta de disponibilidad
            Label infoLabel = new Label();
            infoLabel.Text = "Disponibilidad de consultorios";
            infoLabel.Font = new Font("Inter", 16, FontStyle.Bold);
            infoLabel.ForeColor = Color.FromArgb(23, 124, 116);
            infoLabel.Location = new Point(20, 20);
            infoLabel.AutoSize = true;
            contentPanel.Controls.Add(infoLabel);

            // Crear un calendario para la disponibilidad
            calendario = new MonthCalendar();
            calendario.Location = new Point((contentPanel.Width - calendario.Width) / 2, 60);
            calendario.MaxSelectionCount = 1;
            contentPanel.Controls.Add(calendario);

            // Botón para consultar la disponibilidad
            Button btnConsultarDisponibilidad = new Button();
            btnConsultarDisponibilidad.Text = "Consultar disponibilidad de consultorios";
            btnConsultarDisponibilidad.Size = new Size(380, 50);
            btnConsultarDisponibilidad.BackColor = Color.FromArgb(23, 124, 116);
            btnConsultarDisponibilidad.ForeColor = Color.White;
            btnConsultarDisponibilidad.Font = new Font("Inter", 14);
            btnConsultarDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnConsultarDisponibilidad.FlatAppearance.BorderSize = 0;
            btnConsultarDisponibilidad.Location = new Point((contentPanel.Width - btnConsultarDisponibilidad.Width) / 2, 260);
            contentPanel.Controls.Add(btnConsultarDisponibilidad);

            // Evento para el botón de consultar
            btnConsultarDisponibilidad.Click += (s, e) => AbrirDisponibilidad();
        }

        private void AbrirDisponibilidad()
        {
            // Obtener la fecha seleccionada del calendario
            string fechaSeleccionada = calendario.SelectionStart.ToShortDateString();

            // Abrir el formulario ConsultarDisponibilidadConsultorios con la fecha seleccionada
            ConsultarDisponibilidadConsultorios form = new ConsultarDisponibilidadConsultorios(fechaSeleccionada);
            form.ShowDialog();
        }
    }
}
