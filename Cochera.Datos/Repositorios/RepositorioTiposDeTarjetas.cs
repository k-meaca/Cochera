using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioTiposDeTarjetas : Repositorio
    {

        //------------CONSTRUCTOR------------//

        public RepositorioTiposDeTarjetas(SqlConnection conexion) : base(conexion) { }

        public RepositorioTiposDeTarjetas(SqlConnection conexion, SqlTransaction transaccion) : base(conexion, transaccion) { }

        //------------METODOS-----------//


        //----PRIVADOS----//

        private TipoDePago CrearTipo(SqlDataReader lector)
        {
            int tipoId = lector.GetInt32(0);
            string tipo = lector.GetString(1);

            return new TipoDePago(tipoId, tipo);
        }

        //----PUBLICOS----//
        public List<TipoDePago> ObtenerTiposDeTarjeta()
        {
            try
            {
                List<TipoDePago> tipos = new List<TipoDePago>();

                string query = "SELECT * FROM TiposDePago;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            tipos.Add(CrearTipo(lector));
                        }
                    }
                }

                return tipos;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
