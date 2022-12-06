using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cochera.Servicios;
using Cochera.Entidades.Excepciones;
using Cochera.Windows.Utilidades;
using Cochera.Entidades;


namespace Cochera.Windows
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

        //METODOS

        //PRIVADOS

        private void IniciarSesion(Usuario usuario)
        {
            frmPrincipal principal = new frmPrincipal(usuario);
            principal.FormClosed += frmLogin_FormClosed;
            OcultarLogin();
            principal.Show();
        }

        private void VisibilidadDePassword(Image imagen, char caracterVisibilidad)
        {
            imgPassword.Image = imagen;
            txtPassword.PasswordChar = caracterVisibilidad;
        }

        private void LabelConError(Label label, string error)
        {
            label.Text = error;
            label.Visible = true;
        }

        private void LimpiarLabel(Label label)
        {
            label.Text = "";
            label.Visible = false;
        }

        public void OcultarLogin()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            this.Hide();
        }

        private bool ValidarDatos()
        {
            LimpiarLabel(lblErrorUsuario);
            LimpiarLabel(lblErrorPassword);

            bool validos = true;

            if (!ValidarInput(txtUsuario))
            {
                validos = false;
                LabelConError(lblErrorUsuario, "Debe llenar este campo.");
            }

            if (!ValidarInput(txtPassword))
            {
                validos = false;
                LabelConError(lblErrorPassword, "Debe llenar este campo");
            }

            return validos;
        }
        private bool ValidarInput(TextBox input)
        {
            return Validador.InputConTexto(input.Text);
        }


        //EVENTOS

        private void imgSalir_MouseEnter(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Silver;
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
                VisibilidadDePassword(Properties.Resources.pwsVisible, '\0');
            }
            else
            {
                VisibilidadDePassword(Properties.Resources.pwsNoVisible, '*');
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            try
            {
                if (servicio.ValidarUsuario(txtUsuario.Text, txtPassword.Text))
                {
                    Usuario usuario = servicio.CrearUsuario(txtUsuario.Text, txtPassword.Text);
                    IniciarSesion(usuario);
                }
            }
            catch (UsuarioInvalidoExcepcion)
            {
                LabelConError(lblErrorUsuario, "Usuario o contraseña mal ingresados.");
                LabelConError(lblErrorPassword, "Usuario o contraseña mal ingresados.");
            }
            catch (SqlException)
            {
                Mensajero.MensajeError("No se ha podido conectar con el servidor.");
            }
            catch (Exception)
            {
                Mensajero.MensajeError("Ha ocurrido algo inesperado. Comuniquese con el tecnico.");
            }
        }
        
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.LetraLoginValida(e.KeyChar);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.LetraLoginValida(e.KeyChar);
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtUsuario.Focus();
            VisibilidadDePassword(Properties.Resources.pwsNoVisible, '*');
        }
    }
}
