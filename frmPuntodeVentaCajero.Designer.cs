namespace eduCafeEquipo4
{
    partial class frmPuntodeVentaCajero
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lineaMenu = new System.Windows.Forms.Panel();
            this.btnMisVentas = new System.Windows.Forms.Button();
            this.btnPuntoVenta = new System.Windows.Forms.Button();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblEduCafe = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.cmbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalleVenta = new System.Windows.Forms.Panel();
            this.btnCobrarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtTotalRecibido = new System.Windows.Forms.TextBox();
            this.lblTotalRecibido = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colDetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetallePrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            this.panelDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.lineaMenu);
            this.panelMenu.Controls.Add(this.btnMisVentas);
            this.panelMenu.Controls.Add(this.btnPuntoVenta);
            this.panelMenu.Controls.Add(this.lblSistema);
            this.panelMenu.Controls.Add(this.lblEduCafe);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 739);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // lineaMenu
            // 
            this.lineaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.lineaMenu.Location = new System.Drawing.Point(25, 660);
            this.lineaMenu.Name = "lineaMenu";
            this.lineaMenu.Size = new System.Drawing.Size(180, 1);
            this.lineaMenu.TabIndex = 10;
            // 
            // btnMisVentas
            // 
            this.btnMisVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnMisVentas.FlatAppearance.BorderSize = 0;
            this.btnMisVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisVentas.ForeColor = System.Drawing.Color.White;
            this.btnMisVentas.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminProductosB;
            this.btnMisVentas.Location = new System.Drawing.Point(0, 253);
            this.btnMisVentas.Name = "btnMisVentas";
            this.btnMisVentas.Size = new System.Drawing.Size(230, 38);
            this.btnMisVentas.TabIndex = 4;
            this.btnMisVentas.Text = "Mis ventas";
            this.btnMisVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisVentas.UseVisualStyleBackColor = false;
            // 
            // btnPuntoVenta
            // 
            this.btnPuntoVenta.BackColor = System.Drawing.Color.White;
            this.btnPuntoVenta.FlatAppearance.BorderSize = 0;
            this.btnPuntoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(85)))));
            this.btnPuntoVenta.Image = global::eduCafeEquipo4.Properties.Resources.imicio_admin_verde;
            this.btnPuntoVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuntoVenta.Location = new System.Drawing.Point(0, 214);
            this.btnPuntoVenta.Name = "btnPuntoVenta";
            this.btnPuntoVenta.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnPuntoVenta.Size = new System.Drawing.Size(230, 38);
            this.btnPuntoVenta.TabIndex = 3;
            this.btnPuntoVenta.Text = "Punto de venta";
            this.btnPuntoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuntoVenta.UseVisualStyleBackColor = false;
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTitulo.Location = new System.Drawing.Point(270, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Punto de venta";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(273, 66);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(294, 18);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Realiza ventas de producto de forma rápida";
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblBuscarProducto.Location = new System.Drawing.Point(270, 103);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(69, 18);
            this.lblBuscarProducto.TabIndex = 3;
            this.lblBuscarProducto.Text = "Producto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBuscarProducto.Location = new System.Drawing.Point(270, 124);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(210, 25);
            this.txtBuscarProducto.TabIndex = 4;
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblBuscarCategoria.Location = new System.Drawing.Point(495, 103);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblBuscarCategoria.TabIndex = 5;
            this.lblBuscarCategoria.Text = "Categoría";
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(495, 124);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(150, 26);
            this.cmbBuscarCategoria.TabIndex = 6;
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.AllowUserToAddRows = false;
            this.dgvProductosVenta.AllowUserToDeleteRows = false;
            this.dgvProductosVenta.AllowUserToResizeRows = false;
            this.dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgvProductosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosVenta.ColumnHeadersHeight = 38;
            this.dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colCategoria,
            this.colPrecio,
            this.colStock,
            this.colAgregar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosVenta.EnableHeadersVisualStyles = false;
            this.dgvProductosVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.dgvProductosVenta.Location = new System.Drawing.Point(270, 165);
            this.dgvProductosVenta.MultiSelect = false;
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.ReadOnly = true;
            this.dgvProductosVenta.RowHeadersVisible = false;
            this.dgvProductosVenta.RowHeadersWidth = 51;
            this.dgvProductosVenta.RowTemplate.Height = 36;
            this.dgvProductosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosVenta.Size = new System.Drawing.Size(515, 470);
            this.dgvProductosVenta.TabIndex = 7;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.MinimumWidth = 6;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
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
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colAgregar
            // 
            this.colAgregar.HeaderText = "Agregar";
            this.colAgregar.MinimumWidth = 6;
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.ReadOnly = true;
            // 
            // panelDetalleVenta
            // 
            this.panelDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.panelDetalleVenta.Controls.Add(this.btnCobrarVenta);
            this.panelDetalleVenta.Controls.Add(this.btnCancelarVenta);
            this.panelDetalleVenta.Controls.Add(this.cmbMetodoPago);
            this.panelDetalleVenta.Controls.Add(this.lblMetodoPago);
            this.panelDetalleVenta.Controls.Add(this.txtCambio);
            this.panelDetalleVenta.Controls.Add(this.lblCambio);
            this.panelDetalleVenta.Controls.Add(this.txtTotalRecibido);
            this.panelDetalleVenta.Controls.Add(this.lblTotalRecibido);
            this.panelDetalleVenta.Controls.Add(this.txtTotalPagar);
            this.panelDetalleVenta.Controls.Add(this.lblTotalPagar);
            this.panelDetalleVenta.Controls.Add(this.txtSubtotal);
            this.panelDetalleVenta.Controls.Add(this.lblSubtotal);
            this.panelDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.panelDetalleVenta.Controls.Add(this.lblTituloDetalle);
            this.panelDetalleVenta.Location = new System.Drawing.Point(805, 95);
            this.panelDetalleVenta.Name = "panelDetalleVenta";
            this.panelDetalleVenta.Size = new System.Drawing.Size(350, 540);
            this.panelDetalleVenta.TabIndex = 8;
            // 
            // btnCobrarVenta
            // 
            this.btnCobrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.btnCobrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCobrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCobrarVenta.Location = new System.Drawing.Point(195, 475);
            this.btnCobrarVenta.Name = "btnCobrarVenta";
            this.btnCobrarVenta.Size = new System.Drawing.Size(110, 40);
            this.btnCobrarVenta.TabIndex = 0;
            this.btnCobrarVenta.Text = "Cobrar venta";
            this.btnCobrarVenta.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenta.Location = new System.Drawing.Point(55, 475);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(125, 40);
            this.btnCancelarVenta.TabIndex = 1;
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbMetodoPago.Location = new System.Drawing.Point(155, 422);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(175, 26);
            this.cmbMetodoPago.TabIndex = 2;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblMetodoPago.Location = new System.Drawing.Point(35, 425);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(116, 18);
            this.lblMetodoPago.TabIndex = 3;
            this.lblMetodoPago.Text = "Método de pago";
            // 
            // txtCambio
            // 
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Location = new System.Drawing.Point(155, 387);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(175, 27);
            this.txtCambio.TabIndex = 4;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCambio.Location = new System.Drawing.Point(35, 390);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(60, 18);
            this.lblCambio.TabIndex = 5;
            this.lblCambio.Text = "Cambio";
            // 
            // txtTotalRecibido
            // 
            this.txtTotalRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalRecibido.Location = new System.Drawing.Point(155, 352);
            this.txtTotalRecibido.Name = "txtTotalRecibido";
            this.txtTotalRecibido.Size = new System.Drawing.Size(175, 27);
            this.txtTotalRecibido.TabIndex = 6;
            // 
            // lblTotalRecibido
            // 
            this.lblTotalRecibido.AutoSize = true;
            this.lblTotalRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTotalRecibido.Location = new System.Drawing.Point(35, 355);
            this.lblTotalRecibido.Name = "lblTotalRecibido";
            this.lblTotalRecibido.Size = new System.Drawing.Size(97, 18);
            this.lblTotalRecibido.TabIndex = 7;
            this.lblTotalRecibido.Text = "Total recibido";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Location = new System.Drawing.Point(155, 317);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(175, 27);
            this.txtTotalPagar.TabIndex = 8;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblTotalPagar.Location = new System.Drawing.Point(35, 320);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(94, 18);
            this.lblTotalPagar.TabIndex = 9;
            this.lblTotalPagar.Text = "Total a pagar";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Location = new System.Drawing.Point(155, 282);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(175, 27);
            this.txtSubtotal.TabIndex = 10;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSubtotal.Location = new System.Drawing.Point(35, 285);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(62, 18);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AllowUserToResizeRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVenta.ColumnHeadersHeight = 36;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetalleProducto,
            this.colDetallePrecio,
            this.colDetalleCantidad,
            this.colDetalleSubtotal,
            this.colDetalleAcciones});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(20, 55);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 34;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(310, 210);
            this.dgvDetalleVenta.TabIndex = 12;
            // 
            // colDetalleProducto
            // 
            this.colDetalleProducto.HeaderText = "Producto";
            this.colDetalleProducto.MinimumWidth = 6;
            this.colDetalleProducto.Name = "colDetalleProducto";
            this.colDetalleProducto.ReadOnly = true;
            // 
            // colDetallePrecio
            // 
            this.colDetallePrecio.HeaderText = "Precio";
            this.colDetallePrecio.MinimumWidth = 6;
            this.colDetallePrecio.Name = "colDetallePrecio";
            this.colDetallePrecio.ReadOnly = true;
            // 
            // colDetalleCantidad
            // 
            this.colDetalleCantidad.HeaderText = "Cantidad";
            this.colDetalleCantidad.MinimumWidth = 6;
            this.colDetalleCantidad.Name = "colDetalleCantidad";
            this.colDetalleCantidad.ReadOnly = true;
            // 
            // colDetalleSubtotal
            // 
            this.colDetalleSubtotal.HeaderText = "Subtotal";
            this.colDetalleSubtotal.MinimumWidth = 6;
            this.colDetalleSubtotal.Name = "colDetalleSubtotal";
            this.colDetalleSubtotal.ReadOnly = true;
            // 
            // colDetalleAcciones
            // 
            this.colDetalleAcciones.HeaderText = "Acciones";
            this.colDetalleAcciones.MinimumWidth = 6;
            this.colDetalleAcciones.Name = "colDetalleAcciones";
            this.colDetalleAcciones.ReadOnly = true;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTituloDetalle.Location = new System.Drawing.Point(20, 18);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(160, 24);
            this.lblTituloDetalle.TabIndex = 13;
            this.lblTituloDetalle.Text = "Detalle de venta";
            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblNota.Location = new System.Drawing.Point(270, 650);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(885, 35);
            this.lblNota.TabIndex = 9;
            this.lblNota.Text = "Selecciona un producto de la lista o agrégalo al carrito para comenzar la venta.";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPuntodeVentaCajero
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.panelDetalleVenta);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.cmbBuscarCategoria);
            this.Controls.Add(this.lblBuscarCategoria);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 739);
            this.MinimumSize = new System.Drawing.Size(1196, 739);
            this.Name = "frmPuntodeVentaCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de venta";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            this.panelDetalleVenta.ResumeLayout(false);
            this.panelDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEduCafe;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Button btnPuntoVenta;
        private System.Windows.Forms.Button btnMisVentas;
        private System.Windows.Forms.Panel lineaMenu;
        private System.Windows.Forms.Button btnCerrarSesion;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.ComboBox cmbBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgregar;
        private System.Windows.Forms.Panel panelDetalleVenta;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetallePrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleAcciones;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalRecibido;
        private System.Windows.Forms.TextBox txtTotalRecibido;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnCobrarVenta;
        private System.Windows.Forms.Label lblNota;
    }
}