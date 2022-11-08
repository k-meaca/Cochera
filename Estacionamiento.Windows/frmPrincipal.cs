using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Windows.Utilidades;
using Estacionamiento.Entidades;
using Estacionamiento.Servicios;

namespace Estacionamiento.Windows
{
    public partial class frmPrincipal : Form
    {

        //ATRIBUTOS

        private Usuario usuarioSesion;
        private ToolStripButton botonMenuSeleccionado;
        private Form formularioActivo;

        //CONSTRUCTOR

        public frmPrincipal(Usuario usuarioSesion)
        {
            InitializeComponent();

            reloj.Start();

            this.usuarioSesion = usuarioSesion;

            InfoSesion();
        }

        //------------------METODOS------------------//

        //-------PRIVADOS-------//


        private void CerrarFormularioActivo()
        {
            formularioActivo.Close();
            formularioActivo = null;
        }
        private void InfoSesion()
        {
            lblUsuario.Text = "USUARIO: " + usuarioSesion.NombreCompleto().ToUpper();

            lblFecha.Text = "FECHA: " + DateTime.Now.ToShortDateString();

            lblHora.Text = "HORA: " + DateTime.Now.ToShortTimeString();

        }
        private void MostrarFormulario(Form formulario)
        {

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;

            pnlFormularios.Controls.Add(formulario);

            formularioActivo = formulario;

            formulario.Show();
        }

        private void SeleccionarBoton(ToolStripButton boton)
        {
            if (boton.Checked)
            {
                botonMenuSeleccionado = null;
                boton.Checked = false;
            }
            else
            {
                if (!(botonMenuSeleccionado is null))
                {
                    ToolStripButton botonAux = botonMenuSeleccionado;
                    botonMenuSeleccionado = null;
                    botonAux.Checked = false;
                }
                boton.Checked = true;
                botonMenuSeleccionado = boton;
            }
        }

        //-------PUBLICOS-------//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
        }


        //------------------EVENTOS------------------//

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "HORA: " + DateTime.Now.ToShortTimeString();
        }

        //-------IMAGENES-------//

        #region
        private void imgSalir_Click(object sender, EventArgs e)
        {
            reloj.Stop();
            Close();   
        }

        private void imgControl_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Silver;
        }

        private void imgControl_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void imgMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        //-------BOTONES DEL MENU-------//

        //---BOTON CLIENTES---//

        #region
        private void btnClientesMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (btnClientesMenu.Checked)
            {
                btnClientesMenu_MouseEnter(sender, e);
            }
            else
            {
                btnClientesMenu_MouseLeave(sender, e);
            }
        }
        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnClientesMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnClientesMenu.Image = Properties.Resources.ClientesMenuGIF;
        }
        private void btnClientesMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnClientesMenu.Checked)
                btnClientesMenu.Image = Properties.Resources.ClientesMenu;
        }


        #endregion

        //---BOTON CTAS CTES---//

        #region
        private void btnCuentasCtesMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCuentasCtesMenu.Checked)
            {
                btnCuentasCtesMenu_MouseEnter(sender, e);
            }
            else
            {
                btnCuentasCtesMenu_MouseLeave(sender, e);
            }
        }

        private void btnCuentasCtesMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnCuentasCtesMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
            {
                btnCuentasCtesMenu.Image = Properties.Resources.CuentasCorrientesMenuGIF;
            }
        }

        private void btnCuentasCtesMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnCuentasCtesMenu.Checked)
                btnCuentasCtesMenu.Image = Properties.Resources.CuentasCorrientesMenu;
        }

        #endregion

        //---BOTON TARIFAS---//

        #region
        private void btnTarifasMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTarifasMenu.Checked)
            {
                btnTarifasMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmTarifas(this));
            }
            else
            {
                btnTarifasMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnTarifasMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnTarifasMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnTarifasMenu.Image = Properties.Resources.TarifasMenuGIF;
        }

        private void btnTarifasMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnTarifasMenu.Checked)
                btnTarifasMenu.Image = Properties.Resources.TarifasMenu;
        }
        #endregion
    }
}
