using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
    public class Abonado : IIngreso
    {

        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int AbonadoId { get; private set; }

        private Modelo modelo;

        private Tarifa tarifa;

        private Cliente cliente;

        private Ingreso ingreso;

        public DateTime FechaExpiracion { get; private set; }

        private decimal importe;

        public bool Baja { get; private set; }

        //------------CONSTRUCTOR------------//

        public Abonado(int abonadoId, Modelo modelo, Tarifa tarifa, Ingreso ingreso,
            Cliente cliente, DateTime fechaExpiracion, decimal importe, bool baja)
        {
            AbonadoId = abonadoId;
            this.modelo = modelo;
            this.tarifa = tarifa;
            this.cliente = cliente;
            this.ingreso = ingreso;
            FechaExpiracion = fechaExpiracion;
            this.importe = importe;
            Baja = baja;
        }

        //------------METODOS-------------//

        //----PUBLICOS----//

        public bool esAbonado()
        {
            return true;
        }

        public string NombreCompletoCliente()
        {
            return cliente.NombreCompleto();
        }

        public string ObtenerApellidoCliente()
        {
            return cliente.Apellido;
        }

        public int ObtenerEstacionamientoId()
        {
            return ingreso.ObtenerEstacionamientoId();
        }
        public DateTime ObtenerFechaIngreso()
        {
            return ingreso.ObtenerFechaIngreso();
        }
        public string ObtenerImagenVehiculo()
        {
            return ingreso.ObtenerImagenVehiculo();
        }

        public decimal ObtenerImporte()
        {
            return importe;
        }

        public int ObtenerIngresoId()
        {
            return ingreso.ObtenerIngresoId();
        }

        public string ObtenerMarca()
        {
            return modelo.ObtenerMarca();
        }

        public string ObtenerModelo()
        {
            return modelo.Nombre;
        }

        public string ObtenerNombreCliente()
        {
            return cliente.Nombre;
        }

        public string ObtenerNumeroDoc()
        {
            return cliente.ObtenerNumeroDoc();
        }

        public string ObtenerPatente()
        {
            return ingreso.ObtenerPatente();
        }
        public string ObtenerSector()
        {
            return ingreso.ObtenerSector();
        }

        public string ObtenerTiempoTarifa()
        {
            return tarifa.Tiempo;
        }

        public string ObtenerTipoVehiculo()
        {
            return ingreso.ObtenerTipoVehiculo();
        }

        public int ObtenerTipoVehiculoId()
        {
            return ingreso.ObtenerTipoVehiculoId();
        }

        public string ObtenerVehiculo()
        {
            return ingreso.ObtenerTipoVehiculo();
        }

        public string ObtenerUbicacion()
        {
            return ingreso.ObtenerUbicacion();
        }

    }
}
