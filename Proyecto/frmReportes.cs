using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.MultiSelect = false;

        }

        private void ConfigurarComboBoxTipo()
        {
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("venta");
            cmbTipoReporte.Items.Add("compra");
            cmbTipoReporte.Items.Add("devolución");
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
            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.MultiSelect = false;

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
            errIdUsuario.Clear();
            errIdProducto.Clear();
            txtIdUsuario.BackColor = Color.White;
            txtIdProducto.BackColor = Color.White;
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

        private void LimpiarOtrosCampos(TextBox actual)
        {
            if (actual != txtIdUsuario) txtIdUsuario.Clear();
            if (actual != txtIdProducto) txtIdProducto.Clear();
            if (actual != txtIdReporte) txtIdReporte.Clear();
            txtTotal.Clear();
            cmbTipoReporte.SelectedIndex = -1;
        }


        #endregion

        #region Validar datos 
        private bool ValidarTodo()
        {
            validarIdUsuario();
            validarIdProducto();
            validarTipoReporte();
            validarTotal();

            if (!string.IsNullOrEmpty(errIdUsuario.GetError(txtIdUsuario))) return false;
            if (!string.IsNullOrEmpty(errIdProducto.GetError(txtIdProducto))) return false;
            if (!string.IsNullOrEmpty(errTipoReporte.GetError(cmbTipoReporte))) return false;
            if (!string.IsNullOrEmpty(errTotal.GetError(txtTotal))) return false;

            return true;
        }

        private void validarIdUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                txtIdUsuario.BackColor = Color.IndianRed;
                errIdUsuario.SetError(txtIdUsuario, "Debe escribir el ID del usuario");
            }
            else
            {
                errIdUsuario.Clear();
                txtIdUsuario.BackColor = Color.White;
            }
        }

        private void validarIdProducto()
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                txtIdProducto.BackColor = Color.IndianRed;
                errIdProducto.SetError(txtIdProducto, "Debe escribir el ID del producto");
            }
            else
            {
                errIdProducto.Clear();
                txtIdProducto.BackColor = Color.White;
            }
        }

        private void validarTipoReporte()
        {
            if (cmbTipoReporte.SelectedIndex == -1)
            {
                errTipoReporte.SetError(cmbTipoReporte, "Debe seleccionar un tipo de reporte");
            }
            else
            {
                errTipoReporte.Clear();
            }
        }

        private void validarTotal()
        {
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                txtTotal.BackColor = Color.IndianRed;
                errTotal.SetError(txtTotal, "Debe escribir el total");
            }
            else if (!decimal.TryParse(txtTotal.Text, out _))
            {
                txtTotal.BackColor = Color.IndianRed;
                errTotal.SetError(txtTotal, "Debe ser un valor decimal válido");
            }
            else
            {
                errTotal.Clear();
                txtTotal.BackColor = Color.White;
            }
        }



        #endregion

        #region Elementos de  UI
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodo()) return;

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
                    IdReporte = Convert.ToInt32(row.Cells["IdReporte"].Value)
                };

            
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
                string tipo = cmbTipoReporte.SelectedItem.ToString().ToLower();

                var reportes = daoReportes.ObtenerPorTipo(tipo);
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

        private void btnBuscarporID_Click(object sender, EventArgs e)
        {
            validarIdUsuario();
            if (!string.IsNullOrEmpty(errIdUsuario.GetError(txtIdUsuario))) return;

            try
            {
                int id = Convert.ToInt32(txtIdUsuario.Text);
                var reportes = daoReportes.ObtenerPorUsuario(id);

                if (reportes.Count == 0)
                {
                    MessageBox.Show("No se encontraron reportes para ese usuario.");
                }

                dgvReportes.DataSource = reportes;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            LimpiarOtrosCampos(txtIdUsuario);
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            LimpiarOtrosCampos(txtIdProducto);
           
        }

        private void btnBuscarPorProducto_Click(object sender, EventArgs e)
        {
            validarIdProducto();
            if (!string.IsNullOrEmpty(errIdProducto.GetError(txtIdProducto))) return;

            try
            {
                int id = Convert.ToInt32(txtIdProducto.Text);
                var reportes = daoReportes.ObtenerPorProducto(id);

                if (reportes.Count == 0)
                {
                    MessageBox.Show("No se encontraron reportes para ese producto.");
                }

                dgvReportes.DataSource = reportes;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnBucarPorReporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdReporte.Text))
            {
                MessageBox.Show("Ingrese un ID de reporte para buscar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIdReporte.Text);
                var reporte = daoReportes.ObtenerPorIdConDetalles(id);

                if (reporte == null)
                {
                    MessageBox.Show("No se encontró el reporte con ese ID.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar un solo registro en la tabla
                dgvReportes.DataSource = new List<Reporte> { reporte };
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar reporte: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdReporte_TextChanged(object sender, EventArgs e)
        {
            LimpiarOtrosCampos(txtIdReporte);
        }

        private void txtIdReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        #endregion

    }
}
