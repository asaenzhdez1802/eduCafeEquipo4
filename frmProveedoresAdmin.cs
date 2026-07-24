using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmProveedoresAdmin : Form
    {
        int IdProveedorSeleccionado = 0;

        private float factorZoomActual = 1.0f;
        private const float INCREMENTO = 0.15f;
        private const float ZOOM_MAXIMO = 1.7f; 
        private const float ZOOM_MINIMO = 0.8f; 
        public frmProveedoresAdmin()
        {
            InitializeComponent();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmDashAdmin frm = new frmDashAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioAdmin frm = new frmInventarioAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();

            frm.Show();

            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();

            frm.Show();

            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿En realidad quiere cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                login frm = new login();

                frm.Show();

                this.Hide();
            }
        }

        private void frmProveedoresAdmin_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            Conexion Conclase = new Conexion();

            try
            {
                using (MySqlConnection conexion = Conclase.GetConexion())
                {
                    if (conexion.State == ConnectionState.Closed)
                    {
                        conexion.Open();
                    }

                    string query = "SELECT id_proveedor, nombre_proveedor, empresa, correo, telefono, calle, colonia, ciudad, codigo_postal, estado FROM proveedor";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvProveedores.DataSource = dt;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];
                IdProveedorSeleccionado = Convert.ToInt32(fila.Cells["id_proveedor"].Value);

                txtNombreProveedor.Text = fila.Cells["nombre_proveedor"].Value.ToString();
                txtEmpresa.Text = fila.Cells["empresa"].Value.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtCalle.Text = fila.Cells["calle"].Value.ToString();
                txtColonia.Text = fila.Cells["colonia"].Value.ToString();
                txtCiudad.Text = fila.Cells["ciudad"].Value.ToString();
                txtCodigoPostal.Text = fila.Cells["codigo_postal"].Value.ToString();
                txtEstado.Text = fila.Cells["estado"].Value.ToString();

                ConfigurarInterfaz(esNuevo: false);
            }
        }
  
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            ConfigurarInterfaz(esNuevo: true);
        }
        //Es para identificar que no hayan datos iguales
        private bool ExisteProveedor(string nombre, string correo, string telefono)
        {
            Conexion conClase = new Conexion();
            MySqlConnection dbConn = conClase.GetConexion();

            if (dbConn == null) return false;

            try
            {
                string sql = "SELECT COUNT(*) FROM proveedor WHERE nombre_proveedor = @nombre OR correo = @correo OR telefono =@telefono";
                MySqlCommand cmd = new MySqlCommand(sql, dbConn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                dbConn.Close();

                return cantidad > 0;
            }
            catch
            {
                if (dbConn.State == System.Data.ConnectionState.Open) dbConn.Close();
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtEmpresa.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtColonia.Text) || string.IsNullOrWhiteSpace(txtCiudad.Text) || string.IsNullOrWhiteSpace(txtCodigoPostal.Text) || txtEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            Conexion conClase = new Conexion();
            MySqlConnection dbConn = conClase.GetConexion();
            if (dbConn == null) return;

            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    if (ExisteProveedor(txtNombreProveedor.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim()))
                    {
                        MessageBox.Show("El proveedor ya existe en la base de datos.", "Proveedor existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dbConn.Close();
                        return;
                    }

                    string sql = "INSERT INTO proveedor (nombre_proveedor, empresa, correo, telefono, calle, colonia, ciudad, codigo_postal, estado) VALUES (@nombre_proveedor, @empresa, @correo, @telefono, @calle, @colonia, @ciudad, @codigo_postal, @estado)";
                    MySqlCommand cmd = new MySqlCommand(sql, dbConn);

                    cmd.Parameters.AddWithValue("@nombre_proveedor", txtNombreProveedor.Text.Trim());
                    cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                    cmd.Parameters.AddWithValue("@colonia", txtColonia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo_postal", txtCodigoPostal.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado", txtEstado.Text);

                    int filas = cmd.ExecuteNonQuery();
                    dbConn.Close();

                    if (filas > 0)
                    {
                        MessageBox.Show("Proveedor registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProveedores();
                        ConfigurarInterfaz(esNuevo: true);
                    }
                }
                else if (btnGuardar.Text == "Actualizar")
                {
                    if (dgvProveedores.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Por favor, selecciona primero un proveedor de la tabla para poder editarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dbConn.Close();
                        return;
                    }

                    DataGridViewRow fila = dgvProveedores.SelectedRows[0];

                    if (txtNombreProveedor.Text.Trim() == Convert.ToString(fila.Cells["nombre_proveedor"].Value).Trim() && txtEmpresa.Text.Trim() == Convert.ToString(fila.Cells["empresa"].Value).Trim() && txtCorreo.Text.Trim() == Convert.ToString(fila.Cells["correo"].Value).Trim() && txtTelefono.Text.Trim() == Convert.ToString(fila.Cells["telefono"].Value).Trim() && txtCalle.Text.Trim() == Convert.ToString(fila.Cells["calle"].Value).Trim() && txtColonia.Text.Trim() == Convert.ToString(fila.Cells["colonia"].Value).Trim() && txtCiudad.Text.Trim() == Convert.ToString(fila.Cells["ciudad"].Value).Trim() && txtCodigoPostal.Text.Trim() == Convert.ToString(fila.Cells["codigo_postal"].Value).Trim() && txtEstado.Text.Trim() == Convert.ToString(fila.Cells["estado"].Value).Trim())
                    {
                        MessageBox.Show("No se realizó ningún cambio porque los datos son idénticos a los actuales.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConn.Close();
                        return;
                    }

                    string sql = "UPDATE proveedor SET nombre_proveedor = @nombre_proveedor, empresa = @empresa, correo = @correo, telefono = @telefono, calle = @calle, colonia = @colonia, ciudad = @ciudad, codigo_postal = @codigo_postal, estado = @estado WHERE id_proveedor = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, dbConn);

                    cmd.Parameters.AddWithValue("@nombre_proveedor", txtNombreProveedor.Text.Trim());
                    cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                    cmd.Parameters.AddWithValue("@colonia", txtColonia.Text.Trim());
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo_postal", txtCodigoPostal.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@id", IdProveedorSeleccionado);

                    cmd.ExecuteNonQuery();
                    dbConn.Close();

                    MessageBox.Show("Datos del proveedor actualizados con éxito.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    ConfigurarInterfaz(esNuevo: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación del Proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dbConn.State == System.Data.ConnectionState.Open) dbConn.Close();
            }
        }
        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProveedor.Text))
            {
                CargarProveedores();
                return;
            }

            Conexion conClase = new Conexion();
            MySqlConnection conn = conClase.GetConexion();
            if (conn == null) return;

            try
            {
                string sql = "SELECT id_proveedor, nombre_proveedor, empresa, correo, telefono, calle, colonia, ciudad, codigo_postal, estado " +
                             "FROM proveedor " +
                             "WHERE nombre_proveedor LIKE @nombre";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscarProveedor.Text.Trim() + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProveedores.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por nombre: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        // Método para limpiar todos los campos del formulario
        private void LimpiarCampos()
        {
            txtNombreProveedor.Clear();
            txtEmpresa.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
            txtCiudad.Clear();
            txtCodigoPostal.Clear();
            txtEstado.SelectedIndex = -1;
            IdProveedorSeleccionado = 0;
        }
        //Configuraciones de los interfaces como también integra limpiar los formularios
        private void ConfigurarInterfaz(bool esNuevo)
        {
            if (esNuevo)
            {
                LimpiarCampos();
                btnGuardar.Text = "Guardar";
            }
            else
            {
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaAdmin frm = new frmCategoriaAdmin();

            frm.Show();

            this.Hide();
        }

        private void AplicarZoom(Control parent, float factor)
        {
            foreach (Control c in parent.Controls)
            {
                // Guarda el tamaño original 
                if (c.Tag == null || !(c.Tag is float))
                {
                    c.Tag = c.Font.Size;
                }

                float tamanoBase = (float)c.Tag;
                c.Font = new Font(c.Font.FontFamily, tamanoBase * factor, c.Font.Style);

                if (c.HasChildren)
                {
                    AplicarZoom(c, factor);
                }
            }
        }

        private void bntMasZoom_Click(object sender, EventArgs e)
        {
            if (factorZoomActual < ZOOM_MAXIMO)
            {
                factorZoomActual += INCREMENTO;
                AplicarZoom(this, factorZoomActual);
            }
        }

        private void btnMenosZoom_Click(object sender, EventArgs e)
        {
            if (factorZoomActual > ZOOM_MINIMO)
            {
                factorZoomActual -= INCREMENTO;
                AplicarZoom(this, factorZoomActual);
            }
        }

        private void btnRestZoom_Click(object sender, EventArgs e)
        {
            factorZoomActual = 1.0f;
            AplicarZoom(this, factorZoomActual);
        }
    }
}