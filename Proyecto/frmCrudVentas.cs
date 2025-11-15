using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Proyecto
{
    public partial class frmCrudVentas : Form
    {
        #region Variables globales
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        #endregion

        public frmCrudVentas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmCrudVentas_Load(object sender, EventArgs e)
        {
            MostrarVentas();
        }
        private void MostrarVentas()
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Ventas";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVentas.DataSource = dt;
            }
        }
        private void LimpiarCampos()
        {
            txtIdVenta.Clear();
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            dtpFecha.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                string query = "INSERT INTO Ventas (Fecha, Cliente, Producto, Cantidad, PrecioUnitario) " +
                               "VALUES (@Fecha, @Cliente, @Producto, @Cantidad, @PrecioUnitario)";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                cmd.Parameters.AddWithValue("@Producto", txtProducto.Text);
                cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecioUnitario.Text));
                cmd.ExecuteNonQuery();
            }

            MostrarVentas();
            LimpiarCampos();
            MessageBox.Show("Venta guardada correctamente");

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label1.Text = dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(dgvVentas.Rows[e.RowIndex].Cells["Fecha"].Value);
                txtCliente.Text = dgvVentas.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                txtProducto.Text = dgvVentas.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                txtCantidad.Text = dgvVentas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
                txtPrecioUnitario.Text = dgvVentas.Rows[e.RowIndex].Cells["PrecioUnitario"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Seleccione una venta para editar");
                return;
            }

            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                string query = "UPDATE Ventas SET Fecha=@Fecha, Cliente=@Cliente, Producto=@Producto, " +
                               "Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario WHERE IdVenta=@IdVenta";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@IdVenta", int.Parse(label1.Text));
                cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                cmd.Parameters.AddWithValue("@Producto", txtProducto.Text);
                cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecioUnitario.Text));
                cmd.ExecuteNonQuery();
            }
            
            MostrarVentas();
            LimpiarCampos();
            MessageBox.Show("Venta actualizada correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("Seleccione una venta para eliminar");
                return;
            }

            if (MessageBox.Show("¿Seguro que desea eliminar esta venta?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection cn = new MySqlConnection(connectionString))
                {
                    cn.Open();
                    string query = "DELETE FROM Ventas WHERE IdVenta=@IdVenta";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IdVenta", int.Parse(label1.Text));
                    cmd.ExecuteNonQuery();
                }

                MostrarVentas();
                LimpiarCampos();
                MessageBox.Show("Venta eliminada correctamente");
            }
        }
       
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Cursor = Cursors.Hand;

            // Efecto de brillo al pasar el mouse
            if (btn.BackColor == System.Drawing.Color.FromArgb(41, 128, 185))
                btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            else if (btn.BackColor == System.Drawing.Color.FromArgb(46, 204, 113))
                btn.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            else if (btn.BackColor == System.Drawing.Color.FromArgb(241, 196, 15))
                btn.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            else if (btn.BackColor == System.Drawing.Color.FromArgb(231, 76, 60))
                btn.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        }

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
        #region Elementos Ui
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

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }
        #region Eventos de Botones
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
    }
}
