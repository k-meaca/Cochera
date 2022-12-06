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
<<<<<<< HEAD

            Ingreso ingreso = (Ingreso)(ingresos.Find(i => i.ObtenerIngresoId() == ingresoId));

            return new Salida(salidaId, ingreso, fechaSalida);
        }



        //----PUBLICOS----//
        public int DarSalida(Ingreso ingreso, DateTime fechaSalida)
=======
            decimal montoTotal = lector.GetDecimal(3);

            Ingreso ingreso = (Ingreso)(ingresos.Find(i => i.ObtenerIngresoId() == ingresoId));

            return new Salida(salidaId, ingreso, fechaSalida, montoTotal);
        }

        private Salida SinSalida(Ingreso ingreso)
        {
            DateTime ayer = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);

            return new Salida(-1, ingreso, ayer, 0);
        }

        //----PUBLICOS----//
        public int DarSalida(Ingreso ingreso, DateTime fechaSalida, decimal montoTotal)
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        {
            try
            {
                int salidaId;

<<<<<<< HEAD
                string query = "exec SP_DarSalida @IngresoId, @FechaSalida;";
=======
                string query = "exec SP_DarSalida @IngresoId, @FechaSalida, @MontoTotal;";
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@IngresoId", ingreso.ObtenerIngresoId());
                    comando.Parameters.AddWithValue("@FechaSalida", fechaSalida);
<<<<<<< HEAD
=======
                    comando.Parameters.AddWithValue("@MontoTotal", montoTotal);
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

                    salidaId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return salidaId;
            }
            catch (SqlException)
            {
                throw;
            }
        }

<<<<<<< HEAD
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

=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
