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

        public List<Modelo> ObtenerModelos()
        {
            List<Modelo> modelos;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMarcas = new RepositorioMarcas(conexion);
                repositorioTipoVehiculo = new RepositorioTiposDeVehiculo(conexion);
                repositorioModelos = new RepositorioModelos(conexion);

                List<Marca> marcas = repositorioMarcas.ObtenerMarcas();
                List<TipoDeVehiculo> tipos = repositorioTipoVehiculo.obtenerTiposDeVehiculo();
                modelos = repositorioModelos.ObtenerModelos(marcas, tipos);
            }

            return modelos;
        }
    }
}
