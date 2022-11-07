using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioCuentasCorrientes : Repositorio
    {

        //------------CONSTRUCTOR------------//

        public RepositorioCuentasCorrientes(SqlConnection conexion) : base(conexion) { }

        public RepositorioCuentasCorrientes(SqlConnection conexion, SqlTransaction transaccion) : base(conexion, transaccion) { }

        //------------METODOS------------//

        //----PRIVADOS----//

        private CuentaCorriente CrearCuenta(List<Cliente> clientes, List<Tarjeta> tarjetas, SqlDataReader lector)
        {
            int ctaCteId = lector.GetInt32(0);
            int clienteId = lector.GetInt32(1);
            int tarjetaId = lector.GetInt32(2);

            Cliente cliente = clientes.Find(a => a.ClienteId == clienteId);
            Tarjeta tarjeta = tarjetas.Find(t => t.TarjetaId == tarjetaId);

            return new CuentaCorriente(ctaCteId, cliente, tarjeta);
        }

        //----PUBLICOS----//

        public void GenerarCuentaCorriente(Cliente cliente, int tarjetaId)
        {
            try
            {
                string query = "exec SP_GenerarCuentaCorriente @ClienteId, @TarjetaId";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                    comando.Parameters.AddWithValue("TarjetaId", tarjetaId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


        public List<CuentaCorriente> ObtenerCuentasCorrientes(List<Cliente> clientes, List<Tarjeta> tarjetas) 
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
                            cuentas.Add(CrearCuenta(clientes, tarjetas, lector));
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
