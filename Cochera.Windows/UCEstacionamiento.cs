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
using Cochera.Entidades.Enumeraciones;
using Cochera.Windows.Utilidades;
using Cochera.Servicios;


namespace Cochera.Windows
{
    public partial class UCEstacionamiento : UserControl
    {
        //------------ATRIBUTOS------------//

        private frmPlantaBaja formPB;
        private Estacionamiento estacionamiento;
        private Ingreso ingreso;

        private ServicioIngresos servicioIngresos;


        //------------CONSTRUCTOR------------//
        public UCEstacionamiento(frmPlantaBaja formPB,Estacionamiento estacionamiento)
        {
            InitializeComponent();
            this.formPB = formPB;
            this.estacionamiento = estacionamiento;

            servicioIngresos = new ServicioIngresos();

            InicializarComponentes();
        }

        //------------METODOS----------//

        //----PRIVADOS----//

        private void Desocupar()
        {
            frmDarSalida frmSalida = new frmDarSalida(ingreso, this);

            formPB.AnularBotones();

            frmSalida.Show();
        }

        private void InicializarComponentes()
        {
            if (estacionamiento.Ocupado)
            {
                Ingreso ingreso = servicioIngresos.ObtenerIngreso(estacionamiento);
                EstacionamientoOcupado(ingreso);
            }
            else
            {
                DesocuparEstacionamiento();
            }

            lblUbicacion.Text = estacionamiento.Ubicacion;

        }

        private void SetearImagen()
        {
            imgVehiculo.Image = Image.FromFile(@ingreso.ObtenerImagenVehiculo());
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            formPB.ActivarBotones();
        }



        public void DesocuparEstacionamiento()
        {
            estacionamiento.SacarVehiculo();

            ingreso = null;

            CorrectorDeEstados.ActivarBoton(btnEstacionar);
            CorrectorDeEstados.AnularBoton(btnDesocupar);

            imgVehiculo.Image = null;
        }

        public void EstacionamientoOcupado(Ingreso ingreso)
        {
            this.ingreso = ingreso;
            
            CorrectorDeEstados.ActivarBoton(btnDesocupar);
            CorrectorDeEstados.AnularBoton(btnEstacionar);

            SetearImagen();
        }


        //-----------EVENTOS-----------//
        private void btnDesocupar_Click(object sender, EventArgs e)
        {
            Desocupar();
        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            frmIngresosEdicion frmEstacionar = new frmIngresosEdicion(estacionamiento,this);

            formPB.AnularBotones();

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
