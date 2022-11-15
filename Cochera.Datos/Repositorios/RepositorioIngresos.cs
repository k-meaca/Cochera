using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioIngresos
    {
        //------------ATRIBUTOS------------//

        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //-----------CONSTRUCTOR-----------//

        public RepositorioIngresos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioIngresos(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //-----------METODOS-------------//

        public void GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime ingreso, Estacionamiento estacionamiento)
        {
            try
            {
                string query = "exec SP_GenerarIngreso @Patente, @TipoVehiculoId, @FechaIngreso, @EstacionamientoId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Patente", patente);
                    comando.Parameters.AddWithValue("@TipoVehiculoId", tipo.TipoId);
                    comando.Parameters.AddWithValue("@FechaIngreso", ingreso);
                    comando.Parameters.AddWithValue("@EstacionamientoId", estacionamiento.EstacionamientoId);

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
