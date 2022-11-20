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
    public partial class frmPlantaBaja : Form, ISectorEstacionamiento
    {
        //------------ATRIBUTOS------------//

        private frmEstacionamiento formEstacionamiento;
        List<Estacionamiento> estacionamientosPB;


        //------------CONSTRUCTOR------------//
        public frmPlantaBaja(frmEstacionamiento formEstacionamiento, List<Estacionamiento> estacionamientos)
        {
            InitializeComponent();

            this.formEstacionamiento = formEstacionamiento;

            estacionamientosPB = estacionamientos;

            CargarContenedorMotos();

            CargarContenedorAutos();
        }

        //------------METODOS------------//

        //----PRIVATE----//

        private void CargarContenedorMotos()
        {
            ServicioTiposDeVehiculos servicioTipos = new ServicioTiposDeVehiculos();

            TipoDeVehiculo moto = servicioTipos.ConstruirMoto();

            foreach(Estacionamiento estacionamiento in estacionamientosPB)
            {
                if (estacionamiento.PuedeEstacionarVehiculo(moto))
                {
                    UCEstacionamiento estacionamientoMoto = new UCEstacionamiento(this, estacionamiento);

                    contenedorMotos.Controls.Add(estacionamientoMoto);

                }
            }

            List<Estacionamiento> estacionamientoMotos = estacionamientosPB.FindAll(e => e.PuedeEstacionarVehiculo(moto) == true);

            lblCantTotalMotos.Text = estacionamientoMotos.Count.ToString();
            ActualizarLugares(moto);
        }

        private void CargarContenedorAutos()
        {
            ServicioTiposDeVehiculos servicioTipos = new ServicioTiposDeVehiculos();

            TipoDeVehiculo auto = servicioTipos.ConstruirAuto();

            foreach (Estacionamiento estacionamiento in estacionamientosPB)
            {
                if (estacionamiento.PuedeEstacionarVehiculo(auto))
                {
                    UCEstacionamiento estacionamientoAutos = new UCEstacionamiento(this, estacionamiento);
                 
                    contenedorAutos.Controls.Add(estacionamientoAutos);
                }

            }

            List<Estacionamiento> estacionamientosAutos = estacionamientosPB.FindAll(e => e.PuedeEstacionarVehiculo(auto));

            lblCantTotalComunes.Text = estacionamientosAutos.Count.ToString();
            ActualizarLugares(auto);
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            contenedorAutos.Enabled = true;
            contenedorMotos.Enabled = true;
            formEstacionamiento.ActivarBotones();
        }

        public void ActualizarLugares(TipoDeVehiculo vehiculo)
        {
            List<Estacionamiento> estacionamientos = estacionamientosPB.FindAll(e => e.PuedeEstacionarVehiculo(vehiculo));

            if (vehiculo.Tipo.Contains("Moto"))
            {
                lblCantidadOcupadosMotos.Text = estacionamientos.Count(e => e.Ocupado == true).ToString();
                lblCantLibresMotos.Text = estacionamientos.Count(e => e.Ocupado == false).ToString();
            }
            else
            {
                lblCantOcupadosComunes.Text = estacionamientos.Count(e => e.Ocupado == true).ToString();
                lblCantLibresComunes.Text = estacionamientos.Count(e => e.Ocupado == false).ToString();                
            }
        }

        public void AnularBotones()
        {
            contenedorAutos.Enabled = false;
            contenedorMotos.Enabled = false;
            formEstacionamiento.AnularBotones();
        }

        //------------EVENTOS------------//
    }
}
