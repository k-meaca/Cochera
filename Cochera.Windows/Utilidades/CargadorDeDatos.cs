using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cochera.Windows.Utilidades
{
    public static class CargadorDeDatos
    {
        //------------METODOS------------//

        //----PUBLICOS----//

        public static void SetearComboBox<T>(ComboBox combo, List<T> datos)
        {
            foreach(T dato in datos)
            {
                combo.Items.Add(dato.ToString());
                combo.Tag = datos;
            }
            combo.SelectedIndex = 0;
        }
    }
}
