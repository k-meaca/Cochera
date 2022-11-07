using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class TipoDePago
    {
        //------------ATRIBUTOS Y PROPIEDADES-------------//

        public int TipoId { get; private set; }

        public string Tipo { get; private set; }

        //------------CONSTRUCTOR------------//

        public TipoDePago(int tipoId, string tipoDePago)
        {
            TipoId = tipoId;
            Tipo = tipoDePago;
        }

        //------------METODOS------------//

        public override string ToString()
        {
            return Tipo;
        }
    }
}
