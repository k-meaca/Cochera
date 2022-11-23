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

        private ServicioAbonados servicioAbonados;

        //------------METODOS------------//

        public List<CuentaCorriente> ObtenerCuentasCorrientes()
        {
            servicioAbonados = new ServicioAbonados();

            List<Abonado> abonados = servicioAbonados.ObtenerAbonados();

            List<CuentaCorriente> cuentas;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioCtasCtes = new RepositorioCuentasCorrientes(conexion);

                cuentas = repositorioCtasCtes.ObtenerCuentasCorrientes(abonados);
            }

            return cuentas;
        }

    }
}
