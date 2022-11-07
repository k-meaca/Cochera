using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioMovimientosSalidas : Repositorio
    {
        //------------CONSTRUCTOR------------//

        public RepositorioMovimientosSalidas(SqlConnection conexion) : base(conexion) { }

        public RepositorioMovimientosSalidas(SqlConnection conexion, SqlTransaction transaccion) : base(conexion,transaccion) { }

        //------------METODOS------------//

        //----PRIVADOS----//

        public MovimientoSalida CrearMovimiento(List<Salida> salidas, SqlDataReader lector)
        {
            int movimientoId = lector.GetInt32(0);
            int salidaId = lector.GetInt32(1);
            decimal importe = lector.GetDecimal(2);

            Salida salida = salidas.Find(s => s.SalidaId == salidaId);

            return new MovimientoSalida(movimientoId, salida, importe);
        }

        //----PUBLICOS----//

        public List<MovimientoSalida> MovimientosSalidas(List<Salida> salidas)
        {
            try
            {
                List<MovimientoSalida> movimientos = new List<MovimientoSalida>();

                string query = "SELECT * FROM MovimientosSalidas;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            movimientos.Add(CrearMovimiento(salidas, lector));
                        }
                    }
                }

                return movimientos;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void PagarSalida(int salidaId, decimal importe)
        {
            try
            {
                string query = "exec SP_PagarSalida @SalidaId, @Importe;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@SalidaId", salidaId);
                    comando.Parameters.AddWithValue("@Importe", importe);

                    comando.ExecuteNonQuery();
                }
            }
            catch(SqlException)
            {
                throw;
            }
        }
    }
}
