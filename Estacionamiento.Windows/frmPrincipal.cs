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


        //CONSTRUCTOR

        public frmPrincipal(Usuario usuarioSesion)
        {
            InitializeComponent();

            reloj.Start();

            this.usuarioSesion = usuarioSesion;

            InfoSesion();
        }

        //METODOS

        //PRIVADOS

        private void InfoSesion()
        {
            lblUsuario.Text = "USUARIO: " + usuarioSesion.Nombre + " " + usuarioSesion.Apellido;

            lblFecha.Text = "FECHA: " + DateTime.Now.ToShortDateString();

            lblHora.Text = "HORA: " + DateTime.Now.ToShortTimeString();

        } 

        //METODOS


        //EVENTOS

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "HORA: " + DateTime.Now.ToShortTimeString();
        }

        private void imgSalir_MouseEnter(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Red;
        }

        private void imgSalir_MouseLeave(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Transparent;
        }
        private void imgSalir_Click(object sender, EventArgs e)
        {
            reloj.Stop();
            Close();   
        }
    }
}
