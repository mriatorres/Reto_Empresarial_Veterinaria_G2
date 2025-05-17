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
    public partial class RegHistorialVacunacion : Form
    {
        public RegHistorialVacunacion()
        {
            InitializeComponent();
        }

        private void RegHistorialVacunacion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia de login form
            DashboardVeterinario dashboardvet = new DashboardVeterinario();

            // Mostrar login form
            dashboardvet.Show();

            // Cerrar DashboardVeterinario form
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPesoBtn_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void registroHistorialBtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia de crearActhistorialmedico
            CrearActHistorialMedico crearActhistorialmedico = new CrearActHistorialMedico();

            // Mostrar crearActhistorialmedico
            crearActhistorialmedico.Show();

            // Cerrar RegHistorialVacunacion form
            this.Close();
        }
=======

        private void CrearActHistorialBtn_Click(object sender, EventArgs e)
        {
             
            // Crear una instancia de crearActhistorialmedico
            CrearActHistorialMedico crearActhistorialmed = new CrearActHistorialMedico();

            // Mostrar crearActhistorialmedico
            crearActhistorialmed.Show();

            // Cerrar RegHistorialVacunacion form
            this.Hide();
        
    }
>>>>>>> c1b130b3a22383bb3ed03181cf86479fc4ef85ec
    }
}
