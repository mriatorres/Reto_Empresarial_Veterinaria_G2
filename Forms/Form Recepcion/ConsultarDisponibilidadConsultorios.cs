using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class ConsultarDisponibilidadConsultorios : FormBaseRec
    {
        private Dictionary<string, Dictionary<string, string>> disponibilidad = new Dictionary<string, Dictionary<string, string>>();
        private string fechaSeleccionada;

        public ConsultarDisponibilidadConsultorios(string fecha) : base("Veterinaria La Mascota")
        {
            fechaSeleccionada = fecha;

            // Título en la parte azul
            Label panelTitle = new Label();
            panelTitle.Text = "Fecha seleccionada: " + fecha;
            panelTitle.Font = new Font("Inter", 22, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 80);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Inicializar disponibilidad si no existe para la fecha
            if (!disponibilidad.ContainsKey(fecha))
            {
                disponibilidad[fecha] = new Dictionary<string, string>();
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 7; j < 17; j += 2)
                    {
                        string horario = $"{j}:00-{j + 2}:00";
                        disponibilidad[fecha][$"Consultorio {i} {horario}"] = "Disponible";
                    }
                }
            }

            int xBase = 50;
            int yBase = 150;
            int spacingX = 200;
            int spacingY = 60;

            for (int consultorio = 1; consultorio <= 3; consultorio++)
            {
                // Título del consultorio
                Label lblConsultorio = new Label();
                lblConsultorio.Text = $"Consultorio {consultorio}";
                lblConsultorio.Font = new Font("Inter", 16, FontStyle.Bold);
                lblConsultorio.ForeColor = Color.FromArgb(31, 41, 55);
                lblConsultorio.Location = new Point(xBase + (consultorio - 1) * spacingX, yBase);
                lblConsultorio.AutoSize = true;
                contentPanel.Controls.Add(lblConsultorio);

                int yHorario = yBase + 30;
                for (int j = 7; j < 17; j += 2)
                {
                    string horario = $"{j}:00-{j + 2}:00";
                    string key = $"Consultorio {consultorio} {horario}";

                    Label lblHorario = new Label();
                    lblHorario.Text = horario;
                    lblHorario.Font = new Font("Inter", 12);
                    lblHorario.ForeColor = Color.FromArgb(31, 41, 55);
                    lblHorario.Location = new Point(xBase + (consultorio - 1) * spacingX, yHorario);
                    lblHorario.AutoSize = true;
                    contentPanel.Controls.Add(lblHorario);

                    ComboBox cbEstado = new ComboBox();
                    cbEstado.Items.AddRange(new string[] { "Disponible", "Ocupado" });
                    cbEstado.SelectedItem = disponibilidad[fecha][key];
                    cbEstado.Size = new Size(100, 30);
                    cbEstado.Location = new Point(xBase + (consultorio - 1) * spacingX + 100, yHorario);
                    cbEstado.SelectedIndexChanged += (s, e) =>
                    {
                        disponibilidad[fecha][key] = cbEstado.SelectedItem.ToString();
                    };
                    contentPanel.Controls.Add(cbEstado);

                    yHorario += spacingY;
                }
            }

            // Botón para guardar cambios
            Button btnGuardar = new Button();
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.Size = new Size(280, 50);
            btnGuardar.BackColor = Color.FromArgb(23, 124, 116);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Font = new Font("Inter", 14);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Location = new Point((contentPanel.Width - btnGuardar.Width) / 2, yBase + 300);
            btnGuardar.Click += (s, e) => GuardarCambios();
            contentPanel.Controls.Add(btnGuardar);
        }

        private void GuardarCambios()
        {
            MessageBox.Show("Disponibilidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

