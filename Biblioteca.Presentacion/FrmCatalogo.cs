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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
