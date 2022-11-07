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
using Cochera.Entidades.Interfaces;
using Cochera.Windows.Utilidades;
using Cochera.Windows.Interfaces;


namespace Cochera.Windows
{
    public partial class frmEstacionamientoTodos : Form, IGeneradorIngresos, IGeneradorSalidas
    {
        //------------ATRIBUTOS-------------//

        private frmEstacionamiento formEstacionamiento;
        private ServicioEstacionamientos servicioEstacionamientos;
        private ServicioIngresos servicioIngresos;
        private ServicioAbonados servicioAbonados;

        public frmEstacionamientoTodos(frmEstacionamiento formEstacionamiento)
        {
            InitializeComponent();

            this.formEstacionamiento = formEstacionamiento;
            servicioEstacionamientos = new ServicioEstacionamientos();
            servicioIngresos = new ServicioIngresos();
            servicioAbonados = new ServicioAbonados();

            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();

            CargarGrilla(estacionamientos);

            MostrarLugaresLibres(estacionamientos);
        }


        //------------METODOS------------//


        //----PRIVADOS----//

        private void ActualizarFila(Tuple<Estacionamiento, IIngreso> dato, IIngreso ingreso)
        {
            DataGridViewRow fila = datosEstacionamientos.SelectedRows[0];
            CargadorDeDatos.CargarDatosEnFila(fila, dato.Item1, ingreso);
        }

        private void BuscarPorPatente(string patente)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();

            if (!Validador.InputConTexto(patente))
            {
                CargarGrilla(estacionamientos);
            }
            else
            {
                List<IIngreso> ingresos = ObtenerIngresos(estacionamientos);

                ingresos = ingresos.FindAll(i => i.ObtenerPatente().Contains(patente));

                List<Estacionamiento> estacionamientosAux = new List<Estacionamiento>();

                foreach (IIngreso ingreso in ingresos)
                {
                    estacionamientosAux.Add(estacionamientos.Find(e => e.Ubicacion == ingreso.ObtenerUbicacion()));
                }

                datosEstacionamientos.Rows.Clear();

                CargadorDeDatos.CargarDataGrid(datosEstacionamientos, estacionamientosAux, ingresos);
            }

        }

        private void CargarGrilla(List<Estacionamiento> estacionamientos)
        {
            datosEstacionamientos.Rows.Clear();

            List<IIngreso> ingresos = ObtenerIngresos(estacionamientos);

            CargadorDeDatos.CargarDataGrid(datosEstacionamientos, estacionamientos, ingresos);
        }

        private void FiltrarPorVehiculo(string tipo)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos().FindAll(est => est.Ocupado);

            List<IIngreso> ingresos = ObtenerIngresos(estacionamientos);

            ingresos = ingresos.FindAll(i => i.ObtenerTipoVehiculo() == tipo);

            List<Estacionamiento> estacionamientosAux = new List<Estacionamiento>();

            foreach(IIngreso ingreso in ingresos)
            {
                estacionamientosAux.Add(estacionamientos.Find(e => e.Ubicacion == ingreso.ObtenerUbicacion()));
            }

            datosEstacionamientos.Rows.Clear();

