using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Entidades;


namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioTiposDeVehiculo
    {
        //------------ATRIBUTOS------------//

        private SqlConnection conexion;

        //------------CONSTRUCTOR------------//

        public RepositorioTiposDeVehiculo(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public List<TipoDeVehiculo> obtenerTiposDeVehiculo()
        {
            List<TipoDeVehiculo> tipos = new List<TipoDeVehiculo>();

            try
            {
                string query = "SELECT * FROM TiposDeVehiculos;";

                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tipoId = lector.GetInt32(0);
                            string tipo = lector.GetString(1);

                            TipoDeVehiculo tipoDeVehiculo = new TipoDeVehiculo(tipoId, tipo);

                            tipos.Add(tipoDeVehiculo);
                        }
                    } 
                }
            }
            catch(SqlException)
            {
                throw;
            }

            return tipos;
        }

    }
}
