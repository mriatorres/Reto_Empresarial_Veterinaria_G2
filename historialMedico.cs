public class HistorialMedico
{
    public Mascota MascotaAsociada { get; set; }
    public double PesoActual { get; set; }
    public string Observaciones { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public HistorialMedico(Mascota mascota)
    {
        MascotaAsociada = mascota;
        PesoActual = 0;
        Observaciones = "";
        FechaActualizacion = DateTime.Now;
    }
}
