using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Cochera.Entidades;
using Cochera.Entidades.Interfaces;
using Cochera.Windows.Clases;


namespace Cochera.Windows.Utilidades
{
    public static class CargadorDeDatos
    {
        //------------METODOS------------//


        //----PUBLICOS----//

        //--COMBO BOX--//

        #region
        public static void SetearComboBox<T>(ComboBox combo, List<T> datos)
        {
            //SetearCombo(combo, datos);
            foreach (T dato in datos)
            {
                combo.Items.Add(dato.ToString());
            }
            combo.Tag = datos;
            combo.SelectedIndex = 0;
        }

        public static void SetearListBox<T>(ListBox caja, List<T> datos)
        {
            foreach(T dato in datos)
            {
                caja.Items.Add(dato.ToString());
            }
            caja.Tag = datos;
        }

        #endregion

        //--GRILLA REDUCIDA CLIENTES--//

        #region
        public static void CargarDataGridReducido(DataGridView grilla, List<Cliente> clientes)
        {

            foreach(Cliente cliente in clientes)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFilaReducida(fila, cliente);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFilaReducida(DataGridViewRow fila, Cliente cliente)
        {
            fila.Cells[0].Value = cliente.NombreCompleto();

            fila.Cells[1].Value = cliente.ObtenerNumeroDoc();

            fila.Tag = cliente;
        }

        #endregion

        //--DATA GRAL--//

        #region
        public static void CargarFilaEnGrilla(DataGridView grilla, DataGridViewRow fila)
        {
            grilla.Rows.Add(fila);
        }

        public static DataGridViewRow CrearFila(DataGridView grilla)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(grilla);

            return fila;
        }

        #endregion

        //--DATA INGRESOS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<IIngreso> ingresos)
        {
            foreach(IIngreso ingreso in ingresos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, ingreso);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, IIngreso ingreso)
        {
            fila.Cells[0].Value = ingreso.ObtenerPatente();
            fila.Cells[1].Value = ingreso.ObtenerTipoVehiculo();
            fila.Cells[2].Value = ingreso.ObtenerFechaIngreso().ToShortDateString();
            fila.Cells[3].Value = ingreso.ObtenerFechaIngreso().ToShortTimeString();
            fila.Cells[4].Value = ingreso.ObtenerUbicacion();
            fila.Cells[5].Value = ingreso.ObtenerSector();

            fila.Tag = ingreso;
        }

        #endregion

        //--DATA SALIDAS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Salida> salidas)
        {
            foreach(Salida salida in salidas)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, salida);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Salida salida)
        {
            fila.Cells[0].Value = salida.ObtenerPatente();
            fila.Cells[1].Value = salida.ObtenerTipoVehiculo();
            fila.Cells[2].Value = salida.ObtenerFechaIngreso().ToShortDateString();
            fila.Cells[3].Value = salida.ObtenerFechaIngreso().ToShortTimeString();
            fila.Cells[4].Value = salida.FechaSalida.ToShortDateString();
            fila.Cells[5].Value = salida.FechaSalida.ToShortTimeString();
            fila.Cells[6].Value = salida.ObtenerUbicacion();
            fila.Cells[7].Value = salida.ObtenerSector();

            fila.Tag = salida;
        }

        #endregion

        //--DATA ESTACIONAMIENTOS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Estacionamiento> estacionamientos, List<IIngreso> ingresos)
        {
            foreach(Estacionamiento estacionamiento in estacionamientos)
            {
                IIngreso ingreso = ingresos.Find(i => i.ObtenerUbicacion() == estacionamiento.Ubicacion);
    
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, estacionamiento, ingreso);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Estacionamiento estacionamiento, IIngreso ingreso)
        {

            fila.Cells[0].Value = estacionamiento.ObtenerSector();
            fila.Cells[1].Value = estacionamiento.Ubicacion;
            fila.Cells[2].Value = estacionamiento.Ocupado ? "SI" : "NO";
            
            if(ingreso is null)
            {
                fila.Cells[3].Value = "";
                fila.Cells[4].Value = "";
                fila.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                if (ingreso.esAbonado())
                {
                    fila.DefaultCellStyle.BackColor = Color.Gold;
                }
                fila.Cells[3].Value = ingreso.ObtenerPatente();
                fila.Cells[4].Value = ingreso.ObtenerTipoVehiculo();
            }

            Tuple<Estacionamiento, IIngreso> dato = new Tuple<Estacionamiento, IIngreso>(estacionamiento,ingreso);
            
            fila.Tag = dato;
        }

        #endregion

        //--DATA MARCAS--//

        #region

