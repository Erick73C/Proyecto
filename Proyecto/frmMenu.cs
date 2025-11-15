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
        public frmMenu()
        {
            InitializeComponent();
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
        private void btnCrud1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudUsuarios());
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
                // frmLogin login = new frmLogin();
                // login.Show();
            }
        }

        private void btnCrud2_Leave(object sender, EventArgs e)
        {

        }
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

        private void btnCrud3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudVentas());
        }

        private void btnCrud2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCrudProductos());
        }
    }
}
