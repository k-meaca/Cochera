using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cochera.Datos;
using Cochera.Datos.Repositorios;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;

namespace Cochera.Servicios
{
    public class ServicioIngresos
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        private RepositorioIngresos repositorioIngresos;
        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioTiposDeVehiculo repositorioTipos;
        private RepositorioSectores repositorioSectores;
        private RepositorioAbonados repositorioAbonados;
        private RepositorioTarifas repositorioTarifas;

        private ServicioModelos servicioModelos;
        private ServicioClientes servicioClientes;
        private ServicioTarifas servicioTarifas;

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//

        public void AbonadoAhoraEsIngreso(Abonado abonado)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioIngresos = new RepositorioIngresos(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    repositorioIngresos.AbonadoAhoraEsIngreso(abonado);

                    repositorioEstacionamientos.OcuparEstacionamiento(abonado.ObtenerEstacionamientoId());

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }


        public void ActualizarIngreso(Ingreso ingreso)
        {
            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioIngresos = new RepositorioIngresos(conexion);

                repositorioIngresos.ActualizarIngreso(ingreso);
            }
        }

        public void EliminarIngreso(Estacionamiento estacionamiento, Ingreso ingreso)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioIngresos = new RepositorioIngresos(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    repositorioIngresos.EliminarIngreso(ingreso);
                    repositorioEstacionamientos.DesocuparEstacionamiento(estacionamiento.EstacionamientoId);

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }


        public Ingreso GenerarIngreso(string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {

            SqlTransaction transaccion = null;
            Ingreso ingreso;

            try
            {

                using (SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioIngresos = new RepositorioIngresos(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    ingreso = repositorioIngresos.GenerarIngreso(patente, tipo, fechaIngreso, estacionamiento);
                    repositorioEstacionamientos.OcuparEstacionamiento(estacionamiento.EstacionamientoId);

                    transaccion.Commit();
                }

                return ingreso;
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }

        public IIngreso ObtenerIngreso(Estacionamiento estacionamiento)
        {
            IIngreso ingreso;

            servicioClientes = new ServicioClientes();
            servicioModelos = new ServicioModelos();
            servicioTarifas = new ServicioTarifas();

            List<Cliente> clientes = servicioClientes.ObtenerClientes();
            List<Modelo> modelos = servicioModelos.ObtenerModelos();
            List<Tarifa> tarifas = servicioTarifas.ObtenerTarifas();


            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioIngresos = new RepositorioIngresos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioAbonados = new RepositorioAbonados(conexion);

                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ingreso = repositorioIngresos.ObtenerIngreso(estacionamiento, tipos);

                ingreso = repositorioAbonados.IngresoEsAbonado(modelos, tarifas, (Ingreso)ingreso, clientes);
            }

            return ingreso;
        }

        public List<IIngreso> ObtenerIngresos()
        {
            List<IIngreso> ingresos;

            using (SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ingresos = repositorioIngresos.ObtenerIngresos(tipos, estacionamientos);
            }

            return ingresos;

        }

        public Ingreso ObtenerUltimoIngreso(string patente)
        {
            Ingreso ultimoIngreso;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();

                ultimoIngreso = repositorioIngresos.ObtenerUltimoIngreso(patente,tipos,estacionamientos);
            }

            return ultimoIngreso;
        }

    }
}
