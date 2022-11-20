using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cochera.Windows.Utilidades
{
    public static class CorrectorDeEstados
    {

        public static void AnularBotones(ToolStrip botonesMenu)
        {
            foreach(ToolStripButton boton in botonesMenu.Items)
            {
                boton.Enabled = false;
            }
        }

        public static void ActivarBotones(ToolStrip botonesMenu)
        {
            foreach(ToolStripButton boton in botonesMenu.Items)
            {
                boton.Enabled = true;
            }
        }

        public static void ActivarBoton(Button boton)
        {
            boton.Visible = true;
            boton.Enabled = true;
        }

        public static void AnularBoton(Button boton)
        {
            boton.Visible = false;
            boton.Enabled = false;
        }

        public static void SetearFecha(DateTimePicker selectorFecha, DateTime fechaInicial)
        {
            selectorFecha.MinDate = fechaInicial;
            selectorFecha.MaxDate = DateTime.Now;
        }

    }
}
