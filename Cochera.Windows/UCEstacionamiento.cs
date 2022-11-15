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
using Cochera.Windows.Utilidades;


namespace Cochera.Windows
{
    public partial class UCEstacionamiento : UserControl
    {
        //------------ATRIBUTOS------------//

        private frmPlantaBaja formPB;
        private Estacionamiento estacionamiento;


        //------------CONSTRUCTOR------------//
        public UCEstacionamiento(frmPlantaBaja formPB,Estacionamiento estacionamiento)
        {
            InitializeComponent();
            this.formPB = formPB;
            this.estacionamiento = estacionamiento;

            InicializarComponentes();
        }

        //------------METODOS----------//

        //----PRIVADOS----//

        private void InicializarComponentes()
        {
            if (estacionamiento.Ocupado)
            {
                EstacionamientoOcupado();
            }
            else
            {
                DesocuparEstacionamiento();
            }

            lblUbicacion.Text = estacionamiento.Ubicacion;

        }

        //----PUBLICOS----//

        public void DesocuparEstacionamiento()
        {
            CorrectorDeEstados.ActivarBoton(btnEstacionar);
            CorrectorDeEstados.AnularBoton(btnDesocupar);
        }

        public void EstacionamientoOcupado()
        {
            CorrectorDeEstados.ActivarBoton(btnDesocupar);
            CorrectorDeEstados.AnularBoton(btnEstacionar);
        }

        public void ActivarBotones()
        {
            formPB.ActivarBotones();
        }

        //-----------EVENTOS-----------//
        private void btnDesocupar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstacionar_Click(object sender, EventArgs e)
        {
            frmIngresosEdicion frmEstacionar = new frmIngresosEdicion(estacionamiento,this);

            formPB.AnularBotones();

            frmEstacionar.Show();
        }
    }
}
