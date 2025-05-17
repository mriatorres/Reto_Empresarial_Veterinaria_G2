using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public class Mascota
    {
        public string NombreMascota;
        public string FechaNacimiento;
        public string Especie;
        public string Sexo;
        public string MotivoIngreso;
        public string IdMascota;
        public string AcudienteDocumento;
    }

    public class RegistrarMascota : FormBaseRec
    {
        // Lista para almacenar los datos de las mascotas
        private List<Mascota> listaMascotas = new List<Mascota>();
        // Campos de texto y combobox
        private TextBox[] textBoxes;
        private ComboBox cbSexo;
        // Field to store the Acudiente information
        private Acudiente acudiente;

        public RegistrarMascota(Acudiente acudiente) : base("Veterinaria La Mascota")
        {
            // Guardar info acudiente
            this.acudiente = acudiente;

            // Título en la parte azul (parte superior del formulario)
            Label panelTitle = new Label();
            panelTitle.Text = "Registrar datos de la mascota";
            panelTitle.Font = new Font("Inter", 20, FontStyle.Bold);
            panelTitle.ForeColor = Color.FromArgb(31, 41, 55);
            panelTitle.Location = new Point((this.Width - 400) / 2, 70);
            panelTitle.AutoSize = true;
            this.Controls.Add(panelTitle);

            // Etiqueta de información general dentro del panel heredado
            Label infoLabel = new Label();
            infoLabel.Text = "Información de la mascota";
            infoLabel.Font = new Font("Inter", 14, FontStyle.Bold);
            infoLabel.ForeColor = Color.FromArgb(23, 124, 116);
            infoLabel.Location = new Point(20, 20);
            infoLabel.AutoSize = true;
            contentPanel.Controls.Add(infoLabel);

            // Campos de texto y etiquetas
            string[] labels = { "Nombre de la mascota", "Fecha de nacimiento de la mascota",
                                "Especie y/o raza de la mascota", "Sexo mascota",
                                "Motivo de ingreso", "ID de la mascota" };
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

                if (i == 3) // ComboBox para el sexo de la mascota
                {
                    cbSexo = new ComboBox();
                    cbSexo.Items.AddRange(new string[] { "Macho", "Hembra" });
                    cbSexo.Size = new Size(250, 30);
                    cbSexo.Location = new Point(x, y + 25);
                    cbSexo.Font = new Font("Inter", 12);
                    cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
                    contentPanel.Controls.Add(cbSexo);
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(250, 30);
                    textBox.Location = new Point(x, y + 25);
                    textBox.Font = new Font("Inter", 12);
                    textBox.BorderStyle = BorderStyle.FixedSingle;

                    textBoxes[i] = textBox;
                    contentPanel.Controls.Add(textBox);
                }

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

            // Botón para registrar los datos
            Button btnRegistrar = new Button();
            btnRegistrar.Text = "Registrar";
            btnRegistrar.Size = new Size(280, 50);
            btnRegistrar.BackColor = Color.FromArgb(23, 124, 116);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Font = new Font("Inter", 14);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.Location = new Point((contentPanel.Width - btnRegistrar.Width) / 2, y + 30);
            contentPanel.Controls.Add(btnRegistrar);

            // Efecto hover en el botón
            btnRegistrar.MouseEnter += (s, e) => btnRegistrar.BackColor = Color.FromArgb(30, 144, 255);
            btnRegistrar.MouseLeave += (s, e) => btnRegistrar.BackColor = Color.FromArgb(23, 124, 116);

            // Evento para el botón
            btnRegistrar.Click += (s, e) => GuardarDatos();
        }

        // Método para guardar los datos ingresados
        private void GuardarDatos()
        {
            Mascota nuevaMascota = new Mascota
            {
                NombreMascota = textBoxes[0].Text,
                FechaNacimiento = textBoxes[1].Text,
                Especie = textBoxes[2].Text,
                Sexo = cbSexo.SelectedItem?.ToString() ?? "No especificado",
                MotivoIngreso = textBoxes[4].Text,
                IdMascota = textBoxes[5].Text,
                AcudienteDocumento = acudiente?.Documento
            };

            // Añadir la nueva mascota a la lista local
            listaMascotas.Add(nuevaMascota);

            // Mostrar mensaje de éxito
            MessageBox.Show("Mascota registrada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mostrar el formulario emergente con el ID de la mascota
            string idRegistrado = nuevaMascota.IdMascota;
            RegistrarOtraMascota form = new RegistrarOtraMascota(idRegistrado);
            form.ShowDialog();

            // Limpiar los campos después del registro
            foreach (var textBox in textBoxes)
            {
                if (textBox != null)
                    textBox.Clear();
            }
            cbSexo.SelectedIndex = -1;
        }
    }
}

