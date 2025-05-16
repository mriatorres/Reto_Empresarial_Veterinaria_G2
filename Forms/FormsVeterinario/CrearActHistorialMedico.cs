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
    public partial class CrearActHistorialMedico: Form
    {
        private string placeholderText = "Ingrese el ID de registro de la mascota";
        public CrearActHistorialMedico()
        {
            InitializeComponent();
            InitializePlaceholder();

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
    }
}
