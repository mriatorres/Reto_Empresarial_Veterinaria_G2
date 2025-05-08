using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinario_2
{
    public class Cliente : Persona
    {
        public List<Mascota> Mascotas;

        public Cliente(string nombreDueno, string identificacionDueno, List<Mascota> mascotas)
            : base(nombreDueno, identificacionDueno, "Cliente")
        {
            Mascotas = mascotas ?? new List<Mascota>();
        }

        public void MostrarInformacionCompleta()
        {
            Console.WriteLine("\n--- Información Detallada del Cliente ---");
            Console.WriteLine($"Nombre Dueño: {Nombre}");
            Console.WriteLine($"Identificación Dueño: {Identificacion}");
            Console.WriteLine($"Rol: {Especialidad}");

            if (Mascotas.Any())
            {
                Console.WriteLine("\n  Mascotas Registradas:");
                int contadorMascota = 1;
                foreach (var mascota in Mascotas)
                {
                    Console.WriteLine($"  ----------------------------------");
                    Console.WriteLine($"  Mascota #{contadorMascota++}:");
                    Console.WriteLine($"    ID Mascota: {mascota.IdMascota}");
                    Console.WriteLine($"    Nombre: {mascota.NombreMascota}");
                    Console.WriteLine($"    Fecha de Nacimiento: {mascota.FechaNacimiento:dd/MM/yyyy}"); 
                    Console.WriteLine($"    Raza/Especie: {mascota.RazaEspecie}");
                    Console.WriteLine($"    Sexo: {mascota.Sexo}");
                    Console.WriteLine($"    Motivo de Ingreso: {mascota.MotivoIngreso}");
                    Console.WriteLine($"    Especialidad de Servicio Requerida: {mascota.ServicioRequerido}");
                }
                Console.WriteLine($"  ----------------------------------");
            }
            else
            {
                Console.WriteLine("  No tiene mascotas registradas.");
            }
            Console.WriteLine("---------------------------------------\n");
        }
    }
}
