using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendar_citas_y_cirugias
{
    internal class Cita
    {
        public Cliente cliente;
        public Mascota mascota;
        public Veterinario veterinario;
        public string tipo; //cita o cirugia?
        public int precio;

        public Cita(Cliente cliente, Mascota mascota, Veterinario veterinario, string tipo)
        {
            this.cliente = cliente;
            this.mascota = mascota;
            this.veterinario = veterinario;
            this.tipo = tipo;
        }

        public void CheckarPrecio()
        {
            switch (tipo)
            {
                case "Cita":
                    precio = 10000;
                    break;
                case "Cirugia":
                    precio = 50000;
                    break;
            }
        }
    }
}
