using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Servicios;
using Estacionamiento.Entidades.Excepciones;


namespace Estacionamiento.Windows
{
    public partial class frmLogin : Form
    {
        //ATRIBUTOS

        ServicioUsuarios servicio;

        //CONSTRUCTOR
        public frmLogin()
        {
            InitializeComponent();

            txtUsuario.Clear();
            txtPassword.Clear();

            servicio = new ServicioUsuarios();
        }


        //EVENTOS

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
            Dispose();
        }

        private void imgPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                imgPassword.Image = Estacionamiento.Windows.Properties.Resources.pwsVisible;
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                imgPassword.Image = Estacionamiento.Windows.Properties.Resources.pwsNoVisible;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicio.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
                {
                    
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                }
            }
            catch (UsuarioInvalidoExcepcion)
            {
                MessageBox.Show("Error", "Usuario invalido", MessageBoxButtons.OK);
            }
        }
    }
}
