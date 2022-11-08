using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Entidades;

namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioTarifasPorVehiculo
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;

        //------------CONSTRUCTOR------------//
        public RepositorioTarifasPorVehiculo(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

        public List<TarifaPorVehiculo> obtenerTarifasPorVehiculo(List<TipoDeVehiculo> tipos, List<Tarifa> tarifas)
        {
            List<TarifaPorVehiculo> tarifasPorVehiculos = new List<TarifaPorVehiculo>();

            try
            {
                string query = "SELECT * FROM TarifasPorVehiculos;";
                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tipoId = lector.GetInt32(0);
                            int tarifaId = lector.GetInt32(1);
                            decimal monto = lector.GetDecimal(2);

                            TarifaPorVehiculo tpf = new TarifaPorVehiculo(tipos[tipoId - 1], tarifas[tarifaId - 1], monto);

                            tarifasPorVehiculos.Add(tpf);
                        }
                    }

                }
            }
            catch (SqlException)
            {
                throw;
            }

            return tarifasPorVehiculos;
        }

        public void ActualizarTarifa(TarifaPorVehiculo tarifaPorVehiculo)
        {
            try
            {
                string query = "exec SP_ActualizarTarifaPorVehiculo @TipoId, @TarifaId, @Monto;";

                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoId", tarifaPorVehiculo.ObtenerTipoId());
                    comando.Parameters.AddWithValue("@TarifaId", tarifaPorVehiculo.ObtenerTarifaId());
                    comando.Parameters.AddWithValue("@Monto", tarifaPorVehiculo.ObtenerMonto());

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
