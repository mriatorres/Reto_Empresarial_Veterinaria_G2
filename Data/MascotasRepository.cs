using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionVeterinaria.Forms.Forms_Recepcion;

namespace SistemaGestionVeterinaria
{
    public static class MascotasRepository
    {
        // The global list of registered mascotas
        private static readonly List<Mascota> mascotas = new List<Mascota>();
        // Expose a read-only copy of the list (optional)
        public static IReadOnlyList<Mascota> Mascotas => mascotas.AsReadOnly();
        // Add a new mascota to the list
        public static void AddMascota(Mascota nuevaMascota)
        {
            if (nuevaMascota != null)
            {
                mascotas.Add(nuevaMascota);
            }
        }
        // Check if a mascota exists by ID
        public static bool IsMascotaRegistered(string idMascota)
        {
            return mascotas.Exists(m => m.IdMascota == idMascota);
        }

    }
}
