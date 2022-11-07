using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cochera.Servicios;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;
using Cochera.Windows.Utilidades;
using Cochera.Windows.Interfaces;
using Cochera.Windows.Clases;

namespace Cochera.Windows
{
    public partial class frmIngresosEdicion : Form, IAgregadorClientes
    {

        //------------ATRIBUTOS------------//

        #region

        private ServicioTiposDeVehiculos servicioTipos;
        private ServicioTarifasPorVehiculo servicioTarifasPorVehiculo;
        private ServicioClientes servicioClientes;
        private ServicioTarifas servicioTarifas;
        private ServicioModelos servicioModelos;
        private ServicioMarcas servicioMarcas;
        private ServicioIngresos servicioIngresos;
        private ServicioAbonados servicioAbonados;
        private ServicioCuentasCorrientes servicioCuentasCtes;

        private Estacionamiento estacionamiento;
        private IGeneradorIngresos generadorIngresos;

        private IIngreso ingreso;
        #endregion

        //------------CONSTRUCTOR------------//
        public frmIngresosEdicion(Estacionamiento estacionamiento, IGeneradorIngresos generadorIngresos)
        {
            InitializeComponent();

            servicioTarifas = new ServicioTarifas();
            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();
            servicioTipos = new ServicioTiposDeVehiculos();
            servicioClientes = new ServicioClientes();
            servicioModelos = new ServicioModelos();
            servicioMarcas = new ServicioMarcas();
            servicioIngresos = new ServicioIngresos();
            servicioAbonados = new ServicioAbonados();
            servicioCuentasCtes = new ServicioCuentasCorrientes();

            this.estacionamiento = estacionamiento;
            this.generadorIngresos = generadorIngresos;

            SetearComponentes();
  
            SetearTamanio(213, 464);

            CorrectorDeEstados.AnularBoton(btnEditar);
            CorrectorDeEstados.ActivarBoton(btnEstacionar);
        }


        public frmIngresosEdicion(Estacionamiento estacionamiento, IIngreso ingreso, IGeneradorIngresos generadorIngresos) :
            this(estacionamiento, generadorIngresos)
        {
            this.ingreso = ingreso;

            ModoEdicion();

        }
        //------------METODOS------------//

        //----PRIVADOS----//


        //--CALCULOS--//

        #region
        private DateTime CalcularFechaExpiracion()
        {
            List<Tarifa> tarifas = (List<Tarifa>)cmboxTarifa.Tag;

            Tarifa tarifa = tarifas.Find(t => t.Tiempo == (string)cmboxTarifa.SelectedItem);

            Parkimetro parkimetro = new Parkimetro();

            return parkimetro.CalcularFechaExpiracion(tarifa);
        }

        private decimal CalcularPrecio()
        {

            List<TipoDeVehiculo> tipos = (List<TipoDeVehiculo>)cmboxTipoVehiculo.Tag;

            TipoDeVehiculo tipo = tipos.Find(t => t.Tipo == (string)cmboxTipoVehiculo.SelectedItem);

            List<Tarifa> tarifas = (List<Tarifa>)cmboxTarifa.Tag;

            Tarifa tarifa = tarifas.Find(t => t.Tiempo == (string)cmboxTarifa.SelectedItem);

            return servicioTarifasPorVehiculo.ObtenerPrecio(tipo, tarifa);
        }

        #endregion

        //--ALMACENAMIENTO--//

        #region

        private void ActualizarSector(TipoDeVehiculo tipo, IIngreso ingreso)
        {
            generadorIngresos.EstacionamientoOcupado(tipo, ingreso);

            generadorIngresos.ActualizarLugares(tipo);
        }

        private void EditarVehiculo()
        {
            try
            {
                ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime fechaIngreso);

                ((Ingreso)ingreso).ActualizarIngreso(tipo, patente,fechaIngreso);

                servicioIngresos.ActualizarIngreso((Ingreso)ingreso);

                ActualizarSector(tipo, ingreso);

                Close();
            }
            catch (Exception)
            {
                Mensajero.MensajeError("No ha sido posible actualizar este ingreso.");
            }
        }

