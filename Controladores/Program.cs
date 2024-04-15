using Prrueba4Evaluacion.Dtos;
using Prrueba4Evaluacion.Servicios;

namespace Prrueba4Evaluacion.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Today;
            string fichero = $"C:\\Users\\vspc\\OneDrive\\Escritorio\\{fechaHoy.ToString("ddMMyyyy")}-entidad.txt";
            //Interfaces e implementaciones
            MenuInterfaz mi = new MenuImplementacion();
            VehiculosInterfaz vi = new VehiculosImplementacion();
            ZonaNorteImplementacion zn = new ZonaNorteImplementacion();
            ZonaOesteImplementacion zo = new ZonaOesteImplementacion();
            ZonaEsteImplementacion ze = new  ZonaEsteImplementacion();

            //Variables globales
            int opcionMenuPrincipal;
            int opcionMenuSecundario;
            int opcionMenuEste;
            bool cerrarMenu = false;

            try
            {
                do
                {
                    switch (opcionMenuPrincipal = mi.MenuInicial())
                    {
                        case 0:
                            StreamWriter sw = new StreamWriter(fichero);
                            sw.WriteLine("Puertos Sur");
                            foreach (VehiculosDto var in listaVehiculosSur)
                            {
                                sw.WriteLine($"{var.IdVehiculo};{var.MatriculaVehiculo};{var.TipoVehiculo};{var.ZonaDestinoVehiculo};{var.LlevaMercancias};{var.FechaPasoVehiculo}");
                            }
                            sw.WriteLine("Puerto Norte");
                            foreach (VehiculosDto var in listaVehiculosNorte)
                            {
                                sw.WriteLine($"{var.IdVehiculo};{var.MatriculaVehiculo};{var.TipoVehiculo};{var.ZonaDestinoVehiculo};{var.LlevaMercancias};{var.FechaPasoVehiculo}");
                            }
                            sw.WriteLine("Puerto Este");
                            foreach (VehiculosDto var in listaVehiculosEste)
                            {
                                sw.WriteLine($"{var.IdVehiculo};{var.MatriculaVehiculo};{var.TipoVehiculo};{var.ZonaDestinoVehiculo};{var.LlevaMercancias};{var.FechaPasoVehiculo}");
                            }
                            sw.WriteLine("Puerto Oeste");
                            foreach (VehiculosDto var in listaVehiculosOeste)
                            {
                                sw.WriteLine($"{var.IdVehiculo};{var.MatriculaVehiculo};{var.TipoVehiculo};{var.ZonaDestinoVehiculo};{var.LlevaMercancias};{var.FechaPasoVehiculo}");
                            }
                            sw.Close();
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Añadir vehiculos");
                            vi.añadirVehiculos();
                            break;
                        case 2:
                            if (listaVehiculosSur.Count > 0)
                            {
                                switch (opcionMenuSecundario = mi.menuSecundario())
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        zn.acceso();
                                        break;
                                    case 2:
                                        ze.acceso();
                                        switch (opcionMenuEste = mi.menuDeLaZonaEste())
                                        {
                                            case 0:   
                                                break;
                                            case 1:
                                               // vi.revision();
                                                break;
                                            default:
                                                Console.WriteLine("No has elegido ninguna opcion, se le devolvera al puerto sur");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        zo.acceso();
                                        break;
                                    default:
                                        Console.WriteLine("No has elegido ninguna opcion, se le devolvera al puerto sur");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Debes de añadir como inimo algun vehiculo");
                            }
                            break;
                        default:
                            Console.WriteLine("Has elegido la opcion incorrecta por favor vuelve a repetir y escoja una opcion valida");
                            break;
                    }

                } while (!cerrarMenu);
            }catch (Exception ex) 
            {
                Console.WriteLine("La aplicacion esta en mantenimiento, por favor esperese 5 minutos");
                StreamWriter swE = new StreamWriter(fichero);
               swE.Write(ex.ToString());
                swE.Close();
            }

        }

        //A partir de aqui solo iran los metodos estaticos
        public static List<VehiculosDto> listaVehiculosSur = new List<VehiculosDto>();
        public static List<VehiculosDto> listaVehiculosNorte = new List<VehiculosDto>();
        public static List<VehiculosDto> listaVehiculosOeste = new List<VehiculosDto>();
        public static List<VehiculosDto> listaVehiculosEste = new List<VehiculosDto>();


    }
}
