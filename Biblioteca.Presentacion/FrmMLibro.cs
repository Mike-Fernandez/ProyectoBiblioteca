using System;
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
    public partial class FrmMLibro : Form
    {
        public FrmMLibro()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvListado.DataSource = NLibro.listarAvailable();
                this.Formato();
                lblTotal.Text = "Total registros " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                if (Convert.ToString(cboBuscar.SelectedValue) == "Titulo")
                {
                    dgvListado.DataSource = NLibro.buscarTituloAvailable(txtBuscar.Text);
                    lblTotal.Text = "Total registros " + Convert.ToString(dgvListado.Rows.Count);
                }
                else if (Convert.ToString(cboBuscar.SelectedValue) == "Autor")
                {
                    dgvListado.DataSource = NLibro.buscarAutorAvailable(txtBuscar.Text);
                    lblTotal.Text = "Total registros " + Convert.ToString(dgvListado.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            dgvListado.Columns[0].Visible = false;
            btnActualizar.Visible = false;
        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            txtAutor.Clear();
            txtEditionYear.Clear();
            txtEditorial.Clear();
            txtId.Clear();
            txtIdioma.Clear();
            txtIsbn.Clear();
            txtNumeroEdicion.Clear();
            numudNumeroEjemplares.Value = 0;
            txtPais.Clear();
            txtTitulo.Clear();
            txtUbicacion.Clear();
            txtDescripcion.Clear();
            numudNumeroPaginas.Value = 0;
            errorIcono.Clear();

            dgvListado.Columns[0].Visible = false;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;
            chckSeleccionar.Checked = false;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.Formato();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtTitulo.Text == string.Empty || txtAutor.Text == string.Empty || numudNumeroEjemplares.Value < 1 || txtIsbn.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados.");
                    errorIcono.SetError(numudNumeroEjemplares, "Se debe de insertar por lo menos un ejemplar del libro");
                    errorIcono.SetError(txtIsbn, "Ingrese el codigo isbn del libro");
                    errorIcono.SetError(txtTitulo, "Ingrese el titulo del libro.");
                    errorIcono.SetError(txtAutor, "Ingrese el autor del libro.");
                }
                else
                {
                    rpta = NLibro.Insertar(Convert.ToInt32(numudNumeroEjemplares.Value), Convert.ToInt32(txtIsbn.Text), txtTitulo.Text.Trim(),
                        txtAutor.Text.Trim(), txtEditorial.Text.Trim(), txtEditionYear.Text.Trim(), Convert.ToInt32(txtNumeroEdicion.Text),
                        txtPais.Text.Trim(), txtIdioma.Text.Trim(), Convert.ToString(cboMateria.SelectedValue), Convert.ToInt32(numudNumeroPaginas.Value),
                        txtUbicacion.Text.Trim(), txtDescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtTitulo.Text == string.Empty || txtAutor.Text == string.Empty || numudNumeroEjemplares.Value < 1 || txtIsbn.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados.");
                    errorIcono.SetError(numudNumeroEjemplares, "Se debe de insertar por lo menos un ejemplar del libro");
                    errorIcono.SetError(txtIsbn, "Ingrese el codigo isbn del libro");
                    errorIcono.SetError(txtTitulo, "Ingrese el titulo del libro.");
                    errorIcono.SetError(txtAutor, "Ingrese el autor del libro.");
                }
                else
                {
                    rpta = NLibro.Actualizar(Convert.ToInt32(numudNumeroEjemplares.Value), Convert.ToInt32(txtIsbn.Text), txtTitulo.Text.Trim(),
                        txtAutor.Text.Trim(), txtEditorial.Text.Trim(), txtEditionYear.Text.Trim(), Convert.ToInt32(txtNumeroEdicion.Text),
                        txtPais.Text.Trim(), txtIdioma.Text.Trim(), Convert.ToString(cboMateria.SelectedValue), Convert.ToInt32(numudNumeroPaginas.Value),
                        txtUbicacion.Text.Trim(), txtDescripcion.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizo de forma correcta el registro");
                        this.Listar();
                        tabMLibros.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabMLibros.SelectedIndex = 0;
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chckEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                chckEliminar.Value = !Convert.ToBoolean(chckEliminar.Value);
            }
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtId.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Código"].Value);
                numudNumeroEjemplares.Value = Convert.ToDecimal(dgvListado.CurrentRow.Cells["Número de ejemplares"].Value);
                txtIsbn.Text = Convert.ToString(dgvListado.CurrentRow.Cells["ISBN"].Value);
                txtTitulo.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Título"].Value);
                txtAutor.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Autor"].Value);
                txtEditorial.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Editorial"].Value);
                txtEditionYear.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Año de edición"].Value);
                txtNumeroEdicion.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Número de edición"].Value);
                txtPais.Text = Convert.ToString(dgvListado.CurrentRow.Cells["País"].Value);
                txtIdioma.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Idioma"].Value);
                cboMateria.SelectedValue = Convert.ToString(dgvListado.CurrentRow.Cells["Materia"]);
                numudNumeroPaginas.Value = Convert.ToDecimal(dgvListado.CurrentRow.Cells["Número de páginas"].Value);
                txtUbicacion.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Ubicación"].Value);
                txtDescripcion.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Descripción"].Value);
                tabMLibros.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "| Error: " + ex.Message);
            }
        }

        private void chckSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSeleccionar.Checked)
            {
                dgvListado.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvListado.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de biblioteca",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";
                    string imagen = "";

                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            imagen = Convert.ToString(row.Cells[9].Value);
                            rpta = NLibro.Eliminar(codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[4].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
