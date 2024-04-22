using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prrueba4Evaluacion.Controladores;
using Prrueba4Evaluacion.Dtos;

namespace Prrueba4Evaluacion.Servicios
{
    internal class VehiculosImplementacion : VehiculosInterfaz
    {
        public void añadirVehiculos()
        {
            string afirmacionBucle;
            do
            {
                long id = idAutomatico();
                Console.WriteLine("Dame la matricula del vehiculo.");
                string matricula = Console.ReadLine();
                string tipo;
                do
                {
                    Console.WriteLine("Cual es el tipo del vehiculo--> P (particulares) / F (Frigorificos) / A (Camiones articulados) ");
                    tipo = Console.ReadLine().ToLower();
                } while (!(tipo.Equals("p") || tipo.Equals("f") || tipo.Equals("a")));
                string zona;
                do
                {
                    Console.WriteLine("¿A que zona/puerto quieres acceder? Este/Oeste/Norte/Sur");
                    zona = Console.ReadLine().ToLower();
                } while (!(zona.Equals("este") || zona.Equals("oeste") || zona.Equals("norte") || zona.Equals("sur")));
               
                Console.WriteLine("¿LLeva mercancias? si/no");
                bool mercancias;
                string afirmacion = Console.ReadLine().ToLower();
                if (afirmacion.Equals("si"))
                {
                    mercancias = true;
                }
                else
                {
                    mercancias = false;
                }
                VehiculosDto vehiculos = new VehiculosDto(id, matricula, tipo, zona, mercancias);
                program.listaVehiculosSur.Add(vehiculos);

                Console.WriteLine("¿Quieres volver a meter otro vehiculo? si/no");
                afirmacionBucle = Console.ReadLine().ToLower();
            } while (afirmacionBucle.Equals("si"));
           
          
        }

        public void revision()
        {
            int contador = 0;
            burbuja();
            foreach (VehiculosDto var in program.listaVehiculosEste)
            {
                if (var.LlevaMercancias == false)
                {
                    contador++;
                    var.FechaPasoVehiculo = DateTime.Now;
                    var.ZonaDestinoVehiculo = "norte";
                    program.listaVehiculosNorte.Add(var);

                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No hay ningun vehiculo apto");
            }
            else if (contador == 1)
            {
                Console.WriteLine($"Hay {contador} vehiculo apto");
            }
            else
            {
                Console.WriteLine($"Hay {contador} vehiculos aptos");
            }
        }

        private void burbuja()
        {
            if (program.listaVehiculosEste.Count() >= 3)
            {
                for (int i = 0; i < program.listaVehiculosEste.Count() - 1; i++)
                {
                    for (int j = 0; j < program.listaVehiculosEste.Count() - 1 - i; j++)
                    {
                        if (program.listaVehiculosEste[j].IdVehiculo > program.listaVehiculosEste[j + 1].IdVehiculo)
                        {
                            VehiculosDto aux = program.listaVehiculosEste[j];
                            program.listaVehiculosEste[j] = program.listaVehiculosEste[j + 1];
                            program.listaVehiculosEste[j + 1] = aux;
                        }
                    }
                }
            }

        }

        private long idAutomatico()
        {
            long idVehiculo;

            if (program.listaVehiculosSur.Count <= 0)
            {
                idVehiculo = 1;
            }
            else
            {
                idVehiculo = program.listaVehiculosSur[program.listaVehiculosSur.Count - 1].IdVehiculo + 1;
            }
            return idVehiculo;


        }
    }
}
