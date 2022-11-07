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
    public class ServicioTarjetas
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//
        private RepositorioTarjetas repositorioTarjetas;

        private ServicioTiposDeTarjetas servicioTiposTarjetas;
        private ServicioMarcasDeTarjetas servicioMarcasTarjetas;

        //------------METODOS------------//

        public List<Tarjeta> ObtenerTarjetas()
        {
            List<Tarjeta> tarjetas;

            servicioMarcasTarjetas = new ServicioMarcasDeTarjetas();
            servicioTiposTarjetas = new ServicioTiposDeTarjetas();

            List<TipoDePago> tipos = servicioTiposTarjetas.ObtenerTiposDeTarjetas();
            List<MarcaTarjeta> marcas = servicioMarcasTarjetas.ObtenerMarcasDeTarjetas();

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioTarjetas = new RepositorioTarjetas(conexion);

                tarjetas = repositorioTarjetas.ObtenerTarjetas(tipos,marcas);
            }

            return tarjetas;
        }
    }
}
