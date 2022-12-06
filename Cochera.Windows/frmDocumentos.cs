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
    public partial class frmDocumentos : Form
    {
        frmPrincipal formPrincipal;
        ServicioTiposDeDocumentos serviciosTipoDocumentos;
        public frmDocumentos(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            serviciosTipoDocumentos = new ServicioTiposDeDocumentos();
        }


        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarFilaEnGrilla(DataGridViewRow fila)
        {
            datosDocumentos.Rows.Add(fila);
        }
        private void CargarGrilla()
        {
            List<Documento> documentos = serviciosTipoDocumentos.ObtenerTiposDeDocumentos();

            CargadorDeDatos.CargarDataGrid(datosDocumentos, documentos);
        }



        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void ActualizarDocumento(Documento doc)
        {
            DataGridViewRow fila = datosDocumentos.SelectedRows[0];

            CargadorDeDatos.CargarDatosEnFila(fila, doc);
        }

        public void AgregarDocumento(Documento doc)
        {
            DataGridViewRow fila = CargadorDeDatos.CrearFila(datosDocumentos);

            CargadorDeDatos.CargarDatosEnFila(fila, doc);

            CargadorDeDatos.CargarFilaEnGrilla(datosDocumentos,fila);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }

        //------------EVENTOS------------//


        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoDocsEdicion frmAgregarDoc = new frmTipoDocsEdicion(this);

            AnularBotones();

            frmAgregarDoc.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(datosDocumentos.SelectedRows.Count > 0)
            {
                frmTipoDocsEdicion frmEditarDoc = new frmTipoDocsEdicion(this, (Documento)datosDocumentos.SelectedRows[0].Tag);

                AnularBotones();

                frmEditarDoc.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(datosDocumentos.SelectedRows.Count > 0)
            {
                Documento doc = (Documento)datosDocumentos.SelectedRows[0].Tag;

                DialogResult opcion = Mensajero.MensajeAdvertencia("Esta por eliminar un dato.", "Cuidado.. operacion con riesgo.");

                if(opcion == DialogResult.OK)
                {
                    try
                    {
                        serviciosTipoDocumentos.EliminarDocumento(doc);

                        datosDocumentos.Rows.Remove(datosDocumentos.SelectedRows[0]);

                        Mensajero.MensajeExitoso($"Se elimino correctamente el tipo de documento: {doc.TipoDoc}, con todos sus datos asociados.");
                    }
                    catch (Exception)
                    {
                        Mensajero.MensajeError($"No se ha podido eliminar el documento: {doc.TipoDoc}. Elimine primero sus clientes asociados.");
                    }
                }
            }
        }
    }
}
