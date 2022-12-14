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
    public class ServicioSectores
    {
        //------------ATRIBUTOS------------//

        RepositorioSectores repositorioSectores;


        //------------METODOS------------//


        public List<Sector> ObtenerSectores()
        {
            List<Sector> sectores;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                sectores = repositorioSectores.ObtenerSectores();
            }

            return sectores;
        }
    }
}
