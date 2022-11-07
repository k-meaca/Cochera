using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
    public class MovimientoSalida : IContable
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int MovimientoId { get; private set; }

        private Salida salida;

        public decimal importe; 

        //------------CONSTRUCTOR------------//

        public MovimientoSalida(int movimientoId, Salida salida, decimal importe)
        {
            MovimientoId = movimientoId;
            this.salida = salida;
            this.importe = importe;
        }

        //----------METODOS------------//

        public string Descripcion()
        {
            return "SALIDA COMUN";
        }

        public string Vehiculo()
        {
            return salida.ObtenerTipoVehiculo();
        }

        public string Patente()
        {
            return salida.ObtenerPatente();
        }

        public DateTime FechaMovimiento()
        {
            return salida.FechaSalida;
        }

        public string MedioDePago()
        {
            return "EFECTIVO";
        }

        public decimal Importe()
        {
            return importe;
        }

    }
}
