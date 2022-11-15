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

namespace Cochera.Windows
{
    public partial class frmPlantaBaja : Form
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
                    UCEstacionamientoM estacionamientoMoto = new UCEstacionamientoM(this, estacionamiento);

                    contenedorMotos.Controls.Add(estacionamientoMoto);

                }
            }   
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
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            contenedorAutos.Enabled = true;
            contenedorMotos.Enabled = true;
            formEstacionamiento.ActivarBotones();
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
