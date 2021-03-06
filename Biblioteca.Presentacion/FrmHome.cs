using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion
{
    public partial class FrmHome : Form
    {
        private int childFormNumber = 0;
        public int idUsuario;
        public int idRol;
        public string nombreRol;
        public string nombre;


        public FrmHome()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

//        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
//        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void seleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatalogo frm = new FrmCatalogo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del sistema?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMLibro frm = new FrmMLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo frm = new FrmPrestamo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido: " + this.nombre, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.nombreRol.Equals("Admin"))
            {
                MnuMantenimiento.Enabled = true;
                MnuConsultar.Enabled = true;
            }
            else
            {
                MnuMantenimiento.Enabled = false;
                MnuConsultar.Enabled = true;
            }
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucion frm = new FrmDevolucion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void librosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteLibros reporte = new Reportes.FrmReporteLibros();
            reporte.ShowDialog();
        }

        private void prestamosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportePrestamos reporte = new Reportes.FrmReportePrestamos();
            reporte.ShowDialog();
        }
    }
}
