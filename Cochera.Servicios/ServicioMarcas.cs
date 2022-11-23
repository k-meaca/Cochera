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
    public class ServicioMarcas
    {
        //------------ATRIBUTOS-----------//

        private RepositorioMarcas repositorioMarcas;

        //------------METODOS-----------//

        //----PUBLICOS----//

        public void ActualizarMarca(Marca marca)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                repositorioMarcas.ActualizarMarca(marca);
            }
        }

        public Marca AgregarMarca(string nombreMarca)
        {
            Marca marca;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                marca = repositorioMarcas.AgregarMarca(nombreMarca);
            }

            return marca;
        }

        public void EliminarMarca(Marca marca)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);

                repositorioMarcas.EliminarMarca(marca);
            }
        }
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcas;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                marcas = repositorioMarcas.ObtenerMarcas();
            }

            return marcas;
        }

        public Marca ObtenerMarca(int marcaId)
        {
            Marca marca;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                marca = repositorioMarcas.ObtenerMarca(marcaId);
            }

            return marca;
        }
    }
}
