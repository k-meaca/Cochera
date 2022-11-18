using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioSalidas
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

        public RepositorioSalidas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioSalidas(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }


        //------------METODOS------------//


        //----PUBLICOS----//
        public int DarSalida(Ingreso ingreso, DateTime fechaSalida, decimal montoTotal)
        {
            try
            {
                int salidaId;

                string query = "exec SP_DarSalida @IngresoId, @FechaSalida, @MontoTotal;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@IngresoId", ingreso.IngresoId);
                    comando.Parameters.AddWithValue("@FechaSalida", fechaSalida);
                    comando.Parameters.AddWithValue("@MontoTotal", montoTotal);

                    salidaId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return salidaId;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
