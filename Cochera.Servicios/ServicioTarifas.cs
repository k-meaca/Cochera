using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;
using Cochera.Datos;
using Cochera.Datos.Repositorios;


namespace Cochera.Servicios
{
    public class ServicioTarifas
    {
        //------------ATRIBUTOS------------//

        private RepositorioTarifas repositorioTarifas;

        //------------METODOS------------//

        public List<Tarifa> ObtenerTarifas()
        {
            List<Tarifa> tarifas;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifas = new RepositorioTarifas(conexion);
                tarifas = repositorioTarifas.ObtenerTarifas();
            }

            return tarifas;
        }

        public List<Tarifa> ObtenerTarifasAbonados()
        {
            List<Tarifa> tarifas;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarifas = new RepositorioTarifas(conexion);
                tarifas = repositorioTarifas.ObtenerTarifasAbonados();
            }

            return tarifas;

        }
    }
}
