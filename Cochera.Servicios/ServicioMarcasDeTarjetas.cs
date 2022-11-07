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
    public class ServicioMarcasDeTarjetas
    {
        //------------ATRIBUTOS------------//

        private RepositorioMarcasDeTarjetas repositorioMarcas;

        //-----------METODOS-----------//

        public List<MarcaTarjeta> ObtenerMarcasDeTarjetas()
        {
            List<MarcaTarjeta> marcas;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcasDeTarjetas(conexion);

                marcas = repositorioMarcas.ObtenerMarcasDeTarjetas();
            }

            return marcas;
        }
    }
}
