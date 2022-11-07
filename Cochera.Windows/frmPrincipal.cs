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
using Cochera.Windows.Utilidades;
using Cochera.Entidades;
using Cochera.Servicios;

namespace Cochera.Windows
{
    public partial class frmPrincipal : Form
    {

        //ATRIBUTOS

        private Usuario usuarioSesion;
        private ToolStripButton botonMenuSeleccionado;
        private Form formularioActivo;


        private ServicioAbonados servicioAbonados;
        private ServicioIngresos servicioIngresos;
        private List<Abonado> abonados;

        //CONSTRUCTOR

        public frmPrincipal(Usuario usuarioSesion)
        {
            InitializeComponent();

            minutero.Start();

            this.usuarioSesion = usuarioSesion;
            servicioAbonados = new ServicioAbonados();

            abonados = servicioAbonados.ObtenerAbonados().Where(a => !a.Baja).ToList();

            InfoSesion();

            InformarAbonadosPorCaducar();
        }

        //------------------METODOS------------------//

        //-------PRIVADOS-------//

        #region

        private bool ActualizarAbonados(List<Abonado> abonados)
        {
            bool actualizado = false;

            foreach (Abonado abonado in abonados)
            {
                if ((abonado.FechaExpiracion - DateTime.Now).TotalHours < 0)
                {
                    NoEsMasAbonado(abonado);

                    actualizado = true;
                }
            }

            return actualizado;
        }

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

        private void InformarAbonadosPorCaducar()
        {
            if (ActualizarAbonados(abonados))
            {
                abonados = servicioAbonados.ObtenerAbonados().Where(a => !a.Baja).ToList();
            }

            Func<Abonado, bool> porCaducar = a => (a.FechaExpiracion - DateTime.Now).TotalHours < 72;

            List<Abonado> abonadosPorCaducar = abonados.Where(porCaducar).ToList();

            if (abonadosPorCaducar.Count >= 1)
            {
                frmAbonadosPorVencer frmAbonados = new frmAbonadosPorVencer(this, abonadosPorCaducar);

                frmAbonados.Show();
            }
        }

        private void MostrarFormulario(Form formulario)
        {

            try
            {
                formulario.TopLevel = false;

                formulario.Dock = DockStyle.Fill;

                pnlFormularios.Controls.Add(formulario);

                formularioActivo = formulario;

                formulario.Show();
            }
            catch (SqlException)
            {
                Mensajero.MensajeError("Ocurrio algun problema con el servidor.");
            }
            catch (Exception)
            {
                Mensajero.MensajeError("Ocurrio algo inesperado.");
            }
        }

        private void NoEsMasAbonado(Abonado abonado)
        {
            try
            {
                servicioIngresos = new ServicioIngresos();

                servicioAbonados.DarBaja(abonado);

                servicioIngresos.AbonadoAhoraEsIngreso(abonado);
            }
            catch (Exception)
            {
                Mensajero.MensajeError("No ha sido posible dar de baja al abonado.");
            }
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

        #endregion

        //-------PUBLICOS-------//

        #region
        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            imgMinimizar.Enabled = true;
            imgSalir.Enabled = true;
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            imgMinimizar.Enabled = false;
            imgSalir.Enabled = false;
        }

        #endregion

        //------------------EVENTOS------------------//

        //----RELOJES----//

        #region
        private void reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "HORA: " + DateTime.Now.ToShortTimeString();
        }

        private void relojAbonados_Tick(object sender, EventArgs e)
        {
            abonados = servicioAbonados.ObtenerAbonados().Where(a => !a.Baja).ToList();
            InformarAbonadosPorCaducar();
        }

        #endregion

        //-------IMAGENES-------//

