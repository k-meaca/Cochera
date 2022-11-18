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
    public class ServicioSalidas
    {
        //------------ATRIBUTOS------------//
        private RepositorioSalidas repositorioSalidas;
        private RepositorioTarifasEnSalida repositorioTarifasEnSalida;
        private RepositorioEstacionamientos repositorioEstacionamiento;

        //------------METODOS------------//

        public void DarSalida(Ingreso ingreso, DateTime fechaSalida, decimal montoTotal, List<Tarifa> tarifas)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioSalidas = new RepositorioSalidas(conexion, transaccion);
                    repositorioTarifasEnSalida = new RepositorioTarifasEnSalida(conexion, transaccion);
                    repositorioEstacionamiento = new RepositorioEstacionamientos(conexion, transaccion);

                    int salidaId = repositorioSalidas.DarSalida(ingreso, fechaSalida, montoTotal);
                    repositorioTarifasEnSalida.EstablecerTarifasParaSalida(salidaId, tarifas);

                    repositorioEstacionamiento.DesocuparEstacionamiento(ingreso.ObtenerEstacionamientoId());

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }
    }
}
