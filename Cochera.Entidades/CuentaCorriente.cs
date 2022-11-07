using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Entidades.Interfaces;

namespace Cochera.Entidades
{
    public class CuentaCorriente
    {
        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int CuentaId { get; private set; }

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
        }
    }
}
