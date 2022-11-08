using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Estacionamiento.Entidades;


namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioTipoDocumentos
    {
        //------------ATRIBUTOS------------//
        private SqlConnection conexion;

        //------------CONSTRUCTOR------------//
        public RepositorioTipoDocumentos(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        //------------METODOS------------//


        //----PRIVADOS----//


        //----PUBLICOS----//

        public List<Documento> ObtenerDocumentos()
        {
            List<Documento> documentos = new List<Documento>();

            try
            {
                string query = "SELECT * FROM TiposDeDocumentos;";

                using (SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;
                    
                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int tipoDocId = lector.GetInt32(0);
                            string tipo = lector.GetString(1);

                            Documento documento = new Documento(tipoDocId, tipo);

                            documentos.Add(documento);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return documentos;
        }

    }
}
