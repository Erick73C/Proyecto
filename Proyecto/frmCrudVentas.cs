using MySql.Data.MySqlClient;
using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCrudVentas : Form
    {
        #region Variables globales
        private clsDaoVentas daoVentas = new clsDaoVentas();
        private bool modoEditar = false;
        private bool modoNuevo = false;

        #endregion

        #region Metodos auxiliares
        public frmCrudVentas()
        {
            InitializeComponent();
        }

        private void MostrarVentas()
        {
            try
            {
                dgvVentas.DataSource = daoVentas.ObtenerTodasLasVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las ventas: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdVenta.Clear();
            txtCliente.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtTotal.Clear();
            dtpFecha.Value = DateTime.Now;

            modoEditar = false;
        }

        private void CargarProductos()
        {
            try
            {
                clsDaoProductos dao = new clsDaoProductos();
                var lista = dao.ObtenerTodosLosProductos();

                cbxProducto.DataSource = lista;
                cbxProducto.DisplayMember = "Nombre";      // Lo que se muestra al usuario
                cbxProducto.ValueMember = "IdProducto";    // El valor real del producto
                cbxProducto.SelectedIndex = -1;            // Ninguno seleccionado al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotal()
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) &&
                decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                txtTotal.Text = (cantidad * precio).ToString("0.00");
            }
        }

        private void frmCrudVentas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
            CargarProductos();
            HabilitarCampos(false);

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvVentas.ReadOnly = true;
            dgvVentas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dtpFecha.Enabled = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;

        }

        private void HabilitarCampos(bool habilitar)
        {
            txtCliente.Enabled = habilitar;
            cbxProducto.Enabled = habilitar;
            txtCantidad.Enabled = habilitar;
            txtPrecioUnitario.Enabled = habilitar;
            dtpFecha.Enabled = !modoEditar;   

            txtIdVenta.Enabled = false;       
            txtTotal.Enabled = false;         
        }

        #endregion

        #region Validacion de campos
        private bool ValidarTodo()
        {
            validarCliente();
            validarProducto();
            validarCantidad();
            validarPrecioUnitario();
            validarTotal();

            if (!string.IsNullOrEmpty(errCliente.GetError(txtCliente))) return false;
            if (!string.IsNullOrEmpty(errProduto.GetError(cbxProducto))) return false;
            if (!string.IsNullOrEmpty(errCantidad.GetError(txtCantidad))) return false;
            if (!string.IsNullOrEmpty(errPrecioUnitario.GetError(txtPrecioUnitario))) return false;
            if (!string.IsNullOrEmpty(errTotal.GetError(txtTotal))) return false;

            return true;
        }

        private void validarCliente()
        {
            string patron = @"^[A-Za-zÁÉÍÓÚáéíóúÑñÜü ]+$";
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                txtCliente.BackColor = Color.IndianRed;
                errCliente.SetError(txtCliente, "Debe escribir el nombre del cliente.");
            }
            else if (!Regex.IsMatch(txtCliente.Text, patron))
            {
                txtCliente.BackColor = Color.IndianRed;
                errCliente.SetError(txtCliente, "El nombre no debe contener números ni caracteres especiales.");
            }
            else if (txtCliente.Text.Length > 50)
            {
                txtCliente.BackColor = Color.IndianRed;
                errCliente.SetError(txtCliente, "Máximo 50 caracteres.");
            }
            else
            {
                txtCliente.BackColor = Color.White;
                errCliente.Clear();
            }
        }

        private void validarProducto()
        {
            if (cbxProducto.SelectedIndex == -1)
            {
                cbxProducto.BackColor = Color.IndianRed;
                errProduto.SetError(cbxProducto, "Debe seleccionar un producto.");
            }
            else
            {
                cbxProducto.BackColor = Color.White;
                errProduto.Clear();
            }
        }

        private void validarCantidad()
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                txtCantidad.BackColor = Color.IndianRed;
                errCantidad.SetError(txtCantidad, "Debe ingresar un número entero.");
            }
            else if (cantidad <= 0)
            {
                txtCantidad.BackColor = Color.IndianRed;
                errCantidad.SetError(txtCantidad, "La cantidad debe ser mayor a 0.");
            }
            else
            {
                txtCantidad.BackColor = Color.White;
                errCantidad.Clear();
            }
        }

        private void validarPrecioUnitario()
        {
            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                txtPrecioUnitario.BackColor = Color.IndianRed;
                errPrecioUnitario.SetError(txtPrecioUnitario, "Debe ingresar un precio válido.");
            }
            else if (precio <= 0)
            {
                txtPrecioUnitario.BackColor = Color.IndianRed;
                errPrecioUnitario.SetError(txtPrecioUnitario, "El precio debe ser mayor a 0.");
            }
            else
            {
                txtPrecioUnitario.BackColor = Color.White;
                errPrecioUnitario.Clear();
            }
        }

        private void validarTotal()
        {
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                txtTotal.BackColor = Color.IndianRed;
                errTotal.SetError(txtTotal, "El total no puede quedar vacío.");
            }
            else
            {
                txtTotal.BackColor = Color.White;
                errTotal.Clear();
            }
        }

        #endregion

        #region Elementos Ui

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            if (modoNuevo) return;

            DataGridViewRow row = dgvVentas.Rows[e.RowIndex];

            txtIdVenta.Text = row.Cells["IdVenta"].Value.ToString();
            txtCliente.Text = row.Cells["Cliente"].Value.ToString();
            string prod = row.Cells["Producto"].Value.ToString();
            cbxProducto.SelectedIndex = cbxProducto.FindStringExact(prod);
            txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
            txtPrecioUnitario.Text = row.Cells["PrecioUnitario"].Value.ToString();
            txtTotal.Text = row.Cells["Total"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);

            HabilitarCampos(false);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedIndex >= 0)
            {
                var prod = (Producto)cbxProducto.SelectedItem;
                txtPrecioUnitario.Text = prod.PrecioUnitario.ToString("0.00");
            }
        }


        #region Eventos de Botones
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            modoEditar = false;
            LimpiarCampos();

            dtpFecha.Value = DateTime.Now;
           dtpFecha.Enabled = false;

            HabilitarCampos(true);

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvVentas.Enabled = false;
            cbxProducto.SelectedIndex = -1;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarTodo())
                return;

            Venta v = new Venta
            {
                Cliente = txtCliente.Text.Trim(),
                Producto = cbxProducto.Text.Trim(),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text),
                Fecha = dtpFecha.Value
            };

            try
            {
                if (modoEditar)
                {
                    v.IdVenta = int.Parse(txtIdVenta.Text);
                    daoVentas.ActualizarVenta(v);
                    MessageBox.Show("Venta actualizada correctamente.");
                }
                else
                {
                    daoVentas.InsertarVenta(v);
                    MessageBox.Show("Venta registrada correctamente.");
                }

                MostrarVentas();
                LimpiarCampos();
                HabilitarCampos(false);

                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                modoNuevo = false;
                dgvVentas.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdVenta.Text))
            {
                MessageBox.Show("Seleccione una venta primero.");
                return;
            }

            modoEditar = true;

            HabilitarCampos(true);

            txtIdVenta.Enabled = false;   
            dtpFecha.Enabled = false;     
            txtTotal.Enabled = false;     

            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            dgvVentas.Enabled = true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdVenta.Text))
            {
                MessageBox.Show("Seleccione una venta primero.");
                return;
            }

            int id = int.Parse(txtIdVenta.Text);

            if (MessageBox.Show("¿Eliminar esta venta?", "Confirmar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                daoVentas.EliminarVenta(id);
                MostrarVentas();
                LimpiarCampos();
                MessageBox.Show("Venta eliminada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        #endregion

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Restaurar color original
            if (btn == btnNuevo)
                btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            else if (btn == btnGuardar)
                btn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            else if (btn == btnEditar)
                btn.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            else if (btn == btnEliminar)
                btn.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }
        #endregion

       
    }
}