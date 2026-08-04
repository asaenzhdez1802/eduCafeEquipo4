using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmPuntodeVentaCajero : Form
    {
        private bool cargandoCategorias = false;
        private bool actualizandoImportes = false;

        private const int PRODUCTO_ID = 0;
        private const int PRODUCTO_NOMBRE = 1;
        private const int PRODUCTO_CATEGORIA = 2;
        private const int PRODUCTO_PRECIO = 3;
        private const int PRODUCTO_STOCK = 4;
        private const int PRODUCTO_AGREGAR = 5;

        private const int DETALLE_PRODUCTO = 0;
        private const int DETALLE_PRECIO = 1;
        private const int DETALLE_CANTIDAD = 2;
        private const int DETALLE_SUBTOTAL = 3;
        private const int DETALLE_ACCIONES = 4;

        private sealed class ProductoCarritoInfo
        {
            public int IdProducto { get; set; }
            public int StockDisponible { get; set; }
        }

        private sealed class ArticuloVenta
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal { get; set; }
        }

        public frmPuntodeVentaCajero()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {

            Load -= frmPuntodeVentaCajero_Load;
            Load += frmPuntodeVentaCajero_Load;

            txtBuscarProducto.TextChanged -= txtBuscarProducto_TextChanged;

            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;

            cmbBuscarCategoria.SelectedIndexChanged -= cmbBuscarCategoria_SelectedIndexChanged;

            cmbBuscarCategoria.SelectedIndexChanged += cmbBuscarCategoria_SelectedIndexChanged;

            cmbMetodoPago.SelectedIndexChanged -= cmbMetodoPago_SelectedIndexChanged;

            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;

            txtTotalRecibido.TextChanged -= txtTotalRecibido_TextChanged;

            txtTotalRecibido.TextChanged += txtTotalRecibido_TextChanged;

            txtTotalRecibido.KeyPress -= txtTotalRecibido_KeyPress;

            txtTotalRecibido.KeyPress += txtTotalRecibido_KeyPress;

            dgvProductosVenta.CellClick -= dgvProductosVenta_CellClick;

            dgvProductosVenta.CellClick += dgvProductosVenta_CellClick;

            dgvDetalleVenta.CellClick -= dgvDetalleVenta_CellClick;

            dgvDetalleVenta.CellClick += dgvDetalleVenta_CellClick;

            btnCancelarVenta.Click -= btnCancelar_Click;
            btnCancelarVenta.Click += btnCancelar_Click;

            btnCobrarVenta.Click -= btnCobrar_Click;
            btnCobrarVenta.Click += btnCobrar_Click;

            btnMisVentas.Click -= btnMisVentas_Click;
            btnMisVentas.Click += btnMisVentas_Click;

            btnCerrarSesion.Click -= btnCerrarSesion_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
        }

        private void frmPuntodeVentaCajero_Load(object sender, EventArgs e)
        {
            if (!ValidarSesion())
            {
                return;
            }

            ConfigurarFormulario();
            CargarCategorias();
            CargarProductos();
        }

        private bool ValidarSesion()
        {
            if (!SesionActual.HaySesionActiva)
            {
                MessageBox.Show(
                    "No existe una sesión activa. Inicia sesión nuevamente.",
                    "Sesión no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                MostrarLogin();
                return false;
            }

            if (!SesionActual.Rol.Equals(
                "Cajero",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Esta sección solamente está disponible para cajeros.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                SesionActual.CerrarSesion();
                MostrarLogin();

                return false;
            }

            return true;
        }

        private void ConfigurarFormulario()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.SelectedIndex = 0;

            txtSubtotal.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtTotalRecibido.Clear();
            txtCambio.Text = "0.00";

            txtSubtotal.ReadOnly = true;
            txtTotalPagar.ReadOnly = true;
            txtCambio.ReadOnly = true;

            dgvProductosVenta.AllowUserToAddRows = false;
            dgvProductosVenta.AllowUserToDeleteRows = false;
            dgvProductosVenta.ReadOnly = true;
            dgvProductosVenta.MultiSelect = false;
            dgvProductosVenta.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            if (dgvProductosVenta.ColumnCount > PRODUCTO_PRECIO)
            {
                dgvProductosVenta
                    .Columns[PRODUCTO_PRECIO]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvDetalleVenta.ColumnCount > DETALLE_PRECIO)
            {
                dgvDetalleVenta
                    .Columns[DETALLE_PRECIO]
                    .DefaultCellStyle.Format = "N2";
            }

            if (dgvDetalleVenta.ColumnCount > DETALLE_SUBTOTAL)
            {
                dgvDetalleVenta
                    .Columns[DETALLE_SUBTOTAL]
                    .DefaultCellStyle.Format = "N2";
            }

            dgvProductosVenta.ClearSelection();
            dgvDetalleVenta.ClearSelection();

            lblNota.Text =
                $"Cajero: {SesionActual.NombreCompleto}. " +
                "Selecciona un producto para comenzar la venta.";
        }

        private void CargarCategorias()
        {
            cargandoCategorias = true;

            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT
                            id_categoria,
                            nombre
                        FROM categoria
                        WHERE estado = 'Activo'
                        ORDER BY nombre ASC;";

                    using (MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion))
                    {
                        DataTable tablaCategorias =
                            new DataTable();

                        adaptador.Fill(tablaCategorias);

                        DataRow filaTodas =
                            tablaCategorias.NewRow();

                        filaTodas["id_categoria"] = 0;
                        filaTodas["nombre"] = "Todas";

                        tablaCategorias.Rows.InsertAt(
                            filaTodas,
                            0
                        );

                        cmbBuscarCategoria.DisplayMember =
                            "nombre";

                        cmbBuscarCategoria.ValueMember =
                            "id_categoria";

                        cmbBuscarCategoria.DataSource =
                            tablaCategorias;

                        cmbBuscarCategoria.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar las categorías.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                cargandoCategorias = false;
            }
        }

        private int ObtenerCategoriaSeleccionada()
        {
            if (cmbBuscarCategoria.SelectedValue == null)
            {
                return 0;
            }

            if (int.TryParse(
                cmbBuscarCategoria.SelectedValue.ToString(),
                out int idCategoria))
            {
                return idCategoria;
            }

            return 0;
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductosVenta.Rows.Clear();

                string nombreProducto =
                    txtBuscarProducto.Text.Trim();

                int idCategoria =
                    ObtenerCategoriaSeleccionada();

                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        return;
                    }

                    string consulta = @"
                        SELECT
                            p.id_producto,
                            p.nombre AS producto,
                            c.nombre AS categoria,
                            p.precio_venta,
                            COALESCE(
                                i.existencia_actual,
                                0
                            ) AS existencia_actual
                        FROM producto AS p
                        INNER JOIN categoria AS c
                            ON c.id_categoria = p.id_categoria
                        LEFT JOIN inventario AS i
                            ON i.id_producto = p.id_producto
                        WHERE p.estado = 'Activo'
                          AND c.estado = 'Activo'
                          AND (
                              @nombreProducto = ''
                              OR p.nombre LIKE @busqueda
                          )
                          AND (
                              @idCategoria = 0
                              OR p.id_categoria = @idCategoria
                          )
                        ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(
                            "@nombreProducto",
                            MySqlDbType.VarChar
                        ).Value = nombreProducto;

                        comando.Parameters.Add(
                            "@busqueda",
                            MySqlDbType.VarChar
                        ).Value = "%" + nombreProducto + "%";

                        comando.Parameters.Add(
                            "@idCategoria",
                            MySqlDbType.Int32
                        ).Value = idCategoria;

                        using (MySqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                decimal precio =
                                    Convert.ToDecimal(
                                        lector["precio_venta"]
                                    );

                                int existencia =
                                    Convert.ToInt32(
                                        lector["existencia_actual"]
                                    );

                                dgvProductosVenta.Rows.Add(
                                    lector["id_producto"],
                                    lector["producto"],
                                    lector["categoria"],
                                    precio,
                                    existencia,
                                    existencia > 0
                                        ? "Agregar"
                                        : "Sin stock"
                                );
                            }
                        }
                    }
                }

                dgvProductosVenta.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar los productos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarProducto_TextChanged(
            object sender,
            EventArgs e)
        {
            CargarProductos();
        }

        private void cmbBuscarCategoria_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (!cargandoCategorias)
            {
                CargarProductos();
            }
        }

        private void dgvProductosVenta_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != PRODUCTO_AGREGAR)
            {
                return;
            }

            DataGridViewRow fila =
                dgvProductosVenta.Rows[e.RowIndex];

            int idProducto =
                Convert.ToInt32(
                    fila.Cells[PRODUCTO_ID].Value
                );

            string nombreProducto =
                Convert.ToString(
                    fila.Cells[PRODUCTO_NOMBRE].Value
                );

            decimal precio =
                Convert.ToDecimal(
                    fila.Cells[PRODUCTO_PRECIO].Value
                );

            int existencia =
                Convert.ToInt32(
                    fila.Cells[PRODUCTO_STOCK].Value
                );

            if (existencia <= 0)
            {
                MessageBox.Show(
                    "Este producto no tiene existencias disponibles.",
                    "Producto sin stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            AgregarProductoAlDetalle(
                idProducto,
                nombreProducto,
                precio,
                existencia
            );
        }

        private void AgregarProductoAlDetalle(
            int idProducto,
            string nombreProducto,
            decimal precio,
            int stockDisponible)
        {
            foreach (DataGridViewRow fila
                in dgvDetalleVenta.Rows)
            {
                ProductoCarritoInfo informacion =
                    fila.Tag as ProductoCarritoInfo;

                if (informacion == null)
                {
                    continue;
                }

                if (informacion.IdProducto != idProducto)
                {
                    continue;
                }

                int cantidadActual =
                    Convert.ToInt32(
                        fila.Cells[DETALLE_CANTIDAD].Value
                    );

                if (cantidadActual >=
                    informacion.StockDisponible)
                {
                    MessageBox.Show(
                        "No puedes agregar más unidades porque alcanzaste el stock disponible.",
                        "Stock insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                cantidadActual++;

                fila.Cells[DETALLE_CANTIDAD].Value =
                    cantidadActual;

                fila.Cells[DETALLE_SUBTOTAL].Value =
                    precio * cantidadActual;

                CalcularTotales();
                return;
            }

            int indiceFila =
                dgvDetalleVenta.Rows.Add(
                    nombreProducto,
                    precio,
                    1,
                    precio,
                    "Quitar"
                );

            dgvDetalleVenta
                .Rows[indiceFila]
                .Tag = new ProductoCarritoInfo
                {
                    IdProducto = idProducto,
                    StockDisponible = stockDisponible
                };

            CalcularTotales();

            lblNota.Text =
                $"Se agregó {nombreProducto} a la venta.";
        }

        private void dgvDetalleVenta_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != DETALLE_ACCIONES)
            {
                return;
            }

            DataGridViewRow fila =
                dgvDetalleVenta.Rows[e.RowIndex];

            int cantidad =
                Convert.ToInt32(
                    fila.Cells[DETALLE_CANTIDAD].Value
                );

            if (cantidad > 1)
            {
                cantidad--;

                decimal precio =
                    Convert.ToDecimal(
                        fila.Cells[DETALLE_PRECIO].Value
                    );

                fila.Cells[DETALLE_CANTIDAD].Value =
                    cantidad;

                fila.Cells[DETALLE_SUBTOTAL].Value =
                    precio * cantidad;
            }
            else
            {
                dgvDetalleVenta.Rows.RemoveAt(e.RowIndex);
            }

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila
                in dgvDetalleVenta.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                subtotal += Convert.ToDecimal(
                    fila.Cells[DETALLE_SUBTOTAL].Value
                );
            }

            txtSubtotal.Text =
                subtotal.ToString("0.00");


            txtTotalPagar.Text =
                subtotal.ToString("0.00");

            ActualizarCambio();
        }

        private void cmbMetodoPago_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ActualizarEstadoMetodoPago();
        }

        private void ActualizarEstadoMetodoPago()
        {
            string metodo =
                cmbMetodoPago.SelectedItem?.ToString()
                ?? "Efectivo";

            bool esTarjeta =
                metodo.Equals(
                    "Tarjeta",
                    StringComparison.OrdinalIgnoreCase
                );

            actualizandoImportes = true;

            try
            {
                if (esTarjeta)
                {
                    txtTotalRecibido.ReadOnly = true;
                    txtTotalRecibido.Text =
                        txtTotalPagar.Text;

                    txtCambio.Text = "0.00";
                }
                else
                {
                    txtTotalRecibido.ReadOnly = false;
                    txtTotalRecibido.Clear();
                    txtCambio.Text = "0.00";
                }
            }
            finally
            {
                actualizandoImportes = false;
            }

            ActualizarCambio();
        }

        private void txtTotalRecibido_TextChanged(
            object sender,
            EventArgs e)
        {
            if (!actualizandoImportes)
            {
                ActualizarCambio();
            }
        }

        private void txtTotalRecibido_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) ||
                char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                bool yaTieneSeparador =
                    txtTotalRecibido.Text.Contains(".") ||
                    txtTotalRecibido.Text.Contains(",");

                e.Handled = yaTieneSeparador;
                return;
            }

            e.Handled = true;
        }

        private void ActualizarCambio()
        {
            decimal total = ObtenerDecimal(
                txtTotalPagar.Text
            );

            string metodo =
                cmbMetodoPago.SelectedItem?.ToString()
                ?? "Efectivo";

            if (metodo.Equals(
                "Tarjeta",
                StringComparison.OrdinalIgnoreCase))
            {
                actualizandoImportes = true;

                try
                {
                    txtTotalRecibido.Text =
                        total.ToString("0.00");

                    txtCambio.Text = "0.00";
                }
                finally
                {
                    actualizandoImportes = false;
                }

                return;
            }

            decimal recibido =
                ObtenerDecimal(
                    txtTotalRecibido.Text
                );

            decimal cambio = recibido - total;

            txtCambio.Text =
                cambio > 0
                    ? cambio.ToString("0.00")
                    : "0.00";

            if (dgvDetalleVenta.Rows.Count == 0)
            {
                lblNota.Text =
                    $"Cajero: {SesionActual.NombreCompleto}. " +
                    "Selecciona un producto para comenzar la venta.";

                return;
            }

            if (recibido > 0 && recibido < total)
            {
                decimal faltante = total - recibido;

                lblNota.Text =
                    $"Faltan ${faltante:0.00} para completar el pago.";
            }
            else
            {
                lblNota.Text =
                    "La venta está lista para cobrarse.";
            }
        }

        private decimal ObtenerDecimal(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return 0;
            }

            if (decimal.TryParse(
                texto,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal resultado))
            {
                return resultado;
            }

            string textoNormalizado =
                texto.Replace(',', '.');

            if (decimal.TryParse(
                textoNormalizado,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out resultado))
            {
                return resultado;
            }

            return 0;
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                LimpiarVenta();
                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Deseas cancelar la venta actual?",
                    "Cancelar venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta == DialogResult.Yes)
            {
                LimpiarVenta();
            }
        }

        private void LimpiarVenta()
        {
            actualizandoImportes = true;

            try
            {
                dgvDetalleVenta.Rows.Clear();

                txtSubtotal.Text = "0.00";
                txtTotalPagar.Text = "0.00";
                txtTotalRecibido.Clear();
                txtCambio.Text = "0.00";

                cmbMetodoPago.SelectedIndex = 0;
            }
            finally
            {
                actualizandoImportes = false;
            }

            txtTotalRecibido.ReadOnly = false;

            lblNota.Text =
                $"Cajero: {SesionActual.NombreCompleto}. " +
                "Selecciona un producto para comenzar la venta.";

            dgvDetalleVenta.ClearSelection();
        }

        private void btnCobrar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSesion())
            {
                return;
            }

            List<ArticuloVenta> articulos =
                ObtenerArticulosVenta();

            if (articulos.Count == 0)
            {
                MessageBox.Show(
                    "Agrega al menos un producto antes de cobrar.",
                    "Venta vacía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal total =
                ObtenerDecimal(txtTotalPagar.Text);

            if (total <= 0)
            {
                MessageBox.Show(
                    "El total de la venta no es válido.",
                    "Total no válido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string metodoPago =
                cmbMetodoPago.SelectedItem?.ToString()
                ?? "Efectivo";

            decimal montoRecibido;
            decimal cambio;

            if (metodoPago.Equals(
                "Efectivo",
                StringComparison.OrdinalIgnoreCase))
            {
                montoRecibido =
                    ObtenerDecimal(
                        txtTotalRecibido.Text
                    );

                if (montoRecibido < total)
                {
                    MessageBox.Show(
                        "El monto recibido es menor al total de la venta.",
                        "Monto insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtTotalRecibido.Focus();
                    return;
                }

                cambio = montoRecibido - total;
            }
            else
            {
                montoRecibido = total;
                cambio = 0;
            }

            DialogResult confirmacion =
                MessageBox.Show(
                    $"¿Deseas registrar la venta por ${total:0.00}?",
                    "Confirmar cobro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            RegistrarVenta(
                articulos,
                total,
                montoRecibido,
                cambio,
                metodoPago
            );
        }

        private List<ArticuloVenta> ObtenerArticulosVenta()
        {
            List<ArticuloVenta> articulos =
                new List<ArticuloVenta>();

            foreach (DataGridViewRow fila
                in dgvDetalleVenta.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                ProductoCarritoInfo informacion =
                    fila.Tag as ProductoCarritoInfo;

                if (informacion == null)
                {
                    continue;
                }

                articulos.Add(
                    new ArticuloVenta
                    {
                        IdProducto =
                            informacion.IdProducto,

                        Nombre =
                            Convert.ToString(
                                fila.Cells[
                                    DETALLE_PRODUCTO
                                ].Value
                            ),

                        PrecioUnitario =
                            Convert.ToDecimal(
                                fila.Cells[
                                    DETALLE_PRECIO
                                ].Value
                            ),

                        Cantidad =
                            Convert.ToInt32(
                                fila.Cells[
                                    DETALLE_CANTIDAD
                                ].Value
                            ),

                        Subtotal =
                            Convert.ToDecimal(
                                fila.Cells[
                                    DETALLE_SUBTOTAL
                                ].Value
                            )
                    }
                );
            }

            return articulos;
        }

        private void RegistrarVenta(
            List<ArticuloVenta> articulos,
            decimal total,
            decimal montoRecibido,
            decimal cambio,
            string metodoPago)
        {
            try
            {
                using (MySqlConnection conexion =
                    new Conexion().GetConexion())
                {
                    if (conexion == null)
                    {
                        MessageBox.Show(
                            "No fue posible conectarse a la base de datos.",
                            "Error de conexión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    using (MySqlTransaction transaccion =
                        conexion.BeginTransaction())
                    {
                        try
                        {

                            foreach (ArticuloVenta articulo
                                in articulos)
                            {
                                ValidarExistencia(
                                    conexion,
                                    transaccion,
                                    articulo
                                );
                            }

                            int idCliente =
                                ObtenerOCrearClientePublicoGeneral(
                                    conexion,
                                    transaccion
                                );

                            bool tieneMetodoPago =
                                ExisteColumnaMetodoPago(
                                    conexion,
                                    transaccion
                                );

                            long idVenta =
                                InsertarVenta(
                                    conexion,
                                    transaccion,
                                    idCliente,
                                    total,
                                    montoRecibido,
                                    cambio,
                                    metodoPago,
                                    tieneMetodoPago
                                );

                            foreach (ArticuloVenta articulo
                                in articulos)
                            {
                                InsertarDetalleVenta(
                                    conexion,
                                    transaccion,
                                    idVenta,
                                    articulo
                                );

                                DescontarInventario(
                                    conexion,
                                    transaccion,
                                    articulo
                                );

                                RegistrarMovimientoInventario(
                                    conexion,
                                    transaccion,
                                    articulo
                                );
                            }

                            transaccion.Commit();

                            MessageBox.Show(
                                $"Venta #{idVenta} registrada correctamente.\n\n" +
                                $"Cajero: {SesionActual.NombreCompleto}\n" +
                                $"Total: ${total:0.00}\n" +
                                $"Cambio: ${cambio:0.00}",
                                "Venta completada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LimpiarVenta();
                            CargarProductos();
                        }
                        catch
                        {
                            try
                            {
                                transaccion.Rollback();
                            }
                            catch
                            {
                                // No se reemplaza el error original.
                            }

                            throw;
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo completar la venta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al registrar la venta.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ValidarExistencia(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            ArticuloVenta articulo)
        {
            string consulta = @"
                SELECT existencia_actual
                FROM inventario
                WHERE id_producto = @idProducto
                FOR UPDATE;";

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                comando.Parameters.Add(
                    "@idProducto",
                    MySqlDbType.Int32
                ).Value = articulo.IdProducto;

                object resultado =
                    comando.ExecuteScalar();

                if (resultado == null ||
                    resultado == DBNull.Value)
                {
                    throw new InvalidOperationException(
                        $"El producto \"{articulo.Nombre}\" no tiene un registro de inventario."
                    );
                }

                int existenciaActual =
                    Convert.ToInt32(resultado);

                if (existenciaActual < articulo.Cantidad)
                {
                    throw new InvalidOperationException(
                        $"No existe suficiente stock para \"{articulo.Nombre}\".\n" +
                        $"Disponible: {existenciaActual}\n" +
                        $"Solicitado: {articulo.Cantidad}"
                    );
                }
            }
        }

        private int ObtenerOCrearClientePublicoGeneral(
            MySqlConnection conexion,
            MySqlTransaction transaccion)
        {
            string buscarCliente = @"
                SELECT id_cliente
                FROM cliente
                WHERE nombres = 'Público'
                  AND primer_apellido = 'General'
                LIMIT 1;";

            using (MySqlCommand comandoBuscar =
                new MySqlCommand(
                    buscarCliente,
                    conexion,
                    transaccion
                ))
            {
                object resultado =
                    comandoBuscar.ExecuteScalar();

                if (resultado != null &&
                    resultado != DBNull.Value)
                {
                    return Convert.ToInt32(resultado);
                }
            }

            string insertarCliente = @"
                INSERT INTO cliente
                (
                    nombres,
                    primer_apellido,
                    segundo_apellido,
                    telefono,
                    correo
                )
                VALUES
                (
                    'Público',
                    'General',
                    NULL,
                    NULL,
                    NULL
                );";

            using (MySqlCommand comandoInsertar =
                new MySqlCommand(
                    insertarCliente,
                    conexion,
                    transaccion
                ))
            {
                comandoInsertar.ExecuteNonQuery();

                return Convert.ToInt32(
                    comandoInsertar.LastInsertedId
                );
            }
        }

        private bool ExisteColumnaMetodoPago(
            MySqlConnection conexion,
            MySqlTransaction transaccion)
        {
            string consulta = @"
                SELECT COUNT(*)
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = DATABASE()
                  AND TABLE_NAME = 'venta'
                  AND COLUMN_NAME = 'metodo_pago';";

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                int cantidad =
                    Convert.ToInt32(
                        comando.ExecuteScalar()
                    );

                return cantidad > 0;
            }
        }

        private long InsertarVenta(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            int idCliente,
            decimal total,
            decimal montoRecibido,
            decimal cambio,
            string metodoPago,
            bool tieneMetodoPago)
        {
            string consulta;

            if (tieneMetodoPago)
            {
                consulta = @"
                    INSERT INTO venta
                    (
                        id_cliente,
                        id_usuario,
                        monto_recibido,
                        cambio,
                        metodo_pago,
                        total
                    )
                    VALUES
                    (
                        @idCliente,
                        @idUsuario,
                        @montoRecibido,
                        @cambio,
                        @metodoPago,
                        @total
                    );";
            }
            else
            {

                consulta = @"
                    INSERT INTO venta
                    (
                        id_cliente,
                        id_usuario,
                        monto_recibido,
                        cambio,
                        total
                    )
                    VALUES
                    (
                        @idCliente,
                        @idUsuario,
                        @montoRecibido,
                        @cambio,
                        @total
                    );";
            }

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                comando.Parameters.Add(
                    "@idCliente",
                    MySqlDbType.Int32
                ).Value = idCliente;


                comando.Parameters.Add(
                    "@idUsuario",
                    MySqlDbType.Int32
                ).Value = SesionActual.IdUsuario;

                comando.Parameters.Add(
                    "@montoRecibido",
                    MySqlDbType.Decimal
                ).Value = montoRecibido;

                comando.Parameters.Add(
                    "@cambio",
                    MySqlDbType.Decimal
                ).Value = cambio;

                comando.Parameters.Add(
                    "@total",
                    MySqlDbType.Decimal
                ).Value = total;

                if (tieneMetodoPago)
                {
                    comando.Parameters.Add(
                        "@metodoPago",
                        MySqlDbType.VarChar
                    ).Value = metodoPago;
                }

                comando.ExecuteNonQuery();

                return comando.LastInsertedId;
            }
        }

        private void InsertarDetalleVenta(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            long idVenta,
            ArticuloVenta articulo)
        {
            string consulta = @"
                INSERT INTO detalle_venta
                (
                    id_venta,
                    id_producto,
                    cantidad,
                    precio_unitario,
                    subtotal
                )
                VALUES
                (
                    @idVenta,
                    @idProducto,
                    @cantidad,
                    @precioUnitario,
                    @subtotal
                );";

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                comando.Parameters.Add(
                    "@idVenta",
                    MySqlDbType.Int64
                ).Value = idVenta;

                comando.Parameters.Add(
                    "@idProducto",
                    MySqlDbType.Int32
                ).Value = articulo.IdProducto;

                comando.Parameters.Add(
                    "@cantidad",
                    MySqlDbType.Int32
                ).Value = articulo.Cantidad;

                comando.Parameters.Add(
                    "@precioUnitario",
                    MySqlDbType.Decimal
                ).Value = articulo.PrecioUnitario;

                comando.Parameters.Add(
                    "@subtotal",
                    MySqlDbType.Decimal
                ).Value = articulo.Subtotal;

                comando.ExecuteNonQuery();
            }
        }

        private void DescontarInventario(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            ArticuloVenta articulo)
        {
            string consulta = @"
                UPDATE inventario
                SET existencia_actual =
                    existencia_actual - @cantidad
                WHERE id_producto = @idProducto
                  AND existencia_actual >= @cantidad;";

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                comando.Parameters.Add(
                    "@cantidad",
                    MySqlDbType.Int32
                ).Value = articulo.Cantidad;

                comando.Parameters.Add(
                    "@idProducto",
                    MySqlDbType.Int32
                ).Value = articulo.IdProducto;

                int filasAfectadas =
                    comando.ExecuteNonQuery();

                if (filasAfectadas != 1)
                {
                    throw new InvalidOperationException(
                        $"No fue posible descontar el inventario de \"{articulo.Nombre}\"."
                    );
                }
            }
        }

        private void RegistrarMovimientoInventario(
            MySqlConnection conexion,
            MySqlTransaction transaccion,
            ArticuloVenta articulo)
        {
            string consulta = @"
                INSERT INTO movimiento_inventario
                (
                    id_producto,
                    tipo_movimiento,
                    cantidad
                )
                VALUES
                (
                    @idProducto,
                    'Salida',
                    @cantidad
                );";

            using (MySqlCommand comando =
                new MySqlCommand(
                    consulta,
                    conexion,
                    transaccion
                ))
            {
                comando.Parameters.Add(
                    "@idProducto",
                    MySqlDbType.Int32
                ).Value = articulo.IdProducto;

                comando.Parameters.Add(
                    "@cantidad",
                    MySqlDbType.Int32
                ).Value = articulo.Cantidad;

                comando.ExecuteNonQuery();
            }
        }

        private void btnMisVentas_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarSesion())
            {
                return;
            }

            frmMisVentasCajero formularioMisVentas =
                new frmMisVentasCajero();

            formularioMisVentas.Show();

            Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿En realidad quieres cerrar sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            SesionActual.CerrarSesion();
            MostrarLogin();
        }

        private void MostrarLogin()
        {

            login formularioLogin =
                Application.OpenForms
                    .OfType<login>()
                    .FirstOrDefault(
                        formulario =>
                            !formulario.IsDisposed
                    );

            if (formularioLogin == null)
            {
                formularioLogin = new login();
            }

            LimpiarControlesLogin(formularioLogin);

            formularioLogin.Show();
            formularioLogin.WindowState =
                FormWindowState.Normal;

            formularioLogin.BringToFront();
            formularioLogin.Activate();

            Close();
        }

        private void LimpiarControlesLogin(
            login formularioLogin)
        {
            TextBox campoUsuario =
                formularioLogin.Controls
                    .Find("txtUsuario", true)
                    .FirstOrDefault() as TextBox;

            TextBox campoContrasena =
                formularioLogin.Controls
                    .Find("txtContrasena", true)
                    .FirstOrDefault() as TextBox;

            CheckBox mostrarContrasena = formularioLogin.Controls
                    .Find("chkMostrarContrasena", true)
                    .FirstOrDefault() as CheckBox;

            campoUsuario?.Clear();
            campoContrasena?.Clear();

            if (mostrarContrasena != null)
            {
                mostrarContrasena.Checked = false;
            }

            campoUsuario?.Focus();
        }
    }
}