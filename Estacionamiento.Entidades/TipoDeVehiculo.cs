using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Entidades
{
    public class TipoDeVehiculo 
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int TipoId { get; private set; }

        public string Tipo { get; private set; }


        //------------CONSTRUCTOR------------//

        public TipoDeVehiculo(int tipoId, string tipo)
        {
            TipoId = tipoId;
            Tipo = tipo;
        }

        //------------METODOS------------//

        //----PUBLICOS----//
    }
}
