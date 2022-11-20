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
using Cochera.Windows.Interfaces;

namespace Cochera.Windows
{
    public partial class frmSubsuelo : Form, ISectorEstacionamiento
    {
        //------------ATRIBUTOS------------//

        private frmEstacionamiento formEstacionamiento;
        List<Estacionamiento> estacionamientos;

        //------------CONSTRUCTOR------------//
        public frmSubsuelo(frmEstacionamiento formEstacionamiento, List<Estacionamiento> estacionamientos)
        {
            InitializeComponent();

            this.formEstacionamiento = formEstacionamiento;

            this.estacionamientos = estacionamientos;

            CargarContenedorAutos();

            lblSector.Text = estacionamientos[0].ObtenerSector();
        }

        //------------METODOS------------//

        //----PRIVATE----//

        private void CargarContenedorAutos()
        {
            ServicioTiposDeVehiculos servicioTipos = new ServicioTiposDeVehiculos();

            TipoDeVehiculo auto = servicioTipos.ConstruirAuto();

            foreach (Estacionamiento estacionamiento in estacionamientos)
            {
                if (estacionamiento.PuedeEstacionarVehiculo(auto))
                {
                    UCEstacionamiento estacionamientoAutos = new UCEstacionamiento(this, estacionamiento);

                    contenedorAutos.Controls.Add(estacionamientoAutos);
                }

            }

            lblCantTotalSector.Text = estacionamientos.Count.ToString();
            ActualizarLugares(auto);
        }

        //----PUBLICOS----//
    

        public void ActivarBotones()
        {
            contenedorAutos.Enabled = true;
            formEstacionamiento.ActivarBotones();
        }

        public void ActualizarLugares(TipoDeVehiculo auto)
        {
            lblCantOcupadosSector.Text = estacionamientos.Count(e => e.Ocupado == true).ToString();
            lblCantLibresSector.Text = estacionamientos.Count(e => e.Ocupado == false).ToString();
        }

        public void AnularBotones()
        {
            contenedorAutos.Enabled = false;
            formEstacionamiento.AnularBotones();
        }

        
    }
}
