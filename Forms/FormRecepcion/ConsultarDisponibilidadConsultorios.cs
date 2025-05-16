using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class ConsultarDisponibilidadConsultorios : FormBaseRec
    {
        private Dictionary<string, Dictionary<string, string>> disponibilidad;
        private string fechaSeleccionada;
        private string filePath = "disponibilidadConsultorios.txt";

        public ConsultarDisponibilidadConsultorios(string fecha) : base("Veterinaria La Mascota")
        {
            fechaSeleccionada = fecha;
            disponibilidad = CargarDisponibilidad();

            // Título en la parte azul superior con la fecha seleccionada
            Label panelTitle = new Label();
            panelTitle.Text = $"Fecha seleccionada: {fechaSeleccionada}";
            panelTitle.Font = new Font("Inter", 18, FontStyle.Bold);
            panelTitle.ForeColor = Color.White;
            panelTitle.AutoSize = true;
            panelTitle.Location = new Point((headerPanel.Width - panelTitle.Width) / 2, 20);
            headerPanel.Controls.Add(panelTitle);

            int xBase = 20;      // Ajuste hacia la izquierda
            int yBase = 40;      // Ajuste hacia arriba
            int spacingX = 180;  // Ajuste del espacio horizontal
            int spacingY = 50;

            for (int consultorio = 1; consultorio <= 3; consultorio++)
            {
                // Título del consultorio
                Label lblConsultorio = new Label();
                lblConsultorio.Text = $"Consultorio {consultorio}";
                lblConsultorio.Font = new Font("Inter", 16, FontStyle.Bold);
                lblConsultorio.ForeColor = Color.FromArgb(31, 41, 55);
                lblConsultorio.AutoSize = true;
                lblConsultorio.Location = new Point(xBase + (consultorio - 1) * spacingX, yBase);
                contentPanel.Controls.Add(lblConsultorio);

                int yHorario = yBase + 40;
                for (int j = 7; j < 17; j += 2)
                {
                    string horario = $"{j}:00-{j + 2}:00";
                    string key = $"Consultorio {consultorio} {horario}";

                    Label lblHorario = new Label();
                    lblHorario.Text = horario;
                    lblHorario.Font = new Font("Inter", 12);
                    lblHorario.ForeColor = Color.FromArgb(31, 41, 55);
                    lblHorario.AutoSize = true;
                    lblHorario.Location = new Point(xBase + (consultorio - 1) * spacingX, yHorario);
                    contentPanel.Controls.Add(lblHorario);

                    ComboBox cbEstado = new ComboBox();
                    cbEstado.Items.AddRange(new string[] { "Disponible", "Ocupado" });

                    // Inicializar el diccionario si no existe la fecha
                    if (!disponibilidad.ContainsKey(fecha))
                    {
                        disponibilidad[fecha] = new Dictionary<string, string>();
                    }

                    // Inicializar el estado del horario si no existe
                    if (!disponibilidad[fecha].ContainsKey(key))
                    {
                        disponibilidad[fecha][key] = "Disponible";
                    }

                    cbEstado.SelectedItem = disponibilidad[fecha][key];
                    cbEstado.Size = new Size(90, 25);  // Tamaño reducido
                    cbEstado.Location = new Point(xBase + (consultorio - 1) * spacingX + 90, yHorario);
                    cbEstado.SelectedIndexChanged += (s, e) =>
                    {
                        disponibilidad[fecha][key] = cbEstado.SelectedItem.ToString();
                    };
                    contentPanel.Controls.Add(cbEstado);

                    yHorario += spacingY;
                }
            }

            // Botón para guardar cambios en la parte azul inferior
            Button btnGuardar = new Button();
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.Size = new Size(200, 40);
            btnGuardar.BackColor = Color.FromArgb(23, 124, 116);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Font = new Font("Inter", 12, FontStyle.Bold);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Location = new Point((this.Width - btnGuardar.Width) / 2, this.Height - 100);
            btnGuardar.Click += (s, e) => GuardarCambios();
            this.Controls.Add(btnGuardar);
        }

        private void GuardarCambios()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (var fecha in disponibilidad.Keys)
                    {
                        foreach (var item in disponibilidad[fecha])
                        {
                            sw.WriteLine($"{fecha}|{item.Key}|{item.Value}");
                        }
                    }
                }
                MessageBox.Show("Disponibilidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, Dictionary<string, string>> CargarDisponibilidad()
        {
            var data = new Dictionary<string, Dictionary<string, string>>();
            try
            {
                if (File.Exists(filePath))
                {
                    foreach (var line in File.ReadAllLines(filePath))
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            string fecha = parts[0];
                            string key = parts[1];
                            string estado = parts[2];

                            if (!data.ContainsKey(fecha))
                                data[fecha] = new Dictionary<string, string>();

                            data[fecha][key] = estado;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la disponibilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}
