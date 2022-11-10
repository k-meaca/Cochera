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
using Cochera.Windows.Utilidades;

namespace Cochera.Windows
{
    public partial class frmMarcasEdicion : Form
    {
        //------------ATRIBUTOS------------//

        frmMarcas formMarcas;
        Marca marcaEdicion;
        ServicioMarcas servicioMarcas;

        //------------CONSTRUCTORES------------//
        public frmMarcasEdicion(frmMarcas formMarcas)
        {
            InitializeComponent();

            this.formMarcas = formMarcas;

            ModoAgregar();
        }

        public frmMarcasEdicion(frmMarcas formMarcas, Marca marca)
        {
            InitializeComponent();

            this.formMarcas = formMarcas;
            marcaEdicion = marca;

            ModoEditar();
        }

        //------------METODOS------------//

        //----PRIVADOS----//

        private void ModoAgregar()
        {
            lblTitulo.Text = "AGREGAR MARCA";

            CorrectorDeEstados.ActivarBoton(btnAgregar);
            CorrectorDeEstados.AnularBoton(btnEditar);
        }

        private void ModoEditar()
        {
            lblTitulo.Text = "EDITAR MARCA";


            CorrectorDeEstados.ActivarBoton(btnEditar);
            CorrectorDeEstados.AnularBoton(btnAgregar);

            txtMarca.Text = marcaEdicion.Nombre;

        }
        private bool ValidarDato()
        {
            mostradorDeErrores.Clear();

            if (!Validador.InputConTexto(txtMarca.Text))
            {
                mostradorDeErrores.SetError(txtMarca, "Debe llenar este campo.");
                return false;
            }
            return true;
        }

        //------------EVENTOS------------//


        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validador.SoloTexto(e.KeyChar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {
                marcaEdicion.ActualizarMarca(txtMarca.Text);

                servicioMarcas = new ServicioMarcas();

                servicioMarcas.ActualizarMarca(marcaEdicion);

                formMarcas.ActualizarMarca(marcaEdicion);

                Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {

                string nombreMarca = txtMarca.Text;

                servicioMarcas = new ServicioMarcas();

                Marca marca = servicioMarcas.AgregarMarca(nombreMarca);

                formMarcas.AgregarMarca(marca);

                Close();
            }
        }

        private void frmMarcasEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMarcas.ActivarBotones();
        }
    }
}
