using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;
using Cochera.Datos;
using Cochera.Datos.Repositorios;

namespace Cochera.Servicios
{
    public class ServicioMovimientosSalidas
    {

        //------------ATRIBUTOS Y PROPIEDADES------------//

        private RepositorioMovimientosSalidas repositorioMovimientosSalidas;
        private ServicioSalidas servicioSalidas;

        //------------METODOS------------//

        //----PUBLICOS----//

        public List<MovimientoSalida> MovimientosSalidas()
        {
            List<MovimientoSalida> movimientos;

            servicioSalidas = new ServicioSalidas();

            List<Salida> salidas = servicioSalidas.ObtenerSalidas();

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioMovimientosSalidas = new RepositorioMovimientosSalidas(conexion);
                
                movimientos = repositorioMovimientosSalidas.MovimientosSalidas(salidas);
            }

            return movimientos;
        }

    }
}
