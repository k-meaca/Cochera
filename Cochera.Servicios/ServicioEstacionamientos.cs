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
    public class ServicioEstacionamientos
    {

        //------------ATRIBUTOS------------//

        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioSectores repositorioSectores;
        private RepositorioTiposDeVehiculo repositorioTiposVehiculos;
        private RepositorioVehiculosPorEstacionamiento repositorioVPorE;

        //------------METODOS------------//

        //----PRIVADOS----//

        private List<Estacionamiento> ObtenerEstacionamientosPorSector(string sector)
        {
            return ObtenerEstacionamientos().Where(est => est.ObtenerSector() == sector).ToList();
        }

        //----PUBLICOS----//

        public List<Estacionamiento> ObtenerEstacionamientos()
        {
            List<Estacionamiento> estacionamientos;
            List<Sector> sectores;
            List<TipoDeVehiculo> tipos;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTiposVehiculos = new RepositorioTiposDeVehiculo(conexion);
                repositorioVPorE = new RepositorioVehiculosPorEstacionamiento(conexion);

                sectores = repositorioSectores.ObtenerSectores();

                estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);

                tipos = repositorioTiposVehiculos.ObtenerTiposDeVehiculo();

                repositorioVPorE.EstablecerVehiculosPorEstacionamiento(estacionamientos, tipos);
            }

            return estacionamientos;
        }

        public List<Estacionamiento> ObtenerEstacionamientosPB()
        {
            return ObtenerEstacionamientosPorSector("Planta Baja");
        }

        public List<Estacionamiento> ObtenerEstacionamientosSubsueloA()
        {
            return ObtenerEstacionamientosPorSector("Subsuelo A");
        }

        public List<Estacionamiento> ObtenerEstacionamientosSubsueloB()
        {
            return ObtenerEstacionamientosPorSector("Subsuelo B");
        }

        public List<Estacionamiento> ObtenerEstacionamientosSubsueloC()
        {
            return ObtenerEstacionamientosPorSector("Subsuelo C");
        }

        public List<Estacionamiento> ObtenerEstacionamientosSubsueloD()
        {
            return ObtenerEstacionamientosPorSector("Subsuelo D");
        }
    }
}
