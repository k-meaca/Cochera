using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Windows.Utilidades;
using Cochera.Servicios;
using Cochera.Entidades;

namespace Cochera.Windows
{
    public partial class frmMarcas : Form
    {

        //------------ATRIBUTOS------------//
        frmPrincipal formPrincipal;
        ServicioMarcas servicioMarcas;

        //------------CONSTRUCTOR------------//
        public frmMarcas(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarDatosEnFila(DataGridViewRow fila, Marca marca)
        {
            fila.Cells[colMarcas.Index].Value = marca.Nombre;

            fila.Tag = marca;
        }
        private void CargarFilaEnGrilla(DataGridViewRow fila)
        {
            datosMarcas.Rows.Add(fila);
        }
        private void CargarGrilla()
        {
            servicioMarcas = new ServicioMarcas();

            List<Marca> marcas = servicioMarcas.ObtenerMarcas();

            foreach (Marca marca in marcas)
            {
                DataGridViewRow fila = CrearFila();

                CargarDatosEnFila(fila, marca);

                CargarFilaEnGrilla(fila);
            }

        }
        public DataGridViewRow CrearFila()
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(datosMarcas);

            return fila;
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void ActualizarMarca(Marca marca)
        {
            DataGridViewRow fila = datosMarcas.SelectedRows[0];

            CargarDatosEnFila(fila, marca);
        }

        public void AgregarMarca(Marca marca)
        {
            DataGridViewRow fila = CrearFila();

            CargarDatosEnFila(fila, marca);

            CargarFilaEnGrilla(fila);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }


        //------------EVENTOS------------//

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMarcasEdicion frmAgregarModelo = new frmMarcasEdicion(this);

            AnularBotones();

            frmAgregarModelo.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datosMarcas.SelectedRows.Count > 0)
            {
                frmMarcasEdicion frmEditarMarca = new frmMarcasEdicion(this, (Marca)datosMarcas.SelectedRows[0].Tag);

                AnularBotones();

                frmEditarMarca.Show();
            }
        }
    }
}
