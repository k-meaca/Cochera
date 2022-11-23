using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;


namespace Cochera.Datos.Repositorios
{
    public class RepositorioMarcas
    {
        //------------ATRIBUTOS------------//
        SqlConnection conexion;

        //------------CONSTRUCTOR------------//

        public RepositorioMarcas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PUBLICOS----//

        public void ActualizarMarca(Marca marca)
        {
            try
            {
                string query = "exec SP_ActualizarMarca @MarcaId, @Nombre;";

                using(SqlCommand comando = new SqlCommand(query,conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@MarcaId", marca.MarcaId);
                    comando.Parameters.AddWithValue("@Nombre", marca.Nombre);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public Marca AgregarMarca(string marca)
        {
            try
            {
                int marcaId;

                string query = "exec SP_AgregarMarca @Nombre;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Nombre", marca);

                    marcaId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return new Marca(marcaId, marca);

            }
            catch(SqlException)
            {
                throw;
            }
        }

        public void EliminarMarca(Marca marca)
        {
            try
            {
                string query = "exec SP_EliminarMarca @MarcaId;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@MarcaId", marca.MarcaId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public List<Marca> ObtenerMarcas()
        {
            try
            {
                List<Marca> marcas = new List<Marca>();

                string query = "SELECT * FROM Marcas;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Marca marca = new Marca(lector.GetInt32(0), lector.GetString(1));
                            marcas.Add(marca);
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

        public Marca ObtenerMarca(int marcaId)
        {
            try
            {
                string query = "SELECT dbo.UF_ObtenerMarca(@MarcaId);";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@MarcaId", marcaId);

                    string marca = Convert.ToString(comando.ExecuteScalar());

                    return new Marca(marcaId, marca);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
