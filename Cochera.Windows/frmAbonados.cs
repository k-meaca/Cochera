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
    public partial class frmAbonados : Form
    {
        //------------ATRIBUTOS------------//

        private frmPrincipal formPrincipal;
        private ServicioAbonados servicioAbonados;
        public frmAbonados(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            servicioAbonados = new ServicioAbonados();

            this.formPrincipal = formPrincipal;

            CargarGrilla();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarGrilla()
        {
            List<Abonado> abonados = servicioAbonados.ObtenerAbonados().Where(a => !a.Baja).ToList();
            CargadorDeDatos.CargarDataGrid(datosAbonados, abonados);
        }

        //----PUBLICOS----//

        //------------EVENTOS------------//
    }
}
