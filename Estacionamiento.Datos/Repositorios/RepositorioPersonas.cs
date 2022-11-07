using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Entidades;
using Estacionamiento.Entidades.Excepciones;


namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioPersonas
    {
        //ATRIBUTOS
        SqlConnection conexion;

        //CONSTRUCTOR
        public RepositorioPersonas (SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //METODOS

        public void DatosEnUsuario(Usuario usuario)
        {
            try
            {
                string query = "SELECT * FROM dbo.UF_DatosDePersonaEnUsuario(@UsuarioId);";

                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);

                    SqlDataReader lector = comando.ExecuteReader();

                    lector.Read();

                    usuario.Nombre = lector.GetString(0);
                    usuario.Apellido = lector.GetString(1);

                }
            }
            catch(SqlException)
            {
                throw;
            }
        }
    }
}
