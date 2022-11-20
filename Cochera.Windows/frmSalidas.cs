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

        private void CargarGrilla()
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();
            CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);
            MostrarRecaudacion(salidas);
        }
        
        public void MostrarRecaudacion(List<Salida> salidas)
        {
            lblMontoTotal.Text = salidas.Sum(s => s.MontoTotal).ToString("C");
        }

        private void SetearComponentes()
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();

            CorrectorDeEstados.SetearFecha(fechaInicio, salidas[0].FechaSalida);
            CorrectorDeEstados.SetearFecha(fechaFinal, salidas[0].FechaSalida);
        }

        //------------EVENTOS------------//
        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            List<Salida> salidas = servicioSalidas.ObtenerSalidas();

            Func<Salida, bool> enFecha = s => 
                            Convert.ToDateTime(s.FechaSalida.ToShortDateString()) >= Convert.ToDateTime(fechaInicio.Value.ToShortDateString())
                         && Convert.ToDateTime(s.FechaSalida.ToShortDateString()) <= Convert.ToDateTime(fechaFinal.Value.ToShortDateString());

            salidas = salidas.Where(enFecha).ToList();

            datosSalidas.Rows.Clear();

            CargadorDeDatos.CargarDataGrid(datosSalidas, salidas);

            MostrarRecaudacion(salidas);
        }
    }
}
