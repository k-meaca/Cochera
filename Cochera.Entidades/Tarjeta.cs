using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Tarjeta
    {
        //------------ATRIBUTOS Y PROPEIDADES------------//
        public int TarjetaId { get; private set; }

        private string numeroTarjeta;

        public string CodigoSeguridad { get; private set; }

        private TipoDePago tipoDeTarjeta;

        private MarcaTarjeta marca;


        //------------CONSTRUCTOR------------//

        public Tarjeta(int tarjetaId, string numero, string codigo, TipoDePago tipo, MarcaTarjeta marca)
        {
            TarjetaId = tarjetaId;
            this.numeroTarjeta = numero;
            CodigoSeguridad = codigo;
            this.tipoDeTarjeta = tipo;
            this.marca = marca;
        }

        //------------METODOS------------//

        public string MedioDePago()
        {
            return tipoDeTarjeta.Tipo;
        }

        public string ObtenerMarca()
        {
            return marca.Marca;
        }

        public string ObtenerNumero()
        {
            string numero = "";

            for(int i = 1; i <=12; i++)
            {
                if (i >= 4 && i % 4 == 0)
                {
                    numero += "#-";
                }
                else
                {
                    numero += "#";
                }
            }

            numero += numeroTarjeta.Substring(12);

            return numero;
        }

        public string ObtenerNumeroDesprotegido()
        {
            return numeroTarjeta;
        }
    }
}
