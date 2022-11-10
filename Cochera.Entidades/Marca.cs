using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Marca
    {

        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int MarcaId { get; private set; }

        public string Nombre { get; private set; }

        //------------CONSTRUCTOR------------//

        public Marca(int marcaId, string marca)
        {
            MarcaId = marcaId;
            Nombre = marca;
        }

        //------------METODOS------------//


        //----PRIVADOS----//


        //----PUBLICOS----//

        public void ActualizarMarca(string marca)
        {
            Nombre = marca;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
