using Prrueba4Evaluacion.Controladores;
using Prrueba4Evaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prrueba4Evaluacion.Servicios
{
    internal class ZonaEsteImplementacion : ZonasInterfaz
    {
        public override void acceso()
        {
            int contador = 0;
            foreach (VehiculosDto vehiculosEspecificos in program.listaVehiculosSur)
            {
                if ((vehiculosEspecificos.TipoVehiculo.Equals("f") || vehiculosEspecificos.TipoVehiculo.Equals("a")) & vehiculosEspecificos.ZonaDestinoVehiculo.Equals("este"))
                {
                    contador++;
                    vehiculosEspecificos.FechaPasoVehiculo = DateTime.Now;
                    program.listaVehiculosEste.Add(vehiculosEspecificos);
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No ha pasado ningun vehiculo");
            }
            else if (contador == 1)
            {
                Console.WriteLine($"Ha pasado {contador} vehiculo");
            }
            else
            {
                Console.WriteLine($"Han pasado {contador} vehiculos");
            }
        }
    }
}
