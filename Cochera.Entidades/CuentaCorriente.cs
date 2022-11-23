using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
    public class CuentaCorriente : IContable
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int CuentaId { get; private set; }


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
        }
    }
}
