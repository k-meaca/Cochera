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