            CargadorDeDatos.CargarDataGrid(datosEstacionamientos, estacionamientosAux, ingresos);
        }

        private void MostrarLugaresLibres(List<Estacionamiento> estacionamientos)
        {
            lblCantTotal.Text = estacionamientos.Count.ToString();
            lblCantLibresTotales.Text = estacionamientos.Count(e => e.Ocupado == false).ToString();

            lblCantLibresPB.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Planta Baja")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresA.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo A")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresB.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo B")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresC.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo C")
                                                                    .Count(e => e.Ocupado == false).ToString();

            lblCantLibresD.Text = estacionamientos.FindAll(e => e.ObtenerSector() == "Subsuelo D")
                                                        .Count(e => e.Ocupado == false).ToString();
        }

        private List<IIngreso> ObtenerIngresos(List<Estacionamiento> estacionamientos)
        {
            List<IIngreso> ingresos = new List<IIngreso>();

            foreach (Estacionamiento estacionamiento in estacionamientos)
            {
                if (estacionamiento.Ocupado)
                    ingresos.Add(servicioIngresos.ObtenerIngreso(estacionamiento));
            }

            //List<Abonado> abonados = servicioAbonados.ObtenerAbonados();

            //FiltradorDuplicados.FiltrarIngresos(ingresos, abonados);

            return ingresos;
        }

        //----PUBLICOS----//


        //--IGeneradorIngresos--//

        #region
        public void ActivarBotones()
        {
            this.Enabled = true;
            formEstacionamiento.ActivarBotones();
        }
        public void ActualizarLugares(TipoDeVehiculo tipo)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();

            MostrarLugaresLibres(estacionamientos);
        }
        public void AnularBotones()
        {
            this.Enabled = false;
            formEstacionamiento.AnularBotones();
        }

        public string ObtenerUbicacion()
        {
            Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

            return dato.Item1.Ubicacion;
        }

        public bool PuedeEstacionarVehiculo(TipoDeVehiculo tipo)
        {
            Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

            return dato.Item1.PuedeEstacionarVehiculo(tipo);
        }


        #endregion

        //--IGeneradorSalidas--//

        #region
        public void DesocuparEstacionamiento()
        {
            Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

            dato.Item1.SacarVehiculo();

            ActualizarFila(dato, null);

            ActualizarLugares(null);
        }
        public void EstacionamientoOcupado(TipoDeVehiculo tipo, IIngreso ingreso)
        {
            Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

            dato.Item1.EstacionarVehiculo(tipo);

            ActualizarFila(dato, ingreso);
        }

        #endregion

        //------------EVENTOS------------//

        //--BOTONES MENU--//

        #region
        private void btnEstacionar_Click(object sender, EventArgs e)
        {

            bool estacionamientoVacio = datosEstacionamientos.SelectedRows[0].Cells[colPatente.Index].Value.ToString() == "";

            if (datosEstacionamientos.SelectedRows.Count > 0 && estacionamientoVacio)
            {
                Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

                frmIngresosEdicion frmDarIngreso = new frmIngresosEdicion(dato.Item1, this);

                AnularBotones();

                frmDarIngreso.Show();

            }
            else
            {
                Mensajero.MensajeError($"El estacionamiento {ObtenerUbicacion()} ya se encuentra ocupado.");
            }
        }

        private void btnDesocupar_Click(object sender, EventArgs e)
        {
            bool estacionamientoConVehiculo = datosEstacionamientos.SelectedRows[0].Cells[colPatente.Index].Value.ToString() != "";

            if (datosEstacionamientos.SelectedRows.Count > 0 && estacionamientoConVehiculo)
            {
                Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

                frmDarSalida frmGenerarSalida = new frmDarSalida(dato.Item2, this);

                AnularBotones();

                frmGenerarSalida.Show();
            }
            else
            {
                Mensajero.MensajeError($"El estacionamiento {ObtenerUbicacion()} no tiene ningun vehiculo estacionado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool estacionamientoConVehiculo = datosEstacionamientos.SelectedRows[0].Cells[colPatente.Index].Value.ToString() != "";

            if (datosEstacionamientos.SelectedRows.Count > 0 && estacionamientoConVehiculo)
            {
                Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

                if (!dato.Item2.esAbonado())
                {
                    frmIngresosEdicion frmEditarIngreso = new frmIngresosEdicion(dato.Item1, dato.Item2, this);

                    AnularBotones();

                    frmEditarIngreso.Show();
                }
                else
                {
                    Mensajero.MensajeError("No es posible editar un abonado ya que se realizo un pago instantaneo." +
                        "Debe dar de baja el abonado y volver a crearlo.");
                }
            }
            else
            {
                Mensajero.MensajeError("No hay ningun vehiculo estacionado para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool estacionamientoConVehiculo = datosEstacionamientos.SelectedRows[0].Cells[colPatente.Index].Value.ToString() != "";

            if (datosEstacionamientos.SelectedRows.Count > 0 && estacionamientoConVehiculo)
            {
                Tuple<Estacionamiento, IIngreso> dato = (Tuple<Estacionamiento, IIngreso>)datosEstacionamientos.SelectedRows[0].Tag;

                if (!dato.Item2.esAbonado())
                {
                    servicioIngresos.EliminarIngreso(dato.Item1, (Ingreso)dato.Item2);

                    dato.Item1.SacarVehiculo();

                    Tuple<Estacionamiento, IIngreso> datoAux = new Tuple<Estacionamiento,IIngreso>(dato.Item1, null);

                    ActualizarFila(dato,null);

                    ActualizarLugares(null);

                }
                else
                {
                    Mensajero.MensajeError("No es posible eliminar un abonado ya que se realizo un pago instantaneo.");
                        
                }
            }
            else
            {
                Mensajero.MensajeError("No hay ningun vehiculo estacionado para eliminar.");
            }
        }

        #endregion

        //--BUSCAR PATENTE--//

        #region
        private void txtBuscarPatente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBuscarPatente_TextChanged(object sender, EventArgs e)
        {
            BuscarPorPatente(txtBuscarPatente.Text);
        }

        #endregion

        //--BOTONES FILTRADO--//

        //-SECTOR-//

        #region
        private void btnFiltrarSectorPB_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientosPB();

            CargarGrilla(estacionamientos);
        }

        private void btnFiltrarSectorA_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientosSubsueloA();

            CargarGrilla(estacionamientos);
        }

        private void btnFiltrarSectorB_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientosSubsueloB();

            CargarGrilla(estacionamientos);
        }

        private void btnFiltrarSectorC_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientosSubsueloC();

            CargarGrilla(estacionamientos);
        }

        private void btnFiltrarSectorD_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientosSubsueloD();

            CargarGrilla(estacionamientos);
        }

        #endregion

        //-ACTUALIZAR-//

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos();
            CargarGrilla(estacionamientos);
        }

        //-VEHICULOS-//

        #region

        private void btnFiltrarAuto_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Auto");
        }

        private void btnFiltrarCamioneta_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Camioneta 4x4");
        }

        private void btnFiltrarCombi_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Combi");
        }

        private void btnFiltrarMoto_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Moto");
        }

        private void btnFiltrarMotoSidecar_Click(object sender, EventArgs e)
        {
            FiltrarPorVehiculo("Moto con sidecar");
        }

        #endregion

        //-POR CONDICION-//

        #region
        private void btnFiltrarOcupado_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos().FindAll(est => est.Ocupado);

            CargarGrilla(estacionamientos);
        }

        private void btnFiltrarLibre_Click(object sender, EventArgs e)
        {
            List<Estacionamiento> estacionamientos = servicioEstacionamientos.ObtenerEstacionamientos().FindAll(est => !est.Ocupado);

            CargarGrilla(estacionamientos);
        }


        #endregion
    }
}
