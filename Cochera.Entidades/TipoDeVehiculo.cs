using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;


namespace Cochera.Entidades
{
    public class TipoDeVehiculo 
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//
        public int TipoId { get; private set; }

        public string Tipo { get; private set; }

        public string ImagenAsociada { get; private set; }

        //------------CONSTRUCTOR------------//

        public TipoDeVehiculo(int tipoId, string tipo, string imagen)
        {
            TipoId = tipoId;
            Tipo = tipo;
            ImagenAsociada = imagen;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public override string ToString()
        {
            return Tipo;
        }
    }
}
