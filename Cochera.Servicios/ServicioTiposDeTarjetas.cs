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
    public class ServicioTiposDeTarjetas
    {
        //------------ATRIBUTOS------------//

        private RepositorioTiposDeTarjetas repositorioTipos;

        //------------METODOS------------//

        public List<TipoDePago> ObtenerTiposDeTarjetas()
        {
            List<TipoDePago> tipos;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTipos = new RepositorioTiposDeTarjetas(conexion);

                tipos = repositorioTipos.ObtenerTiposDeTarjeta();
            }

            return tipos;
        }
    }
}
