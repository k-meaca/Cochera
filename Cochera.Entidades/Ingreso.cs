using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Ingreso
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int IngresoId { get; private set; }

        public string Patente { get; private set; }


        private TipoDeVehiculo tipo;

        public DateTime FechaIngreso { get; private set; }

        private Estacionamiento estacionamiento;

        //------------CONSTRUCTOR------------//

        public Ingreso(int ingresoId, string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {
            IngresoId = ingresoId;
            Patente = patente;
            this.tipo = tipo;
            FechaIngreso = fechaIngreso;
            this.estacionamiento = estacionamiento;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public int ObtenerTipoVehiculoId()
        {
            return tipo.TipoId;
        }

        public int ObtenerEstacionamientoId()
        {
            return estacionamiento.EstacionamientoId;
        }
    }
}
