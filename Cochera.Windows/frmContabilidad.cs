using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;
using Cochera.Servicios;
using Cochera.Windows.Utilidades;


namespace Cochera.Windows
{
    public partial class frmContabilidad : Form
    {
        //------------ATRIBUTOS------------//
        private frmPrincipal formPrincipal;
        private ServicioMovimientosSalidas servicioMovimientoSalidas;
        private ServicioMovimientosCtasCtes servicioMovimientosCtas;


        //------------CONSTRUCTOR------------//

        public frmContabilidad(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicioMovimientoSalidas = new ServicioMovimientosSalidas();
            servicioMovimientosCtas = new ServicioMovimientosCtasCtes();

            List<IContable> contables = ObtenerContables();
 
            SetearComponentes(contables);

            CargarGrilla(contables);
        }

        //------------METODOS------------//

        private void CargarGrilla(List<IContable> contables)
        {
            datosContables.Rows.Clear();
            CargadorDeDatos.CargarDataGrid(datosContables, contables);
            MostrarImporteTotal(contables);
        }

        //--FILTRAR--//

        #region
        private void FiltrarPorDescripcion(string descripcion)
        {
            List<IContable> contables = ObtenerContables();

            contables = contables.FindAll(c => c.Descripcion().Contains(descripcion));

            CargarGrilla(contables);
        }

        private void FiltrarPorFecha(DateTime inicio, DateTime final)
        {
            List<IContable> contables =  ObtenerContables();

            Func<IContable, bool> enFecha = c =>
                           Convert.ToDateTime(c.FechaMovimiento().ToShortDateString()) >= Convert.ToDateTime(fechaInicio.Value.ToShortDateString())
                        && Convert.ToDateTime(c.FechaMovimiento().ToShortDateString()) <= Convert.ToDateTime(fechaFinal.Value.ToShortDateString());

            contables = contables.Where(enFecha).ToList();

            CargarGrilla(contables);
        }

        private void FiltrarPorMedioDePago(string medio)
        {
            List<IContable> contables = ObtenerContables();

            contables = contables.FindAll(c => c.MedioDePago() == medio);

            CargarGrilla(contables);
        }

        private void FiltrarPorVehiculo(string vehiculo)
        {
            List<IContable> contables = ObtenerContables();

            contables = contables.FindAll(c => c.Vehiculo() == vehiculo);

            CargarGrilla(contables);
        }

        #endregion

        private void MostrarImporteTotal(List<IContable> contables)
        {
            lblImporteTotal.Text = $"Importe Total: {contables.Sum(c => c.Importe()):C}";
        }
        private List<IContable> ObtenerContables()
        {

            List<MovimientoSalida> movimientosSalidas = servicioMovimientoSalidas.MovimientosSalidas();
            List<MovimientoCuentaCorriente> movimientosCtas = servicioMovimientosCtas.MovimientosCuentasCorrientes();

            List<IContable> contables = new List<IContable>();
            foreach(MovimientoSalida movimiento in movimientosSalidas)
            {
                contables.Add(movimiento);
            }

            foreach (MovimientoCuentaCorriente movimiento in movimientosCtas)
            {
                contables.Add(movimiento);
            }

            return contables.OrderBy(c => c.FechaMovimiento()).ToList();
        }

        private void SetearComponentes(List<IContable> contables)
        {
            DateTime inicio = contables.First().FechaMovimiento();

            fechaInicio.MinDate = inicio;
            fechaFinal.MinDate = inicio;

            fechaInicio.MaxDate = DateTime.Now;
            fechaFinal.MaxDate = DateTime.Now;

            fechaInicio.Value = fechaInicio.MinDate;
            fechaFinal.Value = fechaFinal.MaxDate;

        }



        //------------EVENTOS------------//

        //--SELECTOR FECHA--//

        #region

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if(fechaInicio.Value > fechaFinal.Value)
            {
                fechaInicio.Value = fechaFinal.Value;
            }
        }

        private void fechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if(fechaFinal.Value < fechaInicio.Value)
            {
                fechaFinal.Value = fechaInicio.Value;
            }
        }

        #endregion

        //--BOTONES FILTRAR--//

        #region
        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = fechaInicio.Value;
            DateTime final = fechaFinal.Value;

            FiltrarPorFecha(inicio, final);
        }
        private void btnFiltrarPorSalida_Click(object sender, EventArgs e)
        {
            FiltrarPorDescripcion("SALIDA");
        }

        private void btnFiltrarPorAbonado_Click(object sender, EventArgs e)
        {
            FiltrarPorDescripcion("ABONADO");
        }

        private void btnFiltrarAuto_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Auto");
        }

        private void btnFiltrarCamioneta_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Camioneta 4x4");
        }

        private void btnFiltrarCombi_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Combi");
        }

        private void btnFiltrarMoto_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Moto");
        }

        private void btnFiltrarMotoSidecar_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Moto con sidecar");
        }

        private void btnFiltrarEfectivo_Click(object sender, EventArgs e)
        {
            FiltrarPorMedioDePago("EFECTIVO");
        }

        private void btnFiltrarDebito_Click(object sender, EventArgs e)
        {
            FiltrarPorMedioDePago("DEBITO AUTOMATICO");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<IContable> contables = ObtenerContables();

            SetearComponentes(contables);

            btnFiltrarPorFecha_Click(sender, e);
        }

        #endregion
    }
}
