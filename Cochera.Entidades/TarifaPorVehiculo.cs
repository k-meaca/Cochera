using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class TarifaPorVehiculo
    {
        //------------ATRIBUTOS------------//

        private TipoDeVehiculo tipoVehiculo;
        private Tarifa tarifa;
        private decimal monto;

        //------------CONSTRUCTOR------------//

        public TarifaPorVehiculo(TipoDeVehiculo tipoVehiculo, Tarifa tarifa, decimal monto)
        {
            this.tipoVehiculo = tipoVehiculo;
            this.tarifa = tarifa;
            this.monto = monto;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public string ObtenerTipo()
        {
            return tipoVehiculo.Tipo;
        }

        public int ObtenerTipoId() => tipoVehiculo.TipoId;

        public string ObtenerTarifa()
        {
            return tarifa.Tiempo;
        }

        public int ObtenerTarifaId() => tarifa.TarifaId;

        public decimal ObtenerMonto()
        {
            return monto;
        }

        public void ActualizarMonto(decimal monto)
        {
            this.monto = monto;
        }

    }
}
