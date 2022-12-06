using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;


namespace Cochera.Datos.Repositorios
{
    public class RepositorioModelos
    {
        //-----------ATRIBUTOS-----------//
        SqlConnection conexion;

        //-----------CONSTRUCTOR------------//

        public RepositorioModelos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private Modelo CrearModelo(List<Marca> marcas, List<TipoDeVehiculo> tipos, SqlDataReader lector)
        {
            int modeloId = lector.GetInt32(0);
            string nombre = lector.GetString(1);
            int marcaId = lector.GetInt32(2);
            int tipoVehiculo = lector.GetInt32(3);

            Marca marca = marcas.Find(m => m.MarcaId == marcaId);
            TipoDeVehiculo tipo = tipos.Find(t => t.TipoId == tipoVehiculo);

            return new Modelo(modeloId, nombre, tipo, marca);

        }

        private Modelo CrearModelo(List<Marca> marcas, TipoDeVehiculo tipo, SqlDataReader lector)
        {
            int modeloId = lector.GetInt32(0);
            string nombre = lector.GetString(1);
            int marcaId = lector.GetInt32(2);

            Marca marca = marcas.Find(m => m.MarcaId == marcaId);

            return new Modelo(modeloId, nombre, tipo, marca);

        }

        //----PUBLICOS----//

        public void ActualizarModelo(Modelo modelo)
        {
            try
            {
                string query = "exec SP_ActualizarModelo @ModeloId, @Nombre, @MarcaId, @TipoVehiculoId;";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@ModeloId", modelo.ModeloId);
                    comando.Parameters.AddWithValue("@Nombre", modelo.Nombre);
                    comando.Parameters.AddWithValue("@MarcaId", modelo.ObtenerMarcaId());
                    comando.Parameters.AddWithValue("@TipoVehiculoId", modelo.ObtenerTipoVehiculoId());

                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Modelo AgregarModelo(string nombreModelo, Marca marca, TipoDeVehiculo tipo)
        {
            try
            {
                int modeloId;

                string query = "exec SP_AgregarModelo @Nombre, @MarcaId, @TipoVehiculoId;";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Nombre", nombreModelo);
                    comando.Parameters.AddWithValue("@MarcaId", marca.MarcaId);
                    comando.Parameters.AddWithValue("@TipoVehiculoId", tipo.TipoId);

                    modeloId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return new Modelo(modeloId, nombreModelo, tipo, marca);

            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void EliminarModelo(Modelo modelo)
        {
            try
            {
                string query = "exec SP_EliminarModelo @ModeloId";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@ModeloId", modelo.ModeloId);

                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException)
            {
                throw;
            }
        }
        public List<Modelo> ObtenerModelos(List<Marca> marcas, List<TipoDeVehiculo> tipos)
        {
            try
            {
                List<Modelo> modelos = new List<Modelo>();

                string query = "SELECT * FROM Modelos;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Modelo modelo = CrearModelo(marcas, tipos, lector);

                            modelos.Add(modelo);
                        }
                    }
                }

                return modelos;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Modelo> ObtenerModelos(List<Marca> marcas, TipoDeVehiculo tipo)
        {
            try
            {
                List<Modelo> modelos = new List<Modelo>();

                string query = "SELECT * FROM dbo.UF_ModelosPorTipoDeVehiculo(@TipoDeVehiculo);";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDeVehiculo", tipo.TipoId);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Modelo modelo = CrearModelo(marcas, tipo, lector);

                            modelos.Add(modelo);
                        }
                    }
                }

                return modelos;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
