using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Datos;
using Cochera.Datos.Repositorios;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Servicios
{
    public class ServicioUsuarios
    {

        //ATRIBUTOS

        RepositorioUsuarios repositorioUsuarios;
        RepositorioPersonas repositorioPersonas;


        //METODOS

        public bool ValidarUsuario(string usuario, string password)
        {
            bool valido;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioUsuarios = new RepositorioUsuarios(conexion);
                valido = repositorioUsuarios.ValidarUsuario(usuario, password);
            }

            return valido;
        }

        public Usuario CrearUsuario(string nick, string password)
        {
            Usuario usuario;
            
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioUsuarios = new RepositorioUsuarios(conexion);
                repositorioPersonas = new RepositorioPersonas(conexion);

                usuario = repositorioUsuarios.CrearUsuario(nick, password);
                repositorioPersonas.DatosEnUsuario(usuario);
            }

            return usuario;
        }
    }
}
