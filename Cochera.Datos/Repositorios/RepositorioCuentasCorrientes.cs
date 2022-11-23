using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioCuentasCorrientes
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

        public RepositorioCuentasCorrientes(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioCuentasCorrientes(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private CuentaCorriente CrearCuenta(List<Abonado> abonados, SqlDataReader lector)
        {
            int ctaCteId = lector.GetInt32(0);
            int abonadoId = lector.GetInt32(1);
            string descripcion = lector.GetString(2);
            decimal debe = lector.GetDecimal(3);
            decimal haber = lector.GetDecimal(4);
            decimal saldo = lector.GetDecimal(5);
            DateTime fechaMov = lector.GetDateTime(6);

            Abonado abonado = abonados.Find(a => a.AbonadoId == abonadoId);

            return new CuentaCorriente(ctaCteId, abonado, descripcion, debe, haber, saldo, fechaMov);
        }

        private string GenerarDescripcion(Abonado abonado)
        {
            string descripcion = "DEB-" + abonado.ObtenerNombreCliente()[0] + abonado.ObtenerApellidoCliente()[0] + "-" + abonado.ObtenerPatente();

            return descripcion;
        }

        //----PUBLICOS----//

        public void DebitarImporte(Abonado abonado, decimal importe)
        {
            try
            {
                string query = "exec SP_DebitarImporte @AbonadoId, @Descripcion, @Debe, @Haber, @Saldo, @FechaMovimiento;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@AbonadoId", abonado.AbonadoId);
                    comando.Parameters.AddWithValue("@Descripcion", GenerarDescripcion(abonado));
                    comando.Parameters.AddWithValue("@Debe", importe);
                    comando.Parameters.AddWithValue("@Haber", importe);
                    comando.Parameters.AddWithValue("@Saldo", 0);
                    comando.Parameters.AddWithValue("@FechaMovimiento", DateTime.Now);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<CuentaCorriente> ObtenerCuentasCorrientes(List<Abonado> abonados) 
        {
            try
            {
                List<CuentaCorriente> cuentas = new List<CuentaCorriente>();

                string query = "SELECT * FROM CuentasCorrientes;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            cuentas.Add(CrearCuenta(abonados, lector));
                        }
                    }
                }

                return cuentas;
            }
            catch (SqlException)
            {
                throw;
            }

        } 
    }
}
