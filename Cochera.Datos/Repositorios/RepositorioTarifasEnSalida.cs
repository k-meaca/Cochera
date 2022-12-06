using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioTarifasEnSalida
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

        public RepositorioTarifasEnSalida(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioTarifasEnSalida(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public void EstablecerTarifasParaSalida(int salidaId, List<Tarifa> tarifas)
        {
            try
            {
                string query = "exec SP_EstablecerTarifaEnSalida @SalidaId, @TarifaId;";

                foreach(Tarifa tarifa in tarifas)
                {
                    using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.AddWithValue("@SalidaId", salidaId);
                        comando.Parameters.AddWithValue("@TarifaId", tarifa.TarifaId);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


    }
}
