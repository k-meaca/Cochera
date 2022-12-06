using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Cliente
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int ClienteId { get; private set; }

        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        private Documento documento;

        public string Telefono { get; private set; }

        //------------CONSTRUCTOR------------//

        public Cliente(int personaId)
        {
            ClienteId = personaId;
        }

        public Cliente(int personaId, string nombre, string apellido, Documento documento) : this(personaId)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.documento = documento;
        }


        //------------METODOS------------//


        //----PRIVADOS----//

        //----PUBLICOS----//


        public void ActualizarDatos(string nombre, string apellido, Documento doc, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            documento = doc;
            Telefono = telefono;
        }

        public void AsignarTelefono(string telefono)
        {
            Telefono = telefono;
        }

        public void EstablecerNombreCompleto(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public void EstablecerDocumento(Documento documento)
        {
            this.documento = documento;
        }

        public string NombreCompleto()
        {
            return Apellido.ToUpper() + ", " + Nombre[0].ToString().ToUpper() + Nombre.Substring(1).ToLower();
        }

        public string ObtenerTipoDoc()
        {
            return documento.TipoDoc;
        }

        public int ObtenerTipoDocId()
        {
            return documento.TipoDocId;
        }

        public string ObtenerNumeroDoc()
        {
            return documento.NumDoc;
        }
    }
}
