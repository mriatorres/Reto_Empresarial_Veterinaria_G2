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
    public partial class DashboardAdministrador: Form
    {
        public DashboardAdministrador()
        {
            InitializeComponent();
        }

        private void btnCalcularIngresos_Click(object sender, EventArgs e)
        {
            CalculoIngresos calculoIngresos = new CalculoIngresos();
            calculoIngresos.ShowDialog();

        }

        private void btnGenerarReportesActividad_Click(object sender, EventArgs e)
        {
            GenerarReportes generarReportes = new GenerarReportes();
            generarReportes.ShowDialog();
        }
    }
}
