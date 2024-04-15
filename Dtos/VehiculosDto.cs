using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prrueba4Evaluacion.Dtos
{
    internal class VehiculosDto
    {
        long idVehiculo;
        string matriculaVehiculo = "aaaaa";
        string tipoVehiculo = "aaaaa";
        string zonaDestinoVehiculo = "aaaaa";
        bool llevaMercancias;
        DateTime fechaPasoVehiculo = DateTime.Now;

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string MatriculaVehiculo { get => matriculaVehiculo; set => matriculaVehiculo = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestinoVehiculo { get => zonaDestinoVehiculo; set => zonaDestinoVehiculo = value; }
        public DateTime FechaPasoVehiculo { get => fechaPasoVehiculo; set => fechaPasoVehiculo = value; }
        public bool LlevaMercancias { get => llevaMercancias; set => llevaMercancias = value; }

        public VehiculosDto(long idVehiculo, string matriculaVehiculo, string tipoVehiculo, string zonaDestinoVehiculo, bool llevaMercancias)
        {
            this.idVehiculo = idVehiculo;
            this.matriculaVehiculo = matriculaVehiculo;
            this.tipoVehiculo = tipoVehiculo;
            this.zonaDestinoVehiculo = zonaDestinoVehiculo;
            LlevaMercancias = llevaMercancias;
            this.fechaPasoVehiculo = fechaPasoVehiculo;
        }
    }
}
