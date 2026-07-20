namespace eduCafeEquipo4
{
    partial class frmCategoriasAdmin
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelMenu = new System.Windows.Forms.Panel();
            this.lineaMenu = new System.Windows.Forms.Panel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblEduCafe = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();

            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelInformacionCategoria = new System.Windows.Forms.Panel();
            this.lblTituloInformacion = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.lblNota = new System.Windows.Forms.Label();

            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panelInformacionCategoria.SuspendLayout();
            this.SuspendLayout();

            // panelMenu
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.lineaMenu);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblSistema);
            this.panelMenu.Controls.Add(this.lblEduCafe);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 739);
            this.panelMenu.TabIndex = 0;

            // lineaMenu
            this.lineaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.lineaMenu.Location = new System.Drawing.Point(25, 660);
            this.lineaMenu.Name = "lineaMenu";
            this.lineaMenu.Size = new System.Drawing.Size(180, 1);
            this.lineaMenu.TabIndex = 10;

            // lblSistema
            this.lblSistema.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(10, 165);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(210, 25);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Sistema de control de ventas";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblEduCafe
            this.lblEduCafe.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEduCafe.ForeColor = System.Drawing.Color.White;
            this.lblEduCafe.Location = new System.Drawing.Point(15, 130);
            this.lblEduCafe.Name = "lblEduCafe";
            this.lblEduCafe.Size = new System.Drawing.Size(200, 35);
            this.lblEduCafe.TabIndex = 1;
            this.lblEduCafe.Text = "Edu Café";
            this.lblEduCafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnCerrarSesion
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminSalirB;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 667);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(230, 40);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "  Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;

            // btnReportes
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminReportesB;
            this.btnReportes.Location = new System.Drawing.Point(0, 405);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(230, 38);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;

            // btnUsuarios
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminUsersB;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 367);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(230, 38);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "  Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;

            // btnProveedores
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminProovedoresB;
            this.btnProveedores.Location = new System.Drawing.Point(0, 329);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(230, 38);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "  Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;

            // btnInventario
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminInventarioB;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 291);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(230, 38);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "  Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;

            // btnProductos
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminProductosB;
            this.btnProductos.Location = new System.Drawing.Point(0, 253);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(230, 38);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "  Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;

            // btnInicio
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(85)))));
            this.btnInicio.Image = global::eduCafeEquipo4.Properties.Resources.imicio_admin_verde;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 214);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(230, 38);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "  Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;

            // picLogo
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::eduCafeEquipo4.Properties.Resources.EDU_CAFÉ__1___1___2_;
            this.picLogo.Location = new System.Drawing.Point(65, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblTitulo.Location = new System.Drawing.Point(270, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Categorías";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(273, 66);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(151, 18);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Administra categorías";

            // lblBuscarCategoria
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblBuscarCategoria.Location = new System.Drawing.Point(270, 103);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(71, 17);
            this.lblBuscarCategoria.TabIndex = 3;
            this.lblBuscarCategoria.Text = "Categoría";

            // txtBuscarCategoria
            this.txtBuscarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtBuscarCategoria.Location = new System.Drawing.Point(270, 124);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(215, 27);
            this.txtBuscarCategoria.TabIndex = 4;

            // btnNuevaCategoria
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(50, 105, 65);
            this.btnNuevaCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 78, 49);
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Roboto", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(505, 122);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(140, 30);
            this.btnNuevaCategoria.TabIndex = 5;
            this.btnNuevaCategoria.Text = "Nueva categoría";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;

            // dgvCategorias
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(250, 248, 242);
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(245, 240, 230);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(245, 240, 230);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeight = 38;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdCategoria,
                this.colNombreCategoria,
                this.colDescripcion,
                this.colAcciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(250, 248, 242);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(226, 235, 226);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(225, 220, 210);
            this.dgvCategorias.Location = new System.Drawing.Point(270, 165);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 36;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(515, 470);
            this.dgvCategorias.TabIndex = 6;

            // colIdCategoria
            this.colIdCategoria.FillWeight = 70F;
            this.colIdCategoria.HeaderText = "ID";
            this.colIdCategoria.MinimumWidth = 6;
            this.colIdCategoria.Name = "colIdCategoria";
            this.colIdCategoria.ReadOnly = true;

            // colNombreCategoria
            this.colNombreCategoria.FillWeight = 135F;
            this.colNombreCategoria.HeaderText = "Nombre de la categoría";
            this.colNombreCategoria.MinimumWidth = 6;
            this.colNombreCategoria.Name = "colNombreCategoria";
            this.colNombreCategoria.ReadOnly = true;

            // colDescripcion
            this.colDescripcion.FillWeight = 170F;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;

            // colAcciones
            this.colAcciones.FillWeight = 80F;
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;

            // panelInformacionCategoria
            this.panelInformacionCategoria.BackColor = System.Drawing.Color.FromArgb(237, 224, 204);
            this.panelInformacionCategoria.Controls.Add(this.btnGuardar);
            this.panelInformacionCategoria.Controls.Add(this.cmbEstado);
            this.panelInformacionCategoria.Controls.Add(this.lblEstado);
            this.panelInformacionCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.panelInformacionCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.panelInformacionCategoria.Controls.Add(this.txtNombreCategoria);
            this.panelInformacionCategoria.Controls.Add(this.lblNombreCategoria);
            this.panelInformacionCategoria.Controls.Add(this.lblTituloInformacion);
            this.panelInformacionCategoria.Location = new System.Drawing.Point(805, 95);
            this.panelInformacionCategoria.Name = "panelInformacionCategoria";
            this.panelInformacionCategoria.Size = new System.Drawing.Size(350, 540);
            this.panelInformacionCategoria.TabIndex = 7;

            // lblTituloInformacion
            this.lblTituloInformacion.AutoSize = true;
            this.lblTituloInformacion.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloInformacion.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblTituloInformacion.Location = new System.Drawing.Point(20, 18);
            this.lblTituloInformacion.Name = "lblTituloInformacion";
            this.lblTituloInformacion.Size = new System.Drawing.Size(220, 23);
            this.lblTituloInformacion.TabIndex = 0;
            this.lblTituloInformacion.Text = "Información de la categoría";

            // lblNombreCategoria
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblNombreCategoria.Location = new System.Drawing.Point(20, 57);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(149, 17);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre de la categoría";

            // txtNombreCategoria
            this.txtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtNombreCategoria.Location = new System.Drawing.Point(20, 78);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(310, 27);
            this.txtNombreCategoria.TabIndex = 2;

            // lblDescripcionCategoria
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblDescripcionCategoria.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(20, 117);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(79, 17);
            this.lblDescripcionCategoria.TabIndex = 3;
            this.lblDescripcionCategoria.Text = "Descripción";

            // txtDescripcionCategoria
            this.txtDescripcionCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionCategoria.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(20, 138);
            this.txtDescripcionCategoria.Multiline = true;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(310, 130);
            this.txtDescripcionCategoria.TabIndex = 4;

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblEstado.Location = new System.Drawing.Point(20, 290);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 17);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";

            // cmbEstado
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Roboto", 9F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(20, 311);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(310, 26);
            this.cmbEstado.TabIndex = 6;

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(37, 124, 68);
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 91, 52);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(115, 390);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 43);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;

            // lblNota
            this.lblNota.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(90, 58, 35);
            this.lblNota.Location = new System.Drawing.Point(270, 650);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(885, 35);
            this.lblNota.TabIndex = 8;
            this.lblNota.Text = "Desde esta sección puedes agregar, editar, eliminar y consultar las categorías.";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // frmCategoriasAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1196, 739);
            this.Size = new System.Drawing.Size(1196, 739);
            this.MinimumSize = new System.Drawing.Size(1196, 739);
            this.MaximumSize = new System.Drawing.Size(1196, 739);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.panelInformacionCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnNuevaCategoria);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.lblBuscarCategoria);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCategoriasAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";

            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panelInformacionCategoria.ResumeLayout(false);
            this.panelInformacionCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEduCafe;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel lineaMenu;
        private System.Windows.Forms.Button btnCerrarSesion;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Button btnNuevaCategoria;

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcciones;

        private System.Windows.Forms.Panel panelInformacionCategoria;
        private System.Windows.Forms.Label lblTituloInformacion;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNota;
    }
}

