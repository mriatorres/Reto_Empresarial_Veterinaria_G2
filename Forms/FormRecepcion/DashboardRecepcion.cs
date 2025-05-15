using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class DashboardRecepcion : FormBaseRec
    {
        public DashboardRecepcion() : base("Veterinaria La Mascota")
        {
            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Panel Personal de Recepción";
            panelTitle.Font = new Font("Inter", 22, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 80);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Mensaje en el área de contenido
            Label messageLabel = new Label();
            messageLabel.Text = "¿Qué desea hacer hoy?";
            messageLabel.Font = new Font("Inter", 18, FontStyle.Bold);
            messageLabel.ForeColor = Color.FromArgb(23, 124, 116); // Mismo color que los botones
            messageLabel.Location = new Point((contentPanel.Width - 300) / 2, 60);
            messageLabel.AutoSize = true;
            contentPanel.Controls.Add(messageLabel);

            // Botón para registrar nuevo cliente y mascota
            Button btnRegistrar = CreateHoverButton("Registrar nuevo cliente y mascota", 120);
            // Evento para abrir el formulario RegistrarCliente
            btnRegistrar.Click += (s, e) =>
            {
                RegistrarCliente registrarClienteForm = new RegistrarCliente();
                registrarClienteForm.ShowDialog();
            };
            contentPanel.Controls.Add(btnRegistrar);

            // Botón para agendar citas y cirugías
            Button btnAgendar = CreateHoverButton("Agendar citas y cirugías", 190);
            contentPanel.Controls.Add(btnAgendar);
        }

        // Método para crear botones con efecto hover
        private Button CreateHoverButton(string text, int yPos)
        {
            Button button = new Button();
            button.Text = text;
            button.Size = new Size(280, 50);
            button.BackColor = Color.FromArgb(23, 124, 116);
            button.ForeColor = Color.White;
            button.Font = new Font("Inter", 14);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Location = new Point((contentPanel.Width - button.Width) / 2, yPos);

            // Efecto de hover
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(30, 144, 255); // Color al pasar el mouse
            button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(23, 124, 116); // Color normal

            return button;
        }
    }
}
