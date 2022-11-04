using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Datos;
using System.Data.SqlClient;

namespace Estacionamiento.Servicios
{
    public class ServicioUsuarios
    {

        //ATRIBUTOS

        RepositorioUsuarios repositorio;


        //METODOS

        public bool ValidarUsuario(string usuario, string password)
        {
            bool valido;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorio = new RepositorioUsuarios(conexion);
                valido = repositorio.ValidarUsuario(usuario, password);
            }

            return valido;
        }
    }
}
