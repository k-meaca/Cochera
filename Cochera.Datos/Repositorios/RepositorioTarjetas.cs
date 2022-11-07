using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioTarjetas : Repositorio
    {
        //------------CONSTRUCTOR------------//

        public RepositorioTarjetas(SqlConnection conexion) : base(conexion) { }

        public RepositorioTarjetas(SqlConnection conexion, SqlTransaction transaccion) : base(conexion, transaccion) { }

        //------------METODOS------------//

        //----PRIVADOS----//

        private Tarjeta CrearTarjeta(List<TipoDePago> tipos, List<MarcaTarjeta> marcas, SqlDataReader lector)
        {
            int tarjetaId = lector.GetInt32(0);
            string numeroTarjeta = lector.GetString(1);
            string codigoSeguridad = lector.GetString(2);
            int tipoTarjetaId = lector.GetInt32(3);
            int marcaTarjetaId = lector.GetInt32(4);

            TipoDePago tipo = tipos.Find(t => t.TipoId == tipoTarjetaId);
            MarcaTarjeta marca = marcas.Find(m => m.MarcaId == marcaTarjetaId);

            return new Tarjeta(tarjetaId, numeroTarjeta, codigoSeguridad, tipo, marca);
        }


        //----PUBLICOS----//

        public int NuevaTarjeta(string numero, string codigo, MarcaTarjeta marca, TipoDePago tipo)
        {
            try
            {
                string query = "exec SP_NuevaTarjeta @NumeroTarjeta, @CodigoSeguridad, @TipoDePagoId, @MarcaTarjetaId;";

                int tarjetaId;

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@NumeroTarjeta", numero);
                    comando.Parameters.AddWithValue("@CodigoSeguridad", codigo);
                    comando.Parameters.AddWithValue("@TipoDePagoId", tipo.TipoId);
                    comando.Parameters.AddWithValue("@MarcaTarjetaId", marca.MarcaId);

                    tarjetaId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return tarjetaId;
            }
            catch (SqlException)
            {
                throw;
            }
        }


        public List<Tarjeta> ObtenerTarjetas(List<TipoDePago> tipos, List<MarcaTarjeta> marcas)
        {
            try
            {
                List<Tarjeta> tarjetas = new List<Tarjeta>();

                string query = "SELECT * FROM Tarjetas";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            tarjetas.Add(CrearTarjeta(tipos, marcas, lector));
                        }
                    }
                }

                return tarjetas;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
