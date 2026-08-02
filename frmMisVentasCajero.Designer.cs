namespace eduCafeEquipo4
{
    partial class frmMisVentasCajero
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
            this.panelVentasDia = new System.Windows.Forms.Panel();
            this.lblCantidadDia = new System.Windows.Forms.Label();
            this.lblMontoDia = new System.Windows.Forms.Label();
            this.lblTextoVentasDia = new System.Windows.Forms.Label();
            this.lblconoVentasDia = new System.Windows.Forms.Label();
            this.panelVentasSemana = new System.Windows.Forms.Panel();
            this.lblCantidadSemana = new System.Windows.Forms.Label();
            this.lblMontoSemana = new System.Windows.Forms.Label();
            this.lblTextoSemana = new System.Windows.Forms.Label();
            this.lblIconoSemana = new System.Windows.Forms.Label();
            this.panelVentasMes = new System.Windows.Forms.Panel();
            this.lblCantidadMes = new System.Windows.Forms.Label();
            this.lblMontoMes = new System.Windows.Forms.Label();
            this.lblTextoMes = new System.Windows.Forms.Label();
            this.lblIconoMes = new System.Windows.Forms.Label();
            this.panelTicketPromedio = new System.Windows.Forms.Panel();
            this.lblPeriodoTicket = new System.Windows.Forms.Label();
            this.lblMontoTicket = new System.Windows.Forms.Label();
            this.lblTextoTicket = new System.Windows.Forms.Label();
            this.lblIconoTicket = new System.Windows.Forms.Label();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.lblEstadoFiltro = new System.Windows.Forms.Label();
            this.cmbMetodoPagoFiltro = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblTituloFiltros = new System.Windows.Forms.Label();
            this.lblIconoFiltros = new System.Windows.Forms.Label();
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.lblNotaHistorial = new System.Windows.Forms.Label();
            this.lblIconoHistorial = new System.Windows.Forms.Label();
            this.ColFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelVentasDia.SuspendLayout();
            this.panelVentasSemana.SuspendLayout();
            this.panelVentasMes.SuspendLayout();
            this.panelTicketPromedio.SuspendLayout();
            this.panelHistorial.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.panelMenu.Size = new System.Drawing.Size(230, 981);
            this.panelMenu.TabIndex = 1;
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
            this.btnMisVentas.BackColor = System.Drawing.Color.White;
            this.btnMisVentas.FlatAppearance.BorderSize = 0;
            this.btnMisVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(123)))), ((int)(((byte)(85)))));
            this.btnMisVentas.Image = global::eduCafeEquipo4.Properties.Resources.MenuAdminProductosB;
            this.btnMisVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnPuntoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(54)))));
            this.btnPuntoVenta.FlatAppearance.BorderSize = 0;
            this.btnPuntoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntoVenta.ForeColor = System.Drawing.Color.White;
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
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.lblTitulo.Location = new System.Drawing.Point(270, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 36);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Mis Ventas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(273, 66);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(223, 18);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Consultas de ventas Realizadas ";
            // 
            // panelVentasDia
            // 
            this.panelVentasDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.panelVentasDia.Controls.Add(this.lblCantidadDia);
            this.panelVentasDia.Controls.Add(this.lblMontoDia);
            this.panelVentasDia.Controls.Add(this.lblTextoVentasDia);
            this.panelVentasDia.Controls.Add(this.lblconoVentasDia);
            this.panelVentasDia.Location = new System.Drawing.Point(270, 100);
            this.panelVentasDia.Name = "panelVentasDia";
            this.panelVentasDia.Size = new System.Drawing.Size(190, 92);
            this.panelVentasDia.TabIndex = 4;
            // 
            // lblCantidadDia
            // 
            this.lblCantidadDia.AutoSize = true;
            this.lblCantidadDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblCantidadDia.Location = new System.Drawing.Point(80, 65);
            this.lblCantidadDia.Name = "lblCantidadDia";
            this.lblCantidadDia.Size = new System.Drawing.Size(69, 18);
            this.lblCantidadDia.TabIndex = 8;
            this.lblCantidadDia.Text = "0 Ventas ";
            // 
            // lblMontoDia
            // 
            this.lblMontoDia.AutoSize = true;
            this.lblMontoDia.Location = new System.Drawing.Point(80, 43);
            this.lblMontoDia.Name = "lblMontoDia";
            this.lblMontoDia.Size = new System.Drawing.Size(44, 18);
            this.lblMontoDia.TabIndex = 8;
            this.lblMontoDia.Text = "$0,00";
            // 
            // lblTextoVentasDia
            // 
            this.lblTextoVentasDia.AutoSize = true;
            this.lblTextoVentasDia.Location = new System.Drawing.Point(80, 12);
            this.lblTextoVentasDia.Name = "lblTextoVentasDia";
            this.lblTextoVentasDia.Size = new System.Drawing.Size(102, 18);
            this.lblTextoVentasDia.TabIndex = 8;
            this.lblTextoVentasDia.Text = "Ventas del Dia";
            // 
            // lblconoVentasDia
            // 
            this.lblconoVentasDia.AutoSize = true;
            this.lblconoVentasDia.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconoVentasDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.lblconoVentasDia.Location = new System.Drawing.Point(26, 12);
            this.lblconoVentasDia.Name = "lblconoVentasDia";
            this.lblconoVentasDia.Size = new System.Drawing.Size(48, 57);
            this.lblconoVentasDia.TabIndex = 8;
            this.lblconoVentasDia.Text = "$";
            // 
            // panelVentasSemana
            // 
            this.panelVentasSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.panelVentasSemana.Controls.Add(this.lblCantidadSemana);
            this.panelVentasSemana.Controls.Add(this.lblMontoSemana);
            this.panelVentasSemana.Controls.Add(this.lblTextoSemana);
            this.panelVentasSemana.Controls.Add(this.lblIconoSemana);
            this.panelVentasSemana.Location = new System.Drawing.Point(475, 100);
            this.panelVentasSemana.Name = "panelVentasSemana";
            this.panelVentasSemana.Size = new System.Drawing.Size(190, 92);
            this.panelVentasSemana.TabIndex = 5;
            // 
            // lblCantidadSemana
            // 
            this.lblCantidadSemana.AutoSize = true;
            this.lblCantidadSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblCantidadSemana.Location = new System.Drawing.Point(76, 65);
            this.lblCantidadSemana.Name = "lblCantidadSemana";
            this.lblCantidadSemana.Size = new System.Drawing.Size(54, 15);
            this.lblCantidadSemana.TabIndex = 13;
            this.lblCantidadSemana.Text = "0 Ventas";
            // 
            // lblMontoSemana
            // 
            this.lblMontoSemana.AutoSize = true;
            this.lblMontoSemana.Location = new System.Drawing.Point(76, 30);
            this.lblMontoSemana.Name = "lblMontoSemana";
            this.lblMontoSemana.Size = new System.Drawing.Size(48, 18);
            this.lblMontoSemana.TabIndex = 14;
            this.lblMontoSemana.Text = "$ 0.00";
            // 
            // lblTextoSemana
            // 
            this.lblTextoSemana.AutoSize = true;
            this.lblTextoSemana.Location = new System.Drawing.Point(39, 7);
            this.lblTextoSemana.Name = "lblTextoSemana";
            this.lblTextoSemana.Size = new System.Drawing.Size(147, 18);
            this.lblTextoSemana.TabIndex = 15;
            this.lblTextoSemana.Text = "Ventas de la Semana";
            // 
            // lblIconoSemana
            // 
            this.lblIconoSemana.AutoSize = true;
            this.lblIconoSemana.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconoSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.lblIconoSemana.Location = new System.Drawing.Point(3, 12);
            this.lblIconoSemana.Name = "lblIconoSemana";
            this.lblIconoSemana.Size = new System.Drawing.Size(48, 57);
            this.lblIconoSemana.TabIndex = 8;
            this.lblIconoSemana.Text = "$";
            // 
            // panelVentasMes
            // 
            this.panelVentasMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(157)))));
            this.panelVentasMes.Controls.Add(this.lblCantidadMes);
            this.panelVentasMes.Controls.Add(this.lblMontoMes);
            this.panelVentasMes.Controls.Add(this.lblTextoMes);
            this.panelVentasMes.Controls.Add(this.lblIconoMes);
            this.panelVentasMes.Location = new System.Drawing.Point(680, 100);
            this.panelVentasMes.Name = "panelVentasMes";
            this.panelVentasMes.Size = new System.Drawing.Size(190, 92);
            this.panelVentasMes.TabIndex = 6;
            // 
            // lblCantidadMes
            // 
            this.lblCantidadMes.AutoSize = true;
            this.lblCantidadMes.Location = new System.Drawing.Point(76, 67);
            this.lblCantidadMes.Name = "lblCantidadMes";
            this.lblCantidadMes.Size = new System.Drawing.Size(65, 18);
            this.lblCantidadMes.TabIndex = 12;
            this.lblCantidadMes.Text = "0 Ventas";
            // 
            // lblMontoMes
            // 
            this.lblMontoMes.AutoSize = true;
            this.lblMontoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblMontoMes.Location = new System.Drawing.Point(74, 39);
            this.lblMontoMes.Name = "lblMontoMes";
            this.lblMontoMes.Size = new System.Drawing.Size(66, 26);
            this.lblMontoMes.TabIndex = 10;
            this.lblMontoMes.Text = "$0.00";
            // 
            // lblTextoMes
            // 
            this.lblTextoMes.AutoSize = true;
            this.lblTextoMes.Location = new System.Drawing.Point(57, 12);
            this.lblTextoMes.Name = "lblTextoMes";
            this.lblTextoMes.Size = new System.Drawing.Size(113, 18);
            this.lblTextoMes.TabIndex = 11;
            this.lblTextoMes.Text = "Ventas del Mes ";
            // 
            // lblIconoMes
            // 
            this.lblIconoMes.AutoSize = true;
            this.lblIconoMes.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconoMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.lblIconoMes.Location = new System.Drawing.Point(3, 23);
            this.lblIconoMes.Name = "lblIconoMes";
            this.lblIconoMes.Size = new System.Drawing.Size(48, 57);
            this.lblIconoMes.TabIndex = 12;
            this.lblIconoMes.Text = "$";
            // 
            // panelTicketPromedio
            // 
            this.panelTicketPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.panelTicketPromedio.Controls.Add(this.lblPeriodoTicket);
            this.panelTicketPromedio.Controls.Add(this.lblMontoTicket);
            this.panelTicketPromedio.Controls.Add(this.lblTextoTicket);
            this.panelTicketPromedio.Controls.Add(this.lblIconoTicket);
            this.panelTicketPromedio.Location = new System.Drawing.Point(885, 100);
            this.panelTicketPromedio.Name = "panelTicketPromedio";
            this.panelTicketPromedio.Size = new System.Drawing.Size(190, 92);
            this.panelTicketPromedio.TabIndex = 7;
            // 
            // lblPeriodoTicket
            // 
            this.lblPeriodoTicket.AutoSize = true;
            this.lblPeriodoTicket.Location = new System.Drawing.Point(53, 72);
            this.lblPeriodoTicket.Name = "lblPeriodoTicket";
            this.lblPeriodoTicket.Size = new System.Drawing.Size(75, 18);
            this.lblPeriodoTicket.TabIndex = 9;
            this.lblPeriodoTicket.Text = "Este Mes ";
            this.lblPeriodoTicket.Click += new System.EventHandler(this.lblPeriodoTicket_Click);
            // 
            // lblMontoTicket
            // 
            this.lblMontoTicket.AutoSize = true;
            this.lblMontoTicket.Location = new System.Drawing.Point(67, 45);
            this.lblMontoTicket.Name = "lblMontoTicket";
            this.lblMontoTicket.Size = new System.Drawing.Size(44, 18);
            this.lblMontoTicket.TabIndex = 10;
            this.lblMontoTicket.Text = "$0.00";
            this.lblMontoTicket.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTextoTicket
            // 
            this.lblTextoTicket.AutoSize = true;
            this.lblTextoTicket.Location = new System.Drawing.Point(53, 12);
            this.lblTextoTicket.Name = "lblTextoTicket";
            this.lblTextoTicket.Size = new System.Drawing.Size(117, 18);
            this.lblTextoTicket.TabIndex = 10;
            this.lblTextoTicket.Text = "Ticket Promedio";
            // 
            // lblIconoTicket
            // 
            this.lblIconoTicket.AutoSize = true;
            this.lblIconoTicket.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconoTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.lblIconoTicket.Location = new System.Drawing.Point(13, 23);
            this.lblIconoTicket.Name = "lblIconoTicket";
            this.lblIconoTicket.Size = new System.Drawing.Size(48, 57);
            this.lblIconoTicket.TabIndex = 11;
            this.lblIconoTicket.Text = "$";
            // 
            // panelHistorial
            // 
            this.panelHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHistorial.Controls.Add(this.panelFiltro);
            this.panelHistorial.Controls.Add(this.dgvHistorialVentas);
            this.panelHistorial.Controls.Add(this.lblNotaHistorial);
            this.panelHistorial.Controls.Add(this.lblIconoHistorial);
            this.panelHistorial.Location = new System.Drawing.Point(277, 215);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(805, 420);
            this.panelHistorial.TabIndex = 8;
            // 
            // panelFiltro
            // 
            this.panelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(205)))));
            this.panelFiltro.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltro.Controls.Add(this.btnFiltrar);
            this.panelFiltro.Controls.Add(this.cmbEstadoFiltro);
            this.panelFiltro.Controls.Add(this.lblEstadoFiltro);
            this.panelFiltro.Controls.Add(this.cmbMetodoPagoFiltro);
            this.panelFiltro.Controls.Add(this.lblMetodoPago);
            this.panelFiltro.Controls.Add(this.dtpFechaFin);
            this.panelFiltro.Controls.Add(this.lblFechaFin);
            this.panelFiltro.Controls.Add(this.dtpFechaInicio);
            this.panelFiltro.Controls.Add(this.lblFechaInicio);
            this.panelFiltro.Controls.Add(this.lblTituloFiltros);
            this.panelFiltro.Controls.Add(this.lblIconoFiltros);
            this.panelFiltro.Location = new System.Drawing.Point(565, 50);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(220, 335);
            this.panelFiltro.TabIndex = 3;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(107, 281);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(130, 35);
            this.btnLimpiarFiltros.TabIndex = 18;
            this.btnLimpiarFiltros.Text = "Limpiar ";
            this.btnLimpiarFiltros.UseCompatibleTextRendering = true;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(145)))), ((int)(((byte)(85)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(15, 281);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 35);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoFiltro
            // 
            this.cmbEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFiltro.FormattingEnabled = true;
            this.cmbEstadoFiltro.Location = new System.Drawing.Point(15, 240);
            this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            this.cmbEstadoFiltro.Size = new System.Drawing.Size(190, 26);
            this.cmbEstadoFiltro.TabIndex = 17;
            // 
            // lblEstadoFiltro
            // 
            this.lblEstadoFiltro.AutoSize = true;
            this.lblEstadoFiltro.Location = new System.Drawing.Point(15, 220);
            this.lblEstadoFiltro.Name = "lblEstadoFiltro";
            this.lblEstadoFiltro.Size = new System.Drawing.Size(55, 18);
            this.lblEstadoFiltro.TabIndex = 16;
            this.lblEstadoFiltro.Text = "Estado";
            // 
            // cmbMetodoPagoFiltro
            // 
            this.cmbMetodoPagoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPagoFiltro.FormattingEnabled = true;
            this.cmbMetodoPagoFiltro.Location = new System.Drawing.Point(15, 185);
            this.cmbMetodoPagoFiltro.Name = "cmbMetodoPagoFiltro";
            this.cmbMetodoPagoFiltro.Size = new System.Drawing.Size(190, 26);
            this.cmbMetodoPagoFiltro.TabIndex = 15;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(15, 165);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(116, 18);
            this.lblMetodoPago.TabIndex = 14;
            this.lblMetodoPago.Text = "Metodo de pago";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(15, 130);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(190, 24);
            this.dtpFechaFin.TabIndex = 13;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(19, 111);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(77, 18);
            this.lblFechaFin.TabIndex = 9;
            this.lblFechaFin.Text = "Fecha Fin ";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(15, 75);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(190, 24);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 55);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 18);
            this.lblFechaInicio.TabIndex = 11;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblTituloFiltros
            // 
            this.lblTituloFiltros.AutoSize = true;
            this.lblTituloFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.lblTituloFiltros.Location = new System.Drawing.Point(47, 8);
            this.lblTituloFiltros.Name = "lblTituloFiltros";
            this.lblTituloFiltros.Size = new System.Drawing.Size(49, 18);
            this.lblTituloFiltros.TabIndex = 10;
            this.lblTituloFiltros.Text = "Filtros";
            // 
            // lblIconoFiltros
            // 
            this.lblIconoFiltros.AutoSize = true;
            this.lblIconoFiltros.Location = new System.Drawing.Point(16, 8);
            this.lblIconoFiltros.Name = "lblIconoFiltros";
            this.lblIconoFiltros.Size = new System.Drawing.Size(19, 18);
            this.lblIconoFiltros.TabIndex = 9;
            this.lblIconoFiltros.Text = "▽";
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.AllowUserToAddRows = false;
            this.dgvHistorialVentas.AllowUserToDeleteRows = false;
            this.dgvHistorialVentas.AllowUserToResizeRows = false;
            this.dgvHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dgvHistorialVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFolio,
            this.colVerDetalle,
            this.colFecha,
            this.colHora,
            this.colProductos,
            this.colTotal,
            this.colMetodoPago});
            this.dgvHistorialVentas.EnableHeadersVisualStyles = false;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(15, 50);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.ReadOnly = true;
            this.dgvHistorialVentas.RowHeadersWidth = 51;
            this.dgvHistorialVentas.RowTemplate.Height = 24;
            this.dgvHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(535, 335);
            this.dgvHistorialVentas.TabIndex = 2;
            // 
            // lblNotaHistorial
            // 
            this.lblNotaHistorial.AutoSize = true;
            this.lblNotaHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.lblNotaHistorial.Location = new System.Drawing.Point(47, 23);
            this.lblNotaHistorial.Name = "lblNotaHistorial";
            this.lblNotaHistorial.Size = new System.Drawing.Size(135, 18);
            this.lblNotaHistorial.TabIndex = 1;
            this.lblNotaHistorial.Text = "Historial de Ventas ";
            // 
            // lblIconoHistorial
            // 
            this.lblIconoHistorial.AutoSize = true;
            this.lblIconoHistorial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconoHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.lblIconoHistorial.Location = new System.Drawing.Point(15, 13);
            this.lblIconoHistorial.Name = "lblIconoHistorial";
            this.lblIconoHistorial.Size = new System.Drawing.Size(34, 31);
            this.lblIconoHistorial.TabIndex = 0;
            this.lblIconoHistorial.Text = "▣";
            // 
            // ColFolio
            // 
            this.ColFolio.HeaderText = "Folio";
            this.ColFolio.MinimumWidth = 6;
            this.ColFolio.Name = "ColFolio";
            this.ColFolio.ReadOnly = true;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "Acciones";
            this.colVerDetalle.MinimumWidth = 6;
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.HeaderText = "Hora";
            this.colHora.MinimumWidth = 6;
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colProductos
            // 
            this.colProductos.HeaderText = "Productos";
            this.colProductos.MinimumWidth = 6;
            this.colProductos.Name = "colProductos";
            this.colProductos.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo de Pago";
            this.colMetodoPago.MinimumWidth = 6;
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.ReadOnly = true;
            // 
            // frmMisVentasCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1291, 748);
            this.Controls.Add(this.panelHistorial);
            this.Controls.Add(this.panelTicketPromedio);
            this.Controls.Add(this.panelVentasMes);
            this.Controls.Add(this.panelVentasSemana);
            this.Controls.Add(this.panelVentasDia);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMisVentasCajero";
            this.Text = "Mis Ventas ";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelVentasDia.ResumeLayout(false);
            this.panelVentasDia.PerformLayout();
            this.panelVentasSemana.ResumeLayout(false);
            this.panelVentasSemana.PerformLayout();
            this.panelVentasMes.ResumeLayout(false);
            this.panelVentasMes.PerformLayout();
            this.panelTicketPromedio.ResumeLayout(false);
            this.panelTicketPromedio.PerformLayout();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel lineaMenu;
        private System.Windows.Forms.Button btnMisVentas;
        private System.Windows.Forms.Button btnPuntoVenta;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblEduCafe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelVentasDia;
        private System.Windows.Forms.Panel panelVentasSemana;
        private System.Windows.Forms.Panel panelVentasMes;
        private System.Windows.Forms.Panel panelTicketPromedio;
        private System.Windows.Forms.Label lblconoVentasDia;
        private System.Windows.Forms.Label lblTextoVentasDia;
        private System.Windows.Forms.Label lblCantidadDia;
        private System.Windows.Forms.Label lblMontoDia;
        private System.Windows.Forms.Label lblIconoSemana;
        private System.Windows.Forms.Label lblPeriodoTicket;
        private System.Windows.Forms.Label lblMontoMes;
        private System.Windows.Forms.Label lblTextoMes;
        private System.Windows.Forms.Label lblIconoMes;
        private System.Windows.Forms.Label lblCantidadSemana;
        private System.Windows.Forms.Label lblMontoSemana;
        private System.Windows.Forms.Label lblTextoSemana;
        private System.Windows.Forms.Label lblTextoTicket;
        private System.Windows.Forms.Label lblIconoTicket;
        private System.Windows.Forms.Label lblCantidadMes;
        private System.Windows.Forms.Label lblMontoTicket;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label lblNotaHistorial;
        private System.Windows.Forms.Label lblIconoHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label lblTituloFiltros;
        private System.Windows.Forms.Label lblIconoFiltros;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbEstadoFiltro;
        private System.Windows.Forms.Label lblEstadoFiltro;
        private System.Windows.Forms.ComboBox cmbMetodoPagoFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
    }
}