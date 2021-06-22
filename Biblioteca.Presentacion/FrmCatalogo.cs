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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dgvListadoLibros.DataSource = NLibro.listarTodos();
                lblTotal.Text = "Total registros " + Convert.ToString(dgvListadoLibros.Rows.Count);
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
                    dgvListadoLibros.DataSource = NLibro.buscarTitulo(txtBuscar.Text);
                    lblTotal.Text = "Total registros " + Convert.ToString(dgvListadoLibros.Rows.Count);
                } else if (Convert.ToString(cboBuscar.SelectedValue) == "Autor")
                {
                    dgvListadoLibros.DataSource = NLibro.buscarAutor(txtBuscar.Text);
                    lblTotal.Text = "Total registros " + Convert.ToString(dgvListadoLibros.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
            txtBuscar.Clear();
            errorIcono.Clear();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
