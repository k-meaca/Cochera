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
using Cochera.Windows.Interfaces;


namespace Cochera.Windows
{
    public partial class frmClientes : Form, IAgregadorClientes
    {
        //------------ATRIBUTOS------------//

        frmPrincipal formPrincipal;
        ServicioClientes servicioClientes;


        //------------CONSTRUCTOR------------//
        public frmClientes(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            servicioClientes = new ServicioClientes();

            datosClientes.Rows.Clear();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarGrilla()
        {
            List<Cliente> clientes = servicioClientes.ObtenerClientes();

            CargadorDeDatos.CargarDataGrid(datosClientes, clientes);
        }

        private string MensajeEliminacionError(Cliente cliente)
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("No se ha podido eliminar al cliente:");
            mensaje.AppendLine($"Nombre: {cliente.NombreCompleto()}");
            mensaje.AppendLine($"Nro. doc: {cliente.ObtenerNumeroDoc()}");
            mensaje.AppendLine("Primero debe eliminar su cuenta asociada y sus vehiculos asociados.");

            return mensaje.ToString();
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

            DialogResult opcion = Mensajero.MensajeAdvertencia("Advertencia.. esta por eliminar un cliente", "Cuidad.. operacion con riesgo.");

            if(opcion == DialogResult.OK)
            {
                if (datosClientes.SelectedRows.Count > 0)
                {
                    Cliente cliente = (Cliente)datosClientes.SelectedRows[0].Tag;
                    try
                    {
                        servicioClientes.EliminarCliente(cliente);

                        datosClientes.Rows.Remove(datosClientes.SelectedRows[0]);

                        Mensajero.MensajeExitoso("La eliminacion ha sido exitosa.");
                    }
                    catch (Exception)
                    {
                        Mensajero.MensajeError(MensajeEliminacionError(cliente));
                    }
                }
            }

        }
    }
}
