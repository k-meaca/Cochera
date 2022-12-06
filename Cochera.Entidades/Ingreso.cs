using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;


namespace Cochera.Entidades
{
    public class Ingreso : IIngreso
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        private int ingresoId;

        private string patente;

        protected TipoDeVehiculo tipo;

        public DateTime fechaIngreso;

        protected Estacionamiento estacionamiento;

        //------------CONSTRUCTOR------------//

        public Ingreso(int ingresoId, string patente, TipoDeVehiculo tipo, DateTime fechaIngreso, Estacionamiento estacionamiento)
        {
            this.ingresoId = ingresoId;
            this.patente = patente;
            this.tipo = tipo;
            this.fechaIngreso = fechaIngreso;
            this.estacionamiento = estacionamiento;
        }


        //------------METODOS------------//

        //----PUBLICOS----//

        public void ActualizarIngreso(TipoDeVehiculo tipo, string patente, DateTime fechaIngreso)
        {
            this.tipo = tipo;
            this.patente = patente;
            this.fechaIngreso = fechaIngreso;
        }

        public bool esAbonado()
        {
            return false;
        }
        public int ObtenerEstacionamientoId()
        {
            return estacionamiento.EstacionamientoId;
        }

        public DateTime ObtenerFechaIngreso()
        {
            return fechaIngreso;
        }
        public string ObtenerImagenVehiculo()
        {
            return tipo.ImagenAsociada;
        }

        public int ObtenerIngresoId()
        {
            return ingresoId;
        }

        public string ObtenerPatente()
        {
            return patente;
        }
        public string ObtenerSector()
        {
            return estacionamiento.ObtenerSector();
        }

        public string ObtenerTipoVehiculo()
        {
            return tipo.Tipo;
        }

        public int ObtenerTipoVehiculoId()
        {
            return tipo.TipoId;
        }

        public string ObtenerUbicacion()
        {
            return estacionamiento.Ubicacion;
        }
    }
}
