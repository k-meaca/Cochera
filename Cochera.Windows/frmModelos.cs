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

        private void CargarGrilla()
        {
            servicioModelos = new ServicioModelos();

            List<Modelo> modelos = servicioModelos.ObtenerModelos();

            CargadorDeDatos.CargarDataGrid(datosModelos, modelos);

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

            CargadorDeDatos.CargarDatosEnFila(fila, modelo);
        }

        public void AgregarModelo(Modelo modelo)
        {
            DataGridViewRow fila = CargadorDeDatos.CrearFila(datosModelos);

            CargadorDeDatos.CargarDatosEnFila(fila, modelo);

            CargadorDeDatos.CargarFilaEnGrilla(datosModelos, fila);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = Mensajero.MensajeAdvertencia("Advertencia.. esta por eliminar un dato", "Cuidado.. operacion con riesgo.");

            if (opcion == DialogResult.OK)
            {
                if(datosModelos.SelectedRows.Count > 0)
                {
                    Modelo modelo = (Modelo)datosModelos.SelectedRows[0].Tag;

                    try
                    {
                        servicioModelos.EliminarModelo(modelo);

                        datosModelos.Rows.Remove(datosModelos.SelectedRows[0]);

                        Mensajero.MensajeExitoso("Eliminacion exitosa.");
                    }
                    catch (Exception)
                    {
                        Mensajero.MensajeError("No se ha podido eliminar el modelo ya que hay vehiculos abonados asociados.");
                    }
                }
            }
        }
    }
}
