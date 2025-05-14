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
    public partial class DashboardVeterinario : Form
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

        public DashboardVeterinario()
        {
            InitializeComponent();
            LoadSampleUsers();
        }

        // Load sample users into the list
        private void LoadSampleUsers()
        {
            users.Add(new User("admin@example.com", "admin123", "admin"));
            users.Add(new User("receptionist@example.com", "receptionist123", "receptionist"));
            users.Add(new User("veterinary@example.com", "veterinary123", "veterinary"));
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
                switch (matchedUser.Role.ToLower())
                {
                   /* case "admin":
                        AdminMenuForm adminMenu = new AdminMenuForm();
                        adminMenu.Show();
                        this.Hide();
                        break;*/
                    case "receptionist":
                        DashboardRecepcion dashboardRecepcion = new DashboardRecepcion();
                        dashboardRecepcion.Show();
                        this.Hide();
                        //dashboardRecepcion.FormClosed += (s, args) => this.Show();

                        break;
                    case "veterinary":
                        DashboardVeterinario dashboardVeterinario = new DashboardVeterinario();
                        dashboardVeterinario.Show();
                        this.Hide();
                        //dashboardVeterinario.FormClosed += (s, args) => this.Show();

                        break;
                    default:
                        MessageBox.Show("No se reconoce el rol del usuario.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }

   
}

