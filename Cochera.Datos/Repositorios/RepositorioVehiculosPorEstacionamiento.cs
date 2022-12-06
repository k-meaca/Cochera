using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;


namespace Cochera.Datos.Repositorios
{
    public class RepositorioVehiculosPorEstacionamiento
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;

        //------------CONSTRUCTOR-----------//
        public RepositorioVehiculosPorEstacionamiento(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        public void EstablecerVehiculoEnEstacionamiento(int estacionamientoId, int tipoVehiculoId, List<Estacionamiento> estacionamientos, List<TipoDeVehiculo> tipos)
        {
            Estacionamiento estacionamiento = estacionamientos.Find(e => e.EstacionamientoId == estacionamientoId);
            TipoDeVehiculo tipo = tipos.Find(t => t.TipoId == tipoVehiculoId);

            estacionamiento.PermitirVehiculo(tipo);
        }

        //----PUBLICOS----//

        public void EstablecerVehiculosPorEstacionamiento(List<Estacionamiento> estacionamiento, List<TipoDeVehiculo> tipos)
        {
            try
            {
                string query = "SELECT * FROM VehiculosParaEstacionamientos;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int estacionamientoId = lector.GetInt32(0);
                            int tipoVehiculoId = lector.GetInt32(1);

                            EstablecerVehiculoEnEstacionamiento(estacionamientoId, tipoVehiculoId, estacionamiento, tipos);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
