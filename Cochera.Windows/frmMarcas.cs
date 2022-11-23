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

        private void CargarGrilla()
        {
            servicioMarcas = new ServicioMarcas();

            List<Marca> marcas = servicioMarcas.ObtenerMarcas();

            CargadorDeDatos.CargarDataGrid(datosMarcas, marcas);

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

            CargadorDeDatos.CargarDatosEnFila(fila, marca);
        }

        public void AgregarMarca(Marca marca)
        {
            DataGridViewRow fila = CargadorDeDatos.CrearFila(datosMarcas);

            CargadorDeDatos.CargarDatosEnFila(fila, marca);

            CargadorDeDatos.CargarFilaEnGrilla(datosMarcas, fila);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = Mensajero.MensajeAdvertencia("Advertencia.. esta por eliminar un dato.", "Cuidado.. opracion con riesgo");

            if(opcion == DialogResult.OK)
            {
                if(datosMarcas.SelectedRows.Count > 0)
                {
                    Marca marca = (Marca)datosMarcas.SelectedRows[0].Tag;

                    try
                    {
                        servicioMarcas.EliminarMarca(marca);

                        datosMarcas.Rows.Remove(datosMarcas.SelectedRows[0]);

                        Mensajero.MensajeExitoso("Se ha eliminado con exito.");
                    }
                    catch (Exception)
                    {
                        Mensajero.MensajeError("No se ha podido eliminar la marca ya que tiene modelos asociados.");
                    }
                }
            }
        }
    }
}
