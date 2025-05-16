using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVeterinaria.Forms.Forms_admin
{
    public partial class GenerarReportes: Form
    {
        public GenerarReportes()
        {
            InitializeComponent();
        }

        private void btnReporteEspacios_Click(object sender, EventArgs e)
        {
            ReporteUsoEspacios reporteUsoEspacios = new ReporteUsoEspacios();
            reporteUsoEspacios.ShowDialog();
        }

        private void btnReporteFrecuencia_Click(object sender, EventArgs e)
        {
            reporteFrecuenciaEnfermedades reportefrecuenciaenfermedades = new reporteFrecuenciaEnfermedades();
            reportefrecuenciaenfermedades.ShowDialog();
        }

        private void btnReporteClientesActivos_Click(object sender, EventArgs e)
        {
            reporteClientes reporteclientes = new reporteClientes();
            reporteclientes.ShowDialog();
        }
    }
}
