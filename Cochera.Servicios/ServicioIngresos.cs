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

        //------------METODOS------------//

        public void GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime ingreso, Estacionamiento estacionamiento)
        {
            
            SqlTransaction transaccion = null;

            try
            {
                
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();
                    
                    repositorioIngresos = new RepositorioIngresos(conexion,transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    repositorioIngresos.GenerarIngreso(patente, tipo,ingreso, estacionamiento);
                    repositorioEstacionamientos.OcuparEstacionamiento(estacionamiento);

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                transaccion.Rollback();
            }
        }
    }
}
