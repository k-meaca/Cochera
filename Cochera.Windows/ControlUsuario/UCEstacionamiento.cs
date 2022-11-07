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
using Cochera.Windows.Interfaces;
using Cochera.Windows.Utilidades;
using Cochera.Servicios;
using Cochera.Entidades.Interfaces;


namespace Cochera.Windows
{
    public partial class UCEstacionamiento : UserControl, IGeneradorIngresos, IGeneradorSalidas
    {
        //------------ATRIBUTOS------------//

        private ISectorEstacionamiento sector;
        private Estacionamiento estacionamiento;
        private IIngreso ingreso;

        private ServicioIngresos servicioIngresos;


        //------------CONSTRUCTOR------------//
        public UCEstacionamiento(ISectorEstacionamiento sector,Estacionamiento estacionamiento)
        {
            InitializeComponent();
            this.sector = sector;
            this.estacionamiento = estacionamiento;

            servicioIngresos = new ServicioIngresos();

            InicializarComponentes();
        }

        //------------METODOS----------//

        //----PRIVADOS----//

        private void Desocupar()
        {
            frmDarSalida frmSalida = new frmDarSalida(ingreso, this);

            sector.AnularBotones();

            frmSalida.Show();
        }

        private void InicializarComponentes()
        {
            if (estacionamiento.Ocupado)
            {
                IIngreso ingreso = servicioIngresos.ObtenerIngreso(estacionamiento);
                EstacionamientoOcupado(ingreso);
            }
            else
            {
                DesocuparEstacionamiento();
            }

            lblUbicacion.Text = estacionamiento.Ubicacion;

        }

        private void LimpiarPatente()
        {
            lblPatente.Text = "";
            pnlPatente.Visible = false;
        }

        private void SetearImagen()
        {
            imgVehiculo.Image = Image.FromFile(@ingreso.ObtenerImagenVehiculo());
            
        }

        private void SetearPatente()
        {
            pnlPatente.Visible = true;
            lblPatente.Text = ingreso.ObtenerPatente();
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            sector.ActivarBotones();
        }

        public void ActualizarLugares(TipoDeVehiculo vehiculo)
        {
            sector.ActualizarLugares(vehiculo);
        }

        public void AnularBotones()
        {
            sector.AnularBotones();
        }

        public void DesocuparEstacionamiento()
        {
            estacionamiento.SacarVehiculo();

            ingreso = null;

            CorrectorDeEstados.ActivarBoton(btnEstacionar);
            CorrectorDeEstados.AnularBoton(btnDesocupar);

            imgVehiculo.Image = null;

            LimpiarPatente();
        }

        public void EstacionamientoOcupado(IIngreso ingreso)
        {
            this.ingreso = ingreso;

            CorrectorDeEstados.ActivarBoton(btnDesocupar);
            CorrectorDeEstados.AnularBoton(btnEstacionar);

            SetearImagen();
            SetearPatente();
        }

        public void EstacionamientoOcupado(TipoDeVehiculo tipo, IIngreso ingreso)
        {
            EstacionamientoOcupado(ingreso);
            estacionamiento.EstacionarVehiculo(tipo);
        }

        public string ObtenerUbicacion()
        {
            return estacionamiento.Ubicacion;
        }

        public bool PuedeEstacionarVehiculo(TipoDeVehiculo tipo)
        {
            return estacionamiento.PuedeEstacionarVehiculo(tipo);
        }

        //-----------EVENTOS-----------//
        private void btnDesocupar_Click(object sender, EventArgs e)
        {
            Desocupar();
        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            frmIngresosEdicion frmEstacionar = new frmIngresosEdicion(estacionamiento, this);

            AnularBotones();

            frmEstacionar.Show();
        }

        private void imgVehiculo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if( !(ingreso is null))
            {
                Desocupar();
            }
        }
    }
}
