using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
<<<<<<< HEAD:Estacionamiento.Datos/Repositorios/RepositorioPersonas.cs
using Estacionamiento.Entidades;
using Estacionamiento.Entidades.Excepciones;


namespace Estacionamiento.Datos.Repositorios
{
    public class RepositorioPersonas
    {
        //ATRIBUTOS
        SqlConnection conexion;

        //CONSTRUCTOR
=======
using Cochera.Entidades;
using Cochera.Entidades.Excepciones;


namespace Cochera.Datos.Repositorios
{
    public class RepositorioPersonas
    {
        //------------ATRIBUTOS------------//

        SqlConnection conexion;
        SqlTransaction transaccion;

        //------------CONSTRUCTOR------------//

>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Datos/Repositorios/RepositorioPersonas.cs
        public RepositorioPersonas (SqlConnection conexion)
        {
            this.conexion = conexion;
        }

<<<<<<< HEAD:Estacionamiento.Datos/Repositorios/RepositorioPersonas.cs
        //METODOS
=======
        public RepositorioPersonas (SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }
        //------------METODOS------------//

        //----PRIVADOS----//


        //----PUBLICOS----//

        public void ActualizarPersona(Cliente cliente)
        {
            try
            {
                string query = "exec SP_ActualizarPersona @PersonaId, @Nombre, @Apellido, @TipoDocId, @NumDoc, @Telefono;";

                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@PersonaId", cliente.ClienteId);
                    comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    comando.Parameters.AddWithValue("@TipoDocId", cliente.ObtenerTipoDocId());
                    comando.Parameters.AddWithValue("@NumDoc", cliente.ObtenerNumeroDoc());
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public int AgregarPersona(string nombre, string apellido, Documento documento, string telefono)
        {
            try
            {
                int personaID;

                string query = "exec SP_AgregarPersona @Nombre, @Apellido, @TipoDocId, @NroDoc, @Telefono;";
                
                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);
                    comando.Parameters.AddWithValue("@TipoDocId", documento.TipoDocId);
                    comando.Parameters.AddWithValue("@NroDoc", documento.NumDoc);
                    comando.Parameters.AddWithValue("@Telefono", telefono);

                    personaID = Convert.ToInt32(comando.ExecuteScalar());
                }

                return personaID;
            }
            catch(SqlException)
            {
                throw;
            }
        }
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Datos/Repositorios/RepositorioPersonas.cs

        public void DatosEnUsuario(Usuario usuario)
        {
            try
            {
                string query = "SELECT * FROM dbo.UF_DatosDePersonaEnUsuario(@UsuarioId);";

<<<<<<< HEAD:Estacionamiento.Datos/Repositorios/RepositorioPersonas.cs
                using(SqlCommand comando = new SqlCommand(query))
=======
                using (SqlCommand comando = new SqlCommand(query))
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Datos/Repositorios/RepositorioPersonas.cs
                {
                    comando.Connection = conexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);

                    SqlDataReader lector = comando.ExecuteReader();

                    lector.Read();

                    usuario.Nombre = lector.GetString(0);
                    usuario.Apellido = lector.GetString(1);

                }
            }
<<<<<<< HEAD:Estacionamiento.Datos/Repositorios/RepositorioPersonas.cs
            catch(SqlException)
=======
            catch (SqlException)
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Datos/Repositorios/RepositorioPersonas.cs
            {
                throw;
            }
        }
<<<<<<< HEAD:Estacionamiento.Datos/Repositorios/RepositorioPersonas.cs
    }
}
=======

        public void EliminarPersona(Cliente cliente)
        {
            try
            {
                string query = "exec SP_EliminarPersona @PersonaId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@PersonaId", cliente.ClienteId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public void SetearClientes(List<Cliente> clientes, List<Documento> documentos)
        {
            try
            {
                string query = "SELECT * FROM dbo.UF_DatosDeClientesEnPersona(@PersonaId);";

                foreach(Cliente cliente in clientes)
                {
                    using (SqlCommand comando = new SqlCommand(query))
                    {
                        comando.Connection = conexion;
                        comando.CommandType = System.Data.CommandType.Text;

                        comando.Parameters.AddWithValue("@PersonaId", cliente.ClienteId);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            lector.Read();

                            cliente.EstablecerNombreCompleto(lector.GetString(0), lector.GetString(1));

                            Documento documento = (Documento)documentos.Find(doc => doc.TipoDocId == lector.GetInt32(2)).Clone();

                            documento.EstablecerNumeroDeDoc(lector.GetString(3));

                            cliente.EstablecerDocumento(documento);

                            string telefono = lector.GetString(4);

                            cliente.AsignarTelefono(telefono is null ? "" : telefono);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }


    }
}
                    

>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983:Cochera.Datos/Repositorios/RepositorioPersonas.cs
