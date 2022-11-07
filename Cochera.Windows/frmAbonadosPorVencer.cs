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
using Cochera.Windows.Clases;

namespace Cochera.Windows
{
    public partial class frmAbonadosPorVencer : Form
    {
        //------------ATRIBUTOS------------//

        private frmPrincipal formPrincipal;

        private ServicioAbonados servicioAbonados;
        private ServicioIngresos servicioIngresos;

        private List<Abonado> abonados;

        //------------CONSTRUCTOR------------//
        public frmAbonadosPorVencer(frmPrincipal formPrincipal, List<Abonado> abonados)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            this.formPrincipal.Enabled = false;

            servicioAbonados = new ServicioAbonados();

            this.abonados = abonados;

            CargarGrilla();
        }

        //------------METODOS------------//

        //----PRIVADOS----//



        private void CargarGrilla()
        {
            abonados = servicioAbonados.ObtenerAbonados().Where(a => !a.Baja).ToList();
            CargadorDeDatos.CargarDataGrid(datosAbonados, abonados);
        }




        //------------EVENTOS------------//

        //--IMAGEN SALIR--//

        #region
        private void imgSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void imgSalir_MouseEnter(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.White;
        }

        private void imgSalir_MouseLeave(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Transparent;
        }

        #endregion

        //--FORMULARIO--//
        private void frmAbonadosPorVencer_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.Enabled = true;
            formPrincipal.ActivarBotones();
        }

        //--BOTONES--//

        #region
        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            if(datosAbonados.SelectedRows.Count > 0)
            {
                DialogResult opcion = Mensajero.MensajeAdvertencia("¿Desea dar de baja este abonado?","Cuidado.. operacion riesgosa");
               
                if(opcion == DialogResult.OK)
                {
                    try
                    {
                        Abonado abonado = (Abonado)datosAbonados.SelectedRows[0].Tag;

                        servicioAbonados.DarBaja(abonado);

                        datosAbonados.Rows.Remove(datosAbonados.SelectedRows[0]);

                        Mensajero.MensajeExitoso("Dado de baja con exito.");
                    }
                    catch (Exception)
                    {
                        Mensajero.MensajeError("No se pudo dar de baja el abonado.");
                    }
                }
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (datosAbonados.SelectedRows.Count > 0)
            {
                try
                {
                    Abonado abonado = (Abonado)datosAbonados.SelectedRows[0].Tag;
                }
                catch (Exception)
                {
                    Mensajero.MensajeError("No se pudo renovar el abonado.");
                }
            }
        }

        #endregion
    }
}
