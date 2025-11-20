using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmClienteCompras : Form
    {
        private clsDaoProductos daoProductos = new clsDaoProductos();
        #region variables globales
        private clsReportes daoReportes;
        private List<DetalleCompra> carrito;
        private decimal totalCompra;
        #endregion

        #region Metodos Auxiliares
        public frmClienteCompras(int idUsuario)
        {
            InitializeComponent();
            daoReportes = new clsReportes();
            carrito = new List<DetalleCompra>();
            totalCompra = 0;
            // En una implementación real, pasarías el ID del usuario logueado
            txtIdUsuario.Text = idUsuario.ToString();
        }

        private void frmClienteCompras_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActualizarCarrito();
            ConfigurarDataGridViews();
            CompletadoDeProductos();
            MostrarProductos();
            dgvProductos.Enabled = false;
            txtIdProducto.ReadOnly = true;
            txtNombreProducto.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;

        }
        private void MostrarProductos()
        {
            try
            {
                var lista = daoProductos.ObtenerProductos();
                dgvProductos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }


        private void ConfigurarDataGridViews()
        {
            // Configurar dgvCarrito
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdProducto",
                HeaderText = "ID Producto",
                Width = 80
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto",
                Width = 150
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 70
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio Unit.",
                Width = 80
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 80
            });
        }
        private void LimpiarFormulario()
        {
            txtIdProducto.Clear();
            txtBuscarProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            txtCantidad.Text = "1";
            txtTotalCompra.Text = "0.00";
        }
        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito.ToList();

            totalCompra = carrito.Sum(item => item.Subtotal);
            txtTotalCompra.Text = totalCompra.ToString("C2");

            lblCantidadItems.Text = $"{carrito.Count} items en el carrito";
        }
        private void GenerarTicket()
        {
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("=== TICKET DE COMPRA ===");
            ticket.AppendLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            ticket.AppendLine($"Cliente ID: {txtIdUsuario.Text}");
            ticket.AppendLine("----------------------------------------");
            ticket.AppendLine("PRODUCTOS:");
            ticket.AppendLine();

            foreach (var item in carrito)
            {
                ticket.AppendLine($"{item.NombreProducto}");
                ticket.AppendLine($"  Cantidad: {item.Cantidad} x {item.PrecioUnitario:C2} = {item.Subtotal:C2}");
            }

            ticket.AppendLine("----------------------------------------");
            ticket.AppendLine($"TOTAL: {totalCompra:C2}");
            ticket.AppendLine("========================================");
            ticket.AppendLine("¡Gracias por su compra!");

            // Mostrar ticket en el TextBox
            txtTicket.Text = ticket.ToString();

            // También podrías guardar el ticket en un archivo
            // GuardarTicketArchivo(ticket.ToString());
        }
        private void CompletadoDeProductos()
        {
            clsDaoProductos dao = new clsDaoProductos();
            var productos = dao.ObtenerTodosLosProductos(); // Método que ya debes tener

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            foreach (var p in productos)
            {
                lista.Add(p.Nombre);  // autocompleta solo por nombre
            }

            txtBuscarProducto.AutoCompleteCustomSource = lista;
        }

        #endregion

        #region Validaciones 
        private bool ValidarTodoProducto()
        {
            validarBusquedaProducto();
            validarProductoCargado();
            validarCantidad();

            if (!string.IsNullOrEmpty(errBuscarProducto.GetError(txtBuscarProducto))) return false;
            if (!string.IsNullOrEmpty(errProducto.GetError(txtNombreProducto))) return false;
            if (!string.IsNullOrEmpty(errCantidad.GetError(txtCantidad))) return false;

            return true;
        }

        /// <summary>
        /// Verifica que el usuario haya buscado o escrito un nombre válido.
        /// </summary>
        private void validarBusquedaProducto()
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                txtBuscarProducto.BackColor = Color.IndianRed;
                errBuscarProducto.SetError(txtBuscarProducto, "Debe escribir el nombre del producto");
            }
            else
            {
                errBuscarProducto.Clear();
                txtBuscarProducto.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Verifica que el producto haya sido cargado correctamente desde BD.
        /// </summary>
        private void validarProductoCargado()
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text) ||
                string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                txtNombreProducto.BackColor = Color.IndianRed;
                errProducto.SetError(txtNombreProducto, "Debe seleccionar un producto válido de la lista");
            }
            else
            {
                errProducto.Clear();
                txtNombreProducto.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Verifica que la cantidad sea numérica y mayor a 0.
        /// </summary>
        private void validarCantidad()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                txtCantidad.BackColor = Color.IndianRed;
                errCantidad.SetError(txtCantidad, "Debe ingresar una cantidad");
            }
            else if (!int.TryParse(txtCantidad.Text, out int c) || c <= 0)
            {
                txtCantidad.BackColor = Color.IndianRed;
                errCantidad.SetError(txtCantidad, "La cantidad debe ser un número mayor a cero");
            }
            else
            {
                errCantidad.Clear();
                txtCantidad.BackColor = Color.White;
            }
        }

        #endregion

        #region Elementos de Interfaz
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            {
                if (!ValidarTodoProducto()) return;

                try
                {
                    var detalle = new DetalleCompra
                    {
                        IdProducto = Convert.ToInt32(txtIdProducto.Text),
                        NombreProducto = txtNombreProducto.Text,
                        Cantidad = Convert.ToInt32(txtCantidad.Text),
                        PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text)
                    };

                    // Calcular subtotal
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;

                    // Verificar si el producto ya está en el carrito
                    var productoExistente = carrito.FirstOrDefault(p => p.IdProducto == detalle.IdProducto);
                    if (productoExistente != null)
                    {
                        productoExistente.Cantidad += detalle.Cantidad;
                        productoExistente.Subtotal = productoExistente.Cantidad * productoExistente.PrecioUnitario;
                    }
                    else
                    {
                        carrito.Add(detalle);
                    }

                    ActualizarCarrito();
                    LimpiarFormulario();
                    txtIdProducto.Focus();

                    MessageBox.Show("Producto agregado al carrito", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto del carrito para eliminar", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = dgvCarrito.CurrentRow.DataBoundItem as DetalleCompra;
            if (producto != null)
            {
                carrito.Remove(producto);
                ActualizarCarrito();
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito ya está vacío", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show("¿Está seguro de vaciar el carrito?", "Confirmar",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                carrito.Clear();
                ActualizarCarrito();
                MessageBox.Show("Carrito vaciado", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos antes de finalizar la compra.",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Registrar cada producto como reporte de venta
                foreach (var item in carrito)
                {
                    var reporte = new Reporte
                    {
                        IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                        IdProducto = item.IdProducto,
                        TipoReporte = "venta",
                        Cantidad = item.Cantidad,
                        Total = item.Subtotal
                    };

                    daoReportes.Insertar(reporte);
                }

                // Generar ticket
                GenerarTicket();

                // Limpiar carrito
                carrito.Clear();
                ActualizarCarrito();

                MessageBox.Show("¡Compra realizada con éxito! Se ha generado el ticket.", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar compra: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTicket.Text))
            {
                MessageBox.Show("No hay ticket para imprimir", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // En una implementación real, aquí iría el código para imprimir
            // Por ahora solo mostramos un mensaje
            MessageBox.Show("Funcionalidad de impresión habilitada. El ticket se enviaría a la impresora.",
                          "Imprimir Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            clsDaoProductos dao = new clsDaoProductos();
            var producto = dao.ObtenerPorNombreExacto(txtBuscarProducto.Text);

            if (producto != null)
            {
                txtIdProducto.Text = producto.IdProducto.ToString();
                txtNombreProducto.Text = producto.Nombre;
                txtPrecioUnitario.Text = producto.PrecioUnitario.ToString("0.00");
            }
        }

        #endregion

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class DetalleCompra
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
