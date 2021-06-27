
namespace Biblioteca.Presentacion
{
    partial class FrmDevolucion
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
            this.gboxBuscarProfesor = new System.Windows.Forms.GroupBox();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.dgvListadoProfesores = new System.Windows.Forms.DataGridView();
            this.SeleccionarProfesor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gboxPrestamosActivos = new System.Windows.Forms.GroupBox();
            this.dgvPrestamosProfesor = new System.Windows.Forms.DataGridView();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.SeleccionarPrestamo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gboxBuscarProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProfesores)).BeginInit();
            this.gboxPrestamosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBuscarProfesor
            // 
            this.gboxBuscarProfesor.Controls.Add(this.btnBuscarProfesor);
            this.gboxBuscarProfesor.Controls.Add(this.txtBuscarProfesor);
            this.gboxBuscarProfesor.Controls.Add(this.dgvListadoProfesores);
            this.gboxBuscarProfesor.Location = new System.Drawing.Point(12, 12);
            this.gboxBuscarProfesor.Name = "gboxBuscarProfesor";
            this.gboxBuscarProfesor.Size = new System.Drawing.Size(516, 291);
            this.gboxBuscarProfesor.TabIndex = 2;
            this.gboxBuscarProfesor.TabStop = false;
            this.gboxBuscarProfesor.Text = "Busqueda de profesor";
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Location = new System.Drawing.Point(296, 34);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarProfesor.TabIndex = 2;
            this.btnBuscarProfesor.Text = "Buscar";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(6, 37);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(254, 20);
            this.txtBuscarProfesor.TabIndex = 1;
            // 
            // dgvListadoProfesores
            // 
            this.dgvListadoProfesores.AllowUserToAddRows = false;
            this.dgvListadoProfesores.AllowUserToDeleteRows = false;
            this.dgvListadoProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarProfesor});
            this.dgvListadoProfesores.Location = new System.Drawing.Point(6, 67);
            this.dgvListadoProfesores.Name = "dgvListadoProfesores";
            this.dgvListadoProfesores.ReadOnly = true;
            this.dgvListadoProfesores.Size = new System.Drawing.Size(504, 218);
            this.dgvListadoProfesores.TabIndex = 0;
            this.dgvListadoProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProfesores_CellContentClick);
            // 
            // SeleccionarProfesor
            // 
            this.SeleccionarProfesor.HeaderText = "Seleccionar";
            this.SeleccionarProfesor.Name = "SeleccionarProfesor";
            this.SeleccionarProfesor.ReadOnly = true;
            // 
            // gboxPrestamosActivos
            // 
            this.gboxPrestamosActivos.Controls.Add(this.dgvPrestamosProfesor);
            this.gboxPrestamosActivos.Location = new System.Drawing.Point(18, 309);
            this.gboxPrestamosActivos.Name = "gboxPrestamosActivos";
            this.gboxPrestamosActivos.Size = new System.Drawing.Size(717, 195);
            this.gboxPrestamosActivos.TabIndex = 3;
            this.gboxPrestamosActivos.TabStop = false;
            this.gboxPrestamosActivos.Text = "Préstamos activos del profesor";
            // 
            // dgvPrestamosProfesor
            // 
            this.dgvPrestamosProfesor.AllowUserToAddRows = false;
            this.dgvPrestamosProfesor.AllowUserToDeleteRows = false;
            this.dgvPrestamosProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarPrestamo});
            this.dgvPrestamosProfesor.Location = new System.Drawing.Point(6, 24);
            this.dgvPrestamosProfesor.Name = "dgvPrestamosProfesor";
            this.dgvPrestamosProfesor.ReadOnly = true;
            this.dgvPrestamosProfesor.Size = new System.Drawing.Size(705, 150);
            this.dgvPrestamosProfesor.TabIndex = 0;
            this.dgvPrestamosProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamosProfesor_CellContentClick);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(588, 230);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(157, 44);
            this.btnDevolucion.TabIndex = 4;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // SeleccionarPrestamo
            // 
            this.SeleccionarPrestamo.HeaderText = "Seleccionar";
            this.SeleccionarPrestamo.Name = "SeleccionarPrestamo";
            this.SeleccionarPrestamo.ReadOnly = true;
            this.SeleccionarPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarPrestamo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.gboxPrestamosActivos);
            this.Controls.Add(this.gboxBuscarProfesor);
            this.Name = "FrmDevolucion";
            this.Text = "FrmDevolucion";
            this.Load += new System.EventHandler(this.FrmDevolucion_Load);
            this.gboxBuscarProfesor.ResumeLayout(false);
            this.gboxBuscarProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProfesores)).EndInit();
            this.gboxPrestamosActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBuscarProfesor;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.DataGridView dgvListadoProfesores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarProfesor;
        private System.Windows.Forms.GroupBox gboxPrestamosActivos;
        private System.Windows.Forms.DataGridView dgvPrestamosProfesor;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarPrestamo;
    }
}