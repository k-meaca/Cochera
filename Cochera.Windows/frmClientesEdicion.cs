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
    public partial class frmClientesEdicion : Form
    {
        //------------ATRIBUTOS------------//

        frmClientes formClientes;
        Cliente clienteEdicion;
        ServicioTiposDeDocumentos servicioTipoDocs;
        ServicioClientes servicioClientes;
        ServicioPersonas servicioPersonas;

        //------------CONSTRUCTOR------------//
        public frmClientesEdicion(frmClientes formClientes)
        {
            InitializeComponent();

            this.formClientes = formClientes;

            ModoAgregar();
            LimpiarInputs();
            SetearComboBox();
        }

        public frmClientesEdicion(frmClientes formClientes, Cliente cliente)
        {
            InitializeComponent();

            this.formClientes = formClientes;
            clienteEdicion = cliente;

            ModoEditar();
            LimpiarInputs();
            SetearComboBox();
            SetearComponentes();

        }

        //------------METODOS------------//

        //----PRIVADOS----//

        #region

        private bool CamposCompletados()
        {
            bool completados = true;
            mostradorDeErrores.Clear();

            List<TextBox> inputs = new List<TextBox>()
            {
                txtNombre,
                txtApellido,
                txtNumeroDoc,
                txtTelefono
            };

            foreach(TextBox txtBox in inputs)
            {
                if (!Validador.InputConTexto(txtBox.Text))
                {
                    completados = false;
                    mostradorDeErrores.SetError(txtBox, "Debe llenar este campo.");
                }
            }

            return completados;
        }
        private void LimpiarInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDoc.Clear();
            txtTelefono.Clear();
        }

        private void ModoAgregar()
        {
            lblTitulo.Text = "AGREGAR CLIENTE";

            CorrectorDeEstados.ActivarBoton(btnAgregar);
            CorrectorDeEstados.AnularBoton(btnEditar);
        }

        private void ModoEditar()
        {
            lblTitulo.Text = "EDITAR CLIENTE";

            CorrectorDeEstados.ActivarBoton(btnEditar);
            CorrectorDeEstados.AnularBoton(btnAgregar);
        }

        private void SetearComboBox()
        {
            servicioTipoDocs = new ServicioTiposDeDocumentos();
            CargadorDeDatos.SetearComboBox<Documento>(cmboxTipoDocs, servicioTipoDocs.ObtenerTiposDeDocumentos());
        }

        private Documento ObtenerDocumento()
        {
            List<Documento> documentos = (List<Documento>)cmboxTipoDocs.Tag;
            Documento doc = (Documento)documentos.Find(d => d.TipoDoc == cmboxTipoDocs.SelectedItem.ToString()).Clone();
            doc.EstablecerNumeroDeDoc(txtNumeroDoc.Text);

            return doc;
        }

        private void SetearComponentes()
        {
            txtNombre.Text = clienteEdicion.Nombre;
            txtApellido.Text = clienteEdicion.Apellido;
            txtNumeroDoc.Text = clienteEdicion.ObtenerNumeroDoc();
            txtTelefono.Text = clienteEdicion.Telefono;

            cmboxTipoDocs.SelectedItem = clienteEdicion.ObtenerTipoDoc();
        }

        #endregion

        //----PUBLICOS----//

        //------------EVENTOS------------//

        //----TEXT BOX----//

        #region
        private void txtSoloTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloTexto(e.KeyChar);
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.NumerosYLetras(e.KeyChar);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloNumerosPositivos(e.KeyChar);
        }

        #endregion

        //----FORMULARIO----//

        #region
        private void frmClientesEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClientes.ActivarBotones();
        }

        #endregion

        //----BOTONES----//

        #region
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CamposCompletados())
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;

                Documento doc = ObtenerDocumento();

                servicioClientes = new ServicioClientes();

                Cliente cliente = servicioClientes.AgregarCliente(nombre, apellido, doc, telefono);

                formClientes.AgregarCliente(cliente);

                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (CamposCompletados())
            {

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;

                Documento doc = ObtenerDocumento();

                clienteEdicion.ActualizarDatos(nombre, apellido, doc, telefono);

                servicioPersonas = new ServicioPersonas();

                servicioPersonas.ActualizarPersona(clienteEdicion);

                formClientes.ActualizarCliente(clienteEdicion);

                this.Close();
            }
        }

        #endregion
    }
}
