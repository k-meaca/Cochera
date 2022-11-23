using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Entidades.Interfaces;
using Cochera.Servicios;
using Cochera.Windows.Utilidades;


namespace Cochera.Windows
{
    public partial class frmIngresos : Form
    {
        //------------ATRIBUTOS------------//

        private frmPrincipal formPrincipal;
        private ServicioIngresos servicioIngresos;
        
        //------------CONSTRUCTOR------------//
        
        public frmIngresos(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicioIngresos = new ServicioIngresos();

            CargarGrilla();

            SetearComponentes();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void BuscarPorPatente(string patente)
        {
            List<IIngreso> ingresos = servicioIngresos.ObtenerIngresos();

            datosIngresos.Rows.Clear();

            if (!Validador.InputConTexto(patente)) 
            {
                CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
            }
            else
            {
                ingresos = ingresos.FindAll(i => i.ObtenerPatente().Contains(patente));
                CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
            }

        }

        private void CargarGrilla()
        {
            List<IIngreso> ingresos = servicioIngresos.ObtenerIngresos();
            CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
        }

        private void SetearComponentes()
        {
            List<IIngreso> ingresos = servicioIngresos.ObtenerIngresos();


            DateTime inicio = ingresos.First().ObtenerFechaIngreso();

            fechaInicio.MinDate = inicio;
            fechaFinal.MinDate = inicio;

            fechaInicio.MaxDate = DateTime.Now;
            fechaFinal.MaxDate = DateTime.Now;

            fechaInicio.Value = fechaInicio.MinDate;
            fechaFinal.Value = fechaFinal.MaxDate;

            //CorrectorDeEstados.SetearFecha(fechaInicio, ingresos[0].ObtenerFechaIngreso());
            //CorrectorDeEstados.SetearFecha(fechaFinal, ingresos[0].ObtenerFechaIngreso());
        }

        //------------EVENTOS------------//

        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            List<IIngreso> ingresos = servicioIngresos.ObtenerIngresos();

            Func<IIngreso, bool> enFecha = i => 
                        Convert.ToDateTime(i.ObtenerFechaIngreso().ToShortDateString()) >= Convert.ToDateTime(fechaInicio.Value.ToShortDateString())
                     && Convert.ToDateTime(i.ObtenerFechaIngreso().ToShortDateString()) <= Convert.ToDateTime(fechaFinal.Value.ToShortDateString());

            ingresos = ingresos.Where(enFecha).ToList();

            datosIngresos.Rows.Clear();

            CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
        }

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

        //-SELECTOR FECHA-//

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
