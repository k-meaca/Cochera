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
<<<<<<< HEAD
        private RepositorioMovimientosCtasCtes repositorioMovimientos;
        private RepositorioIngresos repositorioIngresos;
        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioSalidas repositorioSalidas;

=======
        private RepositorioCuentasCorrientes repositorioCuentasCorrientes;
        private RepositorioIngresos repositorioIngresos;
        private RepositorioEstacionamientos repositorioEstacionamientos;
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

        private ServicioClientes servicioClientes;
        private ServicioModelos servicioModelos;
        private ServicioIngresos servicioIngresos;
        private ServicioTarifas servicioTarifas;

        //------------METODOS------------//

<<<<<<< HEAD

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
=======
        public Abonado GenerarAbonado(TipoDeVehiculo tipo, string patente, DateTime fechaIngreso, Estacionamiento estacionamiento, Modelo modelo,
            Tarifa tarifa, DateTime fechaExpiracion, Cliente cliente, decimal importe)
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
<<<<<<< HEAD
                    repositorioMovimientos = new RepositorioMovimientosCtasCtes(conexion, transaccion);

                    abonado = repositorioAbonados.GenerarAbonado(modelo, tarifa, ingreso, cliente, fechaExpiracion, importe);

                    repositorioMovimientos.DebitarImporte(cuenta, abonado, importe);
=======
                    repositorioCuentasCorrientes = new RepositorioCuentasCorrientes(conexion, transaccion);

                    abonado = repositorioAbonados.GenerarAbonado(modelo, tarifa, ingreso, cliente, fechaExpiracion, importe);
                    repositorioCuentasCorrientes.DebitarImporte(abonado, importe);
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

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
