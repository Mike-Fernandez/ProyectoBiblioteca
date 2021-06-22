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

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
