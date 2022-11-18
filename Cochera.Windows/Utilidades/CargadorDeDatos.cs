using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Cochera.Entidades;
using Cochera.Entidades.Enumeraciones;


namespace Cochera.Windows.Utilidades
{
    public static class CargadorDeDatos
    {
        //------------METODOS------------//


        private static DataGridViewRow CrearFila(DataGridView grilla)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(grilla);

            return fila;
        }

        private static void SetearCombo<T>(ComboBox combo, List<T> datos)
        {
            foreach (T dato in datos)
            {
                combo.Items.Add(dato.ToString());
            }
        }



        //----PUBLICOS----//

        public static void SetearComboBox<T>(ComboBox combo, List<T> datos)
        {
            //SetearCombo(combo, datos);
            foreach (T dato in datos)
            {
                combo.Items.Add(dato.ToString());
            }
            combo.Tag = datos;
            combo.SelectedIndex = 0;
        }

        public static void SetearListBox<T>(ListBox caja, List<T> datos)
        {
            foreach(T dato in datos)
            {
                caja.Items.Add(dato.ToString());
            }
            caja.Tag = datos;
        }

        public static void CargarDataGridReducido<Cliente>(DataGridView grilla, List<Cliente> clientes) where Cliente: Entidades.Cliente
        {

            foreach(Cliente cliente in clientes)
            {
                DataGridViewRow fila = CrearFila(grilla);

                fila.Cells[0].Value = cliente.NombreCompleto();

                fila.Cells[1].Value = cliente.ObtenerNumeroDoc();

                fila.Tag = cliente;

                grilla.Rows.Add(fila);
            }
        }
        
    }
}
