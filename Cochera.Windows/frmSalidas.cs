using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Servicios;
using Cochera.Entidades;
using Cochera.Windows.Utilidades;

namespace Cochera.Windows
{
    public partial class frmSalidas : Form
    {

        //------------ATRIBUTOS------------//

        private frmPrincipal formPrincipal;
        private ServicioSalidas servicioSalidas;


        public frmSalidas(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            servicioSalidas = new ServicioSalidas();

            CargarGrilla();

            SetearComponentes();
        }

        //------------METODOS------------//

        //----PRIVADOS----//
        private void BuscarPorPatente(string patente)
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();

            datosSalidas.Rows.Clear();

            if (!Validador.InputConTexto(patente))
            {
                CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);
            }
            else
            {
                salidas = salidas.FindAll(s => s.ObtenerPatente().Contains(patente));
                CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);
            }
        }

        private void CargarGrilla()
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();
            CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);
        }

        private void SetearComponentes()
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();


            DateTime inicio = salidas.First().FechaSalida;

            fechaInicio.MinDate = inicio;
            fechaFinal.MinDate = inicio;

            fechaInicio.MaxDate = DateTime.Now;
            fechaFinal.MaxDate = DateTime.Now;

            fechaInicio.Value = fechaInicio.MinDate;
            fechaFinal.Value = fechaFinal.MaxDate;
        }

        //------------EVENTOS------------//

        //-FILTRAR FECHA-//

        #region
        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();

            Func<Salida, bool> enFecha = s =>
                            Convert.ToDateTime(s.FechaSalida.ToShortDateString()) >= Convert.ToDateTime(fechaInicio.Value.ToShortDateString())
                         && Convert.ToDateTime(s.FechaSalida.ToShortDateString()) <= Convert.ToDateTime(fechaFinal.Value.ToShortDateString());

            salidas = salidas.Where(enFecha).ToList();

            datosSalidas.Rows.Clear();

            CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);
        }

        #endregion

        //-BUSCAR PATENTE-//

        #region
        private void txtBuscarPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validador.NumerosYLetras(e.KeyChar))
            {
                e.Handled = false;
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBuscarPatente_TextChanged(object sender, EventArgs e)
        {
            BuscarPorPatente(txtBuscarPatente.Text);
        }

        #endregion

        //-SELECTOR FECHA-/

        #region
        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (fechaInicio.Value > fechaFinal.Value)
            {
                fechaInicio.Value = fechaFinal.Value;
            }
        }

        private void fechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (fechaFinal.Value < fechaInicio.Value)
            {
                fechaFinal.Value = fechaInicio.Value;
            }
        }
        #endregion
    }
}
