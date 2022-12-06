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
<<<<<<< HEAD
using Cochera.Windows.Interfaces;
=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
using Cochera.Entidades;
using Cochera.Servicios;

namespace Cochera.Windows
{
    public partial class frmClientesEdicion : Form
    {
        //------------ATRIBUTOS------------//

<<<<<<< HEAD
        IAgregadorClientes formClientes;
=======
        frmClientes formClientes;
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        Cliente clienteEdicion;
        ServicioTiposDeDocumentos servicioTipoDocs;
        ServicioClientes servicioClientes;
        ServicioPersonas servicioPersonas;
<<<<<<< HEAD
        ServicioMarcasDeTarjetas servicioMarcasTarjetas;
        ServicioTiposDeTarjetas servicioTiposDeTarjetas;

        //------------CONSTRUCTOR------------//
        public frmClientesEdicion(IAgregadorClientes formClientes)
=======

        //------------CONSTRUCTOR------------//
        public frmClientesEdicion(frmClientes formClientes)
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        {
            InitializeComponent();

            this.formClientes = formClientes;

            ModoAgregar();
            LimpiarInputs();
            SetearComboBox();
        }

<<<<<<< HEAD
        public frmClientesEdicion(IAgregadorClientes formClientes, Cliente cliente)
=======
        public frmClientesEdicion(frmClientes formClientes, Cliente cliente)
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
<<<<<<< HEAD
                txtTelefono,
                txtNumTarjeta,
                txtCodSeguridad
=======
                txtTelefono
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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

<<<<<<< HEAD
            SetearTamanio(494, 448);

            CorrectorDeEstados.ActivarComponente(cmboxMarcas);
            CorrectorDeEstados.ActivarComponente(cmboxTiposTarjetas);
            CorrectorDeEstados.ActivarComponente(txtNumTarjeta);
            CorrectorDeEstados.ActivarComponente(txtCodSeguridad);
            

=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
            CorrectorDeEstados.ActivarBoton(btnAgregar);
            CorrectorDeEstados.AnularBoton(btnEditar);
        }

        private void ModoEditar()
        {
            lblTitulo.Text = "EDITAR CLIENTE";

<<<<<<< HEAD
            SetearTamanio(494, 269);

            CorrectorDeEstados.AnularComponente(cmboxMarcas);
            CorrectorDeEstados.AnularComponente(cmboxTiposTarjetas);
            CorrectorDeEstados.AnularComponente(txtNumTarjeta);
            CorrectorDeEstados.AnularComponente(txtCodSeguridad);

=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
            CorrectorDeEstados.ActivarBoton(btnEditar);
            CorrectorDeEstados.AnularBoton(btnAgregar);
        }

        private void SetearComboBox()
        {
            servicioTipoDocs = new ServicioTiposDeDocumentos();
            CargadorDeDatos.SetearComboBox<Documento>(cmboxTipoDocs, servicioTipoDocs.ObtenerTiposDeDocumentos());
<<<<<<< HEAD

            servicioMarcasTarjetas = new ServicioMarcasDeTarjetas();
            CargadorDeDatos.SetearComboBox<MarcaTarjeta>(cmboxMarcas, servicioMarcasTarjetas.ObtenerMarcasDeTarjetas());

            servicioTiposDeTarjetas = new ServicioTiposDeTarjetas();
            CargadorDeDatos.SetearComboBox<TipoDePago>(cmboxTiposTarjetas, servicioTiposDeTarjetas.ObtenerTiposDeTarjetas());
        }

        private void SetearTamanio(int ancho, int alto)
        {
            this.Size = new Size(ancho, alto);
=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
        }

        private Documento ObtenerDocumento()
        {
            List<Documento> documentos = (List<Documento>)cmboxTipoDocs.Tag;
            Documento doc = (Documento)documentos.Find(d => d.TipoDoc == cmboxTipoDocs.SelectedItem.ToString()).Clone();
            doc.EstablecerNumeroDeDoc(txtNumeroDoc.Text);

            return doc;
        }

<<<<<<< HEAD
        private MarcaTarjeta ObtenerMarcaTarjeta()
        {
            List<MarcaTarjeta> marcas = (List<MarcaTarjeta>)cmboxMarcas.Tag;
            MarcaTarjeta marca = (MarcaTarjeta)marcas.Find(d => d.Marca == cmboxMarcas.SelectedItem.ToString());
            return marca;
        }

        private TipoDePago ObtenerTipoDeTarjeta()
        {
            List<TipoDePago> tipos = (List<TipoDePago>)cmboxTiposTarjetas.Tag;
            TipoDePago tipo = (TipoDePago)tipos.Find(t => t.Tipo == cmboxTiposTarjetas.SelectedItem.ToString());
            return tipo;
        }

=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
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
<<<<<<< HEAD
        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloNumerosPositivos(e.KeyChar);
        }

        private void txtCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloNumerosPositivos(e.KeyChar);
        }
=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

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
<<<<<<< HEAD
                MarcaTarjeta marca = ObtenerMarcaTarjeta();
                TipoDePago tipo = ObtenerTipoDeTarjeta();

                string numTarjeta = txtNumTarjeta.Text;
                string codigo = txtCodSeguridad.Text;

                servicioClientes = new ServicioClientes();

                Cliente cliente = servicioClientes.AgregarCliente(nombre, apellido, doc, telefono, marca, tipo, numTarjeta, codigo);
=======

                servicioClientes = new ServicioClientes();

                Cliente cliente = servicioClientes.AgregarCliente(nombre, apellido, doc, telefono);
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983

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
<<<<<<< HEAD


=======
>>>>>>> 4421b39b5a7276f4815f13d40c22d4adb7e67983
    }
}
