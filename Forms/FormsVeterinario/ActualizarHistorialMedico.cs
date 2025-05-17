using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
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
    public partial class ActualizarHistorialMedico: Form
    {
        private Mascota mascota;
        private Acudiente acudiente;
        private string idMascota;
        public ActualizarHistorialMedico(string idMascota)
        {
            InitializeComponent();
            this.idMascota = idMascota;


            /// Fetch mascota from repository
            mascota = SistemaGestionVeterinaria.Data.DataRepository.GetMascotaById(idMascota);
            if (mascota != null)
            {
                // Use AcudienteDocumento set in mascota to find owner
                acudiente = SistemaGestionVeterinaria.Data.DataRepository.GetAcudienteByDocumento(mascota.AcudienteDocumento);
                DisplayData();
            }
            else
            {
                MessageBox.Show("Mascota no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void DisplayData()
        {
            // Assuming these TextBoxes exist in the form design:
            nombreacudienteTxt.Text = acudiente?.Nombre ?? "No registrado";
            idacudienteTxt.Text = acudiente?.Documento ?? "";
            emailacudienteTxt.Text = acudiente?.Correo ?? "";
            direccionTxt.Text = acudiente?.Direccion ?? "";
            telefonoTxt.Text = acudiente?.Telefono ?? "";
            nombremascotaTxt.Text = mascota.NombreMascota;
            fechanacmascotaTxt.Text = mascota.FechaNacimiento;
            especiemascotaTxt.Text = mascota.Especie;
            sexomascotaTxt.Text = mascota.Sexo;
        }


        private void CrearHistorialMedico_Load(object sender, EventArgs e)
        {
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanelColored6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia de CrearActHistorial
            CrearActHistorialMedico crearActHistorialMedico = new CrearActHistorialMedico();

            // Mostrar login form
            crearActHistorialMedico.Show();

            // Cerrar DashboardVeterinario form
            this.Hide();
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

        private void nombreacudienteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void idacudienteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailacudienteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void irahistorialBtn_Click(object sender, EventArgs e)
        {

        }

        private void nombremascotaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanelColored11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fechanacmascotaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void especiemascotaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexomascotaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void enfermedadeslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void cirugiaslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
