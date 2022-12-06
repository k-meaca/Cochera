using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cochera.Servicios;
using Cochera.Entidades;

namespace Cochera.Windows.Utilidades
{
    public static class Validador
    {

        //------------METODOS------------//

        //----PRIVADOS----//

        //----PUBLICOS----//
        public static bool LetraLoginValida(char letra)
        {
            if( Char.IsLetterOrDigit(letra) || Char.IsControl(letra) || letra == '_')
            {
                return true;
            }

            return false;
        }

        public static bool InputConTexto(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }

            return true;
        }

        public static bool SoloNumerosPositivos(char letra)
        {
            if (char.IsDigit(letra) || char.IsControl(letra))
            {
                return true;
            }

            return false;
        }

        public static bool InputMayorACero(string input)
        {
            if (InputConTexto(input))
            {
                return Convert.ToDecimal(input) > 0;
            }
            return false;
        }

        public static bool SoloTexto(char letra)
        {
            if (Char.IsLetter(letra) || Char.IsControl(letra) || Char.IsWhiteSpace(letra))
            {
                return true;
            }

            return false;
        }

        public static bool NumerosYLetras(char letra)
        {
            if(SoloNumerosPositivos(letra) || Char.IsLetter(letra))
            {
                return true;
            }

            return false;
        }

        public static bool ValidarIngreso(string patente)
        {
            bool ingresoValido = true;
            
            ServicioIngresos servicioIngresos = new ServicioIngresos();
            ServicioSalidas servicioSalidas = new ServicioSalidas();


            Ingreso ingreso = servicioIngresos.ObtenerUltimoIngreso(patente);
            Salida salida = servicioSalidas.ObtenerUltimaSalida(patente);

            if( ingreso != null && salida != null)
            {
                if(ingreso.ObtenerFechaIngreso() > salida.FechaSalida)
                {
                    ingresoValido = false;
                }
            }
            else if (ingreso != null && salida == null)
            {
                ingresoValido = false;
            }

            return ingresoValido;
            
        }
    }
}
