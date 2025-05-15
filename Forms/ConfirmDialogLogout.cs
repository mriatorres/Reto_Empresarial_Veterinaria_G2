using System;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_Veterinario
{
    public class ConfirmDialogLogout : Form
    {
        private Label messageLabel;
        private PictureBox iconPictureBox;
        private Button continuarButton;
        private Button cancelarButton;

        private readonly Color themeColor = Color.FromArgb(1, 126, 118);
        private readonly int borderThickness = 4;

        public ConfirmDialogLogout()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Confirmación";
            this.FormBorderStyle = FormBorderStyle.None; // Custom border
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(400,288);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.BackColor = Color.White;

            // Icon PictureBox
            iconPictureBox = new PictureBox();
            iconPictureBox.Size = new Size(48, 48);
            iconPictureBox.Location = new Point(188, 140);
            iconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                iconPictureBox.Image = Image.FromFile(Path.Combine( Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Resources/Puzzled1.png"));
            }
            catch
            {
                // Image file missing - ignore
            }

            // Mensaje Label
            messageLabel = new Label();
            messageLabel.Text = "¿Esta seguro que desea cerrar sesion?";
            messageLabel.AutoSize = false;
            messageLabel.Size = new Size(280, 60);
            messageLabel.Location = new Point(45, 60);
            messageLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            messageLabel.ForeColor = themeColor;
            messageLabel.TextAlign = ContentAlignment.MiddleLeft;

            // Continuar Button
            continuarButton = new RoundedButton();
            continuarButton.Text = "Continuar";
            continuarButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            continuarButton.Size = new Size(110, 50);
            continuarButton.Location = new Point(40, 200);
            continuarButton.DialogResult = DialogResult.OK;
            continuarButton.FlatStyle = FlatStyle.Flat;
            continuarButton.BackColor = themeColor;
            continuarButton.ForeColor = Color.White;
            continuarButton.FlatAppearance.BorderSize = 0;

            // Cancelar Button
            cancelarButton = new RoundedButton();
            cancelarButton.Text = "Cancelar";
            cancelarButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            cancelarButton.Size = new Size(110, 50);
            cancelarButton.Location = new Point(240, 200);
            cancelarButton.DialogResult = DialogResult.Cancel;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.BackColor = themeColor;
            cancelarButton.ForeColor = Color.White;
            cancelarButton.FlatAppearance.BorderSize = 0;

            this.Controls.Add(iconPictureBox);
            this.Controls.Add(messageLabel);
            this.Controls.Add(continuarButton);
            this.Controls.Add(cancelarButton);

            this.AcceptButton = continuarButton;
            this.CancelButton = cancelarButton;

        }

        // Custom border painting
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(themeColor, borderThickness))
            {
                e.Graphics.DrawRectangle(pen, borderThickness / 2, borderThickness / 2, this.ClientSize.Width - borderThickness, this.ClientSize.Height - borderThickness);
            }
        }

        // Enable drag of form since no title bar
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;

        private void ConfirmDialog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;

                this.MouseMove += ConfirmDialog_MouseMove;
                this.MouseUp += ConfirmDialog_MouseUp;
            }
        }

        private void ConfirmDialog_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ConfirmDialog_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            this.MouseMove -= ConfirmDialog_MouseMove;
            this.MouseUp -= ConfirmDialog_MouseUp;
        }
    }
}

