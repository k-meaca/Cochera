using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
<<<<<<< HEAD
    public class CuentaCorriente
=======
    public class CuentaCorriente : IContable
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int CuentaId { get; private set; }

<<<<<<< HEAD
        private Cliente cliente;

        private Tarjeta tarjeta;

        public string Nombre { get; set; }

        //------------CONSTRUCTOR------------//

        public CuentaCorriente(int ctaCteId, Cliente cliente, Tarjeta tarjeta)
        {
            CuentaId = ctaCteId;
            this.cliente = cliente;
            this.tarjeta = tarjeta;
        }


        //------------METODOS------------//
        public string MedioDePago()
        {
            return tarjeta.MedioDePago();
        }


        public string NombreCompletoCliente()
        {
            return cliente.NombreCompleto();
        }
        
        public int ObtenerClienteId()
        {
            return cliente.ClienteId;
        }

        public string ObtenerCodigoSeguridadTarjeta()
        {
            return tarjeta.CodigoSeguridad;
        }
        public string ObtenerMarcaTarjeta()
        {
            return tarjeta.ObtenerMarca();
        }

        public string ObtenerNumeroTarjeta()
        {
            return tarjeta.ObtenerNumero();
        }

        public string ObtenerNumeroTarjetaDesprotegido()
        {
            return tarjeta.ObtenerNumeroDesprotegido();
=======

        private Abonado abonado;

        private string descripcion;

        public decimal Debe { get; private set; }

        public decimal Haber { get; private set; }

        public decimal Saldo { get; private set; }

        public DateTime FechaMoviemiento { get; private set; }

        //------------CONSTRUCTOR------------//

        public CuentaCorriente(int ctaCteId, Abonado abonado, string descripcion, decimal debe, decimal haber,
            decimal saldo, DateTime fechaMov)
        {
            CuentaId = ctaCteId;
            this.abonado = abonado;
            this.descripcion = descripcion;
            Debe = debe;
            Haber = haber;
            Saldo = saldo;
            FechaMoviemiento = fechaMov;
        }

        //------------METODOS------------//

        public string NombreCompletoCliente()
        {
            return abonado.NombreCompletoCliente();
        }

        public string ObtenerPatente()
        {
            return abonado.ObtenerPatente();
        }

        public string ObtenerVehiculo()
        {
            return abonado.ObtenerVehiculo();
        }

        public string ObtenerDescripcion()
        {
            return descripcion;
        }

        public string Descripcion()
        {
            return "ABONADO";
        }

        public string Vehiculo()
        {
            return abonado.ObtenerVehiculo();
        }

        public string Patente()
        {
            return abonado.ObtenerPatente();
        }

        public DateTime FechaMovimiento()
        {
            return abonado.ObtenerFechaIngreso();
        }

        public string MedioDePago()
        {
            return "DEBITO AUTOMATICO";
        }

        public decimal Importe()
        {
            return abonado.ObtenerImporte();
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        }
    }
}
