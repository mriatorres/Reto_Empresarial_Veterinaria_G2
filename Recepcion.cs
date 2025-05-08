using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendar_citas_y_cirugias
{
    internal class Recepcion : Persona
    {
        public void AgendarCita()
        {
            //Asignar cliente -> preguntas si cita o cirugia -> asignar medico
            int elec;
            bool elegido = false;
            Cliente cliente = null;
            Mascota mascota = null;
            Veterinario veterinario = null;
            string tipo = null;
            int numCita = Program.citas.Count;
            if (Program.clientes.Any() && Program.veterinarios.Any())
            {
                do//cliente
                {
                    Console.WriteLine("Seleccionar cliente");
                    for (int i = 0; i < Program.clientes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Program.clientes[i].apellido}");
                    }
                    elec = Program.RecolectarOpcion() - 1;
                    if (elec < Program.clientes.Count && elec >= 0)
                    {
                        Console.Clear();
                        cliente = Program.clientes[elec];
                        do//mascota
                        {
                            Console.WriteLine("Asignar Mascota");
                            for (int i = 0; i < cliente.mascotas.Count; i++)
                            {
                                Console.WriteLine($"{i+1}. {cliente.mascotas[i].alias}");
                            }
                            elec = Program.RecolectarOpcion() - 1;
                            if (elec < cliente.mascotas.Count && elec >= 0)
                            {
                                mascota = cliente.mascotas[elec];
                                elegido = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Mascota no existe");
                            }
                        } while (!elegido);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Cliente no existe");
                    }
                } while (!elegido);

                Console.Clear();
                elegido = false;

                do//Tipo
                {
                    Console.WriteLine("Cita o Cirugia?");
                    Console.WriteLine("1. Cita");
                    Console.WriteLine("2. Cirugia");
                    elec = Program.RecolectarOpcion();
                    switch (elec)
                    {
                        case 1:
                            elegido = true;
                            tipo = "Cita";
                            break;
                        case 2:
                            elegido = true;
                            tipo = "Cirugia";
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opcion No existe");
                            break;
                    }

                } while (!elegido);

                Console.Clear();
                elegido = false;

                do//veterinario
                {
                    Console.WriteLine("Asignar medico");
                    for (int i = 0; Program.veterinarios.Count > i; i++)
                    {
                        Console.WriteLine($"{i+1}. {Program.veterinarios[i].nombre}");
                    }
                    elec = Program.RecolectarOpcion() - 1;
                    if (elec < Program.veterinarios.Count && elec >= 0)
                    {
                        veterinario = Program.veterinarios[elec];
                        elegido = true;
                    }
                    else
                    {
                        Console.WriteLine("Veterinario no existe");
                    }
                } while (!elegido);
                Program.citas.Add(new Cita(cliente, mascota, veterinario, tipo));

                //asignar precio
                Program.citas[numCita].CheckarPrecio();
            }
        }
    }
}
