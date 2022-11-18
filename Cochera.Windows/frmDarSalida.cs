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
using Cochera.Windows.Clases;
using Cochera.Servicios;


namespace Cochera.Windows
{
    public partial class frmDarSalida : Form
    {
        //------------ATRIBUTOS------------//

        private Ingreso ingreso;
        private UCEstacionamiento uCEstacionamiento;
        private ServicioTarifasPorVehiculo servicioTarifasPorVehiculo;
        private ServicioSalidas servicioSalidas;
        private List<Tarifa> tarifasIngreso;
        private decimal montoTotal;

        //------------CONSTRUCTOR------------//
        public frmDarSalida(Ingreso ingreso, UCEstacionamiento uCEstacionamiento)
        {
            InitializeComponent();
            this.ingreso = ingreso;
            this.uCEstacionamiento = uCEstacionamiento;
            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();
            servicioSalidas = new ServicioSalidas();

            CargarDatos();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void CalcularTarifa()
        {
            Parkimetro parkimetro = new Parkimetro();
            List<Tarifa> tarifasIngreso = parkimetro.CalcularTarifa(ingreso);

            montoTotal = servicioTarifasPorVehiculo.ObtenerMontoParaTarifas(ingreso.ObtenerTipoVehiculoId(), tarifasIngreso);

            txtTarifa.Text = montoTotal.ToString("C");

        }

        private void CargarDatos()
        {
            txtVehiculo.Text = ingreso.ObtenerTipoVehiculo();
            txtPatente.Text = ingreso.Patente;
            txtUbicacion.Text = ingreso.ObtenerUbicacion();
            txtIngreso.Text = ingreso.FechaIngreso.ToString();

            CalcularTarifa();
        }

        private string DatosVehiculo()
        {
            StringBuilder datos = new StringBuilder();
            
            datos.AppendLine($"Vehiculo: {ingreso.ObtenerTipoVehiculo()}");
            datos.AppendLine($"Patente: {ingreso.Patente}");
            datos.AppendLine($"Estacionamiento: {ingreso.ObtenerUbicacion()}");
            datos.Append($"Sector: {ingreso.ObtenerSector()}");

            return datos.ToString();
        }

        //------------EVENTOS------------//
        private void frmDarSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            uCEstacionamiento.ActivarBotones();
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
                    tarifasIngreso = parkimetro.CalcularTarifa(ingreso);

                    servicioSalidas.DarSalida(ingreso, DateTime.Now, montoTotal, tarifasIngreso);

                    Mensajero.MensajeExitoso($"Se ha liberado el estacionamiento: \n" +
                        $"Ubicacion: {ingreso.ObtenerUbicacion()}\n" +
                        $"Sector: {ingreso.ObtenerSector()}");
                    
                    uCEstacionamiento.DesocuparEstacionamiento();

                    Close();
                }
                catch (Exception)
                {
                    Mensajero.MensajeError($"No se ha podido dar la salida de: \n{DatosVehiculo()}");
                }
            }
        }
    }
}
