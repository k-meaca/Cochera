using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Windows.Utilidades
{
    public static class Validador
    {
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
    }
}
