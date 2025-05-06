using System;

public static class MenuVeterinario
{
    public static void MostrarHistorial(HistorialMedico historial, PersonalVeterinario vet)
    {
        Console.WriteLine("\n=== HISTORIAL MÉDICO ===");
        Console.WriteLine($"Mascota: {historial.MascotaAsociada.Nombre}");
        Console.WriteLine($"Peso actual: {historial.PesoActual} kg");
        Console.WriteLine($"Observaciones: {historial.Observaciones}");
        Console.WriteLine($"Fecha de última actualización: {historial.FechaActualizacion.ToShortDateString()}");
        Console.WriteLine($"Actualizado por: {vet.Nombre} ({vet.Especialidad})");
    }

    public static void ActualizarHistorialDesdeConsola(HistorialMedico historial, PersonalVeterinario vet)
    {
        Console.WriteLine("\n--- Actualizar Peso y Observaciones ---");

        Console.Write("Nuevo peso en kg: ");
        if (!double.TryParse(Console.ReadLine(), out double nuevoPeso))
        {
            Console.WriteLine("✖ Peso inválido.");
            return;
        }

        Console.Write("Observaciones: ");
        string observaciones = Console.ReadLine();

        vet.ActualizarHistorial(historial, nuevoPeso, observaciones);
        Console.WriteLine("✔ Historial actualizado correctamente.");
    }
}