        private void EstacionarVehiculo()
        {
            try
            {

                ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime fechaIngreso);

                ingreso = servicioIngresos.GenerarIngreso(patente, tipo, fechaIngreso, estacionamiento);
                
                ActualizarSector(tipo, ingreso);

                Close();
            }
            catch (SqlException)
            {
                Mensajero.MensajeError("Hubo problemas con el servidor.");
            }
            catch (Exception)
            {
                Mensajero.MensajeError("Ocurrio algo inesperado.");
            }
        }

        private void EstacionarVehiculoAbonado()
        {
            try
            {

                ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime fechaIngreso);

                ObtenerDatosDeAbonado(out Modelo modelo, out Marca marca, out Tarifa tarifa, out DateTime fechaExpiracion, out Cliente cliente);

                decimal importe = CalcularPrecio();

                CuentaCorriente cuenta = servicioCuentasCtes.ObtenerCuentaCorriente(cliente);

                Abonado abonado = servicioAbonados.GenerarAbonado(tipo, patente, fechaIngreso, estacionamiento, modelo, tarifa, fechaExpiracion, cliente, cuenta, importe);

                ActualizarSector(tipo, abonado);

                Close();

            }
            catch (SqlException)
            {
                Mensajero.MensajeError("Hubo problemas con el servidor.");
            }
            catch (Exception)
            { 
                Mensajero.MensajeError("Ocurrio algo inesperado.");
            }
        }

        private void ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime ingreso)
        {
            List<TipoDeVehiculo> tipos = (List<TipoDeVehiculo>)cmboxTipoVehiculo.Tag;

            tipo = tipos.Find(t => t.Tipo == cmboxTipoVehiculo.SelectedItem.ToString());

            patente = txtPatente.Text;

            ingreso = Convert.ToDateTime(txtIngreso.Text);
        }

        private void ObtenerDatosDeAbonado(out Modelo modelo, out Marca marca, out Tarifa tarifa, out DateTime fechaExpiracion, out Cliente cliente)
        {
            List<Modelo> modelos = (List<Modelo>)cmboxModelo.Tag;

            modelo = modelos.Find(m => m.Nombre == cmboxModelo.SelectedItem.ToString());

            marca = servicioMarcas.ObtenerMarca(modelo.ObtenerMarcaId());

            List<Tarifa> tarifas = (List<Tarifa>)cmboxTarifa.Tag;

            tarifa = tarifas.Find(t => t.Tiempo == cmboxTarifa.SelectedItem.ToString());

            Parkimetro parkimetro = new Parkimetro();

            fechaExpiracion = parkimetro.CalcularFechaExpiracion(tarifa);

            cliente = (Cliente)datosClientes.SelectedRows[0].Tag;
        }

        #endregion

        //--SETS--//

        #region

        private void ModoEdicion()
        {
            CorrectorDeEstados.AnularCheck(checkAbonar);
            CorrectorDeEstados.AnularBoton(btnEstacionar);
            CorrectorDeEstados.ActivarBoton(btnEditar);

            cmboxTipoVehiculo.SelectedItem = ingreso.ObtenerTipoVehiculo();
            txtPatente.Text = ingreso.ObtenerPatente();
            txtEstacionamiento.Text = estacionamiento.Ubicacion;
            txtIngreso.Text = ingreso.ObtenerFechaIngreso().ToString();
        }

        private void SetearClientes()
        {
            List<Cliente> clientes = servicioClientes.ObtenerClientes();

            CargadorDeDatos.CargarDataGridReducido(datosClientes, clientes);
        }

        private void SetearComponentes()
        {

            List<TipoDeVehiculo> tipos = servicioTipos.ObtenerTiposDeVehiculo();

            tipos = tipos.FindAll(t => generadorIngresos.PuedeEstacionarVehiculo(t));

            CargadorDeDatos.SetearComboBox<TipoDeVehiculo>(cmboxTipoVehiculo, tipos);

            txtEstacionamiento.Text = generadorIngresos.ObtenerUbicacion();

            txtIngreso.Text = DateTime.Now.ToString();

            checkAbonar.Checked = false;

            txtPatente.Focus();
        }

        private void SetearModelos()
        {
            try
            {
                cmboxModelo.Items.Clear();

                List<TipoDeVehiculo> tipos = (List<TipoDeVehiculo>)cmboxTipoVehiculo.Tag;

                TipoDeVehiculo tipo = tipos.Find(t => t.Tipo == cmboxTipoVehiculo.SelectedItem.ToString());

                List<Modelo> modelos = servicioModelos.ObtenerModelos(tipo);

                CargadorDeDatos.SetearComboBox<Modelo>(cmboxModelo, modelos);
            }
            catch (Exception)
            {
                Mensajero.MensajeError("No hay modelos para ese tipo de vehiculo.");

                cmboxModelo.Items.Clear();
                cmboxModelo.SelectedItem = String.Empty;

                txtMarca.Clear();
            }
        }

        private void SetearMarca() 
        {

            List<Modelo> modelos = (List<Modelo>)cmboxModelo.Tag;

            Modelo modelo = modelos.Find(m => m.Nombre == cmboxModelo.SelectedItem.ToString());


            Marca marca = servicioMarcas.ObtenerMarca(modelo.ObtenerMarcaId());

            txtMarca.Text = marca.Nombre;
        }

        private void SetearTarifa()
        {
            List<Tarifa> tarifas = servicioTarifas.ObtenerTarifasAbonados();

            CargadorDeDatos.SetearComboBox<Tarifa>(cmboxTarifa, tarifas);
        }

        private void SetearTamanio(int ancho, int largo) 
        {
            Size tamanio = new Size(ancho, largo);
            this.Size = tamanio;
            this.CenterToScreen();
        }

        #endregion

        //--VALIDACION--//

        #region
        private bool ValidarDatos()
        {

            mostradorErrores.Clear();

            bool patenteValida = ValidarPatente();

            bool marcaValida = true;

            bool clienteValido = true;

            if (checkAbonar.Checked)
            {
                marcaValida = ValidarMarca();
                clienteValido = ValidarCliente();
            }

            return patenteValida && marcaValida && clienteValido;
        }

        private bool ValidarPatente()
        {
            bool valido = Validador.InputConTexto(txtPatente.Text);

            if (!valido)
            {
                mostradorErrores.SetError(txtPatente, "Debe ingresar una patente.");
            }

            return valido;
        }

        private bool ValidarMarca()
        {
            bool valido = Validador.InputConTexto(txtMarca.Text);

            if (!valido)
            {
                mostradorErrores.SetError(txtMarca,"No es posible generar un abonado sin un modelo y sin una marca.");
            }

            return valido;
        }

        private bool ValidarCliente()
        {
            if(datosClientes.SelectedRows.Count == 0) 
            {
                mostradorErrores.SetError(datosClientes, "Debe haber por lo menos un cliente.");
                return false;
            }

            return true;
        }

        #endregion

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            this.Enabled = true;
        }

        public void AgregarCliente(Cliente cliente)
        {
            DataGridViewRow fila = CargadorDeDatos.CrearFila(datosClientes);
            CargadorDeDatos.CargarDatosEnFilaReducida(fila, cliente);
            CargadorDeDatos.CargarFilaEnGrilla(datosClientes, fila);
        }

        public void ActualizarCliente(Cliente cliente)
        {

        }

        //------------EVENTOS------------//

        //----COMBO BOX----//

        #region
        private void cmboxTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkAbonar.Checked)
            {
                txtPrecio.Text = CalcularPrecio().ToString("C");
                SetearModelos();
            }

        }

        private void cmboxTarifa_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = CalcularPrecio().ToString("C");
            txtExpiracion.Text = CalcularFechaExpiracion().ToString();
        }

        private void cmboxModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            SetearMarca();
        }

        #endregion

        //----CHECK BOX----//

        private void checkAbonar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAbonar.Checked)
            {
                SetearModelos();
                SetearTarifa();
                SetearClientes();
                SetearTamanio(731, 464);
                CalcularFechaExpiracion();
            }
            else
            {
                SetearTamanio(213, 464);
                cmboxModelo.Items.Clear();
                cmboxTarifa.Items.Clear();
                datosClientes.Rows.Clear();
                txtMarca.Clear();
                txtExpiracion.Clear();
            }
        }

        //----BOTONES----//

        #region
        private void btnEstacionar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (Validador.ValidarIngreso(txtPatente.Text))
                {
                    if (checkAbonar.Checked)
                    {
                        EstacionarVehiculoAbonado();
                    }
                    else
                    {
                        EstacionarVehiculo();
                    }
                }
                else
                {
                    Mensajero.MensajeError("Esa patente se ya se encuentra en la cochera.");
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Validador.ValidarIngreso(txtPatente.Text))
                {
                    {
                        EditarVehiculo();
                    }
                }
                else
                {
                    Mensajero.MensajeError("Esa patente se ya se encuentra en la cochera.");
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientesEdicion frmAgregarCliente = new frmClientesEdicion(this);

                this.Enabled = false;

                frmAgregarCliente.Show();

            }
            catch (Exception)
            {
                Mensajero.MensajeError("No ha sido posible agregar un cliente.");
            }
        }

        #endregion

        //----TEXT BOX----//

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validador.NumerosYLetras(e.KeyChar))
            {
                e.Handled = false;
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.Handled = true;
            }

        }


        //----FORMULARIO----//

        private void frmIngresosEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            generadorIngresos.ActivarBotones();
        }
    }
}
