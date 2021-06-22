
namespace Biblioteca.Presentacion
{
    partial class FrmCatalogo
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
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoLibros
            // 
            this.dgvListadoLibros.AllowUserToAddRows = false;
            this.dgvListadoLibros.AllowUserToDeleteRows = false;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.ReadOnly = true;
            this.dgvListadoLibros.Size = new System.Drawing.Size(776, 426);
            this.dgvListadoLibros.TabIndex = 0;
            // 
            // FrmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListadoLibros);
            this.Name = "FrmSeleccion";
            this.Text = "FrmLibro";
            this.Load += new System.EventHandler(this.FrmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoLibros;
    }
}