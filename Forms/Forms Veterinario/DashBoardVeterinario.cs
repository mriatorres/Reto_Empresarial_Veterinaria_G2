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

namespace SistemaGestionVeterinaria.Forms
{
    public partial class DashBoardVeterinario: Form
    {

        public DashBoardVeterinario()
        {
            InitializeComponent();
            InitializeRoundedButton();
        }


        private void InitializeRoundedButton()
        {
            // Create a new instance of the RoundedButton
            RoundedButton roundedButton = new RoundedButton
            {
                Text = "Soy Personal Veterinario",
                Size = new Size(160, 40),
                Location = new Point(34, 18), // Same location as the original button
                BackColor = System.Drawing.Color.FromArgb(23, 124, 116), // Set the background color
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat // Optional: Set flat style
            };
            // Optionally, add an event handler for the button click
            roundedButton.Click += RoundedButton_Click;
            // Add the rounded button to the panel
            panel3.Controls.Add(roundedButton);
        }
        private void RoundedButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rounded button clicked!");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Your existing code
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardVeterinario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
