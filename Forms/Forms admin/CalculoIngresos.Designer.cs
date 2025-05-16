namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    partial class CalculoIngresos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.pbRefrescar = new System.Windows.Forms.PictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMontoGanancias = new System.Windows.Forms.Label();
            this.lblTituloGanancias = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.lblNombreSistema.Location = new System.Drawing.Point(68, 26);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(132, 23);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "Sistema Gestión";
            // 
            // pbRefrescar
            // 
            this.pbRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefrescar.Location = new System.Drawing.Point(456, 22);
            this.pbRefrescar.Name = "pbRefrescar";
            this.pbRefrescar.Size = new System.Drawing.Size(32, 32);
            this.pbRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefrescar.TabIndex = 2;
            this.pbRefrescar.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloFormulario.Location = new System.Drawing.Point(12, 70);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(476, 31);
            this.lblTituloFormulario.TabIndex = 3;
            this.lblTituloFormulario.Text = "Cálculo de Ingresos Mensuales";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.btnCalcular);
            this.pnlContenido.Controls.Add(this.lblMontoGanancias);
            this.pnlContenido.Controls.Add(this.lblTituloGanancias);
            this.pnlContenido.Location = new System.Drawing.Point(40, 120);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(420, 200);
            this.pnlContenido.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcular.BackColor = System.Drawing.Color.Teal;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(118, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(183, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular/Actualizar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // lblMontoGanancias
            // 
            this.lblMontoGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoGanancias.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoGanancias.ForeColor = System.Drawing.Color.Green;
            this.lblMontoGanancias.Location = new System.Drawing.Point(20, 70);
            this.lblMontoGanancias.Name = "lblMontoGanancias";
            this.lblMontoGanancias.Size = new System.Drawing.Size(380, 40);
            this.lblMontoGanancias.TabIndex = 1;
            this.lblMontoGanancias.Text = "$0";
            this.lblMontoGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloGanancias
            // 
            this.lblTituloGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloGanancias.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGanancias.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloGanancias.Location = new System.Drawing.Point(20, 30);
            this.lblTituloGanancias.Name = "lblTituloGanancias";
            this.lblTituloGanancias.Size = new System.Drawing.Size(380, 25);
            this.lblTituloGanancias.TabIndex = 0;
            this.lblTituloGanancias.Text = "Ganancias Estimadas (Último Mes):";
            this.lblTituloGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCopyright.Location = new System.Drawing.Point(438, 345);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(46, 16);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© 2025";
            // 
            // CalculoIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.lblTituloFormulario);
            this.Controls.Add(this.pbRefrescar);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.pbLogo);
            this.Name = "CalculoIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTituloGanancias;
        private System.Windows.Forms.Label lblMontoGanancias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCopyright;
    }
}