using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Registro de Dueño y Mascota ===\n");
        Persona persona = Registro.RegistrarPersona();
        Mascota mascota = Registro.RegistrarMascota();

        PersonalVeterinario vet = new PersonalVeterinario("123456", "Dra. Carolina Gómez", "Veterinaria General");
        HistorialMedico historial = new HistorialMedico(mascota);

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n=== Menú del Veterinario ===");
            Console.WriteLine("1. Ver historial médico");
            Console.WriteLine("2. Actualizar peso y observaciones");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": MenuVeterinario.MostrarHistorial(historial, vet); break;
                case "2": MenuVeterinario.ActualizarHistorialDesdeConsola(historial, vet); break;
                case "3": salir = true; break;
                default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
            }
        }
    }
}