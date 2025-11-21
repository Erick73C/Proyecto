using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCrudUsuarios : Form
    {
        #region Variables Globales
        clsDaoUsuarios daoUsuarios = new clsDaoUsuarios();
        private bool modoEditar = false;
        private bool modoNuevo = false;
        #endregion


        #region Metodos auxiliares
        public frmCrudUsuarios()
        {
            InitializeComponent();
        }

        private void frmCrudUsuarios_Load(object sender, EventArgs e)
        {
            cbxRol.Items.Add("Administrador");
            cbxRol.Items.Add("Recursos Humanos");
            cbxRol.Items.Add("Vendedor");
            cbxRol.Items.Add("Almacenista");

            HabilitarCampos(false);
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtIdUsuario.Enabled = false;

            // CONFIGURACIONES DEL DGV PARA EVITAR EDICIÓN POR DOBLE CLICK
            dgvUsuarios.ReadOnly = true; // evita edición directa de celdas
            dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically; // solo edición por código
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // seleccionar fila completa
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = daoUsuarios.ObtenerTodos();
        }

        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtcontrasenia.Clear();
            txtUsuario.Clear();
            cbxRol.SelectedIndex = -1;
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void HabilitarCampos(bool habilitado)
        {
            txtNombre.Enabled = habilitado;
            txtApellidoPaterno.Enabled = habilitado;
            txtApellidoMaterno.Enabled = habilitado;
            txtCorreo.Enabled = habilitado;
            txtcontrasenia.Enabled = habilitado;
            txtUsuario.Enabled = habilitado;
            cbxRol.Enabled = habilitado;
            dtpFechaRegistro.Enabled = habilitado;
        }


        #endregion

        #region Validaciones

        private bool ValidarTodo()
        {
            validarNombre();
            validarApellidoPaterno();
            validarApellidoMaterno();
            validarCorreo();
            validarUsuario();
            validarContra();
            validarRol();

            if (!string.IsNullOrEmpty(errNombre.GetError(txtNombre))) return false;
            if (!string.IsNullOrEmpty(errApellidoPaterno.GetError(txtApellidoPaterno))) return false;
            if (!string.IsNullOrEmpty(errApellidoMaterno.GetError(txtApellidoMaterno))) return false;
            if (!string.IsNullOrEmpty(errCorreo.GetError(txtCorreo))) return false;
            if (!string.IsNullOrEmpty(errUsuario.GetError(txtUsuario))) return false;
            if (!string.IsNullOrEmpty(errContrasena.GetError(txtcontrasenia))) return false;
            if (!string.IsNullOrEmpty(errRol.GetError(cbxRol))) return false;

            return true;
        }

        private void validarNombre()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombre, "Debe escribir el nombre");
            }
            else if (!Regex.IsMatch(txtNombre.Text, patron))
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombre, "El nombre no puede contener números ni caracteres especiales");
            }
            else if (txtNombre.Text.Length > 30)
            {
                txtNombre.BackColor = Color.IndianRed;
                errNombre.SetError(txtNombre, "El nombre debe ser menor a 30 caracteres");
            }
            else
            {
                errNombre.Clear();
                txtNombre.BackColor = Color.White;
            }
        }

        private void validarApellidoPaterno()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errApellidoPaterno.SetError(txtApellidoPaterno, "Debe escribir el apellido paterno");
            }
            else if (!Regex.IsMatch(txtApellidoPaterno.Text, patron))
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errApellidoPaterno.SetError(txtApellidoPaterno, "El apellido no puede contener números ni caracteres especiales");
            }
            else if (txtNombre.Text == txtApellidoPaterno.Text)
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errApellidoPaterno.SetError(txtApellidoPaterno, "El apellido no puede ser igual al nombre");
            }
            else if (txtApellidoPaterno.Text.Length > 30)
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errApellidoPaterno.SetError(txtApellidoPaterno, "Debe ser menor a 30 caracteres");
            }
            else
            {
                errApellidoPaterno.Clear();
                txtApellidoPaterno.BackColor = Color.White;
            }
        }

        private void validarApellidoMaterno()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
            {
                txtApellidoMaterno.BackColor = Color.IndianRed;
                errApellidoMaterno.SetError(txtApellidoMaterno, "Debe escribir el apellido materno");
            }
            else if (!Regex.IsMatch(txtApellidoMaterno.Text, patron))
            {
                txtApellidoMaterno.BackColor = Color.IndianRed;
                errApellidoMaterno.SetError(txtApellidoMaterno, "El apellido no puede contener números ni caracteres especiales");
            }
            else if (txtApellidoMaterno.Text.Length > 30)
            {
                txtApellidoMaterno.BackColor = Color.IndianRed;
                errApellidoMaterno.SetError(txtApellidoMaterno, "Debe ser menor a 30 caracteres");
            }
            else
            {
                errApellidoMaterno.Clear();
                txtApellidoMaterno.BackColor = Color.White;
            }
        }

        private void validarCorreo()
        {
            string patron = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.BackColor = Color.IndianRed;
                errCorreo.SetError(txtCorreo, "Debe escribir el correo");
            }
            else if (!Regex.IsMatch(txtCorreo.Text, patron))
            {
                txtCorreo.BackColor = Color.IndianRed;
                errCorreo.SetError(txtCorreo, "Formato de correo inválido");
            }
            else
            {
                txtCorreo.BackColor = Color.White;
                errCorreo.Clear();
            }
        }

        private void validarContra()
        {
            if (string.IsNullOrWhiteSpace(txtcontrasenia.Text))
            {
                txtcontrasenia.BackColor = Color.IndianRed;
                errContrasena.SetError(txtcontrasenia, "Debe escribir la contraseña");
            }
            else if (txtcontrasenia.Text.Length < 4)
            {
                txtcontrasenia.BackColor = Color.IndianRed;
                errContrasena.SetError(txtcontrasenia, "Debe tener al menos 4 caracteres");
            }
            else
            {
                txtcontrasenia.BackColor = Color.White;
                errContrasena.Clear();
            }
        }

        private void validarUsuario()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.BackColor = Color.IndianRed;
                errUsuario.SetError(txtUsuario, "Debe escribir el usuario");
            }
            else if (!Regex.IsMatch(txtUsuario.Text, patron))
            {
                txtUsuario.BackColor = Color.IndianRed;
                errUsuario.SetError(txtUsuario, "El nombre no puede contener números ni caracteres especiales");
            }
            else if (txtUsuario.Text.Length > 20)
            {
                txtUsuario.BackColor = Color.IndianRed;
                errUsuario.SetError(txtUsuario, "Debe ser menor a 20 caracteres");
            }
            else
            {
                txtUsuario.BackColor = Color.White;
                errUsuario.Clear();
            }
        }

        private void validarRol()
        {
            if (cbxRol.SelectedIndex == -1)
            {
                cbxRol.BackColor = Color.IndianRed;
                errRol.SetError(cbxRol, "Debe seleccionar un rol");
            }
            else
            {
                cbxRol.BackColor = Color.White;
                errRol.Clear();
            }
        }

        #endregion

        #region Eventos Ui
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            txtIdUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellidoPaterno.Text = fila.Cells["ApellidoPaterno"].Value.ToString();
            txtApellidoMaterno.Text = fila.Cells["ApellidoMaterno"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtUsuario.Text = fila.Cells["UsuarioNombre"].Value.ToString();
            txtcontrasenia.Text = fila.Cells["Contrasena"].Value.ToString();
            cbxRol.Text = fila.Cells["Rol"].Value.ToString();
            dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value);

            HabilitarCampos(false);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
           // validarIdUsuario();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //validarNombre();
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            //validarApellidoPaterno();
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            //validarApellidoMaterno();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //validarCorreo();
        }

        private void txtcontrasenia_TextChanged(object sender, EventArgs e)
        {
            //validarContra();
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validarRol();
        }

        #region Botones de accion
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modoNuevo = true;
            modoEditar = false;
            dtpFechaRegistro.Enabled = false;
            LimpiarCampos();
            HabilitarCampos(true);

            dtpFechaRegistro.Value = DateTime.Now;

            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!ValidarTodo())
            {
                MessageBox.Show("Corrija los campos marcados en rojo.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario u = new Usuario
            {
                IdUsuario = string.IsNullOrWhiteSpace(txtIdUsuario.Text) ? 0 : int.Parse(txtIdUsuario.Text),
                Nombre = txtNombre.Text.Trim(),
                ApellidoPaterno = txtApellidoPaterno.Text.Trim(),
                ApellidoMaterno = txtApellidoMaterno.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                UsuarioNombre = txtUsuario.Text.Trim(),
                Contrasena = txtcontrasenia.Text.Trim(),
                Rol = cbxRol.Text,
                FechaRegistro = dtpFechaRegistro.Value
            };

            if (modoEditar == false)
            {
                daoUsuarios.Insertar(u);
                MessageBox.Show("Usuario registrado correctamente.");
            }
            else
            {
                u.IdUsuario = int.Parse(txtIdUsuario.Text);
                daoUsuarios.Actualizar(u);
                MessageBox.Show("Usuario actualizado correctamente.");
            }

            CargarUsuarios();
            LimpiarCampos();
            HabilitarCampos(false);

            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
            modoNuevo = false;
            dgvUsuarios.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            modoEditar = true;

            HabilitarCampos(true);

            txtIdUsuario.Enabled = false;        
            dtpFechaRegistro.Enabled = false;    

            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            int id = int.Parse(txtIdUsuario.Text);

            if (MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                daoUsuarios.Eliminar(id);
                MessageBox.Show("Usuario eliminado.");

                CargarUsuarios();
                LimpiarCampos();
                HabilitarCampos(false);
            }

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        #endregion

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            txtIdUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellidoPaterno.Text = fila.Cells["ApellidoPaterno"].Value.ToString();
            txtApellidoMaterno.Text = fila.Cells["ApellidoMaterno"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            txtUsuario.Text = fila.Cells["UsuarioNombre"].Value.ToString();
            txtcontrasenia.Text = fila.Cells["Contrasena"].Value.ToString();
            cbxRol.Text = fila.Cells["Rol"].Value.ToString();
            dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value);

            HabilitarCampos(false);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }
        //No sirve pero no se puede borrar
        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Si estamos creando un nuevo usuario, no permitir seleccionar/llenar desde el dgv
            if (modoNuevo) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            // Verificar valores nulos por si acaso
            if (fila.Cells["IdUsuario"].Value == null) return;

            txtIdUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
            txtApellidoPaterno.Text = fila.Cells["ApellidoPaterno"].Value?.ToString() ?? string.Empty;
            txtApellidoMaterno.Text = fila.Cells["ApellidoMaterno"].Value?.ToString() ?? string.Empty;
            txtCorreo.Text = fila.Cells["Correo"].Value?.ToString() ?? string.Empty;
            txtUsuario.Text = fila.Cells["UsuarioNombre"].Value?.ToString() ?? string.Empty;
            txtcontrasenia.Text = fila.Cells["Contrasena"].Value?.ToString() ?? string.Empty;
            cbxRol.Text = fila.Cells["Rol"].Value?.ToString() ?? string.Empty;

            // Fecha: intenta convertir con seguridad
            if (fila.Cells["FechaRegistro"].Value != null && DateTime.TryParse(fila.Cells["FechaRegistro"].Value.ToString(), out DateTime fecha))
            {
                dtpFechaRegistro.Value = fecha;
            }

            HabilitarCampos(false);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }
        #endregion

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
