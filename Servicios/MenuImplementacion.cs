using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prrueba4Evaluacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuDeLaZonaEste()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opcion 0. Ir al puerto Sur");
            Console.WriteLine("Opcion 1. Acceder al puerto Norte (PIF).");
            Console.WriteLine("--------------------------");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int MenuInicial()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opcion 0. Cerrar el menu.");
            Console.WriteLine("Opcion 1. Añadir vehiculo");
            Console.WriteLine("Opcion 2. Acceder al puerto Sur.");
            Console.WriteLine("--------------------------");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }

        public int menuSecundario()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Opcion 0. Ir al puerto Sur");
            Console.WriteLine("Opcion 1. Acceder al Puerto Norte");
            Console.WriteLine("Opcion 2. Acceder al Puerto Este");
            Console.WriteLine("Opcion 3. Acceder al Puerto Oeste");
            Console.WriteLine("--------------------------");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
