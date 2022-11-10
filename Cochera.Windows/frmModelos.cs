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
    public partial class frmModelos : Form
    {
        //------------ATRIBUTOS------------//
        private frmPrincipal formPrincipal;
        private ServicioModelos servicioModelos;
        public frmModelos(frmPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarDatosEnFila(DataGridViewRow fila, Modelo modelo)
        {
            fila.Cells[colTipoVehiculo.Index].Value = modelo.ObtenerTipoVehiculo();
            fila.Cells[colModelo.Index].Value = modelo.Nombre;
            fila.Cells[colMarca.Index].Value = modelo.ObtenerMarca();

            fila.Tag = modelo;
        }

        private void CargarFilaEnGrilla(DataGridViewRow fila)
        {
            datosModelos.Rows.Add(fila);
        }

        private void CargarGrilla()
        {
            servicioModelos = new ServicioModelos();

            List<Modelo> modelos = servicioModelos.ObtenerModelos();

            foreach(Modelo modelo in modelos)
            {
                DataGridViewRow fila = CrearFila();

                CargarDatosEnFila(fila, modelo);

                CargarFilaEnGrilla(fila);
            }

        }

        public DataGridViewRow CrearFila()
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(datosModelos);

            return fila;
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void ActualizarModelo(Modelo modelo)
        {
            DataGridViewRow fila = datosModelos.SelectedRows[0];

            CargarDatosEnFila(fila, modelo);
        }

        public void AgregarModelo(Modelo modelo)
        {
            DataGridViewRow fila = CrearFila();

            CargarDatosEnFila(fila, modelo);

            CargarFilaEnGrilla(fila);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }

        //------------EVENTOS------------//

        //----FORMULARIO----//
        private void frmModelos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //----BOTONES----//
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmModelosEdicion frmAgregarModelo = new frmModelosEdicion(this);

            AnularBotones();

            frmAgregarModelo.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datosModelos.SelectedRows.Count > 0)
            {
                frmModelosEdicion frmEditarModelo = new frmModelosEdicion(this, (Modelo)datosModelos.SelectedRows[0].Tag);

                AnularBotones();

                frmEditarModelo.Show();
            }
        }
    }
}
