
namespace Biblioteca.Presentacion
{
    partial class FrmMLibro
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
            this.components = new System.ComponentModel.Container();
            this.tabMLibros = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chckSeleccionar = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNumeroEjemplares = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditionYear = new System.Windows.Forms.TextBox();
            this.lblEditionYear = new System.Windows.Forms.Label();
            this.txtNumeroEdicion = new System.Windows.Forms.TextBox();
            this.lblNumeroEdicion = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.Label();
            this.lblNumeroPaginas = new System.Windows.Forms.Label();
            this.numudNumeroPaginas = new System.Windows.Forms.NumericUpDown();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.numudNumeroEjemplares = new System.Windows.Forms.NumericUpDown();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabMLibros.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumeroPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumeroEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMLibros
            // 
            this.tabMLibros.Controls.Add(this.tabPage1);
            this.tabMLibros.Controls.Add(this.tabPage2);
            this.tabMLibros.Location = new System.Drawing.Point(12, 12);
            this.tabMLibros.Name = "tabMLibros";
            this.tabMLibros.SelectedIndex = 0;
            this.tabMLibros.Size = new System.Drawing.Size(776, 426);
            this.tabMLibros.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblActualizar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chckSeleccionar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.dgvListado);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.cboBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numudNumeroEjemplares);
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.lblDescripcion);
            this.tabPage2.Controls.Add(this.txtUbicacion);
            this.tabPage2.Controls.Add(this.lblUbicacion);
            this.tabPage2.Controls.Add(this.cboMateria);
            this.tabPage2.Controls.Add(this.numudNumeroPaginas);
            this.tabPage2.Controls.Add(this.lblNumeroPaginas);
            this.tabPage2.Controls.Add(this.Materia);
            this.tabPage2.Controls.Add(this.txtIdioma);
            this.tabPage2.Controls.Add(this.lblIdioma);
            this.tabPage2.Controls.Add(this.txtPais);
            this.tabPage2.Controls.Add(this.lblPais);
            this.tabPage2.Controls.Add(this.txtNumeroEdicion);
            this.tabPage2.Controls.Add(this.lblNumeroEdicion);
            this.tabPage2.Controls.Add(this.txtEditionYear);
            this.tabPage2.Controls.Add(this.lblEditionYear);
            this.tabPage2.Controls.Add(this.txtEditorial);
            this.tabPage2.Controls.Add(this.lblEditorial);
            this.tabPage2.Controls.Add(this.txtAutor);
            this.tabPage2.Controls.Add(this.lblAutor);
            this.tabPage2.Controls.Add(this.txtTitulo);
            this.tabPage2.Controls.Add(this.lblTitulo);
            this.tabPage2.Controls.Add(this.txtIsbn);
            this.tabPage2.Controls.Add(this.lblISBN);
            this.tabPage2.Controls.Add(this.lblNumeroEjemplares);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(21, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // cboBuscar
            // 
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Titulo",
            "Autor"});
            this.cboBuscar.Location = new System.Drawing.Point(405, 18);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboBuscar.TabIndex = 1;
            this.cboBuscar.Text = "Titulo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(549, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListado.Location = new System.Drawing.Point(21, 58);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(721, 287);
            this.dgvListado.TabIndex = 3;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(130, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chckSeleccionar
            // 
            this.chckSeleccionar.AutoSize = true;
            this.chckSeleccionar.Location = new System.Drawing.Point(21, 366);
            this.chckSeleccionar.Name = "chckSeleccionar";
            this.chckSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.chckSeleccionar.TabIndex = 5;
            this.chckSeleccionar.Text = "Seleccionar";
            this.chckSeleccionar.UseVisualStyleBackColor = true;
            this.chckSeleccionar.CheckedChanged += new System.EventHandler(this.chckSeleccionar_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(622, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Location = new System.Drawing.Point(262, 360);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(321, 13);
            this.lblActualizar.TabIndex = 7;
            this.lblActualizar.Text = "Para actualizar la informacion de un libro haga doble click sobre el ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(232, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblNumeroEjemplares
            // 
            this.lblNumeroEjemplares.AutoSize = true;
            this.lblNumeroEjemplares.Location = new System.Drawing.Point(6, 58);
            this.lblNumeroEjemplares.Name = "lblNumeroEjemplares";
            this.lblNumeroEjemplares.Size = new System.Drawing.Size(113, 13);
            this.lblNumeroEjemplares.TabIndex = 1;
            this.lblNumeroEjemplares.Text = "Numero de Ejemplares";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(9, 94);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 3;
            this.lblISBN.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(125, 91);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(207, 20);
            this.txtIsbn.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(125, 136);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(207, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 136);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(125, 177);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(207, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(9, 177);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(125, 222);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(207, 20);
            this.txtEditorial.TabIndex = 10;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(9, 229);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 9;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditionYear
            // 
            this.txtEditionYear.Location = new System.Drawing.Point(125, 265);
            this.txtEditionYear.Name = "txtEditionYear";
            this.txtEditionYear.Size = new System.Drawing.Size(207, 20);
            this.txtEditionYear.TabIndex = 12;
            // 
            // lblEditionYear
            // 
            this.lblEditionYear.AutoSize = true;
            this.lblEditionYear.Location = new System.Drawing.Point(9, 272);
            this.lblEditionYear.Name = "lblEditionYear";
            this.lblEditionYear.Size = new System.Drawing.Size(78, 13);
            this.lblEditionYear.TabIndex = 11;
            this.lblEditionYear.Text = "Año de edicion";
            // 
            // txtNumeroEdicion
            // 
            this.txtNumeroEdicion.Location = new System.Drawing.Point(605, 55);
            this.txtNumeroEdicion.Name = "txtNumeroEdicion";
            this.txtNumeroEdicion.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEdicion.TabIndex = 14;
            // 
            // lblNumeroEdicion
            // 
            this.lblNumeroEdicion.AutoSize = true;
            this.lblNumeroEdicion.Location = new System.Drawing.Point(382, 55);
            this.lblNumeroEdicion.Name = "lblNumeroEdicion";
            this.lblNumeroEdicion.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroEdicion.TabIndex = 13;
            this.lblNumeroEdicion.Text = "Numero de Edicion";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(605, 95);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 16;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(382, 98);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "Pais";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(605, 139);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 20);
            this.txtIdioma.TabIndex = 18;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(382, 139);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 17;
            this.lblIdioma.Text = "Idioma";
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.Location = new System.Drawing.Point(382, 185);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(42, 13);
            this.Materia.TabIndex = 19;
            this.Materia.Text = "Materia";
            // 
            // lblNumeroPaginas
            // 
            this.lblNumeroPaginas.AutoSize = true;
            this.lblNumeroPaginas.Location = new System.Drawing.Point(382, 220);
            this.lblNumeroPaginas.Name = "lblNumeroPaginas";
            this.lblNumeroPaginas.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroPaginas.TabIndex = 21;
            this.lblNumeroPaginas.Text = "Numero de paginas";
            // 
            // numudNumeroPaginas
            // 
            this.numudNumeroPaginas.Location = new System.Drawing.Point(585, 213);
            this.numudNumeroPaginas.Name = "numudNumeroPaginas";
            this.numudNumeroPaginas.Size = new System.Drawing.Size(120, 20);
            this.numudNumeroPaginas.TabIndex = 22;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Items.AddRange(new object[] {
            "Matematicas",
            "Biologia",
            "Fisica",
            "Quimica",
            "Estudios Sociales",
            "Psicologia",
            "Mecanica de Fluidos"});
            this.cboMateria.Location = new System.Drawing.Point(584, 177);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(121, 21);
            this.cboMateria.TabIndex = 23;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(605, 251);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 25;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(382, 258);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 24;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(382, 310);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 26;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(465, 288);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(240, 96);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.Text = "";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(40, 329);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(115, 23);
            this.btnInsertar.TabIndex = 28;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(40, 329);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 23);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // numudNumeroEjemplares
            // 
            this.numudNumeroEjemplares.Location = new System.Drawing.Point(125, 51);
            this.numudNumeroEjemplares.Name = "numudNumeroEjemplares";
            this.numudNumeroEjemplares.Size = new System.Drawing.Size(207, 20);
            this.numudNumeroEjemplares.TabIndex = 31;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // FrmMLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMLibros);
            this.Name = "FrmMLibro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.FrmMLibro_Load);
            this.tabMLibros.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumeroPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumeroEjemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMLibros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chckSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.NumericUpDown numudNumeroPaginas;
        private System.Windows.Forms.Label lblNumeroPaginas;
        private System.Windows.Forms.Label Materia;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtNumeroEdicion;
        private System.Windows.Forms.Label lblNumeroEdicion;
        private System.Windows.Forms.TextBox txtEditionYear;
        private System.Windows.Forms.Label lblEditionYear;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblNumeroEjemplares;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.NumericUpDown numudNumeroEjemplares;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}