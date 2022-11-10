using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioSectores
    {
        //------------ATRIBUTOS-----------//
        private SqlConnection conexion;

        //-----------CONSTRUCTOR------------//
        public RepositorioSectores(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//


        //----PUBLICOS----//

        public List<Sector> ObtenerSectores()
        {
            try
            {
                List<Sector> sectores = new List<Sector>();

                string query = "SELECT * FROM Sectores;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int sectorId = lector.GetInt32(0);
                            string nombre = lector.GetString(1);
                            int capacidad = lector.GetInt32(2);

                            Sector sector = new Sector(sectorId, nombre, capacidad);

                            sectores.Add(sector);
                        }

                    }
                }

                return sectores;

            }
            catch(SqlException)
            {
                throw;
            }
        }

    }
}
