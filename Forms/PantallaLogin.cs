using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionVeterinaria.Forms.Forms_Recepcion;

namespace SistemaGestionVeterinaria.Forms.Forms_Veterinario
{
    public partial class PantallaLogin : Form
    {
        // User class to hold credentials and role
        private class User
        {
            public string Email;
            public string Password;
            public string Role;
            public User(string email, string password, string role)
            {
                this.Email = email;
                this.Password = password;
                this.Role = role;
            }
        }

        // List to hold sample credentials
        private List<User> users = new List<User>();

        // Declare emailTxt and pwdTxt as class-level fields
       /* private RoundedTextBox emailTxt;
        private RoundedTextBox pwdTxt;*/

        public PantallaLogin()
        {
            InitializeComponent();
            LoadSampleUsers();
           // InitializeCustomTextBoxes();
        }

       /* private void InitializeCustomTextBoxes()
        {
            emailTxt = new RoundedTextBox();
            emailTxt.BorderRadius = 20; // Set the desired border radius
            emailTxt.Location = new Point(136, 84); // Set the desired location
            emailTxt.Size = new Size(966, 28); // Set the desired size

            pwdTxt = new RoundedTextBox();
            pwdTxt.BorderRadius = 20; // Set the desired border radius
            pwdTxt.Location = new Point(136, 58); // Set the desired location
            pwdTxt.Size = new Size(966, 28); // Set the desired size
        }*/

        // Load sample users into the list
        private void LoadSampleUsers()
        {
            users.Add(new User("admin@example.com", "admin123", "admin"));
            users.Add(new User("recepcionista@example.com", "recepcionista123", "recepcionista"));
            users.Add(new User("veterinario@example.com", "veterinario123", "veterinario"));
        }

        private void DashboardVeterinario_Load(object sender, EventArgs e)
        {
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredEmail = emailTxt.Text.Trim();
            string enteredPassword = pwdTxt.Text.Trim();

            User matchedUser = users.Find(u =>
                u.Email.Equals(enteredEmail, StringComparison.OrdinalIgnoreCase) &&
                u.Password == enteredPassword);

            if (matchedUser != null)
            {
                Form dashboardForm = null;
                switch (matchedUser.Role.ToLower())
                {
                    case "recepcionista":
                        dashboardForm = new DashboardRecepcion();
                        break;

                    case "veterinario":
                        dashboardForm = new DashboardVeterinario();
                        break;
                    default:
                        MessageBox.Show("No se reconoce el rol del usuario.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the role is not recognized
                }
                // Show the dashboard form and hide the current form
                dashboardForm.Show();
                this.Hide();
                // Handle the FormClosed event to show the login form again
                dashboardForm.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Correo o contraseña invalidos. Por favor vuelva aingresar las credenciales.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia de pantallabienvenida
            PantallaBienvenida pantallaBienvenida = new PantallaBienvenida();

            // Mostrar pantallabienvenida
            pantallaBienvenida.Show();

            // Cerrar pantallabienvenida form
            this.Close();
        }
    }
}
