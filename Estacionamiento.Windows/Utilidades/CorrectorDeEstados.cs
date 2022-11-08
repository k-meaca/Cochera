﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento.Windows.Utilidades
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
    }
}