﻿using System;
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
    public class ServicioSalidas
    {
        //------------ATRIBUTOS------------//
        private RepositorioSalidas repositorioSalidas;
        private RepositorioTarifasEnSalida repositorioTarifasEnSalida;
        private RepositorioEstacionamientos repositorioEstacionamientos;
        private RepositorioIngresos repositorioIngresos;
        private RepositorioTiposDeVehiculo repositorioTipos;
        private RepositorioSectores repositorioSectores;

        //------------METODOS------------//

        public void DarSalida(Ingreso ingreso, DateTime fechaSalida, decimal montoTotal, List<Tarifa> tarifas)
        {
            SqlTransaction transaccion = null;

            try
            {
                using(SqlConnection conexion = ConexionBD.AbrirConexion())
                {
                    transaccion = conexion.BeginTransaction();

                    repositorioSalidas = new RepositorioSalidas(conexion, transaccion);
                    repositorioTarifasEnSalida = new RepositorioTarifasEnSalida(conexion, transaccion);
                    repositorioEstacionamientos = new RepositorioEstacionamientos(conexion, transaccion);

                    int salidaId = repositorioSalidas.DarSalida(ingreso, fechaSalida, montoTotal);
                    repositorioTarifasEnSalida.EstablecerTarifasParaSalida(salidaId, tarifas);

                    repositorioEstacionamientos.DesocuparEstacionamiento(ingreso.ObtenerEstacionamientoId());

                    transaccion.Commit();
                }
            }
            catch (SqlException)
            {
                transaccion.Rollback();
                throw;
            }
        }

        public List<Salida> ObtenerSalidas()
        {
            List<Salida> salidas;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);
                repositorioSalidas = new RepositorioSalidas(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();
                List<Ingreso> ingresos = repositorioIngresos.ObtenerIngresos(tipos, estacionamientos);

                salidas = repositorioSalidas.ObtenerSalidas(ingresos);
            }

            return salidas;
        }

        public Salida ObtenerUltimaSalida(string patente)
        {
            Salida ultimaSalida;

            using(SqlConnection conexion = ConexionBD.AbrirConexion())
            {
                repositorioSalidas = new RepositorioSalidas(conexion);
                repositorioIngresos = new RepositorioIngresos(conexion);
                repositorioEstacionamientos = new RepositorioEstacionamientos(conexion);
                repositorioSectores = new RepositorioSectores(conexion);
                repositorioTipos = new RepositorioTiposDeVehiculo(conexion);

                List<Sector> sectores = repositorioSectores.ObtenerSectores();
                List<Estacionamiento> estacionamientos = repositorioEstacionamientos.ObtenerEstacionamientos(sectores);
                List<TipoDeVehiculo> tipos = repositorioTipos.ObtenerTiposDeVehiculo();
                List<Ingreso> ingresos = repositorioIngresos.ObtenerIngresos(tipos, estacionamientos);

                ultimaSalida = repositorioSalidas.ObtenerUltimaSalida(patente, ingresos);
            }

            return ultimaSalida;
        }
    }
}
