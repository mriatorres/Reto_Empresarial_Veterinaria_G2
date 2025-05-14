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
    public partial class PantallaBienvenida: Form
    {



        public PantallaBienvenida()
        {
            InitializeComponent();
            InitializeRoundedButton();
            //InitializeRoundedPanel();
            panel10.Paint += panel10_Paint; // Subscribe to the Paint event

        }



        /*private void InitializeRoundedPanel()
        {
            // Create a new instance of the RoundedPanel
            RoundedPanel roundedPanel = new RoundedPanel
            {
                BorderRadius = 30,
                Size = new Size(600, 500),
                Location = new Point(200,350),
                BackColor = Color.Coral // Set the background color to white
            };
            // Add the rounded panel to the form
            Controls.Add(roundedPanel);
        }
        */
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
            DashboardVeterinario dashboardVeterinario = new DashboardVeterinario();
            dashboardVeterinario.Show();
            this.Hide();
            dashboardVeterinario.FormClosed += (s, args) => this.Show();

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            // Create a pen with the specified color
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#0E7C82"), 2)) // 2 is the width of the line
            {
                // Calculate the middle of the panel
                int middleY = panel10.Height / 2;
                // Draw the line across the middle of the panel
                e.Graphics.DrawLine(pen, 0, middleY, panel10.Width, middleY);
            }
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
