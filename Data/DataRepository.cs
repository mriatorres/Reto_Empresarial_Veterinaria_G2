using SistemaGestionVeterinaria.Forms.Forms_Recepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVeterinaria.Data
{
    public static class DataRepository
    {
        // Global list of Acudientes
        public static List<Acudiente> Acudientes { get; } = new List<Acudiente>();
        // Global list of Mascotas
        public static List<Mascota> Mascotas { get; } = new List<Mascota>();
        // Optional: Helper methods for fetching by ID or other criteria can be added here
        public static Acudiente GetAcudienteByDocumento(string documento)
        {
            return Acudientes.Find(a => a.Documento == documento);
        }
        public static Mascota GetMascotaById(string idMascota)
        {
            return Mascotas.Find(m => m.IdMascota == idMascota);
        }
    }
}
