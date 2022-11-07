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
using Cochera.Windows.Interfaces;
using Cochera.Windows.Clases;
using Cochera.Servicios;
using Cochera.Entidades.Interfaces;


namespace Cochera.Windows
{
    public partial class frmDarSalida : Form
    {
        //------------ATRIBUTOS------------//

        private IIngreso ingreso;
        private IGeneradorSalidas generadorSalidas;
        private ServicioTarifasPorVehiculo servicioTarifasPorVehiculo;
        private ServicioSalidas servicioSalidas;
        private ServicioAbonados servicioAbonados;

        private List<Tarifa> tarifasIngreso;
        private decimal montoTotal;

        //------------CONSTRUCTOR------------//
        public frmDarSalida(IIngreso ingreso, IGeneradorSalidas generadorSalidas)
        {
            InitializeComponent();
            this.ingreso = ingreso;
            this.generadorSalidas = generadorSalidas;
            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();
            servicioSalidas = new ServicioSalidas();
            servicioAbonados = new ServicioAbonados();

            SetearComponentes();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CalcularTarifa()
        {
            Parkimetro parkimetro = new Parkimetro();
            List<Tarifa> tarifasIngreso = parkimetro.CalcularTarifa((Ingreso)ingreso);

            montoTotal = servicioTarifasPorVehiculo.ObtenerMontoParaTarifas(ingreso.ObtenerTipoVehiculoId(), tarifasIngreso);

            txtTarifa.Text = montoTotal.ToString("C");

        }

        private void CargarDatos()
        {
            txtVehiculo.Text = ingreso.ObtenerTipoVehiculo();
            txtPatente.Text = ingreso.ObtenerPatente();
            txtUbicacion.Text = ingreso.ObtenerUbicacion();
            txtIngreso.Text = ingreso.ObtenerFechaIngreso().ToString();

        }

        private void CargarDatosAbonado()
        {
            Abonado abonado = (Abonado)ingreso;

            txtModelo.Text = abonado.ObtenerModelo();
            txtMarca.Text = abonado.ObtenerMarca();
            txtCliente.Text = abonado.NombreCompletoCliente();
            txtExpiracion.Text = abonado.FechaExpiracion.ToShortDateString();
            txtTarifa.Text = abonado.ObtenerImporte().ToString("C");
        }

        private string DatosVehiculo()
        {
            StringBuilder datos = new StringBuilder();
            
            datos.AppendLine($"Vehiculo: {ingreso.ObtenerTipoVehiculo()}");
            datos.AppendLine($"Patente: {ingreso.ObtenerPatente()}");
            datos.AppendLine($"Estacionamiento: {ingreso.ObtenerUbicacion()}");
            datos.Append($"Sector: {ingreso.ObtenerSector()}");

            return datos.ToString();
        }

        private void SetearComponentes()
        {
            if (!ingreso.esAbonado())
            {
                SetearTamanio(253, 361);
                CargarDatos();
                CalcularTarifa();
                CorrectorDeEstados.AnularBoton(btnDarDeBaja);
            }
            else
            {
                SetearTamanio(516, 361);
                CargarDatos();
                CargarDatosAbonado();
                CorrectorDeEstados.AnularBoton(btnDarSalida);
            }
        }

        private void SetearTamanio(int ancho, int alto)
        {
            Size tamanio = new Size(ancho, alto);

            this.Size = tamanio;
        }

        //------------EVENTOS------------//
        private void frmDarSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            generadorSalidas.ActivarBotones();
        }

        //----IMAGEN SALIR----//

        #region

        private void imgSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgSalir_MouseEnter(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Silver;
        }

        private void imgSalir_MouseLeave(object sender, EventArgs e)
        {
            imgSalir.BackColor = Color.Transparent;
        }

        #endregion

        private void btnDarSalida_Click(object sender, EventArgs e)
        {
            DialogResult opcion = Mensajero.MensajeAdvertencia($"Desea dar salida a: \n{DatosVehiculo()}?", "Cuidado, esta por dar una salida.");
        
            if(opcion == DialogResult.OK)
            {
                try
                {
                    Parkimetro parkimetro = new Parkimetro();
                    tarifasIngreso = parkimetro.CalcularTarifa((Ingreso)ingreso);

                    servicioSalidas.DarSalida((Ingreso)ingreso, DateTime.Now, montoTotal, tarifasIngreso);

                    Mensajero.MensajeExitoso($"Se ha liberado el estacionamiento: \n" +
                        $"Ubicacion: {ingreso.ObtenerUbicacion()}\n" +
                        $"Sector: {ingreso.ObtenerSector()}");
                    
                    generadorSalidas.DesocuparEstacionamiento();

                    Close();
                }
                catch (Exception)
                {
                    Mensajero.MensajeError($"No se ha podido dar la salida de: \n{DatosVehiculo()}");
                }
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            DialogResult opcion = Mensajero.MensajeAdvertencia("¿Desea dar de baja este abonado?", "Cuidado.. operacion riesgosa");

            if(opcion == DialogResult.OK)
            {
                try
                {
                    servicioAbonados.DarBaja((Abonado)ingreso);

                    Mensajero.MensajeExitoso($"Se ha liberado el estacionamiento: \n" +
                    $"Ubicacion: {ingreso.ObtenerUbicacion()}\n" +
                    $"Sector: {ingreso.ObtenerSector()}");

                    generadorSalidas.DesocuparEstacionamiento();

                    Close();
                }
                catch (Exception)
                {
                    Mensajero.MensajeError("No se ha podido dar de baja al abonado.");
                }
            }
        }
    }
}
