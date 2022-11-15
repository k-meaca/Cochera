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
    public partial class frmTarifas : Form
    {

        //------------ATRIBUTOS------------//

        ServicioTarifasPorVehiculo servicioTarifasPorVehiculo;

        frmPrincipal formPrincipal;

        //------------CONSTRUCTOR------------//
        public frmTarifas(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();

            datosTarifas.Rows.Clear();

        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarGrilla()
        {
            List<TarifaPorVehiculo> datos = servicioTarifasPorVehiculo.ObtenerTarifasPorVehiculo();

            foreach(TarifaPorVehiculo dato in datos)
            {
                DataGridViewRow fila = new DataGridViewRow();
                
                fila.CreateCells(datosTarifas);

                fila.Cells[colTipoDeVehiculo.Index].Value = dato.ObtenerTipo();
                fila.Cells[colTiempo.Index].Value = dato.ObtenerTarifa();
                fila.Cells[colTarifa.Index].Value = dato.ObtenerMonto().ToString("C");

                fila.Tag = dato;

                datosTarifas.Rows.Add(fila);
            }
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void ActualizarTarifaPorVehiculo(TarifaPorVehiculo tarifaPorVehiculo)
        {
            servicioTarifasPorVehiculo.ActualizarTarifa(tarifaPorVehiculo);

            datosTarifas.SelectedRows[0].Cells[colTarifa.Index].Value = tarifaPorVehiculo.ObtenerMonto().ToString("C");

            ActivarBotones();
        }
        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }


        //------------EVENTOS------------//
        private void frmTarifasEdicion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEditarMenu_Click(object sender, EventArgs e)
        {
            if(datosTarifas.SelectedRows.Count > 0)
            {
                AnularBotones();

                TarifaPorVehiculo dato = (TarifaPorVehiculo)datosTarifas.SelectedRows[0].Tag;

                frmTarifasEdicion frmEdicion = new frmTarifasEdicion(this,dato);

                frmEdicion.Show();
            }
        }
    }
}
