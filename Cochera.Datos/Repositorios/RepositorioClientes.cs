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
                int clienteId;

                string query = "exec SP_AgregarCliente @PersonaId;";

                using(SqlCommand comando = new SqlCommand(query, conexion, transaccion))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.Parameters.AddWithValue("@PersonaId", personaId);

                    clienteId = Convert.ToInt32(comando.ExecuteScalar());
                }

                cliente = new Cliente(clienteId, personaId, nombre, apellido, doc);
                cliente.AsignarTelefono(telefono);

                return cliente;

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
                            int clienteId = lector.GetInt32(0);
                            int personaId = lector.GetInt32(1);

                            Cliente cliente = new Cliente(clienteId,personaId);

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
