using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Estacionamiento.Entidades.Excepciones;

namespace Estacionamiento.Datos
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

        //PUBLICOS

        public bool ValidarUsuario(string usuario, string password)
        {
            bool valido = false;
            try
            {
                using (SqlCommand procedimiento = new SqlCommand("SELECT dbo.UF_ValidarUsuario (@Usuario, @Password);"))
                {
                    procedimiento.Connection = conexion;
                    procedimiento.CommandType = System.Data.CommandType.Text;
                    procedimiento.Parameters.AddWithValue("@Usuario", usuario);
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

    }
}
