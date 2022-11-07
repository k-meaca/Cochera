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
    public class ServicioMovimientosCtasCtes
    {
        //------------ATRIBUTOS------------//
        private RepositorioMovimientosCtasCtes repositorioMovimientos;

        private ServicioAbonados servicioAbonados;
        private ServicioCuentasCorrientes servicioCuentas;

        //------------METODOS-------------//

        public List<MovimientoCuentaCorriente> MovimientosCuentasCorrientes()
        {
            servicioAbonados = new ServicioAbonados();
            servicioCuentas = new ServicioCuentasCorrientes();

            List<CuentaCorriente> cuentas = servicioCuentas.ObtenerCuentasCorrientes();
            List<Abonado> abonados = servicioAbonados.ObtenerAbonados();

            List<MovimientoCuentaCorriente> movimientos;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMovimientos = new RepositorioMovimientosCtasCtes(conexion);

                movimientos = repositorioMovimientos.MovimientosCuentasCorrientes(cuentas, abonados);
            }

            return movimientos;
        }
    }
}
