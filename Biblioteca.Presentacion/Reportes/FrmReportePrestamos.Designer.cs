
namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReportePrestamos
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
            this.RptPrestamos1 = new Biblioteca.Presentacion.Reportes.RptPrestamos();
            this.dsBiblioteca1 = new Biblioteca.Presentacion.Reportes.DsBiblioteca();
            this.prestamo_listar_activosTableAdapter1 = new Biblioteca.Presentacion.Reportes.DsBibliotecaTableAdapters.prestamo_listar_activosTableAdapter();
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
            this.crystalReportViewer1.ReportSource = this.RptPrestamos1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1117, 684);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsBiblioteca1
            // 
            this.dsBiblioteca1.DataSetName = "DsBiblioteca";
            this.dsBiblioteca1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamo_listar_activosTableAdapter1
            // 
            this.prestamo_listar_activosTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 684);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmReportePrestamos";
            this.Text = "Reporte de Prestamos";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBiblioteca1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RptPrestamos RptPrestamos1;
        private DsBiblioteca dsBiblioteca1;
        private DsBibliotecaTableAdapters.prestamo_listar_activosTableAdapter prestamo_listar_activosTableAdapter1;
    }
}