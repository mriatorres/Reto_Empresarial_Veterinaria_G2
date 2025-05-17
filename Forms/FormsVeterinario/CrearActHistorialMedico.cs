using SistemaGestionVeterinaria.Forms.Forms_Veterinario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.FormsVeterinario
{
    public partial class CrearActHistorialMedico : Form
    {
        private string placeholderText = "Ingrese el ID de registro de la mascota";
        //private List<Mascota> listaMascotas; // Lista para guardar mascotas registradas

        public CrearActHistorialMedico()
        {
            InitializeComponent();
            InitializePlaceholder();
            //listaMascotas = mascotas; // Inicializar la lista de registered mascotas

        }

        private void InitializePlaceholder()
        {
            idMascotaTxt.Text = placeholderText;
            idMascotaTxt.ForeColor = System.Drawing.Color.Gray; // Set placeholder color
            idMascotaTxt.Leave += TextBox_Leave;
            idMascotaTxt.Enter += TextBox_Enter;
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (idMascotaTxt.Text == placeholderText)
            {
                idMascotaTxt.Text = "";
                idMascotaTxt.ForeColor = System.Drawing.Color.Black; // Set text color when typing
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idMascotaTxt.Text))
            {
                idMascotaTxt.Text = placeholderText;
                idMascotaTxt.ForeColor = System.Drawing.Color.Gray; // Restore placeholder color
            }
        }



        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearActHistorialMedico_Load(object sender, EventArgs e)
        {

        }

        private void irahistorialBtn_Click(object sender, EventArgs e)
        {
            string idMascota = idMascotaTxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(idMascota) || idMascota == placeholderText)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "ID no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if mascota is registered using the global repository
            bool isRegistered = MascotasRepository.IsMascotaRegistered(idMascota);
            if (!isRegistered)
            {
                MessageBox.Show("La mascota con el ID ingresado no está registrada.", "Mascota no registrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pass the idMascota to the ActualizarHistorialMedico constructor
                ActualizarHistorialMedico actualizarHistorialMedico = new ActualizarHistorialMedico(idMascota);
                actualizarHistorialMedico.Show();
                this.Hide();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia de RegHistorialVac
            RegHistorialVacunacion regHistorialVacunacion = new RegHistorialVacunacion();

            // Mostrar RegHistorialVac
            regHistorialVacunacion.Show();

            // Cerrar RegHistorialVac form
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (ConfirmDialogLogout confirmDialog = new ConfirmDialogLogout())
            {
                var result = confirmDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // Usuario dio click en "Continuar" — dirigir a login form
                    PantallaLogin loginForm = new PantallaLogin();
                    loginForm.Show();
                    this.Close();
                }
                // (message box se cierra)
            }
        }
    }
}
