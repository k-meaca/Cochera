using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cochera.Entidades;
using Cochera.Servicios;
using Cochera.Windows.Utilidades;

namespace Cochera.Windows
{
    public partial class frmCuentasEdicion : Form
    {
        //------------ATRIBUTOS------------//

        frmCuentasCorrientes formCuentas;
        CuentaCorriente cuentaEdicion;
        ServicioCuentasCorrientes servicioCuentas;
        ServicioMarcasDeTarjetas servicioMarcas;
        ServicioTiposDeTarjetas servicioTipos;


        //------------CONSTRUCTOR------------//
        public frmCuentasEdicion(frmCuentasCorrientes formCuentas, CuentaCorriente cuenta)
        {
            InitializeComponent();

            this.formCuentas = formCuentas;
            this.cuentaEdicion = cuenta;

            servicioCuentas = new ServicioCuentasCorrientes();
            servicioMarcas = new ServicioMarcasDeTarjetas();
            servicioTipos = new ServicioTiposDeTarjetas();

            SetearComponentes();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private bool CamposCompletos()
        {
            bool completados = true;
            mostradorDeErrores.Clear();

            List<TextBox> inputs = new List<TextBox>()
            {
                txtNumTarjeta,
                txtCodSeguridad
            };

            foreach (TextBox txtBox in inputs)
            {
                if (!Validador.InputConTexto(txtBox.Text))
                {
                    completados = false;
                    mostradorDeErrores.SetError(txtBox, "Debe llenar este campo.");
                }
            }

            return completados;
        }

        private void SetearCombos()
        {
            List<MarcaTarjeta> marcas = servicioMarcas.ObtenerMarcasDeTarjetas();
            CargadorDeDatos.SetearComboBox<MarcaTarjeta>(cmboxMarcas, marcas);

            List<TipoDePago> tipos = servicioTipos.ObtenerTiposDeTarjetas();
            CargadorDeDatos.SetearComboBox<TipoDePago>(cmboxTiposTarjetas, tipos);
        }

        private void SetearComponentes()
        {
            txtNumCuenta.Text = cuentaEdicion.CuentaId.ToString();
            txtCliente.Text = cuentaEdicion.NombreCompletoCliente();
            txtDescripcion.Text = cuentaEdicion.Nombre is null ? "" : cuentaEdicion.Nombre;
            txtNumTarjeta.Text = cuentaEdicion.ObtenerNumeroTarjetaDesprotegido();
            txtCodSeguridad.Text = cuentaEdicion.ObtenerCodigoSeguridadTarjeta();

            SetearCombos();

            cmboxMarcas.SelectedItem = cuentaEdicion.ObtenerMarcaTarjeta();
            cmboxTiposTarjetas.SelectedItem = cuentaEdicion.MedioDePago();
        }

        //------------EVENTOS------------//
        private void frmCuentasEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCuentas.ActivarFormulario();
        }

        //----BOTONES----//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())
            {
            }
        }
    }
}
