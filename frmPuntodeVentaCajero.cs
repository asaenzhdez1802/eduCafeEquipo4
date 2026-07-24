using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace eduCafeEquipo4
{
    public partial class frmPuntodeVentaCajero : Form
    {
        private readonly int idCajero;
        private readonly string nombreCajero;

        private bool cargandoCategorias;

        public frmPuntodeVentaCajero(
            int idUsuario,
            string nombreCompleto)
        {
            InitializeComponent();

            idCajero = idUsuario;
            nombreCajero = nombreCompleto;

            Text = "Punto de venta - " + nombreCajero;

            ConfigurarFormulario();
            ConectarEventos();


            CargarCategorias();
            CargarProductos();
        }

        private void ConfigurarFormulario()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.SelectedIndex = 0;

            txtSubtotal.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtTotalRecibido.Text = "";
            txtCambio.Text = "0.00";

            dgvProductosVenta.ClearSelection();
            dgvDetalleVenta.ClearSelection();
            colDetallePrecio.DefaultCellStyle.Format = "0.00";
            colDetalleSubtotal.DefaultCellStyle.Format = "0.00";
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

            if (e.ColumnIndex != colAgregar.Index)
            {
                return;
            }

            DataGridViewRow filaProducto =
                dgvProductosVenta.Rows[e.RowIndex];

            int idProducto = Convert.ToInt32(
                filaProducto.Cells[colIdProducto.Index].Value
            );

            string nombreProducto = Convert.ToString(
                filaProducto.Cells[colProducto.Index].Value
            );

            decimal precio = Convert.ToDecimal(
                filaProducto.Cells[colPrecio.Index].Value
            );

            int stock = Convert.ToInt32(
                filaProducto.Cells[colStock.Index].Value
            );

            if (stock <= 0)
            {
                MessageBox.Show(
                    "El producto no tiene existencias disponibles.",
                    "Producto agotado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            foreach (DataGridViewRow filaDetalle
                     in dgvDetalleVenta.Rows)
            {
                if (filaDetalle.Tag == null)
                {
                    continue;
                }

                int idProductoDetalle =
                    Convert.ToInt32(filaDetalle.Tag);

                if (idProductoDetalle == idProducto)
                {
                    int cantidadActual = Convert.ToInt32(
                        filaDetalle.Cells[
                            colDetalleCantidad.Index
                        ].Value
                    );

                    if (cantidadActual >= stock)
                    {
                        MessageBox.Show(
                            "No puedes agregar más unidades. " +
                            "Solamente hay " + stock +
                            " disponibles.",
                            "Stock insuficiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    int nuevaCantidad = cantidadActual + 1;

                    filaDetalle.Cells[
                        colDetalleCantidad.Index
                    ].Value = nuevaCantidad;

                    filaDetalle.Cells[
                        colDetalleSubtotal.Index
                    ].Value = precio * nuevaCantidad;

                    ActualizarTotales();
                    return;
                }
            }

            int indiceFila = dgvDetalleVenta.Rows.Add(
                nombreProducto,
                precio,
                1,
                precio,
                "Quitar 1"
            );

            DataGridViewRow nuevaFila =
                dgvDetalleVenta.Rows[indiceFila];

            nuevaFila.Tag = idProducto;

            nuevaFila.Cells[
                colDetalleCantidad.Index
            ].Tag = stock;

            ActualizarTotales();

            lblNota.Text =
                "Producto agregado. Puedes continuar con la venta.";
        }
        private void dgvDetalleVenta_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex != colDetalleAcciones.Index)
            {
                return;
            }

            DataGridViewRow fila =
                dgvDetalleVenta.Rows[e.RowIndex];

            int cantidad = Convert.ToInt32(
                fila.Cells[colDetalleCantidad.Index].Value
            );

            decimal precio = Convert.ToDecimal(
                fila.Cells[colDetallePrecio.Index].Value
            );

            if (cantidad > 1)
            {
                cantidad--;

                fila.Cells[
                    colDetalleCantidad.Index
                ].Value = cantidad;

                fila.Cells[
                    colDetalleSubtotal.Index
                ].Value = precio * cantidad;
            }
            else
            {
                dgvDetalleVenta.Rows.RemoveAt(e.RowIndex);
            }

            ActualizarTotales();
        }
        private void ActualizarTotales()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila
                     in dgvDetalleVenta.Rows)
            {
                if (fila.Cells[
                        colDetalleSubtotal.Index
                    ].Value != null)
                {
                    total += Convert.ToDecimal(
                        fila.Cells[
                            colDetalleSubtotal.Index
                        ].Value
                    );
                }
            }

            txtSubtotal.Text = total.ToString("0.00");
            txtTotalPagar.Text = total.ToString("0.00");

            if (cmbMetodoPago.Text == "Tarjeta")
            {
                txtTotalRecibido.Text =
                    total.ToString("0.00");
            }

            CalcularCambio();
        }
        private void txtTotalRecibido_TextChanged(
    object sender,
    EventArgs e)
        {
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal total;
            decimal recibido;

            if (!decimal.TryParse(
                    txtTotalPagar.Text,
                    out total))
            {
                total = 0;
            }

            if (!decimal.TryParse(
                    txtTotalRecibido.Text,
                    out recibido))
            {
                txtCambio.Text = "0.00";
                return;
            }

            if (recibido >= total)
            {
                decimal cambio = recibido - total;
                txtCambio.Text = cambio.ToString("0.00");
            }
            else
            {
                txtCambio.Text = "0.00";
            }
        }
        private void cmbMetodoPago_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            if (cmbMetodoPago.Text == "Tarjeta")
            {
                txtTotalRecibido.ReadOnly = true;
                txtTotalRecibido.Text = txtTotalPagar.Text;
                txtCambio.Text = "0.00";
            }
            else
            {
                txtTotalRecibido.ReadOnly = false;
                txtTotalRecibido.Clear();
                txtCambio.Text = "0.00";
            }
        }
        private void btnCancelarVenta_Click(
    object sender,
    EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay productos en la venta.",
                    "Venta vacía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Deseas cancelar la venta actual?",
                "Cancelar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            dgvDetalleVenta.Rows.Clear();

            txtSubtotal.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtTotalRecibido.Clear();
            txtCambio.Text = "0.00";

            cmbMetodoPago.SelectedIndex = 0;

            lblNota.Text =
                "Selecciona un producto para comenzar la venta.";
        }
        private void ConectarEventos()
        {
            txtBuscarProducto.TextChanged +=
                txtBuscarProducto_TextChanged;

            cmbBuscarCategoria.SelectedIndexChanged +=
                cmbBuscarCategoria_SelectedIndexChanged;

            dgvProductosVenta.CellClick +=
                dgvProductosVenta_CellClick;

            dgvDetalleVenta.CellClick +=
                dgvDetalleVenta_CellClick;

            txtTotalRecibido.TextChanged +=
                txtTotalRecibido_TextChanged;

            cmbMetodoPago.SelectedIndexChanged +=
                cmbMetodoPago_SelectedIndexChanged;

            btnCancelarVenta.Click +=
      btnCancelarVenta_Click;

            btnCobrarVenta.Click +=
                btnCobrarVenta_Click;
        }
        

        private void CargarCategorias()
        {
            try
            {
                cargandoCategorias = true;

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
                        DataTable tablaCategorias = new DataTable();

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

            int idCategoria;

            if (int.TryParse(
                    cmbBuscarCategoria.SelectedValue.ToString(),
                    out idCategoria))
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
                            ON c.id_categoria =
                               p.id_categoria
                        LEFT JOIN inventario AS i
                            ON i.id_producto =
                               p.id_producto
                        WHERE p.estado = 'Activo'
                          AND
                          (
                              @nombre_producto = ''
                              OR p.nombre LIKE @busqueda
                          )
                          AND
                          (
                              @id_categoria = 0
                              OR p.id_categoria =
                                 @id_categoria
                          )
                        ORDER BY p.nombre ASC;";

                    using (MySqlCommand comando =
                           new MySqlCommand(
                               consulta,
                               conexion))
                    {
                        comando.Parameters.AddWithValue( "@nombre_producto", nombreProducto);

                        comando.Parameters.AddWithValue( "@busqueda", "%" + nombreProducto + "%" );

                        comando.Parameters.AddWithValue("@id_categoria",idCategoria  );

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
                                        lector[
                                            "existencia_actual"
                                        ]
                                    );

                                dgvProductosVenta.Rows.Add(
                                    lector["id_producto"],
                                    lector["producto"],
                                    lector["categoria"],
                                    precio.ToString("0.00"),
                                    existencia,
                                    "Agregar"
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

        private void btnCobrarVenta_Click(
    object sender,
    EventArgs e)
        {
            int productosEnCarrito = 0;
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvDetalleVenta.Rows)
            {
                if (fila.IsNewRow || fila.Tag == null)
                {
                    continue;
                }

                productosEnCarrito++;

                total += Convert.ToDecimal(
                    fila.Cells[colDetalleSubtotal.Index].Value
                );
            }

            if (productosEnCarrito == 0)
            {
                MessageBox.Show(
                    "Debes agregar al menos un producto.",
                    "Venta vacía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal montoRecibido;
            decimal cambio;

            if (cmbMetodoPago.Text == "Tarjeta")
            {
                montoRecibido = total;
                cambio = 0;
            }
            else
            {
                if (!decimal.TryParse(
                        txtTotalRecibido.Text.Trim(),
                        out montoRecibido))
                {
                    MessageBox.Show(
                        "Escribe correctamente el monto recibido.",
                        "Monto requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtTotalRecibido.Focus();
                    return;
                }

                if (montoRecibido < total)
                {
                    MessageBox.Show(
                        "El monto recibido es menor al total de la venta.",
                        "Pago insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtTotalRecibido.Focus();
                    return;
                }

                cambio = montoRecibido - total;
            }

            DialogResult respuesta = MessageBox.Show(
                "Total: $" + total.ToString("0.00") + "\n" +
                "Recibido: $" + montoRecibido.ToString("0.00") + "\n" +
                "Cambio: $" + cambio.ToString("0.00") + "\n\n" +
                "¿Deseas registrar la venta?",
                "Confirmar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            btnCobrarVenta.Enabled = false;

            MySqlConnection conexion = null;
            MySqlTransaction transaccion = null;

            try
            {
                conexion = new Conexion().GetConexion();

                if (conexion == null)
                {
                    throw new Exception(
                        "No fue posible conectarse con la base de datos."
                    );
                }

                transaccion = conexion.BeginTransaction();

                int idCliente;

                string consultaCliente = @"
            SELECT id_cliente
            FROM cliente
            ORDER BY id_cliente
            LIMIT 1;";

                using (MySqlCommand comandoCliente =
                       new MySqlCommand(
                           consultaCliente,
                           conexion,
                           transaccion))
                {
                    object resultadoCliente =
                        comandoCliente.ExecuteScalar();

                    if (resultadoCliente == null ||
                        resultadoCliente == DBNull.Value)
                    {
                        throw new Exception(
                            "No existe ningún cliente registrado."
                        );
                    }

                    idCliente = Convert.ToInt32(
                        resultadoCliente
                    );
                }

                string insertarVenta = @"
            INSERT INTO venta
            (
                id_cliente,
                id_usuario,
                fecha_hora,
                monto_recibido,
                cambio,
                total
            )
            VALUES
            (
                @id_cliente,
                @id_usuario,
                @fecha_hora,
                @monto_recibido,
                @cambio,
                @total
            );";

                int idVenta;

                using (MySqlCommand comandoVenta =
                       new MySqlCommand(
                           insertarVenta,
                           conexion,
                           transaccion))
                {
                    comandoVenta.Parameters.AddWithValue(
                        "@id_cliente",
                        idCliente
                    );

                    comandoVenta.Parameters.AddWithValue(
                        "@id_usuario",
                        idCajero
                    );

                    comandoVenta.Parameters.AddWithValue(
                        "@fecha_hora",
                        DateTime.Now
                    );

                    comandoVenta.Parameters.AddWithValue(
                        "@monto_recibido",
                        montoRecibido
                    );

                    comandoVenta.Parameters.AddWithValue(
                        "@cambio",
                        cambio
                    );

                    comandoVenta.Parameters.AddWithValue(
                        "@total",
                        total
                    );

                    comandoVenta.ExecuteNonQuery();

                    idVenta = Convert.ToInt32(
                        comandoVenta.LastInsertedId
                    );
                }

                foreach (DataGridViewRow fila
                         in dgvDetalleVenta.Rows)
                {
                    if (fila.IsNewRow || fila.Tag == null)
                    {
                        continue;
                    }

                    int idProducto =
                        Convert.ToInt32(fila.Tag);

                    string nombreProducto =
                        Convert.ToString(
                            fila.Cells[
                                colDetalleProducto.Index
                            ].Value
                        );

                    decimal precio =
                        Convert.ToDecimal(
                            fila.Cells[
                                colDetallePrecio.Index
                            ].Value
                        );

                    int cantidad =
                        Convert.ToInt32(
                            fila.Cells[
                                colDetalleCantidad.Index
                            ].Value
                        );

                    decimal subtotal =
                        precio * cantidad;

                    string consultarStock = @"
                SELECT existencia_actual
                FROM inventario
                WHERE id_producto = @id_producto
                FOR UPDATE;";

                    int existenciaActual;

                    using (MySqlCommand comandoStock =
                           new MySqlCommand(
                               consultarStock,
                               conexion,
                               transaccion))
                    {
                        comandoStock.Parameters.AddWithValue(
                            "@id_producto",
                            idProducto
                        );

                        object resultadoStock =
                            comandoStock.ExecuteScalar();

                        if (resultadoStock == null ||
                            resultadoStock == DBNull.Value)
                        {
                            throw new Exception(
                                "El producto " +
                                nombreProducto +
                                " no tiene inventario registrado."
                            );
                        }

                        existenciaActual =
                            Convert.ToInt32(resultadoStock);
                    }

                    if (cantidad > existenciaActual)
                    {
                        throw new Exception(
                            "No hay suficiente existencia de " +
                            nombreProducto + ".\n" +
                            "Existencia disponible: " +
                            existenciaActual
                        );
                    }

                    string insertarDetalle = @"
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
                                @id_venta,
                                @id_producto,
                                @cantidad,
                                @precio_unitario,
                                @subtotal
                            );";

                    using (MySqlCommand comandoDetalle =
                           new MySqlCommand(
                               insertarDetalle,
                               conexion,
                               transaccion))
                    {
                        comandoDetalle.Parameters.AddWithValue(
                            "@id_venta",
                            idVenta
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@id_producto",
                            idProducto
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@cantidad",
                            cantidad
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@precio_unitario",
                            precio
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@subtotal",
                            subtotal
                        );

                        comandoDetalle.ExecuteNonQuery();
                    }

                    string actualizarInventario = @"
                        UPDATE inventario
                        SET existencia_actual =
                        existencia_actual - @cantidad
                        WHERE id_producto = @id_producto
                        AND existencia_actual >= @cantidad;";

                    using (MySqlCommand comandoInventario =
                           new MySqlCommand(
                               actualizarInventario,
                               conexion,
                               transaccion))
                    {
                        comandoInventario.Parameters.AddWithValue(
                            "@cantidad",
                            cantidad
                        );

                        comandoInventario.Parameters.AddWithValue(
                            "@id_producto",
                            idProducto
                        );

                        int filasActualizadas =
                            comandoInventario.ExecuteNonQuery();

                        if (filasActualizadas == 0)
                        {
                            throw new Exception(
                                "No fue posible descontar el inventario de " +
                                nombreProducto + "."
                            );
                        }
                    }
                }

                transaccion.Commit();

                MessageBox.Show(
                    "Venta registrada correctamente.\n\n" +
                    "Número de venta: " + idVenta + "\n" +
                    "Total: $" + total.ToString("0.00") + "\n" +
                    "Cambio: $" + cambio.ToString("0.00"),
                    "Venta realizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dgvDetalleVenta.Rows.Clear();

                txtSubtotal.Text = "0.00";
                txtTotalPagar.Text = "0.00";
                txtTotalRecibido.Clear();
                txtCambio.Text = "0.00";

                cmbMetodoPago.SelectedIndex = 0;

                lblNota.Text =
                    "Selecciona un producto para comenzar la venta.";

                CargarProductos();
            }
            catch (Exception ex)
            {
                if (transaccion != null)
                {
                    try
                    {
                        transaccion.Rollback();
                    }
                    catch
                    {
                        // La transacción ya no pudo revertirse.
                    }
                }

                MessageBox.Show(
                    "No fue posible registrar la venta.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Dispose();
                }

                btnCobrarVenta.Enabled = true;
            }
        }

    }
}