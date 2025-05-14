using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace SistemaGestionVeterinaria.Modelos.Recepcion
{
    
    public class Recepcion : Persona
    {
        private static Dictionary<string, bool> _consultorios;
        private static Dictionary<string, bool> _quirofanos;
        private static List<Cliente> _clientesRegistrados;
        private static HashSet<string> _idsMascotasUsados;
        private static HashSet<string> _idsDuenosUsados;
        private static Random _randomGenerator = new Random();
        private static readonly string[] EspecialidadesServicio = {
        "Dermatología", "Oftalmología", "Cardiología", "Oncología", "Medicina General", "Traumatología", "Neurología"
    }; 

        static Recepcion()
        {
            _consultorios = new Dictionary<string, bool>();
            for (int i = 1; i <= 50; i++) _consultorios.Add($"Consultorio {i}", true);

            _quirofanos = new Dictionary<string, bool>();
            for (int i = 1; i <= 25; i++) _quirofanos.Add($"Quirófano {i}", true);

            _clientesRegistrados = new List<Cliente>();
            _idsMascotasUsados = new HashSet<string>();
            _idsDuenosUsados = new HashSet<string>();
        }

        public Recepcion(string nombre, string identificacion)
            : base(nombre, identificacion, "Recepción") { }

        private string GenerarIdMascotaUnico()
        {
            string nuevoId;
            do
            {
                nuevoId = _randomGenerator.Next(100000, 1000000).ToString();
            } while (_idsMascotasUsados.Contains(nuevoId));
            _idsMascotasUsados.Add(nuevoId);
            return nuevoId;
        }

        public void RegistrarCliente()
        {
            Console.WriteLine("\n--- Registro de Nuevo Cliente ---");
            Console.Write("Nombre del dueño: ");
            string nombreDueno = Console.ReadLine()?.Trim() ?? "";
            while (string.IsNullOrWhiteSpace(nombreDueno))
            {
                Console.Write("El nombre del dueño no puede estar vacío. Intente de nuevo: ");
                nombreDueno = Console.ReadLine()?.Trim() ?? "";
            }

            string idDueno;
            do
            {
                Console.Write("Cedula (CC) del dueño: ");
                idDueno = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrWhiteSpace(idDueno))
                    Console.WriteLine("La cedula no puede estar vacía.");
                else if (_idsDuenosUsados.Contains(idDueno))
                    Console.WriteLine("Esta cedula ya está registrada. Ingrese una diferente.");
                else break;
            } while (true);

            int numeroDeMascotas = 0;
            bool numeroValido = false;
            while (!numeroValido)
            {
                Console.Write("¿Cuántas mascotas desea registrar? (Máximo 10): ");
                if (int.TryParse(Console.ReadLine(), out numeroDeMascotas) && numeroDeMascotas > 0 && numeroDeMascotas <= 10)
                {
                    numeroValido = true;
                }
                else
                {
                    Console.WriteLine("Número no válido debe ser entre 1 y 10.");
                }
            }

            List<Mascota> mascotasDelCliente = new List<Mascota>();
            for (int i = 0; i < numeroDeMascotas; i++)
            {
                Console.WriteLine($"\n-- Datos de la Mascota #{i + 1} ---");

                // Nombre Mascota
                Console.Write($"Nombre de la mascota #{i + 1}: ");
                string nombreMascota = Console.ReadLine()?.Trim() ?? "";
                while (string.IsNullOrWhiteSpace(nombreMascota))
                {
                    Console.Write($"El nombre de la mascota #{i + 1} no puede estar vacío. Intente de nuevo: ");
                    nombreMascota = Console.ReadLine()?.Trim() ?? "";
                }

                // Fecha de Nacimiento
                DateTime fechaNacimientoMascota = default;
                bool fechaValida = false;
                while (!fechaValida)
                {
                    Console.Write($"Fecha de nacimiento de {nombreMascota} (dd/MM/yyyy): ");
                    string inputFecha = Console.ReadLine() ?? "";
                    if (DateTime.TryParseExact(inputFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimientoMascota))
                    {
                        if (fechaNacimientoMascota <= DateTime.Today) 
                        {
                            fechaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("La fecha de nacimiento no puede ser en el futuro. Intente de nuevo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha inválido. Use dd/MM/yyyy. Intente de nuevo.");
                    }
                }

                // Raza o Especie 
                Console.Write($"Raza o especie de {nombreMascota}: ");
                string razaEspecieMascota = Console.ReadLine()?.Trim() ?? "No especificada";

                // Sexo 
                string sexoMascota = "";
                bool sexoValido = false;
                while (!sexoValido)
                {
                    Console.Write($"Sexo de {nombreMascota} (Macho/Hembra): ");
                    string inputSexo = Console.ReadLine()?.Trim().ToLower() ?? "";
                    if (inputSexo == "macho" || inputSexo == "m")
                    {
                        sexoMascota = "Macho";
                        sexoValido = true;
                    }
                    else if (inputSexo == "hembra" || inputSexo == "h")
                    {
                        sexoMascota = "Hembra";
                        sexoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("informacion no válida. por favor, ingrese 'Macho' o 'Hembra'");
                    }
                }

                // Motivo de Ingreso :(
                Console.Write($"Motivo de ingreso para {nombreMascota} : ");
                string motivoIngresoMascota = Console.ReadLine()?.Trim() ?? "Revisión general";


                // Especialidad de Servicio Requerida :)
                Console.WriteLine($"\nSeleccione la especialidad del servicio principal para {nombreMascota}:");
                for (int j = 0; j < EspecialidadesServicio.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {EspecialidadesServicio[j]}");
                }
                string servicioSeleccionado = "";
                bool seleccionEspecialidadValida = false;
                while (!seleccionEspecialidadValida)
                {
                    Console.Write("Ingrese el número de la especialidad: ");
                    if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= EspecialidadesServicio.Length)
                    {
                        servicioSeleccionado = EspecialidadesServicio[opcion - 1];
                        seleccionEspecialidadValida = true;
                    }
                    else Console.WriteLine("Opción no válida. Intente de nuevo.");
                }

                string idMascotaGenerado = GenerarIdMascotaUnico();
                Mascota nuevaMascota = new Mascota(idMascotaGenerado, nombreMascota, fechaNacimientoMascota, razaEspecieMascota, sexoMascota, motivoIngresoMascota, servicioSeleccionado);
                mascotasDelCliente.Add(nuevaMascota);
                Console.WriteLine($"Mascota '{nombreMascota}' (ID: {idMascotaGenerado}) agregada.");
            }

            Cliente nuevoCliente = new Cliente(nombreDueno, idDueno, mascotasDelCliente);
            _clientesRegistrados.Add(nuevoCliente);
            _idsDuenosUsados.Add(idDueno);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n¡Cliente y sus mascotas registrados exitosamente!");
            Console.ResetColor();
            nuevoCliente.MostrarInformacionCompleta();
        }

        public void ConsultarDisponibilidad()
        {
            Console.WriteLine("\n--- Disponibilidad de Salas ---");
            Console.WriteLine($"Consulta realizada por: {Nombre} (ID: {Identificacion}, Rol: {Especialidad})");
            Console.WriteLine("\n** Consultorios **");
            int consultoriosDisponibles = _consultorios.Count(kvp => kvp.Value);
            Console.WriteLine($"Total: {_consultorios.Count}, Disponibles: {consultoriosDisponibles}, Ocupados: {_consultorios.Count - consultoriosDisponibles}");
            Console.WriteLine("\n** Quirófanos **");
            int quirofanosDisponibles = _quirofanos.Count(kvp => kvp.Value);
            Console.WriteLine($"Total: {_quirofanos.Count}, Disponibles: {quirofanosDisponibles}, Ocupados: {_quirofanos.Count - quirofanosDisponibles}");
            Console.WriteLine("-------------------------------\n");
        }

        public void VerClientesRegistrados()
        {
            Console.WriteLine("\n--- Clientes Registrados en el Sistema ---");
            if (!_clientesRegistrados.Any())
            {
                Console.WriteLine("No hay clientes registrados actualmente.");
            }
            else
            {
                int contadorCliente = 1;
                foreach (var cliente in _clientesRegistrados)
                {
                    Console.WriteLine($"\n=== Cliente #{contadorCliente++} ===");
                    cliente.MostrarInformacionCompleta();
                }
            }
            Console.WriteLine("----------------------------------------\n");
        }

        public void AgendarCita()
        {
            Console.WriteLine("\nOpción 'Agendar Cita' seleccionada.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Esta funcionalidad aún no está implementada.");
            Console.ResetColor();
            Console.WriteLine("Volviendo al menú principal...\n");
        }
}
}
