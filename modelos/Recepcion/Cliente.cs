using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVeterinaria.Modelos.Recepcion
{
    public class Cliente : Persona
    {
        public List<Mascota> Mascotas { get; set; }
        public Cliente(string nombre, string identificacion, List<Mascota> mascotas)
            : base(nombre, identificacion, "Cliente") 
        {
            Mascotas = mascotas ?? new List<Mascota>();
        }
        public void MostrarInformacionCompleta()
        {
            Console.WriteLine($"Nombre del dueño: {Nombre}");
            Console.WriteLine($"Identificación: {Identificacion}");
            Console.WriteLine("Mascotas registradas:");
            if (Mascotas.Count == 0)
            {
                Console.WriteLine("  No hay mascotas registradas.");
            }
            else
            {
                foreach (var mascota in Mascotas)
                {
                    Console.WriteLine($"- {mascota.NombreMascota} (ID: {mascota.IdMascota}, Fecha nacimiento: {mascota.FechaNacimiento.ToString("dd/MM/yyyy")}, Raza/Especie: {mascota.RazaEspecie}, Sexo: {mascota.Sexo})");
                }
            }
        }
    }
}
