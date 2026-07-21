namespace eduCafeEquipo4
{
    partial class frmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.panelVentasTotales = new System.Windows.Forms.Panel();
            this.lblDescripcionVentasTotales = new System.Windows.Forms.Label();
            this.lblCantidadVentasTotales = new System.Windows.Forms.Label();
            this.lblTituloVentasTotales = new System.Windows.Forms.Label();
            this.panelNumeroVentas = new System.Windows.Forms.Panel();
            this.lblDescripcionNumeroVentas = new System.Windows.Forms.Label();
            this.lblCantidadNumeroVentas = new System.Windows.Forms.Label();
            this.lblTituloNumeroVentas = new System.Windows.Forms.Label();
            this.panelProductosVendidos = new System.Windows.Forms.Panel();
            this.lblDescripcionProductosVendidos = new System.Windows.Forms.Label();
            this.lblCantidadProductosVendidos = new System.Windows.Forms.Label();
            this.lblTituloProductosVendidos = new System.Windows.Forms.Label();
            this.panelTicketPromedio = new System.Windows.Forms.Panel();
            this.lblDescripcionTicketPromedio = new System.Windows.Forms.Label();
            this.lblCantidadTicketPromedio = new System.Windows.Forms.Label();
            this.lblTituloTicketPromedio = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductosVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelVentasTotales.SuspendLayout();
            this.panelNumeroVentas.SuspendLayout();
            this.panelProductosVendidos.SuspendLayout();
            this.panelTicketPromedio.SuspendLayout();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
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
            this.panelMenu.Location = new System.Drawing.Point(0, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 700);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminSalirB;
            this.btnCerrarSesion.Location = new System.Drawing.Point(-3, 643);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 40);
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
            this.lineaMenu.Location = new System.Drawing.Point(8, 636);
            this.lineaMenu.Name = "lineaMenu";
            this.lineaMenu.Size = new System.Drawing.Size(180, 1);
            this.lineaMenu.TabIndex = 10;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnReportes.Image = global::eduCafeEquipo4.Properties.Resources.reportes_master_verde;
            this.btnReportes.Location = new System.Drawing.Point(0, 405);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(200, 38);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "  Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
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
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
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
            this.btnInventario.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
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
            this.btnProductos.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(200, 38);
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
            this.btnInicio.Location = new System.Drawing.Point(0, 214);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(200, 38);
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
            this.lblSistema.Location = new System.Drawing.Point(-10, 165);
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
            this.lblEduCafe.Location = new System.Drawing.Point(0, 130);
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
            this.picLogo.Location = new System.Drawing.Point(49, 25);
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
            this.lblTitulo.Location = new System.Drawing.Point(270, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 37);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Reportes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(273, 66);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(256, 18);
            this.lblSubtitulo.TabIndex = 11;
            this.lblSubtitulo.Text = "Consulta y genera reportes de venta";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(285, 102);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(95, 18);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Roboto", 9F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(285, 123);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(210, 26);
            this.dtpFechaInicio.TabIndex = 9;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(560, 102);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(87, 18);
            this.lblFechaFinal.TabIndex = 8;
            this.lblFechaFinal.Text = "Fecha final:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Roboto", 9F);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(560, 123);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(210, 26);
            this.dtpFechaFinal.TabIndex = 7;
            // 
            // btnGenerarReporte
            
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(940, 119);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(180, 34);
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // panelVentasTotales
            // 
            this.panelVentasTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.panelVentasTotales.Controls.Add(this.lblDescripcionVentasTotales);
            this.panelVentasTotales.Controls.Add(this.lblCantidadVentasTotales);
            this.panelVentasTotales.Controls.Add(this.lblTituloVentasTotales);
            this.panelVentasTotales.Location = new System.Drawing.Point(270, 175);
            this.panelVentasTotales.Name = "panelVentasTotales";
            this.panelVentasTotales.Size = new System.Drawing.Size(210, 110);
            this.panelVentasTotales.TabIndex = 5;
            // 
            // lblDescripcionVentasTotales
            // 
            this.lblDescripcionVentasTotales.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionVentasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionVentasTotales.Location = new System.Drawing.Point(10, 76);
            this.lblDescripcionVentasTotales.Name = "lblDescripcionVentasTotales";
            this.lblDescripcionVentasTotales.Size = new System.Drawing.Size(190, 20);
            this.lblDescripcionVentasTotales.TabIndex = 0;
            this.lblDescripcionVentasTotales.Text = "Periodo seleccionado";
            this.lblDescripcionVentasTotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadVentasTotales
            // 
            this.lblCantidadVentasTotales.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadVentasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblCantidadVentasTotales.Location = new System.Drawing.Point(10, 32);
            this.lblCantidadVentasTotales.Name = "lblCantidadVentasTotales";
            this.lblCantidadVentasTotales.Size = new System.Drawing.Size(190, 38);
            this.lblCantidadVentasTotales.TabIndex = 1;
            this.lblCantidadVentasTotales.Text = "$ 0.00";
            this.lblCantidadVentasTotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloVentasTotales
            // 
            this.lblTituloVentasTotales.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblTituloVentasTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloVentasTotales.Location = new System.Drawing.Point(10, 10);
            this.lblTituloVentasTotales.Name = "lblTituloVentasTotales";
            this.lblTituloVentasTotales.Size = new System.Drawing.Size(190, 20);
            this.lblTituloVentasTotales.TabIndex = 2;
            this.lblTituloVentasTotales.Text = "Ventas totales";
            this.lblTituloVentasTotales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNumeroVentas
            // 
            this.panelNumeroVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.panelNumeroVentas.Controls.Add(this.lblDescripcionNumeroVentas);
            this.panelNumeroVentas.Controls.Add(this.lblCantidadNumeroVentas);
            this.panelNumeroVentas.Controls.Add(this.lblTituloNumeroVentas);
            this.panelNumeroVentas.Location = new System.Drawing.Point(495, 175);
            this.panelNumeroVentas.Name = "panelNumeroVentas";
            this.panelNumeroVentas.Size = new System.Drawing.Size(210, 110);
            this.panelNumeroVentas.TabIndex = 4;
            // 
            // lblDescripcionNumeroVentas
            // 
            this.lblDescripcionNumeroVentas.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionNumeroVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionNumeroVentas.Location = new System.Drawing.Point(10, 76);
            this.lblDescripcionNumeroVentas.Name = "lblDescripcionNumeroVentas";
            this.lblDescripcionNumeroVentas.Size = new System.Drawing.Size(190, 20);
            this.lblDescripcionNumeroVentas.TabIndex = 0;
            this.lblDescripcionNumeroVentas.Text = "Ventas realizadas";
            this.lblDescripcionNumeroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadNumeroVentas
            // 
            this.lblCantidadNumeroVentas.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadNumeroVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblCantidadNumeroVentas.Location = new System.Drawing.Point(10, 32);
            this.lblCantidadNumeroVentas.Name = "lblCantidadNumeroVentas";
            this.lblCantidadNumeroVentas.Size = new System.Drawing.Size(190, 38);
            this.lblCantidadNumeroVentas.TabIndex = 1;
            this.lblCantidadNumeroVentas.Text = "0";
            this.lblCantidadNumeroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloNumeroVentas
            // 
            this.lblTituloNumeroVentas.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblTituloNumeroVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloNumeroVentas.Location = new System.Drawing.Point(10, 10);
            this.lblTituloNumeroVentas.Name = "lblTituloNumeroVentas";
            this.lblTituloNumeroVentas.Size = new System.Drawing.Size(190, 20);
            this.lblTituloNumeroVentas.TabIndex = 2;
            this.lblTituloNumeroVentas.Text = "Número de ventas";
            this.lblTituloNumeroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProductosVendidos
            // 
            this.panelProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(218)))), ((int)(((byte)(158)))));
            this.panelProductosVendidos.Controls.Add(this.lblDescripcionProductosVendidos);
            this.panelProductosVendidos.Controls.Add(this.lblCantidadProductosVendidos);
            this.panelProductosVendidos.Controls.Add(this.lblTituloProductosVendidos);
            this.panelProductosVendidos.Location = new System.Drawing.Point(720, 175);
            this.panelProductosVendidos.Name = "panelProductosVendidos";
            this.panelProductosVendidos.Size = new System.Drawing.Size(210, 110);
            this.panelProductosVendidos.TabIndex = 3;
            // 
            // lblDescripcionProductosVendidos
            // 
            this.lblDescripcionProductosVendidos.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionProductosVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionProductosVendidos.Location = new System.Drawing.Point(10, 76);
            this.lblDescripcionProductosVendidos.Name = "lblDescripcionProductosVendidos";
            this.lblDescripcionProductosVendidos.Size = new System.Drawing.Size(190, 20);
            this.lblDescripcionProductosVendidos.TabIndex = 0;
            this.lblDescripcionProductosVendidos.Text = "Total productos";
            this.lblDescripcionProductosVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadProductosVendidos
            // 
            this.lblCantidadProductosVendidos.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadProductosVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblCantidadProductosVendidos.Location = new System.Drawing.Point(10, 32);
            this.lblCantidadProductosVendidos.Name = "lblCantidadProductosVendidos";
            this.lblCantidadProductosVendidos.Size = new System.Drawing.Size(190, 38);
            this.lblCantidadProductosVendidos.TabIndex = 1;
            this.lblCantidadProductosVendidos.Text = "0";
            this.lblCantidadProductosVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloProductosVendidos
            // 
            this.lblTituloProductosVendidos.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblTituloProductosVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloProductosVendidos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloProductosVendidos.Name = "lblTituloProductosVendidos";
            this.lblTituloProductosVendidos.Size = new System.Drawing.Size(190, 20);
            this.lblTituloProductosVendidos.TabIndex = 2;
            this.lblTituloProductosVendidos.Text = "Productos vendidos";
            this.lblTituloProductosVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTicketPromedio
            // 
            this.panelTicketPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.panelTicketPromedio.Controls.Add(this.lblDescripcionTicketPromedio);
            this.panelTicketPromedio.Controls.Add(this.lblCantidadTicketPromedio);
            this.panelTicketPromedio.Controls.Add(this.lblTituloTicketPromedio);
            this.panelTicketPromedio.Location = new System.Drawing.Point(945, 175);
            this.panelTicketPromedio.Name = "panelTicketPromedio";
            this.panelTicketPromedio.Size = new System.Drawing.Size(210, 110);
            this.panelTicketPromedio.TabIndex = 2;
            // 
            // lblDescripcionTicketPromedio
            // 
            this.lblDescripcionTicketPromedio.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDescripcionTicketPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblDescripcionTicketPromedio.Location = new System.Drawing.Point(10, 76);
            this.lblDescripcionTicketPromedio.Name = "lblDescripcionTicketPromedio";
            this.lblDescripcionTicketPromedio.Size = new System.Drawing.Size(190, 20);
            this.lblDescripcionTicketPromedio.TabIndex = 0;
            this.lblDescripcionTicketPromedio.Text = "Promedio por venta";
            this.lblDescripcionTicketPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadTicketPromedio
            // 
            this.lblCantidadTicketPromedio.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantidadTicketPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblCantidadTicketPromedio.Location = new System.Drawing.Point(10, 32);
            this.lblCantidadTicketPromedio.Name = "lblCantidadTicketPromedio";
            this.lblCantidadTicketPromedio.Size = new System.Drawing.Size(190, 38);
            this.lblCantidadTicketPromedio.TabIndex = 1;
            this.lblCantidadTicketPromedio.Text = "$ 0.00";
            this.lblCantidadTicketPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTicketPromedio
            // 
            this.lblTituloTicketPromedio.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblTituloTicketPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloTicketPromedio.Location = new System.Drawing.Point(10, 10);
            this.lblTituloTicketPromedio.Name = "lblTituloTicketPromedio";
            this.lblTituloTicketPromedio.Size = new System.Drawing.Size(190, 20);
            this.lblTituloTicketPromedio.TabIndex = 2;
            this.lblTituloTicketPromedio.Text = "Ticket promedio";
            this.lblTituloTicketPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultados.Controls.Add(this.dgvReporte);
            this.panelResultados.Controls.Add(this.lblTituloResultados);
            this.panelResultados.Location = new System.Drawing.Point(270, 305);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(885, 330);
            this.panelResultados.TabIndex = 1;
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToResizeRows = false;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte.ColumnHeadersHeight = 38;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colNumeroVentas,
            this.colProductosVendidos,
            this.colTotalVentas,
            this.colMetodoPago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.dgvReporte.Location = new System.Drawing.Point(20, 50);
            this.dgvReporte.MultiSelect = false;
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 36;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.Size = new System.Drawing.Size(843, 255);
            this.dgvReporte.TabIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colNumeroVentas
            // 
            this.colNumeroVentas.HeaderText = "Número de ventas";
            this.colNumeroVentas.MinimumWidth = 6;
            this.colNumeroVentas.Name = "colNumeroVentas";
            this.colNumeroVentas.ReadOnly = true;
            // 
            // colProductosVendidos
            // 
            this.colProductosVendidos.HeaderText = "Productos vendidos";
            this.colProductosVendidos.MinimumWidth = 6;
            this.colProductosVendidos.Name = "colProductosVendidos";
            this.colProductosVendidos.ReadOnly = true;
            // 
            // colTotalVentas
            // 
            this.colTotalVentas.HeaderText = "Total de ventas";
            this.colTotalVentas.MinimumWidth = 6;
            this.colTotalVentas.Name = "colTotalVentas";
            this.colTotalVentas.ReadOnly = true;
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Método de pago";
            this.colMetodoPago.MinimumWidth = 6;
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.ReadOnly = true;
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.AutoSize = true;
            this.lblTituloResultados.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloResultados.Location = new System.Drawing.Point(20, 15);
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.Size = new System.Drawing.Size(185, 20);
            this.lblTituloResultados.TabIndex = 1;
            this.lblTituloResultados.Text = "Resultados del reporte";
            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblNota.Location = new System.Drawing.Point(270, 650);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(885, 35);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Este reporte muestra las ventas realizadas por día en el rango de fechas seleccio" +
    "nado.";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.Location = new System.Drawing.Point(-2, 443);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(200, 38);
            this.btnCategoria.TabIndex = 14;
            this.btnCategoria.Text = "  Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panelTicketPromedio);
            this.Controls.Add(this.panelProductosVendidos);
            this.Controls.Add(this.panelNumeroVentas);
            this.Controls.Add(this.panelVentasTotales);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 739);
            this.MinimumSize = new System.Drawing.Size(1196, 739);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelVentasTotales.ResumeLayout(false);
            this.panelNumeroVentas.ResumeLayout(false);
            this.panelProductosVendidos.ResumeLayout(false);
            this.panelTicketPromedio.ResumeLayout(false);
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEduCafe;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel lineaMenu;
        private System.Windows.Forms.Button btnCerrarSesion;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnGenerarReporte;

        private System.Windows.Forms.Panel panelVentasTotales;
        private System.Windows.Forms.Label lblTituloVentasTotales;
        private System.Windows.Forms.Label lblCantidadVentasTotales;
        private System.Windows.Forms.Label lblDescripcionVentasTotales;

        private System.Windows.Forms.Panel panelNumeroVentas;
        private System.Windows.Forms.Label lblTituloNumeroVentas;
        private System.Windows.Forms.Label lblCantidadNumeroVentas;
        private System.Windows.Forms.Label lblDescripcionNumeroVentas;

        private System.Windows.Forms.Panel panelProductosVendidos;
        private System.Windows.Forms.Label lblTituloProductosVendidos;
        private System.Windows.Forms.Label lblCantidadProductosVendidos;
        private System.Windows.Forms.Label lblDescripcionProductosVendidos;

        private System.Windows.Forms.Panel panelTicketPromedio;
        private System.Windows.Forms.Label lblTituloTicketPromedio;
        private System.Windows.Forms.Label lblCantidadTicketPromedio;
        private System.Windows.Forms.Label lblDescripcionTicketPromedio;

        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Label lblTituloResultados;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductosVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategoria;
    }
}