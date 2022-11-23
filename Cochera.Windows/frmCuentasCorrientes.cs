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

        private void CargarGrilla() 
        {
            List<CuentaCorriente> ctasCtes = servicioCtaCtes.ObtenerCuentasCorrientes();
            CargadorDeDatos.CargarDataGrid(datosCtasCtes, ctasCtes);
        }
    }
}
