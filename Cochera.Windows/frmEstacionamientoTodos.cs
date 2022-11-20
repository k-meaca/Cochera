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
    public partial class frmEstacionamientoTodos : Form
    {
        //------------ATRIBUTOS-------------//

        private frmEstacionamiento formEstacionamiento;
        private ServicioEstacionamientos servicioEstacionamientos;

        public frmEstacionamientoTodos(frmEstacionamiento formEstacionamiento)
        {
            InitializeComponent();

            this.formEstacionamiento = formEstacionamiento;
            servicioEstacionamientos = new ServicioEstacionamientos();

            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();

            CargarGrilla(estacionamientos);

            MostrarLugaresLibres(estacionamientos);
        }


        //------------METODOS------------//


        //----PRIVADOS----//

        private void CargarGrilla(List<Estacionamiento> estacionamientos)
        {
            CargadorDeDatos.CargarDataGrid(datosEstacionamientos, estacionamientos);
        }

        private void MostrarLugaresLibres(List<Estacionamiento> estacionamientos)
        {
            lblCantTotal.Text = estacionamientos.Count.ToString();
            lblCantLibresTotales.Text = estacionamientos.Count(e => e.Ocupado == false).ToString();

            lblCantLibresPB.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Planta Baja")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresA.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo A")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresB.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo B")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresC.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo C")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresD.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo D")
                                                        .Count(e => e.Ocupado == false).ToString();
        }
    }
}
