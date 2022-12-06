using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;


namespace Cochera.Datos.Repositorios
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

        //----PRIVADOS----//
        private TipoDeVehiculo ConstruirTipoVehiculo(string vehiculo)
        {
            try
            {
                TipoDeVehiculo tipo;

                string query = "SELECT * FROM UF_ObtenerTipoDeVehiculo(@TipoDeVehiculo);";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDeVehiculo", vehiculo);

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        lector.Read();

                        int tipoId = lector.GetInt32(0);
                        string tipoVehiculo = lector.GetString(1);
                        string imagen = lector.GetString(2);

                        tipo = new TipoDeVehiculo(tipoId, tipoVehiculo, imagen);
                    }
                }

                return tipo;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        //----PUBLICOS----//

        public TipoDeVehiculo ConstruirAuto()
        {
            return ConstruirTipoVehiculo("Auto");
        }

        public TipoDeVehiculo ConstruirMoto()
        {
            return ConstruirTipoVehiculo("Moto");
        }

        public List<TipoDeVehiculo> ObtenerTiposDeVehiculo()
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
                            string imagen = lector.GetString(2);

                            TipoDeVehiculo tipoDeVehiculo = new TipoDeVehiculo(tipoId, tipo, imagen);

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
