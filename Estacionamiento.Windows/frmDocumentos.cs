﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Windows.Utilidades;
using Estacionamiento.Servicios;
using Estacionamiento.Entidades;

namespace Estacionamiento.Windows
{
    public partial class frmDocumentos : Form
    {
        frmPrincipal formPrincipal;
        ServicioTiposDeDocumentos serviciosTipoDocumentos;
        public frmDocumentos(frmPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;

            serviciosTipoDocumentos = new ServicioTiposDeDocumentos();
        }


        //------------METODOS------------//

        //----PRIVADOS----//

        private void CargarDatoEnFila(DataGridViewRow fila, Documento documento)
        {
            fila.Cells[colTipoDeDoc.Index].Value = documento.TipoDoc;

            fila.Tag = documento;
        }

        private void CargarFilaEnGrilla(DataGridViewRow fila)
        {
            datosDocumentos.Rows.Add(fila);
        }
        private void CargarGrilla()
        {
            List<Documento> documentos = serviciosTipoDocumentos.ObtenerTiposDeDocumentos();

            foreach (Documento documento in documentos)
            {
                DataGridViewRow fila = CrearFila();

                CargarDatoEnFila(fila, documento);

                CargarFilaEnGrilla(fila);

            }
        }

        public DataGridViewRow CrearFila()
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(datosDocumentos);

            return fila;
        }

        //----PUBLICOS----//

        public void ActivarBotones()
        {
            CorrectorDeEstados.ActivarBotones(botonesMenu);
            formPrincipal.ActivarBotones();
        }

        public void ActualizarDocumento(Documento doc)
        {
            DataGridViewRow fila = datosDocumentos.SelectedRows[0];

            CargarDatoEnFila(fila, doc);
        }

        public void AgregarDocumento(Documento doc)
        {
            DataGridViewRow fila = CrearFila();

            CargarDatoEnFila(fila, doc);

            CargarFilaEnGrilla(fila);
        }

        public void AnularBotones()
        {
            CorrectorDeEstados.AnularBotones(botonesMenu);
            formPrincipal.AnularBotones();
        }

        //------------EVENTOS------------//


        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoDocsEdicion frmAgregarDoc = new frmTipoDocsEdicion(this);

            AnularBotones();

            frmAgregarDoc.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(datosDocumentos.SelectedRows.Count > 0)
            {
                frmTipoDocsEdicion frmEditarDoc = new frmTipoDocsEdicion(this, (Documento)datosDocumentos.SelectedRows[0].Tag);

                AnularBotones();

                frmEditarDoc.Show();
            }
        }
    }
}
