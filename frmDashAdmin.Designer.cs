namespace eduCafeEquipo4
{
    partial class frmDashAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.lblDescripcionVentas = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.lblDescripcionProductos = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.lblDescripcionInventario = new System.Windows.Forms.Label();
            this.lblCantidadInventario = new System.Windows.Forms.Label();
            this.lblTituloInventario = new System.Windows.Forms.Label();
            this.panelAgotados = new System.Windows.Forms.Panel();
            this.lblDescripcionAgotados = new System.Windows.Forms.Label();
            this.lblCantidadAgotados = new System.Windows.Forms.Label();
            this.lblTituloAgotados = new System.Windows.Forms.Label();
            this.panelBajoStock = new System.Windows.Forms.Panel();
            this.dgvBajoStock = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloBajoStock = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelVentas.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.panelAgotados.SuspendLayout();
            this.panelBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
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
            this.panelMenu.Size = new System.Drawing.Size(200, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminSalirB;
            this.btnCerrarSesion.Location = new System.Drawing.Point(-3, 646);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 38);
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
            this.lineaMenu.Location = new System.Drawing.Point(8, 643);
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
            this.btnReportes.Location = new System.Drawing.Point(0, 405);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(200, 38);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminUsersB;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 367);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(200, 38);
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
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(200, 38);
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
            this.btnInventario.Size = new System.Drawing.Size(200, 38);
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
            this.btnProductos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(200, 38);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "  Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnInicio.Image = global::eduCafeEquipo4.Properties.Resources.imicio_admin_verde;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 214);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(200, 38);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "  Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(10, 165);
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
            this.lblEduCafe.Location = new System.Drawing.Point(15, 130);
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
            this.picLogo.Location = new System.Drawing.Point(65, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblBienvenida.Location = new System.Drawing.Point(340, 29);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(292, 40);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Hola, administrador";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(343, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(231, 21);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Resumen general de la cafetería";
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.panelVentas.Controls.Add(this.lblDescripcionVentas);
            this.panelVentas.Controls.Add(this.lblCantidadVentas);
            this.panelVentas.Controls.Add(this.lblTituloVentas);
            this.panelVentas.Location = new System.Drawing.Point(270, 115);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(210, 125);
            this.panelVentas.TabIndex = 4;
            // 
            // lblDescripcionVentas
            // 
            this.lblDescripcionVentas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescripcionVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblDescripcionVentas.Location = new System.Drawing.Point(10, 87);
            this.lblDescripcionVentas.Name = "lblDescripcionVentas";
            this.lblDescripcionVentas.Size = new System.Drawing.Size(190, 25);
            this.lblDescripcionVentas.TabIndex = 2;
            this.lblDescripcionVentas.Text = "Ingreso del día de hoy";
            this.lblDescripcionVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCantidadVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCantidadVentas.Location = new System.Drawing.Point(10, 41);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(190, 42);
            this.lblCantidadVentas.TabIndex = 1;
            this.lblCantidadVentas.Text = "$ 2,450.00";
            this.lblCantidadVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblTituloVentas.Location = new System.Drawing.Point(15, 15);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(180, 22);
            this.lblTituloVentas.TabIndex = 0;
            this.lblTituloVentas.Text = "Ventas del día";
            this.lblTituloVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.panelProductos.Controls.Add(this.lblDescripcionProductos);
            this.panelProductos.Controls.Add(this.lblCantidadProductos);
            this.panelProductos.Controls.Add(this.lblTituloProductos);
            this.panelProductos.Location = new System.Drawing.Point(495, 115);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(210, 125);
            this.panelProductos.TabIndex = 5;
            // 
            // lblDescripcionProductos
            // 
            this.lblDescripcionProductos.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescripcionProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblDescripcionProductos.Location = new System.Drawing.Point(10, 87);
            this.lblDescripcionProductos.Name = "lblDescripcionProductos";
            this.lblDescripcionProductos.Size = new System.Drawing.Size(190, 25);
            this.lblDescripcionProductos.TabIndex = 2;
            this.lblDescripcionProductos.Text = "Productos en el catálogo";
            this.lblDescripcionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCantidadProductos.Location = new System.Drawing.Point(10, 41);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(190, 42);
            this.lblCantidadProductos.TabIndex = 1;
            this.lblCantidadProductos.Text = "125";
            this.lblCantidadProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblTituloProductos.Location = new System.Drawing.Point(15, 15);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(180, 22);
            this.lblTituloProductos.TabIndex = 0;
            this.lblTituloProductos.Text = "Productos registrados";
            this.lblTituloProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.panelInventario.Controls.Add(this.lblDescripcionInventario);
            this.panelInventario.Controls.Add(this.lblCantidadInventario);
            this.panelInventario.Controls.Add(this.lblTituloInventario);
            this.panelInventario.Location = new System.Drawing.Point(720, 115);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(210, 125);
            this.panelInventario.TabIndex = 6;
            // 
            // lblDescripcionInventario
            // 
            this.lblDescripcionInventario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescripcionInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblDescripcionInventario.Location = new System.Drawing.Point(10, 87);
            this.lblDescripcionInventario.Name = "lblDescripcionInventario";
            this.lblDescripcionInventario.Size = new System.Drawing.Size(190, 25);
            this.lblDescripcionInventario.TabIndex = 2;
            this.lblDescripcionInventario.Text = "Productos con bajo stock";
            this.lblDescripcionInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCantidadInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCantidadInventario.Location = new System.Drawing.Point(10, 41);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(190, 42);
            this.lblCantidadInventario.TabIndex = 1;
            this.lblCantidadInventario.Text = "8";
            this.lblCantidadInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloInventario
            // 
            this.lblTituloInventario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblTituloInventario.Location = new System.Drawing.Point(15, 15);
            this.lblTituloInventario.Name = "lblTituloInventario";
            this.lblTituloInventario.Size = new System.Drawing.Size(180, 22);
            this.lblTituloInventario.TabIndex = 0;
            this.lblTituloInventario.Text = "Inventario";
            this.lblTituloInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAgotados
            // 
            this.panelAgotados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.panelAgotados.Controls.Add(this.lblDescripcionAgotados);
            this.panelAgotados.Controls.Add(this.lblCantidadAgotados);
            this.panelAgotados.Controls.Add(this.lblTituloAgotados);
            this.panelAgotados.Location = new System.Drawing.Point(945, 115);
            this.panelAgotados.Name = "panelAgotados";
            this.panelAgotados.Size = new System.Drawing.Size(210, 125);
            this.panelAgotados.TabIndex = 7;
            // 
            // lblDescripcionAgotados
            // 
            this.lblDescripcionAgotados.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescripcionAgotados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblDescripcionAgotados.Location = new System.Drawing.Point(10, 87);
            this.lblDescripcionAgotados.Name = "lblDescripcionAgotados";
            this.lblDescripcionAgotados.Size = new System.Drawing.Size(190, 25);
            this.lblDescripcionAgotados.TabIndex = 2;
            this.lblDescripcionAgotados.Text = "Productos sin existencia";
            this.lblDescripcionAgotados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadAgotados
            // 
            this.lblCantidadAgotados.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCantidadAgotados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCantidadAgotados.Location = new System.Drawing.Point(10, 41);
            this.lblCantidadAgotados.Name = "lblCantidadAgotados";
            this.lblCantidadAgotados.Size = new System.Drawing.Size(190, 42);
            this.lblCantidadAgotados.TabIndex = 1;
            this.lblCantidadAgotados.Text = "2";
            this.lblCantidadAgotados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloAgotados
            // 
            this.lblTituloAgotados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloAgotados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblTituloAgotados.Location = new System.Drawing.Point(15, 15);
            this.lblTituloAgotados.Name = "lblTituloAgotados";
            this.lblTituloAgotados.Size = new System.Drawing.Size(180, 22);
            this.lblTituloAgotados.TabIndex = 0;
            this.lblTituloAgotados.Text = "Productos agotados";
            this.lblTituloAgotados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBajoStock
            // 
            this.panelBajoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelBajoStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBajoStock.Controls.Add(this.dgvBajoStock);
            this.panelBajoStock.Controls.Add(this.lblTituloBajoStock);
            this.panelBajoStock.Location = new System.Drawing.Point(270, 270);
            this.panelBajoStock.Name = "panelBajoStock";
            this.panelBajoStock.Size = new System.Drawing.Size(885, 420);
            this.panelBajoStock.TabIndex = 8;
            // 
            // dgvBajoStock
            // 
            this.dgvBajoStock.AllowUserToAddRows = false;
            this.dgvBajoStock.AllowUserToDeleteRows = false;
            this.dgvBajoStock.AllowUserToResizeRows = false;
            this.dgvBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajoStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgvBajoStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajoStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBajoStock.ColumnHeadersHeight = 42;
            this.dgvBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBajoStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCategoria,
            this.colStockActual,
            this.colStockMinimo,
            this.colEstado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBajoStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBajoStock.EnableHeadersVisualStyles = false;
            this.dgvBajoStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.dgvBajoStock.Location = new System.Drawing.Point(25, 60);
            this.dgvBajoStock.MultiSelect = false;
            this.dgvBajoStock.Name = "dgvBajoStock";
            this.dgvBajoStock.ReadOnly = true;
            this.dgvBajoStock.RowHeadersVisible = false;
            this.dgvBajoStock.RowHeadersWidth = 51;
            this.dgvBajoStock.RowTemplate.Height = 38;
            this.dgvBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBajoStock.Size = new System.Drawing.Size(835, 330);
            this.dgvBajoStock.TabIndex = 1;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock actual";
            this.colStockActual.MinimumWidth = 6;
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.HeaderText = "Stock mínimo";
            this.colStockMinimo.MinimumWidth = 6;
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // lblTituloBajoStock
            // 
            this.lblTituloBajoStock.AutoSize = true;
            this.lblTituloBajoStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloBajoStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloBajoStock.Location = new System.Drawing.Point(25, 20);
            this.lblTituloBajoStock.Name = "lblTituloBajoStock";
            this.lblTituloBajoStock.Size = new System.Drawing.Size(238, 25);
            this.lblTituloBajoStock.TabIndex = 0;
            this.lblTituloBajoStock.Text = "Productos con bajo stock";
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.White;
            this.picUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUsuario.Location = new System.Drawing.Point(270, 30);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(52, 52);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 1;
            this.picUsuario.TabStop = false;
            // 
            // frmDashAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.panelBajoStock);
            this.Controls.Add(this.panelAgotados);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDashAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelVentas.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelInventario.ResumeLayout(false);
            this.panelAgotados.ResumeLayout(false);
            this.panelBajoStock.ResumeLayout(false);
            this.panelBajoStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
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

        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblDescripcion;

        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblDescripcionVentas;

        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.Label lblDescripcionProductos;

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Label lblTituloInventario;
        private System.Windows.Forms.Label lblCantidadInventario;
        private System.Windows.Forms.Label lblDescripcionInventario;

        private System.Windows.Forms.Panel panelAgotados;
        private System.Windows.Forms.Label lblTituloAgotados;
        private System.Windows.Forms.Label lblCantidadAgotados;
        private System.Windows.Forms.Label lblDescripcionAgotados;

        private System.Windows.Forms.Panel panelBajoStock;
        private System.Windows.Forms.Label lblTituloBajoStock;
        private System.Windows.Forms.DataGridView dgvBajoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
