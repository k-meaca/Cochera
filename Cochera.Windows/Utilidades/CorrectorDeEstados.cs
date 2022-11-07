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

        public static void ActivarCheck(CheckBox check)
        {
            check.Checked = true;
            check.Enabled = true;
        }

        public static void AnularCheck(CheckBox check)
        {
            check.Checked = false;
            check.Enabled = false;
        }

        public static void ActivarComponente(TextBox txtBox)
        {
            txtBox.Enabled = true;
        }

        public static void ActivarComponente(ComboBox cmBox)
        {
            cmBox.Enabled = true;
        }

        public static void AnularComponente(TextBox txtBox)
        {
            txtBox.Enabled = false;
        }

        public static void AnularComponente(ComboBox cmBox)
        {
            cmBox.Enabled = false;
        }

        public static void SetearFecha(DateTimePicker selectorFecha, DateTime fechaInicial)
        {
            selectorFecha.MinDate = fechaInicial;
            selectorFecha.MaxDate = DateTime.Now;
        }

    }
}
