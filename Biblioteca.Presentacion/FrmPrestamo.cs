﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            listarLibros();
            listarProfesores();
        }

        private void listarLibros()
        {
            try
            {
                dgvListadoLibros.DataSource = NLibro.listarAvailableSmall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listarProfesores()
        {
            try
            {
                dgvListadoProfesores.DataSource = NUsuario.listarProfesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listarPrestamosProfesor(int id)
        {
            try
            {
                dgvListadoProfesores.DataSource = NPrestamo.ListarPorProfesor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarLibro()
        {
            try
            {
                if (Convert.ToString(cboBuscarLibro.SelectedValue) == "Titulo")
                {
                    dgvListadoLibros.DataSource = NLibro.buscarTitulo(txtBuscarLibro.Text);
                }
                else if (Convert.ToString(cboBuscarLibro.SelectedValue) == "Autor")
                {
                    dgvListadoLibros.DataSource = NLibro.buscarAutor(txtBuscarLibro.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BuscarProfesor()
        {
            try
            {
                dgvListadoProfesores.DataSource = NUsuario.listarProfesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void dgvListadoLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoLibros.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chckSeleccionar = (DataGridViewCheckBoxCell)dgvListadoLibros.Rows[e.RowIndex].Cells["Seleccionar"];
                chckSeleccionar.Value = !Convert.ToBoolean(chckSeleccionar.Value);
            }
        }

        private void dgvListadoProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoProfesores.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chckSeleccionar = (DataGridViewCheckBoxCell)dgvListadoProfesores.Rows[e.RowIndex].Cells["Seleccionar"];
                chckSeleccionar.Value = !Convert.ToBoolean(chckSeleccionar.Value);
            }
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de biblioteca",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigoLibro = -1, codigoProfesor = -1;
                    DateTime fechaDevolucion;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgvListadoLibros.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigoLibro = Convert.ToInt32(row.Cells[1].Value);
                            break;
                        }
                    }
                    foreach(DataGridViewRow row in dgvListadoProfesores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigoProfesor = Convert.ToInt32(row.Cells[1].Value);
                            break;
                        }
                    }
                    fechaDevolucion = dtpDevolucion.Value;
                    rpta = NPrestamo.crearPrestamo(codigoLibro, codigoProfesor, DateTime.Today, fechaDevolucion);

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha realizado el prestamo");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.listarPrestamosProfesor(codigoProfesor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
