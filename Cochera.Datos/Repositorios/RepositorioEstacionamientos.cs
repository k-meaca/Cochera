using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    
    public class RepositorioEstacionamientos
    {

        //------------ATRIBUTOS------------//
        SqlConnection conexion;

        //------------CONSTRUCTOR------------//
        public RepositorioEstacionamientos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public List<Estacionamiento> ObtenerEstacionamientos(List<Sector> sectores)
        {
            try
            {
                List<Estacionamiento> estacionamientos = new List<Estacionamiento>();

                string query = "SELECT * FROM Estacionamientos;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int id = lector.GetInt32(0);
                            string ubicacion = lector.GetString(1);
                            int sectorId = lector.GetInt32(2);
                            bool ocupado = lector.GetBoolean(3);

                            Sector sector = sectores.Find(s => s.SectorId == sectorId);

                            Estacionamiento estacionamiento = new Estacionamiento(id, ubicacion, sector, ocupado);

                            estacionamientos.Add(estacionamiento);
                        }
                    }
                }

                return estacionamientos;
            }
            catch(SqlException)
            {
                throw;
            }

        }
    }
}
