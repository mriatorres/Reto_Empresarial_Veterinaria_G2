namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    partial class reporteFrecuenciaEnfermedades
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
            this.lblFelinosEnfermedad2 = new System.Windows.Forms.Label();
            this.lblFelinosEnfermedad1 = new System.Windows.Forms.Label();
            this.lblFelinosTotalCasos = new System.Windows.Forms.Label();
            this.lblTituloFelinos = new System.Windows.Forms.Label();
            this.lblCaninosEnfermedad2 = new System.Windows.Forms.Label();
            this.lblCaninosEnfermedad1 = new System.Windows.Forms.Label();
            this.lblCaninosTotalCasos = new System.Windows.Forms.Label();
            this.lblTituloCaninos = new System.Windows.Forms.Label();
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
            this.lblTituloPrincipalReporte.Text = "Frecuencia de enfermedades por especie";
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
            this.cmbPeriodo.Items.AddRange(new object[] { "Mes", "Semana", "Día", "Año", "Histórico" });
            this.cmbPeriodo.Location = new System.Drawing.Point(370, 105);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriodo.TabIndex = 7;
            this.cmbPeriodo.Text = "Histórico"; // Default, ya que la lógica actual del admin no filtra por periodo
            // 
            // pnlContenidoDetalle
            // 
            this.pnlContenidoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenidoDetalle.BackColor = System.Drawing.Color.White;
            this.pnlContenidoDetalle.Controls.Add(this.lblFelinosEnfermedad2);
            this.pnlContenidoDetalle.Controls.Add(this.lblFelinosEnfermedad1);
            this.pnlContenidoDetalle.Controls.Add(this.lblFelinosTotalCasos);
            this.pnlContenidoDetalle.Controls.Add(this.lblTituloFelinos);
            this.pnlContenidoDetalle.Controls.Add(this.lblCaninosEnfermedad2);
            this.pnlContenidoDetalle.Controls.Add(this.lblCaninosEnfermedad1);
            this.pnlContenidoDetalle.Controls.Add(this.lblCaninosTotalCasos);
            this.pnlContenidoDetalle.Controls.Add(this.lblTituloCaninos);
            this.pnlContenidoDetalle.Location = new System.Drawing.Point(61, 140);
            this.pnlContenidoDetalle.Name = "pnlContenidoDetalle";
            this.pnlContenidoDetalle.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenidoDetalle.Size = new System.Drawing.Size(678, 268);
            this.pnlContenidoDetalle.TabIndex = 4;
            // 
            // lblFelinosEnfermedad2
            // 
            this.lblFelinosEnfermedad2.AutoSize = true;
            this.lblFelinosEnfermedad2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFelinosEnfermedad2.Location = new System.Drawing.Point(38, 220);
            this.lblFelinosEnfermedad2.Name = "lblFelinosEnfermedad2";
            this.lblFelinosEnfermedad2.Size = new System.Drawing.Size(151, 20);
            this.lblFelinosEnfermedad2.TabIndex = 7;
            this.lblFelinosEnfermedad2.Text = "Enfermedad 2: X casos";
            // 
            // lblFelinosEnfermedad1
            // 
            this.lblFelinosEnfermedad1.AutoSize = true;
            this.lblFelinosEnfermedad1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFelinosEnfermedad1.Location = new System.Drawing.Point(38, 195);
            this.lblFelinosEnfermedad1.Name = "lblFelinosEnfermedad1";
            this.lblFelinosEnfermedad1.Size = new System.Drawing.Size(151, 20);
            this.lblFelinosEnfermedad1.TabIndex = 6;
            this.lblFelinosEnfermedad1.Text = "Enfermedad 1: X casos";
            // 
            // lblFelinosTotalCasos
            // 
            this.lblFelinosTotalCasos.AutoSize = true;
            this.lblFelinosTotalCasos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFelinosTotalCasos.Location = new System.Drawing.Point(38, 170);
            this.lblFelinosTotalCasos.Name = "lblFelinosTotalCasos";
            this.lblFelinosTotalCasos.Size = new System.Drawing.Size(150, 20);
            this.lblFelinosTotalCasos.TabIndex = 5;
            this.lblFelinosTotalCasos.Text = "Felinos - Total casos: XX";
            // 
            // lblTituloFelinos
            // 
            this.lblTituloFelinos.AutoSize = true;
            this.lblTituloFelinos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTituloFelinos.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloFelinos.Location = new System.Drawing.Point(32, 140);
            this.lblTituloFelinos.Name = "lblTituloFelinos";
            this.lblTituloFelinos.Size = new System.Drawing.Size(63, 23);
            this.lblTituloFelinos.TabIndex = 4;
            this.lblTituloFelinos.Text = "Felinos";
            // 
            // lblCaninosEnfermedad2
            // 
            this.lblCaninosEnfermedad2.AutoSize = true;
            this.lblCaninosEnfermedad2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCaninosEnfermedad2.Location = new System.Drawing.Point(38, 105);
            this.lblCaninosEnfermedad2.Name = "lblCaninosEnfermedad2";
            this.lblCaninosEnfermedad2.Size = new System.Drawing.Size(151, 20);
            this.lblCaninosEnfermedad2.TabIndex = 3;
            this.lblCaninosEnfermedad2.Text = "Enfermedad 2: X casos";
            // 
            // lblCaninosEnfermedad1
            // 
            this.lblCaninosEnfermedad1.AutoSize = true;
            this.lblCaninosEnfermedad1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCaninosEnfermedad1.Location = new System.Drawing.Point(38, 80);
            this.lblCaninosEnfermedad1.Name = "lblCaninosEnfermedad1";
            this.lblCaninosEnfermedad1.Size = new System.Drawing.Size(151, 20);
            this.lblCaninosEnfermedad1.TabIndex = 2;
            this.lblCaninosEnfermedad1.Text = "Enfermedad 1: X casos";
            // 
            // lblCaninosTotalCasos
            // 
            this.lblCaninosTotalCasos.AutoSize = true;
            this.lblCaninosTotalCasos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCaninosTotalCasos.Location = new System.Drawing.Point(38, 55);
            this.lblCaninosTotalCasos.Name = "lblCaninosTotalCasos";
            this.lblCaninosTotalCasos.Size = new System.Drawing.Size(159, 20);
            this.lblCaninosTotalCasos.TabIndex = 1;
            this.lblCaninosTotalCasos.Text = "Caninos - Total casos: XX";
            // 
            // lblTituloCaninos
            // 
            this.lblTituloCaninos.AutoSize = true;
            this.lblTituloCaninos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTituloCaninos.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloCaninos.Location = new System.Drawing.Point(32, 25);
            this.lblTituloCaninos.Name = "lblTituloCaninos";
            this.lblTituloCaninos.Size = new System.Drawing.Size(72, 23);
            this.lblTituloCaninos.TabIndex = 0;
            this.lblTituloCaninos.Text = "Caninos";
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
            // reporteFrecuenciaEnfermedades
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
            this.Name = "reporteFrecuenciaEnfermedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-Frecuencia de enfermedades por especie.";
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
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblTituloCaninos;
        private System.Windows.Forms.Label lblCaninosTotalCasos;
        private System.Windows.Forms.Label lblCaninosEnfermedad1;
        private System.Windows.Forms.Label lblCaninosEnfermedad2;
        private System.Windows.Forms.Label lblTituloFelinos;
        private System.Windows.Forms.Label lblFelinosTotalCasos;
        private System.Windows.Forms.Label lblFelinosEnfermedad1;
        private System.Windows.Forms.Label lblFelinosEnfermedad2;
    }
}