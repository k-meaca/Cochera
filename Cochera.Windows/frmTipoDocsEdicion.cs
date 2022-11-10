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
using Cochera.Entidades;
using Cochera.Servicios;

namespace Cochera.Windows
{
    public partial class frmTipoDocsEdicion : Form
    {
        //------------ATRIBUTOS------------//

        frmDocumentos formDocumentos;
        Documento docEdicion;
        ServicioTiposDeDocumentos servicioTipoDocs;

        //------------CONSTRUCTORES------------//
        public frmTipoDocsEdicion(frmDocumentos formDocumentos)
        {
            InitializeComponent();

            this.formDocumentos = formDocumentos;

            ModoAgregar();
        }

        public frmTipoDocsEdicion(frmDocumentos formDocumentos, Documento documento)
        {
            InitializeComponent();

            this.formDocumentos = formDocumentos;
            docEdicion = documento;

            ModoEditar();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void ModoAgregar()
        {
            lblTitulo.Text = "AGREGAR DOCUMENTO";

            CorrectorDeEstados.ActivarBoton(btnAgregar);
            CorrectorDeEstados.AnularBoton(btnEditar);
        }

        private void ModoEditar()
        {
            lblTitulo.Text = "EDITAR DOCUMENTO";


            CorrectorDeEstados.ActivarBoton(btnEditar);
            CorrectorDeEstados.AnularBoton(btnAgregar);

            txtTipoDoc.Text = docEdicion.TipoDoc;

        }
        private bool ValidarDato()
        {
            mostradorDeErrores.Clear();

            if (!Validador.InputConTexto(txtTipoDoc.Text))
            {
                mostradorDeErrores.SetError(txtTipoDoc, "Debe llenar este campo.");
                return false;
            }
            return true;
        }

        //------------EVENTOS------------//


        private void txtTipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloTexto(e.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTipoDocsEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formDocumentos.ActivarBotones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {
                docEdicion.ActualizarTipo(txtTipoDoc.Text);

                servicioTipoDocs = new ServicioTiposDeDocumentos();

                servicioTipoDocs.ActualizarTipoDeDocumento(docEdicion);

                formDocumentos.ActualizarDocumento(docEdicion);

                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {

                string tipoDoc = txtTipoDoc.Text;

                servicioTipoDocs = new ServicioTiposDeDocumentos();

                Documento doc = servicioTipoDocs.AgregarTipoDeDocumento(tipoDoc);

                formDocumentos.AgregarDocumento(doc);

                Close();
            }
        }
    }
}
