using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionVeterinaria.Modelos.Recepcion;

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
