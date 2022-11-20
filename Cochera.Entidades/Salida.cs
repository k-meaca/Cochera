using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Salida
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int SalidaId { get; private set; }

        private Ingreso ingreso;

        public DateTime FechaSalida { get; private set; }

        public decimal MontoTotal { get; private set; }

        //------------CONSTRUCTOR------------//

        public Salida(int salidaId, Ingreso ingreso, DateTime fechaSalida, decimal montoTotal)
        {
            SalidaId = salidaId;
            this.ingreso = ingreso;
            FechaSalida = fechaSalida;
            MontoTotal = montoTotal;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public DateTime ObtenerFechaIngreso()
        {
            return ingreso.FechaIngreso;
        }

        public string ObtenerPatente()
        {
            return ingreso.Patente;
        
        }

        public string ObtenerSector()
        {
            return ingreso.ObtenerSector();
        }

        public string ObtenerTipoVehiculo()
        {
            return ingreso.ObtenerTipoVehiculo();
        }

        public string ObtenerUbicacion()
        {
            return ingreso.ObtenerUbicacion();
        }

    }
}
