using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVeterinaria.Modelos.Recepcion
{
    public class Mascota
    {
        public string IdMascota;
        public string NombreMascota;
        public DateTime FechaNacimiento;
        public string RazaEspecie;
        public string Sexo;
        public string MotivoIngreso;
        public string ServicioRequerido;

        public Mascota(string idMascota, string nombreMascota, DateTime fechaNacimiento, string razaEspecie, string sexo, string motivoIngreso, string servicioRequerido)
        {
            IdMascota = idMascota;
            NombreMascota = nombreMascota;
            FechaNacimiento = fechaNacimiento;
            RazaEspecie = razaEspecie;
            Sexo = sexo;
            MotivoIngreso = motivoIngreso;
            ServicioRequerido = servicioRequerido;
        }
    }
}
