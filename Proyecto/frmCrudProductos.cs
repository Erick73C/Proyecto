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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCrudProductos : Form
    {
        #region variables Globales
        private clsDaoProductos daoProductos = new clsDaoProductos();
        private bool modoEditar = false;
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del producto.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExistencia.Text) || !int.TryParse(txtExistencia.Text, out _))
            {
                MessageBox.Show("La existencia debe ser un número entero.");
                txtExistencia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) || !decimal.TryParse(txtPrecioUnitario.Text, out _))
            {
                MessageBox.Show("El precio unitario debe ser un número decimal.");
                txtPrecioUnitario.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region Eventos de la UI

        private void frmCrudProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            HabilitarCampos(false);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

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
            modoEditar = false;
            LimpiarCampos();
            HabilitarCampos(true);

            txtIdProducto.Enabled = false;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
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

    }
}
