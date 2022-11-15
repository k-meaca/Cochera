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
    public class ServicioTiposDeVehiculos
    {
        //------------ATRIBUTOS-----------//

        private RepositorioTiposDeVehiculo repositorioTiposVehiculos;

        //------------METODOS-----------//

        //----PUBLICOS----//

        public TipoDeVehiculo ConstruirAuto()
        {
            TipoDeVehiculo auto;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTiposVehiculos = new RepositorioTiposDeVehiculo(conexion);
                auto = repositorioTiposVehiculos.ConstruirAuto();
            }

            return auto;
        }

        public TipoDeVehiculo ConstruirMoto()
        {
            TipoDeVehiculo moto;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTiposVehiculos = new RepositorioTiposDeVehiculo(conexion);
                moto = repositorioTiposVehiculos.ConstruirMoto();
            }

            return moto;
        }

        public List<TipoDeVehiculo> ObtenerTiposDeVehiculo()
        {
            List<TipoDeVehiculo> tipos;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTiposVehiculos = new RepositorioTiposDeVehiculo(conexion);
                tipos = repositorioTiposVehiculos.ObtenerTiposDeVehiculo();
            }

            return tipos;
        }
    }
}
