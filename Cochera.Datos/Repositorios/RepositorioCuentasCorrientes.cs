using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
<<<<<<< HEAD
    public class RepositorioCuentasCorrientes : Repositorio
    {

        //------------CONSTRUCTOR------------//

        public RepositorioCuentasCorrientes(SqlConnection conexion) : base(conexion) { }

        public RepositorioCuentasCorrientes(SqlConnection conexion, SqlTransaction transaccion) : base(conexion, transaccion) { }
=======
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
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

        //------------METODOS------------//

        //----PRIVADOS----//

<<<<<<< HEAD
        private CuentaCorriente CrearCuenta(List<Cliente> clientes, List<Tarjeta> tarjetas, SqlDataReader lector)
        {
            int ctaCteId = lector.GetInt32(0);
            int clienteId = lector.GetInt32(1);
            int tarjetaId = lector.GetInt32(2);

            Cliente cliente = clientes.Find(a => a.ClienteId == clienteId);
            Tarjeta tarjeta = tarjetas.Find(t => t.TarjetaId == tarjetaId);

            return new CuentaCorriente(ctaCteId, cliente, tarjeta);
=======
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
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        }

        //----PUBLICOS----//

<<<<<<< HEAD
        public void GenerarCuentaCorriente(Cliente cliente, int tarjetaId)
        {
            try
            {
                string query = "exec SP_GenerarCuentaCorriente @ClienteId, @TarjetaId";
=======
        public void DebitarImporte(Abonado abonado, decimal importe)
        {
            try
            {
                string query = "exec SP_DebitarImporte @AbonadoId, @Descripcion, @Debe, @Haber, @Saldo, @FechaMovimiento;";
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
<<<<<<< HEAD
                    comando.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                    comando.Parameters.AddWithValue("TarjetaId", tarjetaId);
=======
                    comando.Parameters.AddWithValue("@AbonadoId", abonado.AbonadoId);
                    comando.Parameters.AddWithValue("@Descripcion", GenerarDescripcion(abonado));
                    comando.Parameters.AddWithValue("@Debe", importe);
                    comando.Parameters.AddWithValue("@Haber", importe);
                    comando.Parameters.AddWithValue("@Saldo", 0);
                    comando.Parameters.AddWithValue("@FechaMovimiento", DateTime.Now);
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

<<<<<<< HEAD

        public List<CuentaCorriente> ObtenerCuentasCorrientes(List<Cliente> clientes, List<Tarjeta> tarjetas) 
=======
        public List<CuentaCorriente> ObtenerCuentasCorrientes(List<Abonado> abonados) 
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
<<<<<<< HEAD
                            cuentas.Add(CrearCuenta(clientes, tarjetas, lector));
=======
                            cuentas.Add(CrearCuenta(abonados, lector));
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
