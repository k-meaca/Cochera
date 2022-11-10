using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Documento : ICloneable
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//
        
        public int TipoDocId { get; private set; }

        public string TipoDoc { get; private set; }

        public string NumDoc { get; private set; }

        //------------CONSTRUCTOR------------//

        public Documento(int tipoDocId, string tipo)
        {
            TipoDocId = tipoDocId;
            TipoDoc = tipo;
        }

        //------------METODOS------------//

        //----PRIVADOS----//
        
        
        //----PUBLICOS----//

        public void ActualizarTipo(string tipo)
        {
            TipoDoc = tipo;
        }

        public void EstablecerNumeroDeDoc(string numero)
        {
            NumDoc = numero;
        }

        public object Clone()
        {
            Documento documento = new Documento(TipoDocId, TipoDoc);

            if (!(NumDoc is null))
            {
                documento.EstablecerNumeroDeDoc(NumDoc);
            }

            return documento;
        }

        public override string ToString()
        {
            return TipoDoc;
        }
    }
}
