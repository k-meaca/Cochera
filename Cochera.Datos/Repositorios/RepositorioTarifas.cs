using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioTarifas
    {
        //------------ATRIBUTOS------------//

        private SqlConnection conexion;

        //------------CONSTRUCTOR------------//

        public RepositorioTarifas(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//

        //----PRIVADOS----//


        //----PUBLICOS----//
        public List<Tarifa> ObtenerTarifas()
        {
            List<Tarifa> tarifas = new List<Tarifa>();
            try
            {
                string query = "SELECT * FROM Tarifas;";

                using (SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tarifaId = lector.GetInt32(0);
                            string tiempo = lector.GetString(1);
                            Tarifa tarifa = new Tarifa(tarifaId, tiempo);
                            tarifas.Add(tarifa);
                        }

                    }
                }
            }
            catch(SqlException)
            {
                throw;
            }

            return tarifas;
        }

        public List<Tarifa> ObtenerTarifasAbonados()
        {
            try
            {
                List<Tarifa> tarifas = new List<Tarifa>();

                string query = "SELECT * FROM dbo.UF_ObtenerTarifasAbonados();";

                using(SqlCommand comando = new SqlCommand(query,conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tarifaId = lector.GetInt32(0);
                            string tiempo = lector.GetString(1);
                            Tarifa tarifa = new Tarifa(tarifaId, tiempo);
                            tarifas.Add(tarifa);
                        }
                    }
                }

                return tarifas;
            }
            catch(SqlException)
            {
                throw;
            }
        }
    }
}
