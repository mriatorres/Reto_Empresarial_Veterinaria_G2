using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class AgendarCitasyCirugias : FormBaseRec
    {
        private TextBox txtIDMascota;
        private ComboBox cbTipo;
        private TextBox txtCosto;

        public AgendarCitasyCirugias() : base("Veterinaria La Mascota")
        {
            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Agendar citas y cirugías";
            panelTitle.Font = new Font("Inter", 22, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 80);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Etiqueta principal
            Label infoLabel = new Label();
            infoLabel.Text = "El costo varía según el tipo de procedimiento";
            infoLabel.Font = new Font("Inter", 16, FontStyle.Bold);
            infoLabel.ForeColor = Color.FromArgb(23, 124, 116);
            infoLabel.Location = new Point((contentPanel.Width - 500) / 2, 20);
            infoLabel.AutoSize = true;
            contentPanel.Controls.Add(infoLabel);

            // Campos de texto y etiquetas
            string[] labels = { "ID mascota", "Tipo", "Costo" };
            int x = (contentPanel.Width - 500) / 2, y = 80, spacing = 200;

            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label();
                label.Text = labels[i];
                label.Font = new Font("Inter", 12, FontStyle.Regular);
                label.ForeColor = Color.FromArgb(23, 124, 116);
                label.Location = new Point(x, y);
                label.AutoSize = true;
                contentPanel.Controls.Add(label);

                if (i == 1) // ComboBox para el tipo de procedimiento
                {
                    cbTipo = new ComboBox();
                    cbTipo.Items.AddRange(new string[] { "Consulta", "Cirugía" });
                    cbTipo.Size = new Size(200, 30);
                    cbTipo.Location = new Point(x, y + 25);
                    cbTipo.Font = new Font("Inter", 12);
                    cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbTipo.SelectedIndexChanged += (s, e) =>
                    {
                        if (cbTipo.SelectedItem.ToString() == "Consulta")
                        {
                            txtCosto.Text = "5000";
                        }
                        else
                        {
                            txtCosto.Text = "10000";
                        }
                    };
                    contentPanel.Controls.Add(cbTipo);
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(200, 30);
                    textBox.Location = new Point(x, y + 25);
                    textBox.Font = new Font("Inter", 12);
                    textBox.BorderStyle = BorderStyle.FixedSingle;

                    if (i == 0) txtIDMascota = textBox;
                    if (i == 2) txtCosto = textBox;

                    contentPanel.Controls.Add(textBox);
                }

                x += spacing;
            }

            // Botón Ver disponibilidad
            Button btnDisponibilidad = new Button();
            btnDisponibilidad.Text = "Ver disponibilidad";
            btnDisponibilidad.Size = new Size(280, 50);
            btnDisponibilidad.BackColor = Color.FromArgb(23, 124, 116);
            btnDisponibilidad.ForeColor = Color.White;
            btnDisponibilidad.Font = new Font("Inter", 14);
            btnDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnDisponibilidad.FlatAppearance.BorderSize = 0;
            btnDisponibilidad.Location = new Point((contentPanel.Width - btnDisponibilidad.Width) / 2, y + 100);
            contentPanel.Controls.Add(btnDisponibilidad);

            // Efecto hover en el botón
            btnDisponibilidad.MouseEnter += (s, e) => btnDisponibilidad.BackColor = Color.FromArgb(30, 144, 255);
            btnDisponibilidad.MouseLeave += (s, e) => btnDisponibilidad.BackColor = Color.FromArgb(23, 124, 116);

            // Evento del botón Ver disponibilidad
            btnDisponibilidad.Click += (s, e) =>
            {
                if (cbTipo.SelectedItem?.ToString() == "Consulta")
                {
                    VerAgendaConsultorios agendaConsultorios = new VerAgendaConsultorios();
                    agendaConsultorios.ShowDialog();
                }
                else if (cbTipo.SelectedItem?.ToString() == "Cirugía")
                {
                    VerAgendaQuirofanos agendaQuirofanos = new VerAgendaQuirofanos();
                    agendaQuirofanos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione el tipo de procedimiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Firma y autorización del doctor
            Label doctorLabel = new Label();
            doctorLabel.Text = "Doctor que autoriza:";
            doctorLabel.Font = new Font("Inter", 12);
            doctorLabel.ForeColor = Color.FromArgb(23, 124, 116);
            doctorLabel.Location = new Point((contentPanel.Width - 300) / 2, y + 160);
            doctorLabel.AutoSize = true;
            contentPanel.Controls.Add(doctorLabel);

            Label firma = new Label();
            firma.Text = "Dr. M.N";
            firma.Font = new Font("Inter", 20, FontStyle.Italic);
            firma.ForeColor = Color.FromArgb(31, 41, 55);
            firma.Location = new Point((contentPanel.Width - 100) / 2, y + 190);
            firma.AutoSize = true;
            contentPanel.Controls.Add(firma);
        }
    }
}
