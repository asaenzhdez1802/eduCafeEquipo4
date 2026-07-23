namespace eduCafeEquipo4
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lineaMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblEduCafe = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRoles = new System.Windows.Forms.Panel();
            this.lblDescripcionCajero = new System.Windows.Forms.Label();
            this.lblTituloCajero = new System.Windows.Forms.Label();
            this.lblDescripcionAdministrador = new System.Windows.Forms.Label();
            this.lblTituloAdministrador = new System.Windows.Forms.Label();
            this.lblTituloRoles = new System.Windows.Forms.Label();
            this.panelInformacionUsuario = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtNombresReales = new System.Windows.Forms.TextBox();
            this.lblNombresReales = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblTituloInformacion = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panelRoles.SuspendLayout();
            this.panelInformacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnCategoria);
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
            this.panelMenu.Size = new System.Drawing.Size(200, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.Location = new System.Drawing.Point(4, 366);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(200, 38);
            this.btnCategoria.TabIndex = 14;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminSalirB;
            this.btnCerrarSesion.Location = new System.Drawing.Point(-16, 648);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(230, 40);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "  Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lineaMenu
            // 
            this.lineaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.lineaMenu.Location = new System.Drawing.Point(13, 647);
            this.lineaMenu.Name = "lineaMenu";
            this.lineaMenu.Size = new System.Drawing.Size(180, 1);
            this.lineaMenu.TabIndex = 10;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminReportesB;
            this.btnReportes.Location = new System.Drawing.Point(0, 450);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(230, 38);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnUsuarios.Image = global::eduCafeEquipo4.Properties.Resources.usuarios_admin_verde;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 410);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(230, 38);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "  Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProveedores
            // 
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
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnInventario
            // 
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
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProductos
            // 
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
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminInicioB;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 210);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(230, 38);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "  Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(-8, 165);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(210, 25);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "Sistema de control de ventas";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEduCafe
            // 
            this.lblEduCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEduCafe.ForeColor = System.Drawing.Color.White;
            this.lblEduCafe.Location = new System.Drawing.Point(-2, 130);
            this.lblEduCafe.Name = "lblEduCafe";
            this.lblEduCafe.Size = new System.Drawing.Size(200, 35);
            this.lblEduCafe.TabIndex = 1;
            this.lblEduCafe.Text = "Edu Café";
            this.lblEduCafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::eduCafeEquipo4.Properties.Resources.EDU_CAFÉ__1___1___2_;
            this.picLogo.Location = new System.Drawing.Point(47, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTitulo.Location = new System.Drawing.Point(243, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(287, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Usuarios";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(248, 66);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(375, 18);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Administra los usuarios que tienen acceso al sistema";
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblBuscarNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblBuscarNombre.Location = new System.Drawing.Point(244, 103);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(63, 18);
            this.lblBuscarNombre.TabIndex = 3;
            this.lblBuscarNombre.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombre.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtBuscarNombre.Location = new System.Drawing.Point(246, 124);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(215, 27);
            this.txtBuscarNombre.TabIndex = 4;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(105)))), ((int)(((byte)(65)))));
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Roboto", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(471, 122);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(135, 30);
            this.btnNuevoUsuario.TabIndex = 5;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 38;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUsuario,
            this.colUsuario,
            this.colNombreCompleto,
            this.colRol,
            this.colEstadoUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(246, 165);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 36;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(515, 330);
            this.dgvUsuarios.TabIndex = 6;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FillWeight = 60F;
            this.colIdUsuario.HeaderText = "ID";
            this.colIdUsuario.MinimumWidth = 6;
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.FillWeight = 95F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 6;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.FillWeight = 135F;
            this.colNombreCompleto.HeaderText = "Nombre completo";
            this.colNombreCompleto.MinimumWidth = 6;
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.FillWeight = 90F;
            this.colRol.HeaderText = "Rol";
            this.colRol.MinimumWidth = 6;
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // colEstadoUsuario
            // 
            this.colEstadoUsuario.FillWeight = 80F;
            this.colEstadoUsuario.HeaderText = "Estado";
            this.colEstadoUsuario.MinimumWidth = 6;
            this.colEstadoUsuario.Name = "colEstadoUsuario";
            this.colEstadoUsuario.ReadOnly = true;
            // 
            // panelRoles
            // 
            this.panelRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoles.Controls.Add(this.lblDescripcionCajero);
            this.panelRoles.Controls.Add(this.lblTituloCajero);
            this.panelRoles.Controls.Add(this.lblDescripcionAdministrador);
            this.panelRoles.Controls.Add(this.lblTituloAdministrador);
            this.panelRoles.Controls.Add(this.lblTituloRoles);
            this.panelRoles.Location = new System.Drawing.Point(245, 515);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(515, 120);
            this.panelRoles.TabIndex = 7;
            // 
            // lblDescripcionCajero
            // 
            this.lblDescripcionCajero.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionCajero.Location = new System.Drawing.Point(285, 65);
            this.lblDescripcionCajero.Name = "lblDescripcionCajero";
            this.lblDescripcionCajero.Size = new System.Drawing.Size(190, 45);
            this.lblDescripcionCajero.TabIndex = 4;
            this.lblDescripcionCajero.Text = "Puede realizar ventas y consultar productos";
            // 
            // lblTituloCajero
            // 
            this.lblTituloCajero.AutoSize = true;
            this.lblTituloCajero.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloCajero.Location = new System.Drawing.Point(285, 46);
            this.lblTituloCajero.Name = "lblTituloCajero";
            this.lblTituloCajero.Size = new System.Drawing.Size(51, 18);
            this.lblTituloCajero.TabIndex = 3;
            this.lblTituloCajero.Text = "Cajero";
            // 
            // lblDescripcionAdministrador
            // 
            this.lblDescripcionAdministrador.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionAdministrador.Location = new System.Drawing.Point(25, 65);
            this.lblDescripcionAdministrador.Name = "lblDescripcionAdministrador";
            this.lblDescripcionAdministrador.Size = new System.Drawing.Size(190, 45);
            this.lblDescripcionAdministrador.TabIndex = 2;
            this.lblDescripcionAdministrador.Text = "Acceso completo a todas las funciones del sistema";
            // 
            // lblTituloAdministrador
            // 
            this.lblTituloAdministrador.AutoSize = true;
            this.lblTituloAdministrador.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloAdministrador.Location = new System.Drawing.Point(25, 46);
            this.lblTituloAdministrador.Name = "lblTituloAdministrador";
            this.lblTituloAdministrador.Size = new System.Drawing.Size(102, 18);
            this.lblTituloAdministrador.TabIndex = 1;
            this.lblTituloAdministrador.Text = "Administrador";
            // 
            // lblTituloRoles
            // 
            this.lblTituloRoles.AutoSize = true;
            this.lblTituloRoles.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloRoles.Location = new System.Drawing.Point(15, 12);
            this.lblTituloRoles.Name = "lblTituloRoles";
            this.lblTituloRoles.Size = new System.Drawing.Size(170, 20);
            this.lblTituloRoles.TabIndex = 0;
            this.lblTituloRoles.Text = "Información de roles";
            // 
            // panelInformacionUsuario
            // 
            this.panelInformacionUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.panelInformacionUsuario.Controls.Add(this.btnGuardar);
            this.panelInformacionUsuario.Controls.Add(this.cmbEstado);
            this.panelInformacionUsuario.Controls.Add(this.lblEstado);
            this.panelInformacionUsuario.Controls.Add(this.cmbRol);
            this.panelInformacionUsuario.Controls.Add(this.lblRol);
            this.panelInformacionUsuario.Controls.Add(this.txtContrasena);
            this.panelInformacionUsuario.Controls.Add(this.lblContrasena);
            this.panelInformacionUsuario.Controls.Add(this.txtSegundoApellido);
            this.panelInformacionUsuario.Controls.Add(this.lblSegundoApellido);
            this.panelInformacionUsuario.Controls.Add(this.txtPrimerApellido);
            this.panelInformacionUsuario.Controls.Add(this.lblPrimerApellido);
            this.panelInformacionUsuario.Controls.Add(this.txtNombresReales);
            this.panelInformacionUsuario.Controls.Add(this.lblNombresReales);
            this.panelInformacionUsuario.Controls.Add(this.txtNombreUsuario);
            this.panelInformacionUsuario.Controls.Add(this.lblNombreUsuario);
            this.panelInformacionUsuario.Controls.Add(this.lblTituloInformacion);
            this.panelInformacionUsuario.Location = new System.Drawing.Point(785, 95);
            this.panelInformacionUsuario.Name = "panelInformacionUsuario";
            this.panelInformacionUsuario.Size = new System.Drawing.Size(350, 540);
            this.panelInformacionUsuario.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(91)))), ((int)(((byte)(52)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(115, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Roboto", 9F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(20, 386);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(310, 26);
            this.cmbEstado.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblEstado.Location = new System.Drawing.Point(20, 365);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Roboto", 9F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(20, 323);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(310, 26);
            this.cmbRol.TabIndex = 12;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblRol.Location = new System.Drawing.Point(20, 302);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 18);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtContrasena.Location = new System.Drawing.Point(20, 260);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(310, 27);
            this.txtContrasena.TabIndex = 10;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblContrasena.Location = new System.Drawing.Point(20, 239);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(86, 18);
            this.lblContrasena.TabIndex = 9;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtSegundoApellido.Location = new System.Drawing.Point(185, 198);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(145, 27);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblSegundoApellido.Location = new System.Drawing.Point(185, 177);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(129, 18);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtPrimerApellido.Location = new System.Drawing.Point(20, 198);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(145, 27);
            this.txtPrimerApellido.TabIndex = 6;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblPrimerApellido.Location = new System.Drawing.Point(20, 177);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(112, 18);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // txtNombresReales
            // 
            this.txtNombresReales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombresReales.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtNombresReales.Location = new System.Drawing.Point(20, 138);
            this.txtNombresReales.Name = "txtNombresReales";
            this.txtNombresReales.Size = new System.Drawing.Size(310, 27);
            this.txtNombresReales.TabIndex = 4;
            // 
            // lblNombresReales
            // 
            this.lblNombresReales.AutoSize = true;
            this.lblNombresReales.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNombresReales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblNombresReales.Location = new System.Drawing.Point(20, 117);
            this.lblNombresReales.Name = "lblNombresReales";
            this.lblNombresReales.Size = new System.Drawing.Size(116, 18);
            this.lblNombresReales.TabIndex = 3;
            this.lblNombresReales.Text = "Nombres reales";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(20, 78);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(310, 27);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(20, 57);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(140, 18);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblTituloInformacion
            // 
            this.lblTituloInformacion.AutoSize = true;
            this.lblTituloInformacion.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloInformacion.Location = new System.Drawing.Point(20, 18);
            this.lblTituloInformacion.Name = "lblTituloInformacion";
            this.lblTituloInformacion.Size = new System.Drawing.Size(217, 23);
            this.lblTituloInformacion.TabIndex = 0;
            this.lblTituloInformacion.Text = "Agregar / Editar usuario";
            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblNota.Location = new System.Drawing.Point(244, 650);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(885, 35);
            this.lblNota.TabIndex = 9;
            this.lblNota.Text = "Desde esta sección puedes agregar, editar, eliminar y activar o desactivar usuari" +
    "os del sistema.";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.panelInformacionUsuario);
            this.Controls.Add(this.panelRoles);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panelRoles.ResumeLayout(false);
            this.panelRoles.PerformLayout();
            this.panelInformacionUsuario.ResumeLayout(false);
            this.panelInformacionUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Button btnNuevoUsuario;

        private System.Windows.Forms.DataGridView dgvUsuarios;

        private System.Windows.Forms.Panel panelRoles;
        private System.Windows.Forms.Label lblTituloRoles;
        private System.Windows.Forms.Label lblTituloAdministrador;
        private System.Windows.Forms.Label lblDescripcionAdministrador;
        private System.Windows.Forms.Label lblTituloCajero;
        private System.Windows.Forms.Label lblDescripcionCajero;

        private System.Windows.Forms.Panel panelInformacionUsuario;
        private System.Windows.Forms.Label lblTituloInformacion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombresReales;
        private System.Windows.Forms.TextBox txtNombresReales;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoUsuario;
        private System.Windows.Forms.Button btnCategoria;
    }
}