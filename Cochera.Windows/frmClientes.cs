﻿using System;
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
    public partial class frmClientes : Form
    {
        //------------ATRIBUTOS------------//

        frmPrincipal formPrincipal;
        ServicioClientes servicio;


        //------------CONSTRUCTOR------------//
        public frmClientes(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicio = new ServicioClientes();

            datosClientes.Rows.Clear();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarGrilla()
        {
            List<Cliente> clientes = servicio.ObtenerClientes();

            CargadorDeDatos.CargarDataGrid(datosClientes, clientes);
        }

        //----PUBLICOS----//

        public void ActualizarCliente(Cliente cliente)
        {
            DataGridViewRow fila = datosClientes.SelectedRows[0];

            CargadorDeDatos.CargarDatosEnFila(fila, cliente);
        }

        public void AgregarCliente(Cliente cliente)
        {
            DataGridViewRow fila = CargadorDeDatos.CrearFila(datosClientes);

            CargadorDeDatos.CargarDatosEnFila(fila, cliente);

            CargadorDeDatos.CargarFilaEnGrilla(datosClientes, fila);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);

            formPrincipal.AnularBotones();
        }

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);

            formPrincipal.ActivarBotones();
        }

        //------------EVENTOS------------//
        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmClientesEdicion frmAgregar = new frmClientesEdicion(this);

            AnularBotones();

            frmAgregar.Show();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if(datosClientes.SelectedRows.Count > 0)
            {
                frmClientesEdicion frmEditar = new frmClientesEdicion(this, (Cliente)datosClientes.SelectedRows[0].Tag);

                AnularBotones();

                frmEditar.Show();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
