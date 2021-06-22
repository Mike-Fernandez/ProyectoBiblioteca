
namespace Biblioteca.Presentacion
{
    partial class FrmPrestamo
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
            this.gboxbuscarLibro = new System.Windows.Forms.GroupBox();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.gboxBuscarProfesor = new System.Windows.Forms.GroupBox();
            this.gboxPrestamosActivos = new System.Windows.Forms.GroupBox();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.cboBuscarLibro = new System.Windows.Forms.ComboBox();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.dgvListadoProfesores = new System.Windows.Forms.DataGridView();
            this.SeleccionarProfesor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SeleccionarLibros = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.dgvPrestamosProfesor = new System.Windows.Forms.DataGridView();
            this.gboxbuscarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            this.gboxBuscarProfesor.SuspendLayout();
            this.gboxPrestamosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxbuscarLibro
            // 
            this.gboxbuscarLibro.Controls.Add(this.btnBuscarLibro);
            this.gboxbuscarLibro.Controls.Add(this.cboBuscarLibro);
            this.gboxbuscarLibro.Controls.Add(this.txtBuscarLibro);
            this.gboxbuscarLibro.Controls.Add(this.dgvListadoLibros);
            this.gboxbuscarLibro.Location = new System.Drawing.Point(33, 33);
            this.gboxbuscarLibro.Name = "gboxbuscarLibro";
            this.gboxbuscarLibro.Size = new System.Drawing.Size(551, 291);
            this.gboxbuscarLibro.TabIndex = 0;
            this.gboxbuscarLibro.TabStop = false;
            this.gboxbuscarLibro.Text = "Busqueda de Libros";
            // 
            // dgvListadoLibros
            // 
            this.dgvListadoLibros.AllowUserToAddRows = false;
            this.dgvListadoLibros.AllowUserToDeleteRows = false;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarLibros});
            this.dgvListadoLibros.Location = new System.Drawing.Point(6, 67);
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.ReadOnly = true;
            this.dgvListadoLibros.Size = new System.Drawing.Size(539, 218);
            this.dgvListadoLibros.TabIndex = 0;
            this.dgvListadoLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoLibros_CellContentClick);
            // 
            // gboxBuscarProfesor
            // 
            this.gboxBuscarProfesor.Controls.Add(this.btnBuscarProfesor);
            this.gboxBuscarProfesor.Controls.Add(this.txtBuscarProfesor);
            this.gboxBuscarProfesor.Controls.Add(this.dgvListadoProfesores);
            this.gboxBuscarProfesor.Location = new System.Drawing.Point(617, 33);
            this.gboxBuscarProfesor.Name = "gboxBuscarProfesor";
            this.gboxBuscarProfesor.Size = new System.Drawing.Size(516, 291);
            this.gboxBuscarProfesor.TabIndex = 1;
            this.gboxBuscarProfesor.TabStop = false;
            this.gboxBuscarProfesor.Text = "Busqueda de profesor";
            // 
            // gboxPrestamosActivos
            // 
            this.gboxPrestamosActivos.Controls.Add(this.dgvPrestamosProfesor);
            this.gboxPrestamosActivos.Location = new System.Drawing.Point(33, 361);
            this.gboxPrestamosActivos.Name = "gboxPrestamosActivos";
            this.gboxPrestamosActivos.Size = new System.Drawing.Size(717, 195);
            this.gboxPrestamosActivos.TabIndex = 2;
            this.gboxPrestamosActivos.TabStop = false;
            this.gboxPrestamosActivos.Text = "Préstamos activos del profesor";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(833, 385);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(250, 20);
            this.dtpDevolucion.TabIndex = 3;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(833, 361);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(135, 13);
            this.lblFechaDevolucion.TabIndex = 4;
            this.lblFechaDevolucion.Text = "Fecha límite de devolución";
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(854, 464);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(201, 42);
            this.btnPrestamo.TabIndex = 5;
            this.btnPrestamo.Text = "Registrar Préstamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(438, 37);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarLibro.TabIndex = 5;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // cboBuscarLibro
            // 
            this.cboBuscarLibro.FormattingEnabled = true;
            this.cboBuscarLibro.Items.AddRange(new object[] {
            "Titulo",
            "Autor"});
            this.cboBuscarLibro.Location = new System.Drawing.Point(300, 40);
            this.cboBuscarLibro.Name = "cboBuscarLibro";
            this.cboBuscarLibro.Size = new System.Drawing.Size(121, 21);
            this.cboBuscarLibro.TabIndex = 4;
            this.cboBuscarLibro.Text = "Titulo";
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(6, 40);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(288, 20);
            this.txtBuscarLibro.TabIndex = 3;
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
            // SeleccionarLibros
            // 
            this.SeleccionarLibros.HeaderText = "Seleccionar";
            this.SeleccionarLibros.Name = "SeleccionarLibros";
            this.SeleccionarLibros.ReadOnly = true;
            this.SeleccionarLibros.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarLibros.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(6, 37);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(254, 20);
            this.txtBuscarProfesor.TabIndex = 1;
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Location = new System.Drawing.Point(296, 34);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarProfesor.TabIndex = 2;
            this.btnBuscarProfesor.Text = "Buscar";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamosProfesor
            // 
            this.dgvPrestamosProfesor.AllowUserToAddRows = false;
            this.dgvPrestamosProfesor.AllowUserToDeleteRows = false;
            this.dgvPrestamosProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosProfesor.Location = new System.Drawing.Point(6, 24);
            this.dgvPrestamosProfesor.Name = "dgvPrestamosProfesor";
            this.dgvPrestamosProfesor.ReadOnly = true;
            this.dgvPrestamosProfesor.Size = new System.Drawing.Size(705, 150);
            this.dgvPrestamosProfesor.TabIndex = 0;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 577);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.gboxPrestamosActivos);
            this.Controls.Add(this.gboxBuscarProfesor);
            this.Controls.Add(this.gboxbuscarLibro);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.gboxbuscarLibro.ResumeLayout(false);
            this.gboxbuscarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            this.gboxBuscarProfesor.ResumeLayout(false);
            this.gboxBuscarProfesor.PerformLayout();
            this.gboxPrestamosActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxbuscarLibro;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.GroupBox gboxBuscarProfesor;
        private System.Windows.Forms.GroupBox gboxPrestamosActivos;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.ComboBox cboBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.DataGridView dgvListadoProfesores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarLibros;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarProfesor;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.DataGridView dgvPrestamosProfesor;
    }
}