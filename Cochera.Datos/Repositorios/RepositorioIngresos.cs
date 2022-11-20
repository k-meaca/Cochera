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

        //----PRIVADOS----//

        private Ingreso ConstruirIngreso(List<TipoDeVehiculo> tipos, List<Estacionamiento> estacionamientos, SqlDataReader lector)
        {
            int ingresoId = lector.GetInt32(0);
            string patente = lector.GetString(1);
            int tipoId = lector.GetInt32(2);
            DateTime fechaIngreso = lector.GetDateTime(3);
            int estacionamientoId = lector.GetInt32(4);

            TipoDeVehiculo tipo = tipos.Find(t => t.TipoId == tipoId);
            Estacionamiento estacionamiento = estacionamientos.Find(e => e.EstacionamientoId == estacionamientoId);

            return new Ingreso(ingresoId, patente, tipo, fechaIngreso, estacionamiento);

        }

        private Ingreso SinIngreso(TipoDeVehiculo tipo, Estacionamiento estacionamiento)
        {
            DateTime antesDeAyer = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 2);

            return new Ingreso(-1, "", tipo, antesDeAyer, estacionamiento);
        }


        //----PUBLICOS----//
        public Ingreso GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {
            try
            {
                int ingresoId;

                string query = "exec SP_GenerarIngreso @Patente, @TipoVehiculoId, @FechaIngreso, @EstacionamientoId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Patente", patente);
                    comando.Parameters.AddWithValue("@TipoVehiculoId", tipo.TipoId);
                    comando.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                    comando.Parameters.AddWithValue("@EstacionamientoId", estacionamiento.EstacionamientoId);

                    ingresoId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return new Ingreso(ingresoId, patente, tipo, fechaIngreso, estacionamiento);
            }
            catch(SqlException)
            {
                throw;
            }
        }

        public Ingreso ObtenerIngreso(Estacionamiento estacionamiento, List<TipoDeVehiculo> tipos)
        {
            try
            {
                Ingreso ingreso;

                string query = "SELECT * FROM dbo.UF_ObtenerUltimoIngreso(@EstacionamientoId);";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@EstacionamientoId", estacionamiento.EstacionamientoId);

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        lector.Read();

                        int ingresoId = lector.GetInt32(0);
                        string patente = lector.GetString(1);
                        int tipoId = lector.GetInt32(2);
                        DateTime fechaIngreso = lector.GetDateTime(3);

                        TipoDeVehiculo tipo = tipos.Find(t => t.TipoId == tipoId);

                        ingreso = new Ingreso(ingresoId, patente, tipo, fechaIngreso, estacionamiento);
                    }
                }

                return ingreso;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Ingreso> ObtenerIngresos(List<TipoDeVehiculo> tipos, List<Estacionamiento> estacionamientos)
        {
            try
            {
                List<Ingreso> ingresos = new List<Ingreso>();

                string query = "SELECT * FROM Ingresos;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            ingresos.Add(ConstruirIngreso(tipos, estacionamientos,lector));
                        }
                    }
                }

                return ingresos;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Ingreso ObtenerUltimoIngreso(string patente, List<TipoDeVehiculo> tipos, List<Estacionamiento> estacionamientos)
        {

            Ingreso ultimoIngreso;

            ultimoIngreso = ObtenerIngresos(tipos, estacionamientos).FindLast(i => i.Patente == patente);

            //if(ultimoIngreso is null)
            //{
            //    ultimoIngreso = SinIngreso(tipos[0], estacionamientos[0]);
            //}
               
            return ultimoIngreso;
        }

    }

}
