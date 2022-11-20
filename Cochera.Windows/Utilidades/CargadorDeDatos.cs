using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Cochera.Entidades;
using Cochera.Entidades.Enumeraciones;


namespace Cochera.Windows.Utilidades
{
    public static class CargadorDeDatos
    {
        //------------METODOS------------//


        //----PUBLICOS----//

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

        public static void CargarDataGridReducido(DataGridView grilla, List<Cliente> clientes)
        {

            foreach(Cliente cliente in clientes)
            {
                DataGridViewRow fila = CrearFila(grilla);

                fila.Cells[0].Value = cliente.NombreCompleto();

                fila.Cells[1].Value = cliente.ObtenerNumeroDoc();

                fila.Tag = cliente;

                grilla.Rows.Add(fila);
            }
        }
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
        public static void CargarDataGrid(DataGridView grilla, List<Ingreso> ingresos)
        {
            foreach(Ingreso ingreso in ingresos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, ingreso);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Ingreso ingreso)
        {
            fila.Cells[0].Value = ingreso.Patente;
            fila.Cells[1].Value = ingreso.ObtenerTipoVehiculo();
            fila.Cells[2].Value = ingreso.FechaIngreso.ToShortDateString();
            fila.Cells[3].Value = ingreso.FechaIngreso.ToShortTimeString();
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
            fila.Cells[8].Value = salida.MontoTotal.ToString("C");

            fila.Tag = salida;
        }

        #endregion

        //--DATA ESTACIONAMIENTOS--//

        #region
        public static void CargarDataGrid(DataGridView grilla, List<Estacionamiento> estacionamientos)
        {
            foreach(Estacionamiento estacionamiento in estacionamientos)
            {
                DataGridViewRow fila = CrearFila(grilla);

                CargarDatosEnFila(fila, estacionamiento);

                CargarFilaEnGrilla(grilla, fila);
            }
        }

        public static void CargarDatosEnFila(DataGridViewRow fila, Estacionamiento estacionamiento)
        {
            fila.Cells[0].Value = estacionamiento.ObtenerSector();
            fila.Cells[1].Value = estacionamiento.Ubicacion;
            fila.Cells[2].Value = estacionamiento.Ocupado ? "SI" : "NO";

            fila.Tag = estacionamiento;

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



    }
}
