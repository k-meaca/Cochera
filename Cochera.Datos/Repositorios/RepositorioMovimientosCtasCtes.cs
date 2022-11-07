using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioMovimientosCtasCtes
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

        public RepositorioMovimientosCtasCtes(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioMovimientosCtasCtes(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private MovimientoCuentaCorriente CrearMovimiento(List<CuentaCorriente> cuentas, List<Abonado> abonados, SqlDataReader lector)
        {
            int movimientoId = lector.GetInt32(0);
            int cuentaId = lector.GetInt32(1);
            int abonadoId = lector.GetInt32(2);
            decimal debe = lector.GetDecimal(3);
            decimal haber = lector.GetDecimal(4);
            decimal saldo = lector.GetDecimal(5);

            CuentaCorriente cuenta = cuentas.Find(c => c.CuentaId == cuentaId);
            Abonado abonado = abonados.Find(a => a.AbonadoId == abonadoId);

            return new MovimientoCuentaCorriente(movimientoId, cuenta, abonado, debe, haber, saldo);
        }


        //----PUBLICOS----//

        public void DebitarImporte(CuentaCorriente cuenta, Abonado abonado, decimal importe)
        {
            try
            {
                string query = "exec SP_DebitarImporte @CuentaCorrienteId, @AbonadoId, @Debe, @Haber, @Saldo;";

                using (SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@CuentaCorrienteId", cuenta.CuentaId);
                    comando.Parameters.AddWithValue("@AbonadoId", abonado.AbonadoId);
                    comando.Parameters.AddWithValue("@Debe", importe);
                    comando.Parameters.AddWithValue("@Haber", importe);
                    comando.Parameters.AddWithValue("@Saldo", 0);
                    
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<MovimientoCuentaCorriente> MovimientosCuentasCorrientes(List<CuentaCorriente> cuentas, List<Abonado> abonados)
        {
            try
            {
                List<MovimientoCuentaCorriente> movimientos = new List<MovimientoCuentaCorriente>();

                string query = "SELECT * FROM MovimientosCuentasCorrientes;";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            movimientos.Add(CrearMovimiento(cuentas, abonados, lector));
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
    }
}
