using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;


namespace Cochera.Datos.Repositorios
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

        public void ActualizarTipoDeDocumento(Documento documento)
        {
            try
            {
                string query = "exec SP_ActualizarDocumento @TipoDocId, @TipoDoc;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDocId", documento.TipoDocId);
                    comando.Parameters.AddWithValue("@TipoDoc", documento.TipoDoc);

                    comando.ExecuteNonQuery();
                }
            }
            catch(SqlException)
            {
                throw;
            }
        }

        public Documento AgregarTipoDeDocumento(string tipoDoc)
        {
            try
            {
                int tipoDocId;

                string query = "exec SP_AgregarDocumento @TipoDoc;";


                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDoc", tipoDoc);

                    tipoDocId = Convert.ToInt32(comando.ExecuteScalar());
                }

                return new Documento(tipoDocId, tipoDoc);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void EliminarDocumento(Documento doc)
        {
            try
            {
                string query = "exec SP_EliminarDocumento @TipoDeDocumentoId;";
            
                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@TipoDeDocumentoId", doc.TipoDocId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
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
