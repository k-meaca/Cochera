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
    public class ServicioTarifasPorVehiculo
    {
        //------------ATRIBUTOS------------//

        RepositorioTarifas repositorioTarifas;
        RepositorioTiposDeVehiculo repositorioTiposDeVehiculos;
        RepositorioTarifasPorVehiculo repositorioTarifasPorVehiculo;

        //------------METODOS------------//

        //----PUBLICOS----//

        public List<TarifaPorVehiculo> obtenerTarifasPorVehiculo()
        {
            List<TarifaPorVehiculo> tarifasPorVehiculo;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifas = new RepositorioTarifas(conexion);
                repositorioTiposDeVehiculos = new RepositorioTiposDeVehiculo(conexion);
                repositorioTarifasPorVehiculo = new RepositorioTarifasPorVehiculo(conexion);


                List<Tarifa> tarifas = repositorioTarifas.obtenerTarifas();
                List<TipoDeVehiculo> tipos = repositorioTiposDeVehiculos.obtenerTiposDeVehiculo();

                tarifasPorVehiculo = repositorioTarifasPorVehiculo.obtenerTarifasPorVehiculo(tipos,tarifas);

            }

            return tarifasPorVehiculo;
        }

        public void ActualizarTarifa(TarifaPorVehiculo tarifaPorVehiculo)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifasPorVehiculo = new RepositorioTarifasPorVehiculo(conexion);
                repositorioTarifasPorVehiculo.ActualizarTarifa(tarifaPorVehiculo);
            }
        }

    }
}
