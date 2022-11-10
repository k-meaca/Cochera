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
                CorrectorDeEstados.ActivarBoton(btnDesocupar);
                CorrectorDeEstados.AnularBoton(btnEstacionar);
            }
            else
            {
                CorrectorDeEstados.ActivarBoton(btnEstacionar);
                CorrectorDeEstados.AnularBoton(btnDesocupar);
            }

            lblUbicacion.Text = estacionamiento.Ubicacion;

        }

        //-----------EVENTOS-----------//
        private void btnDesocupar_Click(object sender, EventArgs e)
        {

        }
    }
}
