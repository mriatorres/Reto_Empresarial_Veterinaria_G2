public class Persona
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Celular { get; set; }

    public Persona(string cedula, string nombre, string correo, string direccion, string celular)
    {
        Cedula = cedula;
        Nombre = nombre;
        Correo = correo;
        Direccion = direccion;
        Celular = celular;
    }
}
