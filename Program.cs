namespace veterinario_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Consultorio Veterinario Virtual";
            Console.WriteLine("--- Bienvenido al Sistema de Consultorio Veterinario Virtual ---");

            Recepcion recepcionActiva = new Recepcion("Daniel Werner", "R002");
            Console.WriteLine($"Operador: {recepcionActiva.Nombre}, ID: {recepcionActiva.Identificacion}\n");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("--- Menú Principal ---");
                Console.WriteLine("1. Consultar Disponibilidad de Salas");
                Console.WriteLine("2. Registrar Nuevo Cliente y Mascotas");
                Console.WriteLine("3. Ver Clientes Registrados"); 
                Console.WriteLine("4. Agendar Cita");
                Console.WriteLine("5. Salir"); 
                Console.Write("Seleccione una opción: ");

                string? opcionMenu = Console.ReadLine();
                Console.Clear(); // Limpiar consola después de leer la opción para verse mejor :)

                switch (opcionMenu)
                {
                    case "1":
                        recepcionActiva.ConsultarDisponibilidad();
                        break;
                    case "2":
                        recepcionActiva.RegistrarCliente();
                        break;
                    case "3": 
                        recepcionActiva.VerClientesRegistrados();
                        break;
                    case "4":
                        recepcionActiva.AgendarCita();
                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("\nGracias por usar el sistema. Hasta luego");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        Console.ResetColor();
                        break;
                }
                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
