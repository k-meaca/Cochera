using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class MarcaTarjeta
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//
        
        public int MarcaId { get; private set; }

        public string Marca { get; private set; }

        //------------CONSTRUCTOR------------//

        public MarcaTarjeta (int marcaId, string marca)
        {
            MarcaId = marcaId;
            Marca = marca;
        }

        public override string ToString()
        {
            return Marca;
        }
    }
}
