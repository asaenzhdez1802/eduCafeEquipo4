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
    public partial class frmReportes : Form
    {
        public frmReportes()
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventarioAdmin frm = new frmInventarioAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedoresAdmin frm = new frmProveedoresAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();

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

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaAdmin frm = new frmCategoriaAdmin();

            frm.Show();

            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductosAdmin frm = new frmProductosAdmin();

            frm.Show();
            this.Hide();
        }
    }
}
