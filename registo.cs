using System;
using System.Globalization;

public static class Registro
{
    public static Persona RegistrarPersona()
    {
        Console.WriteLine("--- Datos del Dueño ---");
        Console.Write("Cédula: "); string cedula = Console.ReadLine();
        Console.Write("Nombre completo: "); string nombre = Console.ReadLine();
        Console.Write("Correo electrónico: "); string correo = Console.ReadLine();
        Console.Write("Dirección de residencia: "); string direccion = Console.ReadLine();
        Console.Write("Número celular: "); string celular = Console.ReadLine();

        return new Persona(cedula, nombre, correo, direccion, celular);
    }

    public static Mascota RegistrarMascota()
    {
        Console.WriteLine("\n--- Datos de la Mascota ---");
        Mascota m = new Mascota();

        Console.Write("Nombre de la mascota: "); m.Nombre = Console.ReadLine();
        m.FechaNacimiento = LeerFecha("Fecha de nacimiento (dd/mm/yyyy): ");
        Console.Write("Especie y/o raza: "); m.EspecieRaza = Console.ReadLine();
        Console.Write("Sexo (M/F): "); m.Sexo = Console.ReadLine();

        Console.WriteLine("\nIngrese las enfermedades (escriba 'fin' para terminar):");
        while (true)
        {
            Console.Write("➤ Enfermedad: ");
            string entrada = Console.ReadLine();
            if (entrada.ToLower() == "fin") break;
            if (!string.IsNullOrWhiteSpace(entrada)) m.Enfermedades.Add(entrada);
        }

        Console.WriteLine("\n¿Ha tenido cirugías? (s/n): ");
        string opcion = Console.ReadLine().ToLower();
        if (opcion == "s")
        {
            Console.WriteLine("Ingrese las cirugías (escriba 'fin' para terminar):");
            while (true)
            {
                Console.Write("➤ Cirugía: ");
                string cirugia = Console.ReadLine();
                if (cirugia.ToLower() == "fin") break;
                if (!string.IsNullOrWhiteSpace(cirugia)) m.Cirugias.Add(cirugia);
            }
        }
        else
        {
            m.Cirugias.Add("Ninguna");
        }

        return m;
    }

    private static DateTime LeerFecha(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                return fecha;

            Console.WriteLine("✖ Fecha inválida. Use el formato dd/mm/yyyy.");
        }
    }
}
