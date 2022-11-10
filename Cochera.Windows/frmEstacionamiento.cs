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


namespace Cochera.Windows
{
    public partial class frmEstacionamiento : Form
    {
        //------------ATRIBUTOS----------//

        private frmPrincipal formPrincipal;
        private ServicioEstacionamientos servicioEstacionamientos;
        List<Estacionamiento> estacionamientos;

        public frmEstacionamiento(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            servicioEstacionamientos = new ServicioEstacionamientos();


        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarDatosEnFila(DataGridViewRow fila, Estacionamiento estacionamiento)
        {
            fila.Cells[colSector.Index].Value = estacionamiento.ObtenerSector();
            fila.Cells[colUbicacion.Index].Value = estacionamiento.Ubicacion;
            fila.Cells[colOcupado.Index].Value = estacionamiento.Ocupado ? "SI" : "NO";
        }

        private void CargarFilaEnGrilla(DataGridViewRow fila)
        {
            datosEstacionamientos.Rows.Add(fila);
        }

        private void CargarGrilla()
        {

            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();

            foreach (Estacionamiento estacionamiento in estacionamientos)
            {
                DataGridViewRow fila = CrearFila();

                CargarDatosEnFila(fila, estacionamiento);

                CargarFilaEnGrilla(fila);
            }
        }

        private DataGridViewRow CrearFila()
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(datosEstacionamientos);

            return fila;
        }

        //----PUBLICOS----//

        //------------EVENTOS------------//
        
        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            btnMostrarTodos_Click(sender, e);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            datosEstacionamientos.Rows.Clear();
            datosEstacionamientos.Visible = true; ;
            panelBotones.Visible = true;

            CargarGrilla();
        }

        private void btnPlantaBaja_Click(object sender, EventArgs e)
        {
            datosEstacionamientos.Rows.Clear();
            datosEstacionamientos.Visible = false;
            panelBotones.Visible = false;

            servicioEstacionamientos = new ServicioEstacionamientos();

            List<Estacionamiento> estacionamientosPB = servicioEstacionamientos.ObtenerEstacionmientosPB();

            frmPlantaBaja plantaBaja = new frmPlantaBaja(this,estacionamientosPB);

            plantaBaja.TopLevel = false;

            plantaBaja.Dock = DockStyle.Fill;

            pnlEstacionamientos.Controls.Add(plantaBaja);

            plantaBaja.Show();

        }
    }
}
