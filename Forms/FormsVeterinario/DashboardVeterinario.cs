using SistemaGestionVeterinaria.Forms.FormsVeterinario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Veterinario
{
    public partial class DashboardVeterinario: Form
    {
        public DashboardVeterinario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardVeterinario_Load(object sender, EventArgs e)
        {

        }

       

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de regHistorialVac
            RegHistorialVacunacion regHistoVac = new RegHistorialVacunacion();

            // Mostrar regHistorialVac
            regHistoVac.Show();

            // Ocultar el formulario actual (DashboardVeterinario)
            this.Hide();

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia de login form
            PantallaLogin loginForm = new PantallaLogin();

            // Mostrar login form
            loginForm.Show();

            // Cerrar DashboardVeterinario form
            this.Close();

        }
    }
}
