namespace eduCafeEquipo4
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lineaIzquierda = new System.Windows.Forms.Panel();
            this.lblO = new System.Windows.Forms.Label();
            this.lineaDerecha = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(85)))));
            this.panelIzquierdo.Controls.Add(this.lblSistema);
            this.panelIzquierdo.Controls.Add(this.lblNombreEmpresa);
            this.panelIzquierdo.Controls.Add(this.picLogo);
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(430, 739);
            this.panelIzquierdo.TabIndex = 0;
            // 
            // lblSistema
            // 
            this.lblSistema.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(40, 395);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(350, 30);
            this.lblSistema.TabIndex = 2;
            this.lblSistema.Text = "SISTEMA DE CONTROL DE VENTAS";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(65, 345);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(300, 40);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "Edu Café";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(122, 143);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto Cn", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.lblBienvenido.Location = new System.Drawing.Point(650, 85);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(330, 60);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Roboto Cn", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(650, 145);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(330, 39);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Iniciar sesión para continuar";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.lblUsuario.Location = new System.Drawing.Point(592, 215);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(595, 245);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(440, 34);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.lblContrasena.Location = new System.Drawing.Point(591, 304);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(112, 24);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContrasena.Location = new System.Drawing.Point(595, 335);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(440, 34);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.chkMostrarContrasena.Location = new System.Drawing.Point(596, 380);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(206, 28);
            this.chkMostrarContrasena.TabIndex = 7;
            this.chkMostrarContrasena.Text = "Mostrar contraseña";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(595, 425);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(440, 45);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // lineaIzquierda
            // 
            this.lineaIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lineaIzquierda.Location = new System.Drawing.Point(595, 510);
            this.lineaIzquierda.Name = "lineaIzquierda";
            this.lineaIzquierda.Size = new System.Drawing.Size(195, 1);
            this.lineaIzquierda.TabIndex = 9;
            // 
            // lblO
            // 
            this.lblO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblO.Location = new System.Drawing.Point(795, 498);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(40, 25);
            this.lblO.TabIndex = 10;
            this.lblO.Text = "O";
            this.lblO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineaDerecha
            // 
            this.lineaDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lineaDerecha.Location = new System.Drawing.Point(840, 510);
            this.lineaDerecha.Name = "lineaDerecha";
            this.lineaDerecha.Size = new System.Drawing.Size(195, 1);
            this.lineaDerecha.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(223)))), ((int)(((byte)(177)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(35)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(595, 550);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(440, 45);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lineaDerecha);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lineaIzquierda);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.chkMostrarContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panelIzquierdo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edu Café - Inicio de sesión";
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel lineaIzquierda;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Panel lineaDerecha;
        private System.Windows.Forms.Button btnSalir;
    }
}