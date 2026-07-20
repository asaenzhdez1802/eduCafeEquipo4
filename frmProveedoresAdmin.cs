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
                txtCorreo.Text = fila.Cells["empresa"].Value.ToString();
                txtTelefono.Text = fila.Cells["correo"].Value.ToString();
                txtEmpresa.Text = fila.Cells["telefono"].Value.ToString();
                txtCalle.Text = fila.Cells["calle"].Value.ToString();
                txtColonia.Text = fila.Cells["colonia"].Value.ToString();
                txtCiudad.Text = fila.Cells["ciudad"].Value.ToString();
                txtCodigoPostal.Text = fila.Cells["codigo_postal"].Value.ToString();
                txtEstado.Text = fila.Cells["estado"].Value.ToString();
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) |
              string.IsNullOrWhiteSpace(txtEmpresa.Text) ||
              string.IsNullOrWhiteSpace(txtCorreo.Text) ||
              string.IsNullOrWhiteSpace(txtTelefono.Text) ||
              string.IsNullOrWhiteSpace(txtCalle.Text) ||
              string.IsNullOrWhiteSpace(txtColonia.Text) ||
              string.IsNullOrWhiteSpace(txtCiudad.Text) ||
              string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
              string.IsNullOrWhiteSpace(txtEstado.Text))
          {
              MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
          }

          if (ExisteProveedor(txtNombreProveedor.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim()))
          {
              MessageBox.Show("El proveedor ya existe en la base de datos.", "Proveedor existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              return;
          }


          Conexion conClase = new Conexion();
          MySqlConnection dbConn = conClase.GetConexion();

          //Si falla la conexion
          if (dbConn == null) return;

          try
          {
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
                  MessageBox.Show("Proovedor registrado con éxito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  CargarProveedores();

                  txtNombreProveedor.Clear();
                  txtEmpresa.Clear();
                  txtCorreo.Clear();
                  txtTelefono.Clear();
                  txtCalle.Clear();
                  txtColonia.Clear();
                  txtCiudad.Clear();
                  txtCodigoPostal.Clear();
                  txtEstado.SelectedIndex = -1;
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show("Error al registrar el Proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              if (dbConn.State == System.Data.ConnectionState.Open)
              {
                  dbConn.Close();
              }
          }
        }

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
    }
}