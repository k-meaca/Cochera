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
    public partial class frmCuentasCorrientes : Form
    {
        //------------ATRIBUTOS------------//
        private ServicioCuentasCorrientes servicioCtaCtes;

        private frmPrincipal formPrincipal;

        public frmCuentasCorrientes(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicioCtaCtes = new ServicioCuentasCorrientes();

            CargarGrilla();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void AnularFormulario()
        {
            this.Enabled = false;
        }

        private void BuscarCliente(string cliente)
        {
            cliente = cliente.ToUpper();

            List<CuentaCorriente> cuentas = servicioCtaCtes.ObtenerCuentasCorrientes();

            datosCtasCtes.Rows.Clear();

            if (!Validador.InputConTexto(cliente))
            {
                CargadorDeDatos.CargarDataGrid(datosCtasCtes, cuentas);
            }
            else
            {
                cuentas = cuentas.FindAll(c => c.NombreCompletoCliente().ToUpper().Contains(cliente));
                CargadorDeDatos.CargarDataGrid(datosCtasCtes, cuentas);
            }
        }

        private void CargarGrilla() 
        {
            List<CuentaCorriente> ctasCtes = servicioCtaCtes.ObtenerCuentasCorrientes();
            CargadorDeDatos.CargarDataGrid(datosCtasCtes, ctasCtes);
        }

        //----PUBLICOS----//

        public void ActivarFormulario()
        {
            this.Enabled = true;
        }

        //------------EVENTOS------------//

        //----BOTONES----//

        private void btnEditarCta_Click(object sender, EventArgs e)
        {
            if(datosCtasCtes.SelectedRows.Count > 1)
            {
                CuentaCorriente cuenta = (CuentaCorriente)datosCtasCtes.SelectedRows[0].Tag;

                frmCuentasEdicion formEditar = new frmCuentasEdicion(this, cuenta);

                AnularFormulario();

                formEditar.Show();
            }
        }

        //----TEXT BOX----//

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloTexto(e.KeyChar);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente(txtBuscarCliente.Text);
        }
    }
}
