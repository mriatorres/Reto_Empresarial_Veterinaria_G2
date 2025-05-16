namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    partial class GenerarReportes
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
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.pnlOpcionesReporte = new System.Windows.Forms.Panel();
            this.btnReporteClientesActivos = new System.Windows.Forms.Button();
            this.btnReporteFrecuencia = new System.Windows.Forms.Button();
            this.btnReporteEspacios = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            this.pnlOpcionesReporte.SuspendLayout();
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
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
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
            this.pbRefrescar.Location = new System.Drawing.Point(756, 22);
            this.pbRefrescar.Name = "pbRefrescar";
            this.pbRefrescar.Size = new System.Drawing.Size(32, 32);
            this.pbRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefrescar.TabIndex = 2;
            this.pbRefrescar.TabStop = false;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(12, 74);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(776, 31);
            this.lblTituloPrincipal.TabIndex = 3;
            this.lblTituloPrincipal.Text = "Generar reporte de actividad";
            this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOpcionesReporte
            // 
            this.pnlOpcionesReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOpcionesReporte.BackColor = System.Drawing.Color.White;
            this.pnlOpcionesReporte.Controls.Add(this.btnReporteClientesActivos);
            this.pnlOpcionesReporte.Controls.Add(this.btnReporteFrecuencia);
            this.pnlOpcionesReporte.Controls.Add(this.btnReporteEspacios);
            this.pnlOpcionesReporte.Location = new System.Drawing.Point(150, 130);
            this.pnlOpcionesReporte.Name = "pnlOpcionesReporte";
            this.pnlOpcionesReporte.Size = new System.Drawing.Size(500, 250);
            this.pnlOpcionesReporte.TabIndex = 4;
            // 
            // btnReporteClientesActivos
            // 
            this.btnReporteClientesActivos.BackColor = System.Drawing.Color.Teal;
            this.btnReporteClientesActivos.FlatAppearance.BorderSize = 0;
            this.btnReporteClientesActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteClientesActivos.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnReporteClientesActivos.ForeColor = System.Drawing.Color.White;
            this.btnReporteClientesActivos.Location = new System.Drawing.Point(112, 187);
            this.btnReporteClientesActivos.Name = "btnReporteClientesActivos";
            this.btnReporteClientesActivos.Size = new System.Drawing.Size(276, 45);
            this.btnReporteClientesActivos.TabIndex = 2;
            this.btnReporteClientesActivos.Text = "Clientes más activos";
            this.btnReporteClientesActivos.UseVisualStyleBackColor = false;
            // 
            // btnReporteFrecuencia
            // 
            this.btnReporteFrecuencia.BackColor = System.Drawing.Color.Teal;
            this.btnReporteFrecuencia.FlatAppearance.BorderSize = 0;
            this.btnReporteFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteFrecuencia.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnReporteFrecuencia.ForeColor = System.Drawing.Color.White;
            this.btnReporteFrecuencia.Location = new System.Drawing.Point(112, 99);
            this.btnReporteFrecuencia.Name = "btnReporteFrecuencia";
            this.btnReporteFrecuencia.Size = new System.Drawing.Size(276, 64);
            this.btnReporteFrecuencia.TabIndex = 1;
            this.btnReporteFrecuencia.Text = "Frecuencia de enfermedades por especie";
            this.btnReporteFrecuencia.UseVisualStyleBackColor = false;
            // 
            // btnReporteEspacios
            // 
            this.btnReporteEspacios.BackColor = System.Drawing.Color.Teal;
            this.btnReporteEspacios.FlatAppearance.BorderSize = 0;
            this.btnReporteEspacios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEspacios.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnReporteEspacios.ForeColor = System.Drawing.Color.White;
            this.btnReporteEspacios.Location = new System.Drawing.Point(112, 35);
            this.btnReporteEspacios.Name = "btnReporteEspacios";
            this.btnReporteEspacios.Size = new System.Drawing.Size(276, 45);
            this.btnReporteEspacios.TabIndex = 0;
            this.btnReporteEspacios.Text = "Uso de espacios";
            this.btnReporteEspacios.UseVisualStyleBackColor = false;
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
            // GenerarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlOpcionesReporte);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.pbRefrescar);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.pbLogo);
            this.Name = "GenerarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte de actividad";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            this.pnlOpcionesReporte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel pnlOpcionesReporte;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnReporteEspacios;
        private System.Windows.Forms.Button btnReporteFrecuencia;
        private System.Windows.Forms.Button btnReporteClientesActivos;
    }
}