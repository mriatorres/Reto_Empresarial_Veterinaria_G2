using System;

public class PersonalVeterinario
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Especialidad { get; set; }

    public PersonalVeterinario(string cedula, string nombre, string especialidad)
    {
        Cedula = cedula;
        Nombre = nombre;
        Especialidad = especialidad;
    }

    // Método para actualizar el historial médico
    public void ActualizarHistorial(HistorialMedico historial, double nuevoPeso, string observaciones)
    {
        historial.PesoActual = nuevoPeso;
        historial.Observaciones = observaciones;
        historial.FechaActualizacion = DateTime.Now;
    }
}
