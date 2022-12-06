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

        public decimal ObtenerMontoParaTarifas(int tipoVehiculoId, List<Tarifa> tarifas)
        {
            decimal monto;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifasPorVehiculo = new RepositorioTarifasPorVehiculo(conexion);

                monto = repositorioTarifasPorVehiculo.ObtenerMontoParaTarifas(tipoVehiculoId, tarifas);
            }

            return monto;

        }

        public decimal ObtenerPrecio(TipoDeVehiculo tipo, Tarifa tarifa)
        {
            decimal precio;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifasPorVehiculo = new RepositorioTarifasPorVehiculo(conexion);
                precio = repositorioTarifasPorVehiculo.ObtenerPrecio(tipo.TipoId, tarifa);
            }

            return precio;
        }


        public List<TarifaPorVehiculo> ObtenerTarifasPorVehiculo()
        {
            List<TarifaPorVehiculo> tarifasPorVehiculo;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifas = new RepositorioTarifas(conexion);
                repositorioTiposDeVehiculos = new RepositorioTiposDeVehiculo(conexion);
                repositorioTarifasPorVehiculo = new RepositorioTarifasPorVehiculo(conexion);


                List<Tarifa> tarifas = repositorioTarifas.ObtenerTarifas();
                List<TipoDeVehiculo> tipos = repositorioTiposDeVehiculos.ObtenerTiposDeVehiculo();

                tarifasPorVehiculo = repositorioTarifasPorVehiculo.ObtenerTarifasPorVehiculo(tipos,tarifas);

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
