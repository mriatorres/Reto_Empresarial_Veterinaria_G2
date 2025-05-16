namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    partial class DashboardAdministrador
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
            this.lblPanelAdminTitulo = new System.Windows.Forms.Label();
            this.pnlContenidoPrincipal = new System.Windows.Forms.Panel();
            this.btnGenerarReportesActividad = new System.Windows.Forms.Button();
            this.btnCalcularIngresos = new System.Windows.Forms.Button();
            this.lblPreguntaDashboard = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            this.pnlContenidoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(25, 25);
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
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNombreSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.lblNombreSistema.Location = new System.Drawing.Point(80, 38);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(132, 23);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "Sistema Gestión";
            // 
            // pbRefrescar
            // 
            this.pbRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefrescar.Location = new System.Drawing.Point(740, 25);
            this.pbRefrescar.Name = "pbRefrescar";
            this.pbRefrescar.Size = new System.Drawing.Size(32, 32);
            this.pbRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefrescar.TabIndex = 2;
            this.pbRefrescar.TabStop = false;
            // 
            // lblPanelAdminTitulo
            // 
            this.lblPanelAdminTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPanelAdminTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblPanelAdminTitulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPanelAdminTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPanelAdminTitulo.Location = new System.Drawing.Point(8, 89);
            this.lblPanelAdminTitulo.Name = "lblPanelAdminTitulo";
            this.lblPanelAdminTitulo.Size = new System.Drawing.Size(776, 31);
            this.lblPanelAdminTitulo.TabIndex = 3;
            this.lblPanelAdminTitulo.Text = "Panel Administrador";
            this.lblPanelAdminTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContenidoPrincipal
            // 
            this.pnlContenidoPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenidoPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlContenidoPrincipal.Controls.Add(this.btnGenerarReportesActividad);
            this.pnlContenidoPrincipal.Controls.Add(this.btnCalcularIngresos);
            this.pnlContenidoPrincipal.Controls.Add(this.lblPreguntaDashboard);
            this.pnlContenidoPrincipal.Location = new System.Drawing.Point(150, 150);
            this.pnlContenidoPrincipal.Name = "pnlContenidoPrincipal";
            this.pnlContenidoPrincipal.Size = new System.Drawing.Size(500, 230);
            this.pnlContenidoPrincipal.TabIndex = 4;
            // 
            // btnGenerarReportesActividad
            // 
            this.btnGenerarReportesActividad.BackColor = System.Drawing.Color.Teal;
            this.btnGenerarReportesActividad.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportesActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportesActividad.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnGenerarReportesActividad.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportesActividad.Location = new System.Drawing.Point(125, 145);
            this.btnGenerarReportesActividad.Name = "btnGenerarReportesActividad";
            this.btnGenerarReportesActividad.Size = new System.Drawing.Size(250, 45);
            this.btnGenerarReportesActividad.TabIndex = 2;
            this.btnGenerarReportesActividad.Text = "Generar reportes de actividad";
            this.btnGenerarReportesActividad.UseVisualStyleBackColor = false;
            // 
            // btnCalcularIngresos
            // 
            this.btnCalcularIngresos.BackColor = System.Drawing.Color.Teal;
            this.btnCalcularIngresos.FlatAppearance.BorderSize = 0;
            this.btnCalcularIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularIngresos.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCalcularIngresos.ForeColor = System.Drawing.Color.White;
            this.btnCalcularIngresos.Location = new System.Drawing.Point(125, 85);
            this.btnCalcularIngresos.Name = "btnCalcularIngresos";
            this.btnCalcularIngresos.Size = new System.Drawing.Size(250, 45);
            this.btnCalcularIngresos.TabIndex = 1;
            this.btnCalcularIngresos.Text = "Calcular ingresos";
            this.btnCalcularIngresos.UseVisualStyleBackColor = false;
            // 
            // lblPreguntaDashboard
            // 
            this.lblPreguntaDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreguntaDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPreguntaDashboard.ForeColor = System.Drawing.Color.Teal;
            this.lblPreguntaDashboard.Location = new System.Drawing.Point(20, 30);
            this.lblPreguntaDashboard.Name = "lblPreguntaDashboard";
            this.lblPreguntaDashboard.Size = new System.Drawing.Size(460, 23);
            this.lblPreguntaDashboard.TabIndex = 0;
            this.lblPreguntaDashboard.Text = "¿Que desea hacer hoy?";
            this.lblPreguntaDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCopyright.Location = new System.Drawing.Point(738, 435);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(46, 16);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© 2025";
            // 
            // DashboardAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlContenidoPrincipal);
            this.Controls.Add(this.lblPanelAdminTitulo);
            this.Controls.Add(this.pbRefrescar);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.pbLogo);
            this.Name = "DashboardAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            this.pnlContenidoPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Label lblPanelAdminTitulo;
        private System.Windows.Forms.Panel pnlContenidoPrincipal;
        private System.Windows.Forms.Label lblPreguntaDashboard;
        private System.Windows.Forms.Button btnCalcularIngresos;
        private System.Windows.Forms.Button btnGenerarReportesActividad;
        private System.Windows.Forms.Label lblCopyright;
    }
}