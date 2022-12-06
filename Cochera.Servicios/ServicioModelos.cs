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
    public class ServicioModelos
    {
        //------------ATRIBUTOS------------//
        RepositorioModelos repositorioModelos;
        RepositorioMarcas repositorioMarcas;
        RepositorioTiposDeVehiculo repositorioTipoVehiculo;

        //------------METODOS------------//

        public void ActualizarModelo(Modelo modelo)
        {
            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioModelos = new RepositorioModelos(conexion);
                repositorioModelos.ActualizarModelo(modelo);
            }
        }

        public Modelo AgregarModelo(string nombreModelo, Marca marca, TipoDeVehiculo tipo)
        {
            Modelo modelo;
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioModelos = new RepositorioModelos(conexion);
                modelo = repositorioModelos.AgregarModelo(nombreModelo, marca, tipo);
            }

            return modelo;
        }

        public void EliminarModelo(Modelo modelo)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioModelos = new RepositorioModelos(conexion);

                repositorioModelos.EliminarModelo(modelo);
            }
        }
        public List<Modelo> ObtenerModelos()
        {
            List<Modelo> modelos;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                repositorioTipoVehiculo = new RepositorioTiposDeVehiculo(conexion);
                repositorioModelos = new RepositorioModelos(conexion);

                List<Marca> marcas = repositorioMarcas.ObtenerMarcas();
                List<TipoDeVehiculo> tipos = repositorioTipoVehiculo.ObtenerTiposDeVehiculo();
                modelos = repositorioModelos.ObtenerModelos(marcas, tipos);
            }

            return modelos;
        }

        public List<Modelo> ObtenerModelos(TipoDeVehiculo tipo)
        {
            List<Modelo> modelos;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                repositorioModelos = new RepositorioModelos(conexion);
                
                List<Marca> marcas = repositorioMarcas.ObtenerMarcas();
                modelos = repositorioModelos.ObtenerModelos(marcas, tipo);
            }

            return modelos;
        }
    }
}
