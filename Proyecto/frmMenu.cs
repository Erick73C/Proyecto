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
    public partial class frmMenu : Form
    {
        #region Variables Globales
        clsDaoUsuarios dao = new clsDaoUsuarios();
        private Usuario usuarioActual;

        #endregion

        #region Metodos auxiliares

        public frmMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("No se recibió información del usuario.");
                return;
            }

            // Mostrar nombre completo y rol
            lblNombreUsuario.Text =
                $"{usuarioActual.Nombre} {usuarioActual.ApellidoPaterno} ({usuarioActual.Rol})";

            // Control de accesos según rol
            switch (usuarioActual.Rol)
            {
                case "Administrador":
                    btnCompra.Enabled = true;
                    btnCrud1.Enabled = true;  // Usuarios
                    btnCrud2.Enabled = true;  // Productos
                    btnCrud3.Enabled = true;  // Ventas
                    btnReportes.Enabled = true;
                    break;

                case "Recursos Humanos":
                    btnCompra.Enabled = false;
                    btnCompra.Visible = false;
                    btnCrud1.Enabled = true;
                    btnCrud2.Enabled = false;
                    btnCrud2.Visible= false ;
                    btnCrud3.Enabled = false;
                    btnCrud3.Visible = false;
                    btnReportes.Enabled = false;
                    btnReportes.Visible = false;
                    break;

                case "Almacenista":
                    btnCompra.Enabled = false;
                    btnCompra.Visible = false;
                    btnCrud1.Enabled = false;
                    btnCrud1.Visible = false;
                    btnCrud2.Enabled = true;
                    btnCrud3.Enabled = false;
                    btnCrud3.Visible = false; 
                    btnReportes.Enabled = false;
                    btnReportes.Visible = false;
                    break;

                case "Vendedor":
                    btnCompra.Enabled = false;
                    btnCompra.Visible = false;
                    btnCrud1.Enabled = false;
                    btnCrud1.Visible = false;
                    btnCrud2.Enabled = false;
                    btnCrud2.Visible = false;
                    btnCrud3.Enabled = true;
                    btnReportes.Enabled = true;
                    break;
                case "Cliente":
                    btnCompra.Enabled = true;
                    btnCrud1.Visible = false;
                    btnCrud2.Visible = false;
                    btnCrud3.Visible = false;
                    btnReportes.Visible = false;
                    break;
                default:
                    // En caso de rol desconocido, por seguridad, desactiva todo
                    btnCrud1.Enabled = false;
                    btnCrud2.Enabled = false;
                    btnCrud3.Enabled = false;
                    btnReportes.Enabled = false;
                    break;
            }
        }

        private void AbrirFormulario(Form formHijo)
        {
            // Limpiar el panel contenedor
            pnlContenedor.Controls.Clear();

            // Configurar el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agregar al panel contenedor
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;

            // Mostrar el formulario
            formHijo.Show();

            // Ocultar el mensaje de bienvenida
            lblBienvenida.Visible = false;
        }

        #endregion

        #region elementos interfaz
        private void btnCrud1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudUsuarios());
        }

        private void btnCrud3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudVentas());
        }

        private void btnCrud2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudProductos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
                // Aquí puedes agregar la lógica para volver al login
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Usuario: {usuarioActual.UsuarioNombre}\n" +
                $"Nombre: {usuarioActual.Nombre} {usuarioActual.ApellidoPaterno}\n" +
                $"Rol: {usuarioActual.Rol}",
                "Información del Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
             );
        }

        #region Sin logica
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != btnCerrarSesion)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            }
            else
            {
                btn.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            }
            btn.Cursor = Cursors.Hand;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != btnCerrarSesion)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
            else
            {
                btn.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            }
        }

        private void btnCrud2_Leave(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #endregion

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("No se recibió información del usuario.");
                return;
            }

            AbrirFormulario(new frmClienteCompras(usuarioActual.IdUsuario));
        }
    }
}
