﻿using System;
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
using Cochera.Entidades.Enumeraciones;
using Cochera.Windows.Utilidades;

namespace Cochera.Windows
{
    public partial class frmIngresosEdicion : Form
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

        private Estacionamiento estacionamiento;
        private UCEstacionamiento uCEstacionamiento;

        #endregion

        //------------CONSTRUCTOR------------//
        public frmIngresosEdicion(Estacionamiento estacionamiento, UCEstacionamiento ucEstacionamiento)
        {
            InitializeComponent();

            servicioTarifas = new ServicioTarifas();
            servicioTarifasPorVehiculo = new ServicioTarifasPorVehiculo();
            servicioTipos = new ServicioTiposDeVehiculos();
            servicioClientes = new ServicioClientes();
            servicioModelos = new ServicioModelos();
            servicioMarcas = new ServicioMarcas();
            servicioIngresos = new ServicioIngresos();

            this.estacionamiento = estacionamiento;
            this.uCEstacionamiento = ucEstacionamiento;

            SetearComponentes();
  
            SetearTamanio(213, 464);
        }

        //------------METODOS------------//

        //----PRIVADOS----//


        //--CALCULOS--//

        #region
        private void CalcularFechaExpiracion()
        {
            int tarifa = cmboxTarifa.SelectedIndex;

            DateTime fechaExpiracion = Convert.ToDateTime(txtIngreso.Text);

            switch (tarifa)
            {
                case (int)ClasificacionTarifa.Semana:
                    fechaExpiracion = fechaExpiracion.AddDays(7);
                    break;
                case (int)ClasificacionTarifa.Quincena:
                    fechaExpiracion = fechaExpiracion.AddDays(15);
                    break;
                case (int)ClasificacionTarifa.Mes:
                    fechaExpiracion = fechaExpiracion.AddMonths(1);
                    break;
            }

            txtExpiracion.Text = fechaExpiracion.ToString();
        }

        private void CalcularPrecio()
        {

            List<TipoDeVehiculo> tipos = (List<TipoDeVehiculo>)cmboxTipoVehiculo.Tag;

            TipoDeVehiculo tipo = tipos.Find(t => t.Tipo == (string)cmboxTipoVehiculo.SelectedItem);

            List<Tarifa> tarifas = (List<Tarifa>)cmboxTarifa.Tag;

            Tarifa tarifa = tarifas.Find(t => t.Tiempo == (string)cmboxTarifa.SelectedItem);

            decimal precio = servicioTarifasPorVehiculo.ObtenerPrecio(tipo, tarifa);

            txtPrecio.Text = precio.ToString("C");
        }

        #endregion

        //--ALMACENAMIENTO--//

        #region
        private void EstacionarVehiculo()
        {
            try
            {
                ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime ingreso);

                //Ingreso ingreso = new Ingreso(patente, tipo, ingreso, estacionamiento);

                servicioIngresos.GenerarIngreso(patente,tipo,ingreso,estacionamiento);

                estacionamiento.EstacionarVehiculo(tipo);

                uCEstacionamiento.EstacionamientoOcupado();

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

        }

        private void ObtenerDatosDeVehiculo(out TipoDeVehiculo tipo, out string patente, out DateTime ingreso)
        {
            tipo = (TipoDeVehiculo)cmboxTipoVehiculo.Items[cmboxTipoVehiculo.SelectedIndex];

            patente = txtPatente.Text;

            ingreso = DateTime.Now;
        }

        #endregion

        //--SETS--//

        #region
        private void SetearClientes()
        {
            List<Cliente> clientes = servicioClientes.ObtenerClientes();

            CargadorDeDatos.CargarDataGridReducido<Cliente>(datosClientes, clientes);
        }

        private void SetearComponentes()
        {

            List<TipoDeVehiculo> tipos = servicioTipos.ObtenerTiposDeVehiculo();

            tipos = tipos.FindAll(t => estacionamiento.PuedeEstacionarVehiculo(t));

            CargadorDeDatos.SetearComboBox<TipoDeVehiculo>(cmboxTipoVehiculo, tipos);

            txtEstacionamiento.Text = estacionamiento.Ubicacion;

            txtIngreso.Text = DateTime.Now.ToString();

            checkAbonar.Checked = false;
        }

        private void SetearModelos()
        {
            cmboxModelo.Items.Clear();
            
            //List<TipoDeVehiculo> tipos = (List<TipoDeVehiculo>)cmboxTipoVehiculo.Tag;

            //TipoDeVehiculo tipo = tipos.Find(t => t.Tipo == cmboxTipoVehiculo.SelectedItem.ToString());

            TipoDeVehiculo tipo = (TipoDeVehiculo)cmboxTipoVehiculo.Items[cmboxTipoVehiculo.SelectedIndex];

            List<Modelo> modelos = servicioModelos.ObtenerModelos(tipo);

            CargadorDeDatos.SetearComboBox<Modelo>(cmboxModelo, modelos);
        }

        private void SetearMarca() 
        {

            //List<Modelo> modelos = (List<Modelo>)cmboxModelo.Tag;

            //Modelo modelo = modelos.Find(m => m.Nombre == cmboxModelo.SelectedItem.ToString());

            Modelo modelo = (Modelo)cmboxModelo.Items[cmboxModelo.SelectedIndex];

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
        private bool ValidarPatente()
        {
            return Validador.InputConTexto(txtPatente.Text);
        }

        //----PUBLICOS----//


        //------------EVENTOS------------//

        //----COMBO BOX----//

        #region
        private void cmboxTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkAbonar.Checked)
            {
                CalcularPrecio();
            }
        }

        private void cmboxTarifa_SelectedValueChanged(object sender, EventArgs e)
        {
                CalcularPrecio();         
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
                SetearTamanio(704, 464);
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
            if (checkAbonar.Checked && ValidarPatente())
            {
                EstacionarVehiculoAbonado();
            }
            else if(ValidarPatente())
            {
                EstacionarVehiculo();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uCEstacionamiento.ActivarBotones();
            Close();
        }

        #endregion

        //----TEXT BOX----//

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.NumerosYLetras(e.KeyChar);
        }
    }
}
