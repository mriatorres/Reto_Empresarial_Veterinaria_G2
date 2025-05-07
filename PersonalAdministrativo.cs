using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador
{
    public class PersonalAdministrativo: Persona
    {
        public PersonalAdministrativo(string cedula, string nombre, string correo, string direccion, string celular): base(cedula,nombre,correo,direccion,celular)     
        {
        }

        public int CalcularGanancias(List<Cita> listacitas)
        {
            int ganancias=0;
            DateTime mesAnterior = DateTime.Now.AddMonths(-1); //para comparar meses
            foreach (Cita cita in listacitas) 
            {
                if (Cita.fecha >= mesAnterior)//no se tiene en cuenta la cita si es de hace mas de un mes 
                {
                    ganancias += cita.precio;
                }
            }
            return ganancias;
        }

        public void GenerarReporte()
        {

        }
    }
}
