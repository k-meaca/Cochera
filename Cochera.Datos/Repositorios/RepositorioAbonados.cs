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
    public class RepositorioAbonados
    {
        //------------ATRIBUTOS------------//
        SqlConnection conexion;
        SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//
        public RepositorioAbonados(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioAbonados(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private Abonado CrearAbonado(List<Modelo> modelos, List<Tarifa> tarifas, Ingreso ingreso, List<Cliente> clientes, SqlDataReader lector)
        {
            int abonadoId = lector.GetInt32(0);
            int modeloId = lector.GetInt32(1);
            int tarifaId = lector.GetInt32(2);
            int clienteId = lector.GetInt32(4);
            DateTime fechaExpiracion = lector.GetDateTime(5);
            decimal importe = lector.GetDecimal(6);
            bool baja = lector.GetBoolean(7);

            Modelo modelo = modelos.Find(m => m.ModeloId == modeloId);
            Tarifa tarifa = tarifas.Find(t => t.TarifaId == tarifaId);
            Cliente cliente = clientes.Find(c => c.ClienteId == clienteId);

            return new Abonado(abonadoId, modelo, tarifa, ingreso, cliente, fechaExpiracion, importe, baja);

        }


        //----PUBLICOS----//

        public void DarBaja(Abonado abonado)
        {
            try
            {
                string query = "exec SP_DarBajaAbonado @AbonadoId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@AbonadoId", abonado.AbonadoId);

                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Abonado GenerarAbonado(Modelo modelo, Tarifa tarifa, Ingreso ingreso, Cliente cliente, DateTime fechaExpiracion, decimal importe)
        {
            try
            {
                Abonado abonado;

                string query = "exec SP_GenerarAbonado @ModeloId, @TarifaId, @IngresoId, @ClienteId, @FechaExpiracion, @Importe;";
            
                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@ModeloId",modelo.ModeloId);
                    comando.Parameters.AddWithValue("@TarifaId",tarifa.TarifaId);
                    comando.Parameters.AddWithValue("@IngresoId",ingreso.ObtenerIngresoId());
                    comando.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                    comando.Parameters.AddWithValue("@FechaExpiracion",fechaExpiracion);
                    comando.Parameters.AddWithValue("@Importe",importe);

                    int abonadoId = Convert.ToInt32(comando.ExecuteScalar());

                    abonado = new Abonado(abonadoId, modelo, tarifa, ingreso, cliente, fechaExpiracion, importe, false);
                }

                return abonado;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public IIngreso IngresoEsAbonado(List<Modelo> modelos, List<Tarifa> tarifas, Ingreso ingresoBuscado, List<Cliente> clientes)
        {
            try
            {
                IIngreso ingresoGenerado;

                string query = "SELECT * FROM dbo.UF_ObtenerAbonadoParaIngreso(@IngresoId);";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@IngresoId", ingresoBuscado.ObtenerIngresoId());

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.HasRows)
                        {
                            lector.Read();
                            ingresoGenerado = CrearAbonado(modelos, tarifas, ingresoBuscado, clientes, lector);
                        }
                        else
                        {
                            ingresoGenerado = ingresoBuscado;
                        }
                    }
                }
                return ingresoGenerado;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Abonado> ObtenerAbonados(List<Modelo> modelos, List<Tarifa> tarifas, List<IIngreso> ingresos, List<Cliente> clientes)
        {
            try
            {
                List<Abonado> abonados = new List<Abonado>();

                string query = "SELECT * FROM Abonados;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {

                            int ingresoId = lector.GetInt32(3);
                            Ingreso ingreso = (Ingreso)(ingresos.Find(i => i.ObtenerIngresoId() == ingresoId));

                            abonados.Add(CrearAbonado(modelos, tarifas, ingreso, clientes, lector));
                        }
                    }
                }

                return abonados;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
