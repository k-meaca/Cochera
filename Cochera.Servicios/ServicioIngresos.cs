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
    public class ServicioIngresos
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        private RepositorioIngresos repositorioIngresos;
        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioTiposDeVehiculo repositorioTipos;
        private RepositorioSectores repositorioSectores;

        //------------METODOS------------//

        public Ingreso GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {

            SqlTransaction transaccion = null;
            Ingreso ingreso;

            try
            {

                using (SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioIngresos = new RepositorioIngresos(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    ingreso = repositorioIngresos.GenerarIngreso(patente, tipo, fechaIngreso, estacionamiento);
                    repositorioEstacionamientos.OcuparEstacionamiento(estacionamiento.EstacionamientoId);

                    transaccion.Commit();
                }

                return ingreso;
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }

        public Ingreso ObtenerIngreso(Estacionamiento estacionamiento)
        {
            Ingreso ingreso;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioIngresos = new RepositorioIngresos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);

                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ingreso = repositorioIngresos.ObtenerIngreso(estacionamiento, tipos);
            }

            return ingreso;
        }

        public List<Ingreso> ObtenerIngresos()
        {
            List<Ingreso> ingresos;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ingresos = repositorioIngresos.ObtenerIngresos(tipos, estacionamientos);
            }

            return ingresos;

        }

        public Ingreso ObtenerUltimoIngreso(string patente)
        {
            Ingreso ultimoIngreso;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ultimoIngreso = repositorioIngresos.ObtenerUltimoIngreso(patente,tipos,estacionamientos);
            }

            return ultimoIngreso;
        }

    }
}
