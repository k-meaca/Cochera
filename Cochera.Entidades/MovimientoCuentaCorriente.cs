using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
    public class MovimientoCuentaCorriente : IContable
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int MoviemientoId { get; private set; }

        private CuentaCorriente cuenta;

        private Abonado abonado;

        public decimal Debe { get; private set; }

        public decimal Haber { get; private set; }

        public decimal Saldo { get; private set; }

        //------------CONSTRUCTOR------------//

        public MovimientoCuentaCorriente(int movId, CuentaCorriente cuenta, Abonado abonado,
                decimal debe, decimal haber, decimal saldo)
        {
            MoviemientoId = movId;
            this.cuenta = cuenta;
            this.abonado = abonado;
            Debe = debe;
            Haber = haber;
            Saldo = saldo;
        }


        //------------METODOS------------//

        public string ObtenerPatente()
        {
            return abonado.ObtenerPatente();
        }

        public string ObtenerVehiculo()
        {
            return abonado.ObtenerVehiculo();
        }

        public string Descripcion()
        {
            string descripcion = $"CUENTA CORRIENTE Nro: {cuenta.CuentaId}";

            return descripcion;
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
            return cuenta.MedioDePago().ToUpper();
        }

        public decimal Importe()
        {
            return abonado.ObtenerImporte();
        }
    }
}
