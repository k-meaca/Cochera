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
    public class ServicioClientes
    {

        //------------ATRIBUTOS------------//

        RepositorioClientes repositorioClientes;
        RepositorioPersonas repositorioPersonas;
        RepositorioTipoDocumentos repositorioTipoDocumentos;
        RepositorioCuentasCorrientes repositorioCuentasCorrientes;
        RepositorioTarjetas repositorioTarjetas;

        ServicioAbonados servicioAbonados;

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

        public Cliente AgregarCliente(string nombre, string apellido, Documento documento, string telefono, MarcaTarjeta marca,
                                TipoDePago tipo, string numero, string codigo)
        {

            SqlTransaction transaccion = null;
            
            Cliente cliente;
            try
            {
                
                using (SqlConnection conexion = ConexionBD.AbrirConexion())
                {

                    transaccion = conexion.BeginTransaction();

                    repositorioPersonas = new RepositorioPersonas(conexion, transaccion);
                    repositorioClientes = new RepositorioClientes(conexion, transaccion);
                    repositorioCuentasCorrientes = new RepositorioCuentasCorrientes(conexion, transaccion);
                    repositorioTarjetas = new RepositorioTarjetas(conexion, transaccion);

                    int personaId = repositorioPersonas.AgregarPersona(nombre, apellido, documento, telefono);
                    cliente = repositorioClientes.AgregarCliente(personaId, nombre, apellido, documento, telefono);

                    int tarjetaId = repositorioTarjetas.NuevaTarjeta(numero, codigo, marca, tipo);

                    repositorioCuentasCorrientes.GenerarCuentaCorriente(cliente, tarjetaId);

                    transaccion.Commit();
                }

                return cliente;
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }

        }

        public void EliminarCliente(Cliente cliente)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioClientes = new RepositorioClientes(conexion, transaccion);
                    repositorioPersonas = new RepositorioPersonas(conexion, transaccion);
                    repositorioCuentasCorrientes = new RepositorioCuentasCorrientes(conexion, transaccion);
                    

                    repositorioClientes.EliminarCliente(cliente);
                    repositorioPersonas.EliminarPersona(cliente);

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioClientes = new RepositorioClientes(conexion);
                repositorioPersonas = new RepositorioPersonas(conexion);
                repositorioTipoDocumentos = new RepositorioTipoDocumentos(conexion);

                clientes = repositorioClientes.ObtenerClientes();
                List<Documento> documentos = repositorioTipoDocumentos.ObtenerDocumentos();

                repositorioPersonas.SetearClientes(clientes, documentos);
            }

            return clientes;
        }


    }
}
