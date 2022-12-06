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
using Cochera.Windows.Utilidades;
using Cochera.Servicios;

namespace Cochera.Windows
{
    public partial class frmTarifasEdicion : Form
    {

        //------------ATRIBUTOS------------//

        private TarifaPorVehiculo tarifaPorVehiculo;
        private frmTarifas formTarifas;
        private ServicioTarifasPorVehiculo servicioTarifasPorVehiculo;


        //------------CONSTRUCTOR------------//
        public frmTarifasEdicion(frmTarifas frmTarifas, TarifaPorVehiculo tarifaPorVehiculo)
        {
            InitializeComponent();

            formTarifas = frmTarifas;

            this.tarifaPorVehiculo = tarifaPorVehiculo;

            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();

            LimpiarTextos();

            InicializarTextos();
        }



        //------------METODOS------------//


        //----PRIVADOS----//

        private void InicializarTextos()
        {
            txtTipoVehiculo.Text = tarifaPorVehiculo.ObtenerTipo();
            txtTipoVehiculo.Enabled = false;
            
            txtTiempo.Text = tarifaPorVehiculo.ObtenerTarifa();
            txtTiempo.Enabled = false;

            txtMonto.Text = tarifaPorVehiculo.ObtenerMonto().ToString();
        }

        private void LimpiarTextos()
        {
            txtTipoVehiculo.Clear();
            txtTiempo.Clear();
            txtMonto.Clear();
        }


        //----PUBLICOS----//

        //------------EVENTOS------------//

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mostradorDeErrores.Clear();

            if (Validador.InputMayorACero(txtMonto.Text))
            {
                tarifaPorVehiculo.ActualizarMonto(Convert.ToDecimal(txtMonto.Text));

                servicioTarifasPorVehiculo.ActualizarTarifa(tarifaPorVehiculo);

                formTarifas.ActualizarTarifaPorVehiculo(tarifaPorVehiculo);

                formTarifas.ActivarBotones();

                this.Close();
            }
            else
            {
                mostradorDeErrores.SetError(txtMonto, "El monto debe ser mayor a cero.");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloNumerosPositivos(e.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formTarifas.ActivarBotones();
            this.Close();
        }
    }
}
