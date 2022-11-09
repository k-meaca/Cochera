using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Datos;
using Estacionamiento.Datos.Repositorios;
using Estacionamiento.Entidades;

namespace Estacionamiento.Servicios
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
