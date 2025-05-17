using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class Acudiente
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }

    public class RegistrarCliente : FormBaseRec
    {
        // Lista para almacenar los datos de los acudientes
        private List<Acudiente> listaAcudientes = new List<Acudiente>();

        // Campos de texto
        private TextBox[] textBoxes;

        public RegistrarCliente() : base("Veterinaria La Mascota")
        {
            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Registrar datos del acudiente";
            panelTitle.Font = new Font("Inter", 20, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 70);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Etiqueta de información general
            Label infoLabel = new Label();
            infoLabel.Text = "Información del acudiente de la mascota";
            infoLabel.Font = new Font("Inter", 14, FontStyle.Bold);
            infoLabel.ForeColor = Color.FromArgb(23, 124, 116);
            infoLabel.Location = new Point(20, 20);
            infoLabel.AutoSize = true;
            contentPanel.Controls.Add(infoLabel);

            // Campos de texto y etiquetas
            string[] labels = { "Nombre de acudiente", "Documento de identidad del acudiente",
                                "Correo electrónico del acudiente", "Dirección de residencia", "Teléfono" };
            textBoxes = new TextBox[labels.Length];
            int x = 20, y = 60, spacing = 320;

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label();
                label.Text = labels[i];
                label.Font = new Font("Inter", 12, FontStyle.Regular);
                label.ForeColor = Color.FromArgb(23, 124, 116);
                label.Location = new Point(x, y);
                label.AutoSize = true;
                contentPanel.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Size = new Size(250, 30);
                textBox.Location = new Point(x, y + 25);
                textBox.Font = new Font("Inter", 12);
                textBox.BorderStyle = BorderStyle.FixedSingle;

                if (i == 1) textBox.Text = "C.C";
                if (i == 2) textBox.Text = "Email";
                if (i == 3) textBox.Text = "Dirección";
                if (i == 4) textBox.Text = "+57";

                textBoxes[i] = textBox;
                contentPanel.Controls.Add(textBox);

                if ((i + 1) % 2 == 0)
                {
                    x = 20;
                    y += 70;
                }
                else
                {
                    x += spacing;
                }
            }

            // Botón para guardar los datos
            Button btnGuardar = new Button();
            btnGuardar.Text = "Guardar y registrar mascota";
            btnGuardar.Size = new Size(280, 50);
            btnGuardar.BackColor = Color.FromArgb(23, 124, 116);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Font = new Font("Inter", 14);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Location = new Point((contentPanel.Width - btnGuardar.Width) / 2, y + 80);
            contentPanel.Controls.Add(btnGuardar);

            // Efecto hover en el botón
            btnGuardar.MouseEnter += (s, e) => btnGuardar.BackColor = Color.FromArgb(30, 144, 255);
            btnGuardar.MouseLeave += (s, e) => btnGuardar.BackColor = Color.FromArgb(23, 124, 116);

            // Evento para guardar los datos y abrir el formulario RegistrarMascota
            btnGuardar.Click += (s, e) => GuardarDatos();
        }

        // Método para guardar los datos ingresados
        private void GuardarDatos()
        {
            Acudiente nuevoAcudiente = new Acudiente
            {
                Nombre = textBoxes[0].Text,
                Documento = textBoxes[1].Text,
                Correo = textBoxes[2].Text,
                Direccion = textBoxes[3].Text,
                Telefono = textBoxes[4].Text
            };
            // Add the new Acudiente to the global repository
            SistemaGestionVeterinaria.Data.DataRepository.Acudientes.Add(nuevoAcudiente);
            // Open the RegistrarMascota form and pass the new Acudiente
            RegistrarMascota registrarMascotaForm = new RegistrarMascota(nuevoAcudiente);
            registrarMascotaForm.ShowDialog();
        }
    }
}