        #region
        private void imgSalir_Click(object sender, EventArgs e)
        {
            minutero.Stop();
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
            if (((ToolStripButton)sender).Checked)
            {
                btnClientesMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmClientes(this));
            }
            else
            {
                btnClientesMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
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

        //---BOTON MODELOS---//

        #region
        private void btnModelosMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnModelosMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmModelos(this));
            }
            else
            {
                btnModelosMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnModelosMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnModelosMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
            {
                btnModelosMenu.Image = Properties.Resources.ModelosMenuGIF;
            }
        }

        private void btnModelosMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnModelosMenu.Checked)
                btnModelosMenu.Image = Properties.Resources.ModelosMenu;
        }

        #endregion

        //---BOTON TARIFAS---//

        #region
        private void btnTarifasMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
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


        //---BOTON DOCUMENTOS---//

        #region
        private void btnDocumentosMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnDocumentosMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmDocumentos(this));
            }
            else
            {
                btnDocumentosMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnDocumentosMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnDocumentosMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnDocumentosMenu.Image = Properties.Resources.DocumentosMenuGIF;
        }

        private void btnDocumentosMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnDocumentosMenu.Checked)
                btnDocumentosMenu.Image = Properties.Resources.DocumentosMenu;
        }
        #endregion

        //---BOTON ABONADOS--//

        #region
        private void btnAbonadosMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnAbonadosMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmAbonados(this));
            }
            else
            {
                btnAbonadosMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnAbonadosMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnAbonadosMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnAbonadosMenu.Image = Properties.Resources.AbonadosMenuGIF;
        }

        private void btnAbonadosMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnAbonadosMenu.Checked)
                btnAbonadosMenu.Image = Properties.Resources.AbonadosMenu;
        }

        #endregion

        //---BOTON MARCAS---//

        #region
        private void btnMarcasMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnMarcasMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmMarcas(this));
            }
            else
            {
                btnMarcasMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnMarcasMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnMarcasMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnMarcasMenu.Image = Properties.Resources.MarcasMenuGIF;
        }

        private void btnMarcasMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnMarcasMenu.Checked)
                btnMarcasMenu.Image = Properties.Resources.MarcasMenu;
        }
        #endregion

        //---BOTON CTAS CTES---//

        #region
        private void btnCuentasCtesMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnCuentasCtesMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmCuentasCorrientes(this));
            }
            else
            {
                btnCuentasCtesMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnCuentasCtesMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnCuentasCtesMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnCuentasCtesMenu.Image = Properties.Resources.CuentasCtesMenuGIF;
        }

        private void btnCuentasCtesMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnCuentasCtesMenu.Checked)
                btnCuentasCtesMenu.Image = Properties.Resources.CuentasCtesMenu;
        }
        #endregion

        //---BOTON ESTACIONMIENTO---//

        #region
        private void btnEstacionamientoMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnEstacionamientoMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmEstacionamiento(this));
            }
            else
            {
                btnEstacionamientoMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnEstacionamientoMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnEstacionamientoMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnEstacionamientoMenu.Image = Properties.Resources.EstacionamientoMenuGIF;
        }

        private void btnEstacionamientoMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnEstacionamientoMenu.Checked)
                btnEstacionamientoMenu.Image = Properties.Resources.EstacionamientoMenu;
        }

        #endregion

        //---BOTON INGRESOS---//

        #region
        private void btnIngresosMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnIngresosMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmIngresos(this));
            }
            else
            {
                btnIngresosMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnIngresosMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnIngresosMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnIngresosMenu.Image = Properties.Resources.IngresoMenuGIF;
        }

        private void btnIngresosMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnIngresosMenu.Checked)
                btnIngresosMenu.Image = Properties.Resources.IngresoMenu;
        }
        #endregion

        //---BOTON SALIDAS---//

        #region
        private void btnSalidasMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnSalidasMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmSalidas(this));
            }
            else
            {
                btnSalidasMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnSalidasMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnSalidasMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnSalidasMenu.Image = Properties.Resources.SalidaMenuGIF;
        }

        private void btnSalidasMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnSalidasMenu.Checked)
                btnSalidasMenu.Image = Properties.Resources.SalidasMenu;
        }

        #endregion

        //---BOTON CONTABILIDAD---//

        #region
        private void btnContabilidadMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                btnContabilidadMenu_MouseEnter(sender, e);
                MostrarFormulario(new frmContabilidad(this));
            }
            else
            {
                btnContabilidadMenu_MouseLeave(sender, e);
                CerrarFormularioActivo();
            }
        }

        private void btnContabilidadMenu_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnContabilidadMenu_MouseEnter(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null)
                btnContabilidadMenu.Image = Properties.Resources.ContabilidadMenuGIF;
        }

        private void btnContabilidadMenu_MouseLeave(object sender, EventArgs e)
        {
            if (botonMenuSeleccionado is null && !btnContabilidadMenu.Checked)
                btnContabilidadMenu.Image = Properties.Resources.ContabilidadMenu;
        }


        #endregion


    }
}
