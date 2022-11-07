using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioMarcasDeTarjetas : Repositorio
    {
        //------------CONSTRUCTOR------------//

        public RepositorioMarcasDeTarjetas(SqlConnection conexion) : base(conexion) { }

        public RepositorioMarcasDeTarjetas(SqlConnection conexion, SqlTransaction transaccion) : base(conexion, transaccion) { }

        //------------METODOS------------//

        //----PRIVADOS----//

        private MarcaTarjeta CrearMarca(SqlDataReader lector)
        {
            int marcaId = lector.GetInt32(0);
            string marca = lector.GetString(1);

            return new MarcaTarjeta(marcaId, marca);
        }

        //----PUBLICOS----//

        public List<MarcaTarjeta> ObtenerMarcasDeTarjetas()
        {
            try
            {
                List<MarcaTarjeta> marcas = new List<MarcaTarjeta>();

                string query = "SELECT * FROM MarcasDeTarjetas;";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            marcas.Add(CrearMarca(lector));
                        }
                    }
                }

                return marcas;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
