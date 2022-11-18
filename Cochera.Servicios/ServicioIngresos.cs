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

        //------------METODOS------------//

        public Ingreso GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {
            
            SqlTransaction transaccion = null;
            Ingreso ingreso;

            try
            {
                
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();
                    
                    repositorioIngresos = new RepositorioIngresos(conexion,transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    ingreso = repositorioIngresos.GenerarIngreso(patente, tipo,fechaIngreso, estacionamiento);
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

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioIngresos = new RepositorioIngresos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);

                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ingreso = repositorioIngresos.ObtenerIngreso(estacionamiento,tipos);
            }

            return ingreso;
        }
    }
}
