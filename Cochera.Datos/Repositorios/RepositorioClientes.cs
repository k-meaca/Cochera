using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;

namespace Cochera.Datos.Repositorios
{
    public class RepositorioClientes
    {

        //------------ATRIBUTOS------------//
        private SqlConnection conexion;
        private SqlTransaction transaccion;


        //------------CONSTRUCTOR------------//
        public RepositorioClientes(SqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public RepositorioClientes(SqlConnection conexion, SqlTransaction transaccion) : this(conexion)
        {
            this.transaccion = transaccion;
        }

        //------------EVENTOS------------//


        //----PRIVADOS----//

        //----PUBLICOS----//

        public Cliente AgregarCliente(int personaId, string nombre, string apellido, Documento doc, string telefono)
        {
            try
            {
                Cliente cliente;

                string query = "exec SP_AgregarCliente @PersonaId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@PersonaId", personaId);

                    comando.ExecuteNonQuery();
                }

                cliente = new Cliente(personaId, nombre, apellido, doc);
                cliente.AsignarTelefono(telefono);

                return cliente;

            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                string query = "exec SP_EliminarCliente @ClienteId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);

                    comando.ExecuteNonQuery();
                }

            }
            catch (SqlException)
            {
                throw;
            }

        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = "SELECT * FROM Clientes;";

                using(SqlCommand comando = new SqlCommand(query))
                {
                    comando.Connection = conexion;

                    using(SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            int personaId = lector.GetInt32(0);

                            Cliente cliente = new Cliente(personaId);

                            clientes.Add(cliente);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return clientes;
        }
    }
}
