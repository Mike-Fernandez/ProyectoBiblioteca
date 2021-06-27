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
    public partial class FrmDevolucion : Form
    {
        public FrmDevolucion()
        {
            InitializeComponent();
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

        private void listarPrestamosProfesor()
        {
            try
            {
                foreach (DataGridViewRow row in dgvListadoProfesores.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        int id = Convert.ToInt32(row.Cells[1].Value);
                        dgvPrestamosProfesor.DataSource = NPrestamo.ListarPorProfesor(id);
                        break;
                    }
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
                dgvListadoProfesores.DataSource = NUsuario.BuscarProfesor(txtBuscarProfesor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            this.listarProfesores();
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            this.BuscarProfesor();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea devolver este prestamo?", "Sistema de biblioteca",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigoPrestamo = -1;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgvPrestamosProfesor.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigoPrestamo = Convert.ToInt32(row.Cells[1].Value);
                            break;
                        }
                    }
                    rpta = NPrestamo.devolverPrestamo(codigoPrestamo);

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha devuelto el prestamo satisfactoriamente");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.listarPrestamosProfesor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListadoProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoProfesores.Columns["SeleccionarProfesor"].Index)
            {
                DataGridViewCheckBoxCell chckSeleccionar = (DataGridViewCheckBoxCell)dgvListadoProfesores.Rows[e.RowIndex].Cells["SeleccionarProfesor"];
                chckSeleccionar.Value = !Convert.ToBoolean(chckSeleccionar.Value);
                this.listarPrestamosProfesor();
            }
        }

        private void dgvPrestamosProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPrestamosProfesor.Columns["SeleccionarPrestamo"].Index)
            {
                DataGridViewCheckBoxCell chckSeleccionar = (DataGridViewCheckBoxCell)dgvPrestamosProfesor.Rows[e.RowIndex].Cells["SeleccionarPrestamo"];
                chckSeleccionar.Value = !Convert.ToBoolean(chckSeleccionar.Value);
            }
        }
    }
}
