using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entidades
{
    public class Tarifa
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int TarifaId { get; private set; }

        public string Tiempo {get; private set; }

        public decimal Monto { get; private set; }

        //------------CONSTRUCTOR------------//

        public Tarifa(int tarifaId, string tipoTarifa)
        {
            TarifaId = tarifaId;
            Tiempo = tipoTarifa;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

    }
}
