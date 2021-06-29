
namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReporteLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptLibros1 = new Biblioteca.Presentacion.Reportes.RptLibros();
            this.dsBiblioteca1 = new Biblioteca.Presentacion.Reportes.DsBiblioteca();
            this.libro_listar_reporteTableAdapter1 = new Biblioteca.Presentacion.Reportes.DsBibliotecaTableAdapters.libro_listar_reporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBiblioteca1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RptLibros1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1353, 722);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // dsBiblioteca1
            // 
            this.dsBiblioteca1.DataSetName = "DsBiblioteca";
            this.dsBiblioteca1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libro_listar_reporteTableAdapter1
            // 
            this.libro_listar_reporteTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 722);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmReporteLibros";
            this.Text = "Reporte de Libros";
            this.Load += new System.EventHandler(this.FrmReporteLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBiblioteca1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RptLibros RptLibros1;
        private DsBiblioteca dsBiblioteca1;
        private DsBibliotecaTableAdapters.libro_listar_reporteTableAdapter libro_listar_reporteTableAdapter1;
    }
}