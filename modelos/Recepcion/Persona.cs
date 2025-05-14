using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVeterinaria.Modelos.Recepcion
{
    public abstract class Persona
    {
        public string Nombre;
        public string Identificacion;
        public string Especialidad;


        protected Persona(string nombre, string identificacion, string especialidad)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Especialidad = especialidad;
        }
    }
}
