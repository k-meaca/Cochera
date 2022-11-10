using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Cochera.Entidades;
using Cochera.Entidades.Excepciones;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioUsuarios
    {

        //ATRIBUTOS

        SqlConnection conexion;

        //CONSTRUCTOR

        public RepositorioUsuarios(SqlConnection conexion)
        {
            this.conexion = conexion;
        }


        //METODOS

        //PRIVADOS

        //PUBLICOS

        public bool ValidarUsuario(string nick, string password)
        {
            bool valido = false;
            try
            {
                using (SqlCommand procedimiento = new SqlCommand("SELECT dbo.UF_ValidarUsuario (@Nick, @Password);"))
                {
                    procedimiento.Connection = conexion;
                    procedimiento.CommandType = System.Data.CommandType.Text;
                    procedimiento.Parameters.AddWithValue("@Nick", nick);
                    procedimiento.Parameters.AddWithValue("@Password", password);

                    valido = (bool)procedimiento.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw;
            }

            if (!valido)
            {
                throw new UsuarioInvalidoExcepcion("El usuario o contraseña son invalidos.");
            }

            return valido;
        }

        public Usuario CrearUsuario(string nick, string password)
        {
            Usuario usuario;

            try
            {
                string query = "SELECT dbo.UF_ObtenerUsuarioId(@Nick,@Password);";

                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Nick", nick);
                    comando.Parameters.AddWithValue("@Password", password);

                    int usuarioId = Convert.ToInt32(comando.ExecuteScalar());

                    usuario = new Usuario(usuarioId, nick, password);
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return usuario;
        }

    }
}
