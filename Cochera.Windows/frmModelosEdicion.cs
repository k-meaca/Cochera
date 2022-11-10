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
using Cochera.Servicios;
using Cochera.Windows.Utilidades;


namespace Cochera.Windows
{
    public partial class frmModelosEdicion : Form
    {

        //------------ATRIBUTOS------------//

        private frmModelos formModelos;
        private Modelo modeloEdicion;
        private ServicioTiposDeVehiculos servicioTipoVehiculos;
        private ServicioMarcas servicioMarcas;
        private ServicioModelos servicioModelos;

        //------------CONSTRUCTOR------------//
        public frmModelosEdicion(frmModelos formModelos)
        {
            InitializeComponent();

            this.formModelos = formModelos;

            ModoAgregar();
        }

        public frmModelosEdicion(frmModelos formModelos, Modelo modelo)
        {
            InitializeComponent();

            this.formModelos = formModelos;
            modeloEdicion = modelo;

            ModoEditar();

        }


        //------------METODOS------------//

        //----PRIVADOS----//

        private void InicializarComponentes()
        {
            servicioTipoVehiculos = new ServicioTiposDeVehiculos();
            servicioMarcas = new ServicioMarcas();

            CargadorDeDatos.SetearComboBox<TipoDeVehiculo>(cmboxTiposVehiculos, servicioTipoVehiculos.ObtenerTiposDeVehiculo());
            CargadorDeDatos.SetearComboBox<Marca>(cmboxMarcas, servicioMarcas.ObtenerMarcas());

        }

        private void ModoAgregar() 
        {
            lblTitulo.Text = "AGREGAR MODELO";

            CorrectorDeEstados.ActivarBoton(btnAgregar);
            CorrectorDeEstados.AnularBoton(btnEditar);

            InicializarComponentes();
        }

        private void ModoEditar() 
        {
            lblTitulo.Text = "EDITAR MODELO";

            CorrectorDeEstados.ActivarBoton(btnEditar);
            CorrectorDeEstados.AnularBoton(btnAgregar);

            InicializarComponentes();

            cmboxTiposVehiculos.SelectedItem = modeloEdicion.ObtenerTipoVehiculo();
            cmboxMarcas.SelectedItem = modeloEdicion.ObtenerMarca();
            txtModelo.Text = modeloEdicion.Nombre;
        }

        private Marca ObtenerMarca()
        {
            string marca = cmboxMarcas.SelectedItem.ToString();

            return ((List<Marca>)cmboxMarcas.Tag).Find(m => m.Nombre == marca);
            
        }

        private TipoDeVehiculo ObtenerTipoDeVehiculo()
        {
            string tipoVehiculo = cmboxTiposVehiculos.SelectedItem.ToString();

            return ((List<TipoDeVehiculo>)cmboxTiposVehiculos.Tag).Find(t => t.Tipo == tipoVehiculo);
        }

        private bool ValidarInput()
        {
            mostradorDeErrores.Clear();

            if (!Validador.InputConTexto(txtModelo.Text))
            {
                mostradorDeErrores.SetError(txtModelo, "Debe llenar este campo.");
                return false;
            }

            return true;
        }

        //----PUBLICOS----//

        //------------EVENTOS------------//

        //----FORMULARIO----//
        private void frmModelosEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formModelos.ActivarBotones();
        }

        //----TEXT BOX----//
        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloTexto(e.KeyChar);
        }

        //----BOTONES----//
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarInput())
            {
                Marca marca = ObtenerMarca();
                TipoDeVehiculo tipoVehiculo = ObtenerTipoDeVehiculo();

                string nombreModelo = txtModelo.Text;

                servicioModelos = new ServicioModelos();

                Modelo modelo = servicioModelos.AgregarModelo(nombreModelo, marca, tipoVehiculo);

                formModelos.AgregarModelo(modelo);

                Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarInput())
            {
                Marca marca = ObtenerMarca();
                TipoDeVehiculo tipoVehiculo = ObtenerTipoDeVehiculo();

                string nombreModelo = txtModelo.Text;

                modeloEdicion.ActualizarDatos(nombreModelo, marca, tipoVehiculo);

                servicioModelos = new ServicioModelos();

                servicioModelos.ActualizarModelo(modeloEdicion);

                formModelos.ActualizarModelo(modeloEdicion);

                Close();
            }
        }

    }
}
