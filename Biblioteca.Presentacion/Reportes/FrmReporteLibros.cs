using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion.Reportes
{
    public partial class FrmReporteLibros : Form
    {
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            this.libro_listar_reporteTableAdapter1.Fill(this.dsBiblioteca1.libro_listar_reporte);
            this.RptLibros1.SetDataSource(this.dsBiblioteca1);
            this.crystalReportViewer1.ReportSource = RptLibros1;
        }
    }
}
