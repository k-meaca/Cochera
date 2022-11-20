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

        private void CargarGrilla()
        {
            List<Ingreso> ingresos = servicioIngresos.ObtenerIngresos();
            CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
        }

        private void SetearComponentes()
        {
            List<Ingreso> ingresos = servicioIngresos.ObtenerIngresos();

            CorrectorDeEstados.SetearFecha(fechaInicio, ingresos[0].FechaIngreso);
            CorrectorDeEstados.SetearFecha(fechaFinal, ingresos[0].FechaIngreso);
        }

        //------------EVENTOS------------//

        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            List<Ingreso> ingresos = servicioIngresos.ObtenerIngresos();

            Func<Ingreso, bool> enFecha = i => 
                        Convert.ToDateTime(i.FechaIngreso.ToShortDateString()) >= Convert.ToDateTime(fechaInicio.Value.ToShortDateString())
                     && Convert.ToDateTime(i.FechaIngreso.ToShortDateString()) <= Convert.ToDateTime(fechaFinal.Value.ToShortDateString());

            ingresos = ingresos.Where(enFecha).ToList();

            datosIngresos.Rows.Clear();

            CargadorDeDatos.CargarDataGrid(datosIngresos, ingresos);
        }
    }
}
