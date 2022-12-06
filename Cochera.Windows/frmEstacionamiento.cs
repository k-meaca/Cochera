using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Servicios;
using Cochera.Entidades;
using Cochera.Windows.Utilidades;


namespace Cochera.Windows
{
    public partial class frmEstacionamiento : Form
    {
        //------------ATRIBUTOS----------//

        private frmPrincipal formPrincipal;
        private ServicioEstacionamientos servicioEstacionamientos;

        Form formularioActivo;
        ToolStripButton botonSeleccionado;

        public frmEstacionamiento(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            servicioEstacionamientos = new ServicioEstacionamientos();

            SeleccionarBoton(btnMostrarTodos);
        }

        //------------METODOS------------//

        //----PRIVADOS----//



        private void CerrarSector()
        {
            formularioActivo.Close();
            formularioActivo = null;
        }

        private void EstablecerSector(Form frmSector)
        {
      
            formularioActivo = frmSector;

            frmSector.TopLevel = false;

            frmSector.Dock = DockStyle.Fill;

            pnlEstacionamientos.Controls.Add(frmSector);

            frmSector.Show();
        }



        private void SeleccionarBoton(ToolStripButton boton)
        {
            if (!boton.Checked)
            {
                if(botonSeleccionado != null)
                    botonSeleccionado.Checked = false;
                
                boton.Checked = true;
                botonSeleccionado = boton;
            }
            else
            {
                boton.Checked = false;
                botonSeleccionado = null;
                SeleccionarBoton(btnMostrarTodos);
            }
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }

        //------------EVENTOS------------//

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            if(!btnMostrarTodos.Checked)
                SeleccionarBoton((ToolStripButton)sender);

        }
        private void btnMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                frmEstacionamientoTodos todos = new frmEstacionamientoTodos(this);

                EstablecerSector(todos);
            }
            else
            {
                CerrarSector();
            }
        }

        private void btnPlantaBaja_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnPlantaBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {

                List<Estacionamiento> estacionamientosPB = servicioEstacionamientos.ObtenerEstacionamientosPB();

                frmPlantaBaja plantaBaja = new frmPlantaBaja(this, estacionamientosPB);

                EstablecerSector(plantaBaja);

            }
            else
            {
                CerrarSector();
            }
        }

        private void btnSubsueloA_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnSubsueloA_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                List<Estacionamiento> estacionamientosSubsueloA = servicioEstacionamientos.ObtenerEstacionamientosSubsueloA();

                frmSubsuelo subsueloA = new frmSubsuelo(this, estacionamientosSubsueloA);

                EstablecerSector(subsueloA);
            }
            else
            {
                CerrarSector();
            }
        }

        private void btnSubsueloB_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnSubsueloB_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {

                List<Estacionamiento> estacionamientosSubsueloB = servicioEstacionamientos.ObtenerEstacionamientosSubsueloB();

                frmSubsuelo subsueloB = new frmSubsuelo(this, estacionamientosSubsueloB);

                EstablecerSector(subsueloB);
            }
            else
            {
                CerrarSector();
            }
        }

        private void btnSubsueloC_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnSubsueloC_CheckedChanged(object sender, EventArgs e)
        {

            if (((ToolStripButton)sender).Checked)
            {
                List<Estacionamiento> estacionamientosSubsueloC = servicioEstacionamientos.ObtenerEstacionamientosSubsueloC();

                frmSubsuelo subsueloC = new frmSubsuelo(this, estacionamientosSubsueloC);

                EstablecerSector(subsueloC);
            }
            else
            {
                CerrarSector();
            }

        }

        private void btnSubsueloD_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((ToolStripButton)sender);
        }

        private void btnSubsueloD_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripButton)sender).Checked)
            {
                List<Estacionamiento> estacionamientosSubsueloD = servicioEstacionamientos.ObtenerEstacionamientosSubsueloD();

                frmSubsuelo subsueloD = new frmSubsuelo(this, estacionamientosSubsueloD);

                EstablecerSector(subsueloD);
            }
            else
            {
                CerrarSector();
            }
        }

    }
}
