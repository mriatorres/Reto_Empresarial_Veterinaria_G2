namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    partial class ReporteUsoEspacios
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
            this.lblTituloPrincipalReporte = new System.Windows.Forms.Label();
            this.pnlContenidoDetalle = new System.Windows.Forms.Panel();
            this.lblHorasQuirofanos = new System.Windows.Forms.Label(); // Para mostrar "Ocupados / Libres"
            this.lblQuirofanosTotal = new System.Windows.Forms.Label(); // Para "Quirófanos(Total:X)"
            this.lblTituloQuirofanos = new System.Windows.Forms.Label(); // "Quirófanos"
            this.lblHorasConsultorios = new System.Windows.Forms.Label(); // Para mostrar "Ocupados / Libres"
            this.lblConsultoriosTotal = new System.Windows.Forms.Label(); // Para "Consultorios(Total:X)"
            this.lblTituloConsultorios = new System.Windows.Forms.Label(); // "Consultorios"
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            this.pnlContenidoDetalle.SuspendLayout();
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
            this.lblNombreSistema.Size = new System.Drawing.Size(126, 23);
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
            // lblTituloPrincipalReporte
            // 
            this.lblTituloPrincipalReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloPrincipalReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPrincipalReporte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrincipalReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloPrincipalReporte.Location = new System.Drawing.Point(12, 70);
            this.lblTituloPrincipalReporte.Name = "lblTituloPrincipalReporte";
            this.lblTituloPrincipalReporte.Size = new System.Drawing.Size(776, 31);
            this.lblTituloPrincipalReporte.TabIndex = 3;
            this.lblTituloPrincipalReporte.Text = "Uso de espacios registrados";
            this.lblTituloPrincipalReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriodo
            //
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPeriodo.Location = new System.Drawing.Point(290, 105);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(70, 23);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Periodo:";
            //
            // cmbPeriodo
            //
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] { "Actual", "Mes Anterior", "Hoy" }); // Ajustar items si es necesario
            this.cmbPeriodo.Location = new System.Drawing.Point(370, 105);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriodo.TabIndex = 7;
            this.cmbPeriodo.Text = "Actual"; // El reporte de uso de espacios suele ser del estado actual
            // 
            // pnlContenidoDetalle
            // 
            this.pnlContenidoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenidoDetalle.BackColor = System.Drawing.Color.White;
            this.pnlContenidoDetalle.Controls.Add(this.lblHorasQuirofanos);
            this.pnlContenidoDetalle.Controls.Add(this.lblQuirofanosTotal);
            this.pnlContenidoDetalle.Controls.Add(this.lblTituloQuirofanos);
            this.pnlContenidoDetalle.Controls.Add(this.lblHorasConsultorios);
            this.pnlContenidoDetalle.Controls.Add(this.lblConsultoriosTotal);
            this.pnlContenidoDetalle.Controls.Add(this.lblTituloConsultorios);
            this.pnlContenidoDetalle.Location = new System.Drawing.Point(61, 140);
            this.pnlContenidoDetalle.Name = "pnlContenidoDetalle";
            this.pnlContenidoDetalle.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenidoDetalle.Size = new System.Drawing.Size(678, 268);
            this.pnlContenidoDetalle.TabIndex = 4;
            // 
            // lblHorasQuirofanos
            // 
            this.lblHorasQuirofanos.AutoSize = true;
            this.lblHorasQuirofanos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHorasQuirofanos.Location = new System.Drawing.Point(38, 190);
            this.lblHorasQuirofanos.Name = "lblHorasQuirofanos";
            this.lblHorasQuirofanos.Size = new System.Drawing.Size(195, 20); // Texto ejemplo
            this.lblHorasQuirofanos.TabIndex = 5;
            this.lblHorasQuirofanos.Text = "Ocupados: X / Disponibles: Y";
            // 
            // lblQuirofanosTotal
            // 
            this.lblQuirofanosTotal.AutoSize = true;
            this.lblQuirofanosTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuirofanosTotal.Location = new System.Drawing.Point(38, 165);
            this.lblQuirofanosTotal.Name = "lblQuirofanosTotal";
            this.lblQuirofanosTotal.Size = new System.Drawing.Size(125, 20);
            this.lblQuirofanosTotal.TabIndex = 4;
            this.lblQuirofanosTotal.Text = "Quirófanos(Total:X)";
            // 
            // lblTituloQuirofanos
            // 
            this.lblTituloQuirofanos.AutoSize = true;
            this.lblTituloQuirofanos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTituloQuirofanos.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloQuirofanos.Location = new System.Drawing.Point(32, 135);
            this.lblTituloQuirofanos.Name = "lblTituloQuirofanos";
            this.lblTituloQuirofanos.Size = new System.Drawing.Size(92, 23);
            this.lblTituloQuirofanos.TabIndex = 3;
            this.lblTituloQuirofanos.Text = "Quirófanos";
            // 
            // lblHorasConsultorios
            // 
            this.lblHorasConsultorios.AutoSize = true;
            this.lblHorasConsultorios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHorasConsultorios.Location = new System.Drawing.Point(38, 85);
            this.lblHorasConsultorios.Name = "lblHorasConsultorios";
            this.lblHorasConsultorios.Size = new System.Drawing.Size(195, 20); // Texto ejemplo
            this.lblHorasConsultorios.TabIndex = 2;
            this.lblHorasConsultorios.Text = "Ocupados: X / Disponibles: Y";
            // 
            // lblConsultoriosTotal
            // 
            this.lblConsultoriosTotal.AutoSize = true;
            this.lblConsultoriosTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConsultoriosTotal.Location = new System.Drawing.Point(38, 60);
            this.lblConsultoriosTotal.Name = "lblConsultoriosTotal";
            this.lblConsultoriosTotal.Size = new System.Drawing.Size(134, 20);
            this.lblConsultoriosTotal.TabIndex = 1;
            this.lblConsultoriosTotal.Text = "Consultorios(Total:X)";
            // 
            // lblTituloConsultorios
            // 
            this.lblTituloConsultorios.AutoSize = true;
            this.lblTituloConsultorios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTituloConsultorios.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloConsultorios.Location = new System.Drawing.Point(32, 30);
            this.lblTituloConsultorios.Name = "lblTituloConsultorios";
            this.lblTituloConsultorios.Size = new System.Drawing.Size(103, 23);
            this.lblTituloConsultorios.TabIndex = 0;
            this.lblTituloConsultorios.Text = "Consultorios";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCopyright.Location = new System.Drawing.Point(738, 435);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(50, 16);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "© 2025";
            // 
            // ReporteUsoEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlContenidoDetalle);
            this.Controls.Add(this.lblTituloPrincipalReporte);
            this.Controls.Add(this.pbRefrescar);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.pbLogo);
            this.Name = "ReporteUsoEspacios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-Reporte uso de espacios";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            this.pnlContenidoDetalle.ResumeLayout(false);
            this.pnlContenidoDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Label lblTituloPrincipalReporte;
        private System.Windows.Forms.Panel pnlContenidoDetalle;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblTituloConsultorios;
        private System.Windows.Forms.Label lblConsultoriosTotal;
        private System.Windows.Forms.Label lblHorasConsultorios;
        private System.Windows.Forms.Label lblTituloQuirofanos;
        private System.Windows.Forms.Label lblQuirofanosTotal;
        private System.Windows.Forms.Label lblHorasQuirofanos; // Corregido de la versión anterior
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cmbPeriodo;
    }
}