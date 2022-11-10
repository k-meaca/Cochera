using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Datos;
using Cochera.Datos.Repositorios;
using Cochera.Entidades;

namespace Cochera.Servicios
{
    public class ServicioPersonas
    {

        //------------ATRIBUTOS------------//
        RepositorioPersonas repositorioPersonas;

        
        //------------METODOS------------//

        public void ActualizarPersona(Cliente cliente)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioPersonas = new RepositorioPersonas(conexion);
                repositorioPersonas.ActualizarPersona(cliente);
            }
        }

    }
}
