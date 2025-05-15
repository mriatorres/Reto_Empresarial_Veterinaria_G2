using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Veterinario
{
    public partial class FormBaseRec : Form
    {
        protected Panel headerPanel;
        protected Label titleLabel;
        protected PictureBox logo;
        protected PictureBox backIcon;
        protected Panel contentPanel;
        protected Label footerLabel;

        // Constructor del formulario base
        public FormBaseRec(string title)
        {
            // Propiedades del formulario
            this.Text = title;
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(212, 231, 245);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Crear encabezado
            CreateHeader(title);

            // Crear panel de contenido
            CreateContentPanel();

            // Crear pie de página
            CreateFooter();
        }

        // Método para crear el encabezado
        private void CreateHeader(string title)
        {
            headerPanel = new Panel();
            headerPanel.BackColor = Color.White;
            headerPanel.Size = new Size(this.Width, 60);  // Altura reducida
            headerPanel.Dock = DockStyle.Top;
            this.Controls.Add(headerPanel);

            // Logo
            logo = new PictureBox();
            string logoPath = Application.StartupPath + @"\Resources\LogoVet.png";
            if (System.IO.File.Exists(logoPath))
            {
                logo.Image = Image.FromFile(logoPath);
                logo.Size = new Size(50, 50);  // Tamaño reducido
                logo.Location = new Point(20, 5);  // Ajuste de posición
                headerPanel.Controls.Add(logo);
            }

            // Título
            titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font("Instrument Sans", 20, FontStyle.Bold);  // Tamaño ajustado
            titleLabel.ForeColor = Color.FromArgb(31, 41, 55);
            titleLabel.Location = new Point(80, 15);  // Ajuste de posición
            titleLabel.AutoSize = true;
            headerPanel.Controls.Add(titleLabel);

            // Botón de regreso
            backIcon = new PictureBox();
            string backPath = Application.StartupPath + @"\Resources\FlechaRegresar.png";
            if (System.IO.File.Exists(backPath))
            {
                backIcon.Image = Image.FromFile(backPath);
                backIcon.Size = new Size(30, 30);  // Tamaño reducido
                backIcon.Location = new Point(720, 15);
                backIcon.Click += (s, e) => this.Close();
                headerPanel.Controls.Add(backIcon);
            }
        }

        // Método para crear el panel de contenido
        private void CreateContentPanel()
        {
            contentPanel = new Panel();
            contentPanel.BackColor = Color.White;
            contentPanel.Size = new Size(500, 300);
            contentPanel.Location = new Point((this.Width - contentPanel.Width) / 2, 130);
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(contentPanel);
        }

        // Método para crear el pie de página
        private void CreateFooter()
        {
            footerLabel = new Label();
            footerLabel.Text = "© 2025 Sistema de Gestión Veterinaria";
            footerLabel.Font = new Font("Inter", 10);
            footerLabel.ForeColor = Color.Gray;
            footerLabel.AutoSize = true;
            footerLabel.Location = new Point(600, 560);
            this.Controls.Add(footerLabel);
        }
    }
}
