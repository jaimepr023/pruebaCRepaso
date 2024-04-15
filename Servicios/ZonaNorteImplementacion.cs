using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prrueba4Evaluacion.Controladores;
using Prrueba4Evaluacion.Dtos;

namespace Prrueba4Evaluacion.Servicios
{
    internal class ZonaNorteImplementacion : ZonasInterfaz
    {
        public override void acceso()
        {
            int contador = 0;
            foreach (VehiculosDto vehiculosEspecificos in program.listaVehiculosSur)
            {
                if ((vehiculosEspecificos.TipoVehiculo.Equals("f") || vehiculosEspecificos.TipoVehiculo.Equals("a")) & vehiculosEspecificos.LlevaMercancias == false & vehiculosEspecificos.ZonaDestinoVehiculo.Equals("norte"))
                {
                    contador++;
                    vehiculosEspecificos.FechaPasoVehiculo=DateTime.Now;
                    program.listaVehiculosNorte.Add(vehiculosEspecificos);
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
