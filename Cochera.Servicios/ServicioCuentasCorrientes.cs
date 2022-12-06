using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Datos;
using Cochera.Datos.Repositorios;
using Cochera.Entidades;

namespace Cochera.Servicios
{
    public class ServicioCuentasCorrientes
    {
        //------------ATRIBUTOS------------//
        private RepositorioCuentasCorrientes repositorioCtasCtes;

<<<<<<< HEAD
        private ServicioClientes servicioClientes;
        private ServicioTarjetas servicioTarjetas;

        //------------METODOS------------//

        //----PUBLICO----//

        public CuentaCorriente ObtenerCuentaCorriente(Cliente cliente)
        {
            return ObtenerCuentasCorrientes().Find(c => c.ObtenerClienteId() == cliente.ClienteId);
        }

        public List<CuentaCorriente> ObtenerCuentasCorrientes()
        {
            servicioClientes = new ServicioClientes();
            servicioTarjetas = new ServicioTarjetas();

            List<Cliente> clientes = servicioClientes.ObtenerClientes();
            List<Tarjeta> tarjetas = servicioTarjetas.ObtenerTarjetas();
=======
        private ServicioAbonados servicioAbonados;

        //------------METODOS------------//

        public List<CuentaCorriente> ObtenerCuentasCorrientes()
        {
            servicioAbonados = new ServicioAbonados();

            List<Abonado> abonados = servicioAbonados.ObtenerAbonados();
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

            List<CuentaCorriente> cuentas;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioCtasCtes = new RepositorioCuentasCorrientes(conexion);

<<<<<<< HEAD
                cuentas = repositorioCtasCtes.ObtenerCuentasCorrientes(clientes, tarjetas);
=======
                cuentas = repositorioCtasCtes.ObtenerCuentasCorrientes(abonados);
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
            }

            return cuentas;
        }

    }
}
