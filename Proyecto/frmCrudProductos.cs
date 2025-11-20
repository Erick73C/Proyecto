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
    public partial class frmCrudProductos : Form
    {
        #region variables Globales
        private clsDaoProductos daoProductos = new clsDaoProductos();
        private bool modoEditar = false;
        private bool modoNuevo = false;
        #endregion

        #region Metodos auxiliares
        public frmCrudProductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            try
            {
                var lista = daoProductos.ObtenerProductos();
                dgvProductos.DataSource = lista;

                dgvProductos.ClearSelection();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtExistencia.Clear();
            txtPrecioUnitario.Clear();
        }

        private void HabilitarCampos(bool habilitado)
        {
            txtNombre.Enabled = habilitado;
            txtDescripcion.Enabled = habilitado;
            txtExistencia.Enabled = habilitado;
            txtPrecioUnitario.Enabled = habilitado;

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtIdProducto.Enabled = false;
        }

        private Producto ObtenerDatosFormulario()
        {
            return new Producto
            {
                IdProducto = string.IsNullOrEmpty(txtIdProducto.Text) ? 0 : int.Parse(txtIdProducto.Text),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Existencia = int.Parse(txtExistencia.Text.Trim()),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim())
            };
        }

        #endregion
        #region Eventos de validacion de campos

        /// <summary>
        /// Método principal que valida TODOS los campos antes de guardar.
        /// Retorna true si todo está correcto; false si hay errores.
        /// </summary>
        private bool ValidarTodo()
        {
            ValidarNombre();
            ValidarDescripcion();
            ValidarExistencia();
            ValidarPrecio();

            if (!string.IsNullOrEmpty(errNombreProducto.GetError(txtNombre))) return false;
            if (!string.IsNullOrEmpty(errDescripcion.GetError(txtDescripcion))) return false;
            if (!string.IsNullOrEmpty(errExistencia.GetError(txtExistencia))) return false;
            if (!string.IsNullOrEmpty(errPrecioUnitario.GetError(txtPrecioUnitario))) return false;

            return true;
        }

        /// <summary>
        /// Valida que el nombre del producto solo contenga texto y no esté vacío.
        /// </summary>
        private void ValidarNombre()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombreProducto.SetError(txtNombre, "Debe escribir el nombre del producto");
            }
            else if (!Regex.IsMatch(txtNombre.Text, patron))
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombreProducto.SetError(txtNombre, "El nombre no puede contener números ni símbolos");
            }
            else if (txtNombre.Text.Length > 100)
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombreProducto.SetError(txtNombre, "Debe ser menor a 100 caracteres");
            }
            else
            {
                errNombreProducto.Clear();
                txtNombre.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Valida que la descripción sea texto válido y no esté vacía.
        /// </summary>
        private void ValidarDescripcion()
        {
            string patron = @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\s\.,-]+$";

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.IndianRed;
                errDescripcion.SetError(txtDescripcion, "Debe ingresar una descripción");
            }
            else if (!Regex.IsMatch(txtDescripcion.Text, patron))
            {
                txtDescripcion.BackColor = Color.IndianRed;
                errDescripcion.SetError(txtDescripcion, "La descripción solo puede contener letras, números y puntuación básica");
            }
            else if (txtDescripcion.Text.Length > 200)
            {
                txtDescripcion.BackColor = Color.IndianRed;
                errDescripcion.SetError(txtDescripcion, "Debe ser menor a 200 caracteres");
            }
            else
            {
                errDescripcion.Clear();
                txtDescripcion.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Valida que la existencia sea un número entero no negativo.
        /// </summary>
        private void ValidarExistencia()
        {
            if (string.IsNullOrWhiteSpace(txtExistencia.Text))
            {
                txtExistencia.BackColor = Color.IndianRed;
                errExistencia.SetError(txtExistencia, "Debe ingresar la existencia");
            }
            else if (!int.TryParse(txtExistencia.Text, out int existencia))
            {
                txtExistencia.BackColor = Color.IndianRed;
                errExistencia.SetError(txtExistencia, "Solo se permiten números enteros");
            }
            else if (existencia < 0)
            {
                txtExistencia.BackColor = Color.IndianRed;
                errExistencia.SetError(txtExistencia, "La existencia no puede ser negativa");
            }
            else
            {
                errExistencia.Clear();
                txtExistencia.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Valida que el precio sea decimal válido y no negativo.
        /// </summary>
        private void ValidarPrecio()
        {
            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                txtPrecioUnitario.BackColor = Color.IndianRed;
                errPrecioUnitario.SetError(txtPrecioUnitario, "Debe ingresar el precio unitario");
            }
            else if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                txtPrecioUnitario.BackColor = Color.IndianRed;
                errPrecioUnitario.SetError(txtPrecioUnitario, "Debe ingresar un valor decimal válido");
            }
            else if (precio < 0)
            {
                txtPrecioUnitario.BackColor = Color.IndianRed;
                errPrecioUnitario.SetError(txtPrecioUnitario, "El precio no puede ser negativo");
            }
            else
            {
                errPrecioUnitario.Clear();
                txtPrecioUnitario.BackColor = Color.White;
            }
        }
        #endregion


        #region Eventos de la UI

        private void frmCrudProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            HabilitarCampos(false);

            dgvProductos.ReadOnly = true;
            dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (modoNuevo) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            txtExistencia.Text = fila.Cells["Existencia"].Value.ToString();
            txtPrecioUnitario.Text = fila.Cells["PrecioUnitario"].Value.ToString();

            HabilitarCampos(false);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        #region Evento Botones
        private void btnEditar_Click(object sender, EventArgs e)
        {
            modoNuevo = false;
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            modoEditar = true;
            HabilitarCampos(true);

            txtIdProducto.Enabled = false;

            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modoNuevo = true;
            modoEditar = false;

            LimpiarCampos();
            HabilitarCampos(true);
            txtIdProducto.Enabled = false;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvProductos.Enabled = false; 
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodo())
                return;

            Producto p = ObtenerDatosFormulario();

            try
            {
                if (!modoEditar)
                {
                    daoProductos.InsertarProducto(p);
                    MessageBox.Show("Producto registrado correctamente.");
                }
                else
                {
                    daoProductos.ActualizarProducto(p);
                    MessageBox.Show("Producto actualizado correctamente.");
                }

                MostrarProductos();
                LimpiarCampos();
                HabilitarCampos(false);
                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;

            modoNuevo = false;
            dgvProductos.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }

            int id = int.Parse(txtIdProducto.Text);

            if (MessageBox.Show("¿Desea eliminar este producto?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                daoProductos.EliminarProducto(id);
                MessageBox.Show("Producto eliminado correctamente.");

                MostrarProductos();
                LimpiarCampos();
                HabilitarCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }
        #endregion

        #endregion

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