        public static void CargarDataGrid(DataGridView grilla, List<Marca> marcas)
        {
            foreach(Marca marca in marcas)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, marca);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Marca marca)
        {
            fila.Cells[0].Value = marca.Nombre;

            fila.Tag = marca;
        }

        #endregion  

        //--DATA MODELOS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Modelo> modelos)
        {
            foreach(Modelo modelo in modelos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, modelo);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Modelo modelo)
        {
            fila.Cells[0].Value = modelo.ObtenerTipoVehiculo();
            fila.Cells[1].Value = modelo.Nombre;
            fila.Cells[2].Value = modelo.ObtenerMarca();

            fila.Tag = modelo;
        }

        #endregion

        //--DATA TARIFA POR VEHICULO--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<TarifaPorVehiculo> datos)
        {
            foreach(TarifaPorVehiculo dato in datos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, dato);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, TarifaPorVehiculo dato)
        {
            fila.Cells[0].Value = dato.ObtenerTipo();
            fila.Cells[1].Value = dato.ObtenerTarifa();
            fila.Cells[2].Value = dato.ObtenerMonto().ToString("C");

            fila.Tag = dato;
        }

        #endregion

        //--DATA DOCUMENTOS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Documento> documentos)
        {
            foreach(Documento documento in documentos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, documento);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Documento documento)
        {
            fila.Cells[0].Value = documento.TipoDoc;

            fila.Tag = documento;
        }

        #endregion

        //--DATA CLIENTES--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Cliente> clientes)
        {
            foreach(Cliente cliente in clientes)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, cliente);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Cliente cliente)
        {

            fila.Cells[0].Value = cliente.NombreCompleto();
            fila.Cells[1].Value = cliente.ObtenerTipoDoc();
            fila.Cells[2].Value = cliente.ObtenerNumeroDoc();
            fila.Cells[3].Value = cliente.Telefono;

            fila.Tag = cliente;
        }

        #endregion

        //--DATA ABONADOS--//

        #region

        public static void CargarDataGrid(DataGridView grilla, List<Abonado> abonados)
        {
            foreach(Abonado abonado in abonados)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, abonado);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Abonado abonado)
        {
            fila.Cells[0].Value = abonado.NombreCompletoCliente();
            fila.Cells[1].Value = abonado.ObtenerVehiculo();
            fila.Cells[2].Value = abonado.ObtenerPatente();
            fila.Cells[3].Value = abonado.ObtenerModelo();
            fila.Cells[4].Value = abonado.ObtenerMarca();
            fila.Cells[5].Value = abonado.ObtenerTiempoTarifa();
            fila.Cells[6].Value = abonado.ObtenerFechaIngreso().ToShortDateString(); ;
            fila.Cells[7].Value = abonado.FechaExpiracion.ToShortDateString();
            
            Parkimetro parkimetro = new Parkimetro();

            fila.DefaultCellStyle.BackColor = parkimetro.ColorAbonado(abonado);

            fila.Tag = abonado;
        }

        #endregion

        //--DATA CTA CTES--//

        #region

        public static void CargarDataGrid(DataGridView grilla, List<CuentaCorriente> cuentas)
        {
            foreach(CuentaCorriente cuenta in cuentas)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, cuenta);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, CuentaCorriente cuenta)
        {
            fila.Cells[0].Value = cuenta.CuentaId.ToString();
            fila.Cells[1].Value = cuenta.NombreCompletoCliente();
            fila.Cells[2].Value = String.IsNullOrWhiteSpace(cuenta.Nombre) ? "" : cuenta.Nombre;
            fila.Cells[3].Value = cuenta.ObtenerNumeroTarjeta();
            fila.Cells[4].Value = cuenta.ObtenerMarcaTarjeta();
            fila.Cells[5].Value = cuenta.MedioDePago();



            fila.Tag = cuenta;
        }

        #endregion

        //--DATA CONTABLES--//

        #region

        public static void CargarDataGrid(DataGridView grilla, List<IContable> contables)
        {
            foreach(IContable contable in contables)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, contable);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, IContable contable)
        {
            fila.Cells[0].Value = contable.Descripcion();
            fila.Cells[1].Value = contable.Vehiculo();
            fila.Cells[2].Value = contable.Patente();
            fila.Cells[3].Value = contable.FechaMovimiento().ToShortDateString();
            fila.Cells[4].Value = contable.FechaMovimiento().ToShortTimeString();
            fila.Cells[5].Value = contable.MedioDePago();
            fila.Cells[6].Value = contable.Importe().ToString("C");

            fila.Tag = contable;
        }

        #endregion
    }
}
