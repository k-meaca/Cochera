using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Datos;
using Cochera.Datos.Repositorios;
using Cochera.Entidades;

namespace Cochera.Servicios
{
    public class ServicioTiposDeDocumentos
    {

        //------------ATRIBUTOS------------//

        RepositorioTipoDocumentos repositorioTipoDocs;

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

        public void ActualizarTipoDeDocumento(Documento documento)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTipoDocs = new RepositorioTipoDocumentos(conexion);
                repositorioTipoDocs.ActualizarTipoDeDocumento(documento);
            }
        }

        public Documento AgregarTipoDeDocumento(string tipoDoc)
        {
            Documento doc;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTipoDocs = new RepositorioTipoDocumentos(conexion);
                doc = repositorioTipoDocs.AgregarTipoDeDocumento(tipoDoc);
            }

            return doc;
        }

        public void EliminarDocumento(Documento doc)
        {

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {

                repositorioTipoDocs = new RepositorioTipoDocumentos(conexion);

                repositorioTipoDocs.EliminarDocumento(doc);
            }
            
        }

        public List<Documento> ObtenerTiposDeDocumentos()
        {
            List<Documento> documentos;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTipoDocs = new RepositorioTipoDocumentos(conexion);
                documentos = repositorioTipoDocs.ObtenerDocumentos();
            }

            return documentos;
        }
    }
}
