using MySql.Data.MySqlClient;
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
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public frmCrudProductos()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                string query = "INSERT INTO Productos (Nombre, Descripcion, Existencia, PrecioUnitario) " +
                               "VALUES (@Nombre, @Descripcion, @Existencia, @PrecioUnitario)";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Existencia", txtExistencia.Text);
                cmd.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecioUnitario.Text));
                cmd.ExecuteNonQuery();
            }

            MostarProductos();
            LimpiarCampos();
            MessageBox.Show("Producto guardado correctamente");
        }
        private void MostarProductos()
        {
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;
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

        private void frmCrudProductos_Load(object sender, EventArgs e)
        {
            MostarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString();                
                txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtExistencia.Text = dgvProductos.Rows[e.RowIndex].Cells["Existencia"].Value.ToString();
                txtPrecioUnitario.Text = dgvProductos.Rows[e.RowIndex].Cells["PrecioUnitario"].Value.ToString();
            }
        }
    }
}
