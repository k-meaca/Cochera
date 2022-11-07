using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;
using Cochera.Datos;
using Cochera.Datos.Repositorios;

namespace Cochera.Servicios
{
    public class ServicioAbonados
    {
        //------------ATRIBUTOS------------//

        private RepositorioAbonados repositorioAbonados;
        private RepositorioMovimientosCtasCtes repositorioMovimientos;
        private RepositorioIngresos repositorioIngresos;
        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioSalidas repositorioSalidas;


        private ServicioClientes servicioClientes;
        private ServicioModelos servicioModelos;
        private ServicioIngresos servicioIngresos;
        private ServicioTarifas servicioTarifas;

        //------------METODOS------------//


        public void DarBaja(Abonado abonado)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioAbonados = new RepositorioAbonados(conexion, transaccion);
                    repositorioSalidas = new RepositorioSalidas(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    repositorioAbonados.DarBaja(abonado);

                    repositorioSalidas.DarSalidaAbonado(abonado);

                    repositorioEstacionamientos.DesocuparEstacionamiento(abonado.ObtenerEstacionamientoId());

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }

        public Abonado GenerarAbonado(TipoDeVehiculo tipo, string patente, DateTime fechaIngreso, Estacionamiento estacionamiento, Modelo modelo,
            Tarifa tarifa, DateTime fechaExpiracion, Cliente cliente, CuentaCorriente cuenta, decimal importe)
        {
            SqlTransaction transaccion = null;

            try
            {
                Abonado abonado;

                using (SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioIngresos = new RepositorioIngresos(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    Ingreso ingreso = repositorioIngresos.GenerarIngreso(patente, tipo, fechaIngreso, estacionamiento);
                    repositorioEstacionamientos.OcuparEstacionamiento(estacionamiento.EstacionamientoId);

                    repositorioAbonados = new RepositorioAbonados(conexion, transaccion);
                    repositorioMovimientos = new RepositorioMovimientosCtasCtes(conexion, transaccion);

                    abonado = repositorioAbonados.GenerarAbonado(modelo, tarifa, ingreso, cliente, fechaExpiracion, importe);

                    repositorioMovimientos.DebitarImporte(cuenta, abonado, importe);

                    transaccion.Commit();
                }

                return abonado;
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }

        public List<Abonado> ObtenerAbonados()
        {
            List<Abonado> abonados;

            servicioModelos = new ServicioModelos();
            servicioClientes = new ServicioClientes();
            servicioTarifas = new ServicioTarifas();
            servicioIngresos = new ServicioIngresos();

            List<Modelo> modelos = servicioModelos.ObtenerModelos();
            List<Cliente> clientes = servicioClientes.ObtenerClientes();
            List<IIngreso> ingresos = servicioIngresos.ObtenerIngresos();
            List<Tarifa> tarifas = servicioTarifas.ObtenerTarifas();

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioAbonados = new RepositorioAbonados(conexion);

                abonados = repositorioAbonados.ObtenerAbonados(modelos, tarifas, ingresos, clientes);
            }

            return abonados;
        }

    }
}
