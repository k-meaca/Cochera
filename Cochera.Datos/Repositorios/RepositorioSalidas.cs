using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;

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

        //----PRIVADO----//

        private Salida CrearSalida(List<IIngreso> ingresos, SqlDataReader lector)
        {
            int salidaId = lector.GetInt32(0);
            int ingresoId = lector.GetInt32(1);
            DateTime fechaSalida = lector.GetDateTime(2);

            Ingreso ingreso = (Ingreso)(ingresos.Find(i => i.ObtenerIngresoId() == ingresoId));

            return new Salida(salidaId, ingreso, fechaSalida);
        }



        //----PUBLICOS----//
        public int DarSalida(Ingreso ingreso, DateTime fechaSalida)
        {
            try
            {
                int salidaId;

                string query = "exec SP_DarSalida @IngresoId, @FechaSalida;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@IngresoId", ingreso.ObtenerIngresoId());
                    comando.Parameters.AddWithValue("@FechaSalida", fechaSalida);

                    salidaId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return salidaId;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void DarSalidaAbonado(Abonado abonado)
        {
            try
            {
                string query = "exec SP_SalidaAAbonado @IngresoId, @FechaSalida;";

                using (SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@IngresoId", abonado.ObtenerIngresoId());

                    if(DateTime.Now <= abonado.FechaExpiracion)
                    {
                        comando.Parameters.AddWithValue("@FechaSalida", DateTime.Now);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@FechaSalida", abonado.FechaExpiracion);
                    }

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Salida> ObtenerSalidas(List<IIngreso> ingresos)
        {
            try
            {
                List<Salida> salidas = new List<Salida>();

                string query = "SELECT * FROM Salidas;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            salidas.Add(CrearSalida(ingresos,lector));
                        }
                    }
                }

                return salidas;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Salida ObtenerUltimaSalida(string patente, List<IIngreso> ingresos)
        {
            Salida ultimaSalida;

            ultimaSalida = ObtenerSalidas(ingresos).FindLast(s => s.ObtenerPatente() == patente);

            return ultimaSalida;
        }
    }
}
