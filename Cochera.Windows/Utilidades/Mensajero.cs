using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cochera.Windows.Utilidades
{
    public static class Mensajero
    {
        public static void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensajeExitoso(string mensaje)
        {
            MessageBox.Show(mensaje, "Operacion existosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MensajeAdvertencia(string mensaje, string advertencia)
        {
            return MessageBox.Show(mensaje, advertencia, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
