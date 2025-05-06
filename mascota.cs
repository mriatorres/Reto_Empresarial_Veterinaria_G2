using System;
using System.Collections.Generic;

public class Mascota
{
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string EspecieRaza { get; set; }
    public string Sexo { get; set; }

    public List<string> Enfermedades { get; set; } = new();
    public List<string> Cirugias { get; set; } = new();
}
