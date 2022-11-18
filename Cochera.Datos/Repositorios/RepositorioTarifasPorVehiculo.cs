using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
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

        public decimal ObtenerMontoParaTarifas(int tipoVehiculoId, List<Tarifa> tarifas)
        {
            decimal monto = 0;

            foreach(Tarifa tarifa in tarifas)
            {
                monto += ObtenerPrecio(tipoVehiculoId, tarifa);
            }

            return monto;
        }

        public decimal ObtenerPrecio(int tipoVehiculoId, Tarifa tarifa)
        {
            try
            {
                decimal precio;

                string query = "SELECT dbo.UF_ObtenerPrecio(@TipoDeVehiculoId,@TarifaId);";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDeVehiculoId", tipoVehiculoId);
                    comando.Parameters.AddWithValue("@TarifaId", tarifa.TarifaId);

                    precio = Convert.ToDecimal(comando.ExecuteScalar());
                }

                return precio;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<TarifaPorVehiculo> ObtenerTarifasPorVehiculo(List<TipoDeVehiculo> tipos, List<Tarifa> tarifas)
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

                            TipoDeVehiculo tipo = tipos.Find(t => t.TipoId == tipoId);
                            Tarifa tarifa = tarifas.Find(f => f.TarifaId == tarifaId);

                            TarifaPorVehiculo tpf = new TarifaPorVehiculo(tipo, tarifa, monto);

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
