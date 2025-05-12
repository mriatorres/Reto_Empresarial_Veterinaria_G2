using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Recepcion
{
    public partial class FormBaseRec : Form
    {
        protected Panel headerPanel;
        protected Label titleLabel;
        protected PictureBox logo;
        protected Panel contentPanel;
        protected Label footerLabel;

        // Constructor del formulario base
        public FormBaseRec(string vetName)
        {
            // Propiedades del formulario
            this.Text = vetName;
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(212, 231, 245);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Crear encabezado
            CreateHeader(vetName);

            // Crear panel de contenido
            CreateContentPanel();

            // Crear pie de página
            CreateFooter();
        }

        // Método para crear el encabezado
        private void CreateHeader(string vetName)
        {
            headerPanel = new Panel();
            headerPanel.BackColor = Color.White;
            headerPanel.Size = new Size(this.Width, 60);
            headerPanel.Dock = DockStyle.Top;
            this.Controls.Add(headerPanel);

            // Logo
            logo = new PictureBox();
            string logoPath = Application.StartupPath + @"\Resources\LogoVet.png";
            if (System.IO.File.Exists(logoPath))
            {
                logo.Image = Image.FromFile(logoPath);
                logo.Size = new Size(50, 50);
                logo.Location = new Point(20, 5);
                headerPanel.Controls.Add(logo);
            }

            // Título de la veterinaria
            titleLabel = new Label();
            titleLabel.Text = vetName;
            titleLabel.Font = new Font("Instrument Sans", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            titleLabel.Location = new Point(80, 15);
            titleLabel.AutoSize = true;
            headerPanel.Controls.Add(titleLabel);
        }

        // Método para crear el panel de contenido
        private void CreateContentPanel()
        {
            contentPanel = new Panel();
            contentPanel.BackColor = Color.White;
            contentPanel.Size = new Size(600, 350);
            contentPanel.Location = new Point((this.Width - contentPanel.Width) / 2, 130);
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Padding = new Padding(20);
            contentPanel.BackColor = Color.White;
            contentPanel.BorderStyle = BorderStyle.None;
            contentPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, contentPanel.Width, contentPanel.Height, 30, 30));
            this.Controls.Add(contentPanel);
        }

        // Método para crear el pie de página
        private void CreateFooter()
        {
            footerLabel = new Label();
            footerLabel.Text = "© 2025 Veterinaria La Mascota";
            footerLabel.Font = new Font("Inter", 10);
            footerLabel.ForeColor = Color.Gray;
            footerLabel.AutoSize = true;
            footerLabel.Location = new Point(this.Width - 250, this.Height - 60);
            this.Controls.Add(footerLabel);
        }

        // Método para crear bordes redondeados
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
