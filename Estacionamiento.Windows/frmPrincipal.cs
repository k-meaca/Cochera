using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Entidades;
using Estacionamiento.Servicios;

namespace Estacionamiento.Windows
{
    public partial class frmPrincipal : Form
    {

        //ATRIBUTOS

        private Usuario usuarioSesion;

        public frmPrincipal(Usuario usuarioSesion)
        {
            InitializeComponent();

            this.usuarioSesion = usuarioSesion;
        }
    }
}
