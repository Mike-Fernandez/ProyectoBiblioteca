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
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            this.prestamo_listar_activosTableAdapter1.Fill(this.dsBiblioteca1.prestamo_listar_activos);
            this.RptPrestamos1.SetDataSource(this.dsBiblioteca1);
            this.crystalReportViewer1.ReportSource = RptPrestamos1;
        }
    }
}
