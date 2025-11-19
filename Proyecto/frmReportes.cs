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
    public partial class frmReportes : Form
    {
        #region Variables Globales
        private clsReportes daoReportes;
        private Reporte reporteSeleccionado;
        #endregion
        #region Metodos auxiliares
        public frmReportes()
        {
            InitializeComponent();
            daoReportes = new clsReportes();
            reporteSeleccionado = null;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarReportes();
            LimpiarFormulario();
            ConfigurarComboBoxTipo();
        }
        private void ConfigurarComboBoxTipo()
        {
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("Venta");
            cmbTipoReporte.Items.Add("Compra");
            cmbTipoReporte.Items.Add("Devolucion");
        }
        private void CargarReportes()
        {
            try
            {
                var reportes = daoReportes.ObtenerTodosConDetalles();
                dgvReportes.DataSource = reportes;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reportes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGridView()
        {
            if (dgvReportes.Columns.Count > 0)
            {
                dgvReportes.Columns["IdReporte"].HeaderText = "ID Reporte";
                dgvReportes.Columns["IdUsuario"].HeaderText = "ID Usuario";
                dgvReportes.Columns["IdProducto"].HeaderText = "ID Producto";
                dgvReportes.Columns["FechaReporte"].HeaderText = "Fecha Reporte";
                dgvReportes.Columns["TipoReporte"].HeaderText = "Tipo";
                dgvReportes.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvReportes.Columns["Total"].HeaderText = "Total";

                dgvReportes.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvReportes.Columns["FechaReporte"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }
        private void LimpiarFormulario()
        {
            txtIdReporte.Clear();
            txtIdUsuario.Clear();
            txtIdProducto.Clear();
            cmbTipoReporte.SelectedIndex = -1;
            txtTotal.Clear();
            reporteSeleccionado = null;
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("El ID Usuario es requerido", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("El ID Producto es requerido", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdProducto.Focus();
                return false;
            }

            if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de reporte", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoReporte.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtTotal.Text) || !decimal.TryParse(txtTotal.Text, out _))
            {
                MessageBox.Show("El total debe ser un valor decimal válido", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region Elementos de  UI
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            try
            {
                Reporte reporte = new Reporte
                {
                    IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                    IdProducto = Convert.ToInt32(txtIdProducto.Text),
                    TipoReporte = cmbTipoReporte.SelectedItem.ToString(),
                    Total = Convert.ToDecimal(txtTotal.Text)
                };

                if (reporteSeleccionado == null)
                {
                    // Insertar nuevo reporte
                    if (daoReportes.Insertar(reporte))
                    {
                        MessageBox.Show("Reporte guardado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Actualizar reporte existente
                    reporte.IdReporte = reporteSeleccionado.IdReporte;
                    if (daoReportes.Actualizar(reporte))
                    {
                        MessageBox.Show("Reporte actualizado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                CargarReportes();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar reporte: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (reporteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un reporte para eliminar", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show(
                $"¿Está seguro de eliminar el reporte ID: {reporteSeleccionado.IdReporte}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (daoReportes.Eliminar(reporteSeleccionado.IdReporte))
                    {
                        MessageBox.Show("Reporte eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarReportes();
                        LimpiarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar reporte: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReportes.Rows[e.RowIndex];
                reporteSeleccionado = new Reporte
                {
                    IdReporte = Convert.ToInt32(row.Cells["IdReporte"].Value),
                    IdUsuario = Convert.ToInt32(row.Cells["IdUsuario"].Value),
                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    FechaReporte = Convert.ToDateTime(row.Cells["FechaReporte"].Value),
                    TipoReporte = row.Cells["TipoReporte"].Value.ToString(),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Total = Convert.ToDecimal(row.Cells["Total"].Value)
                };

                CargarDatosFormulario();
            }
        }

        private void CargarDatosFormulario()
        {
            if (reporteSeleccionado != null)
            {
                txtIdReporte.Text = reporteSeleccionado.IdReporte.ToString();
                txtIdUsuario.Text = reporteSeleccionado.IdUsuario.ToString();
                txtIdProducto.Text = reporteSeleccionado.IdProducto.ToString();
                cmbTipoReporte.SelectedItem = reporteSeleccionado.TipoReporte;
                txtTotal.Text = reporteSeleccionado.Total.ToString("F2");

                btnGuardar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }
        }

        private void btnBuscarPorTipo_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de reporte para buscar", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reportes = daoReportes.ObtenerPorTipo(cmbTipoReporte.SelectedItem.ToString());
                dgvReportes.DataSource = reportes;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar reportes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarReportes();
            LimpiarFormulario();
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }

        #endregion
    }
}
