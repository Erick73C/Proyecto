using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        #region Variables Globales
        clsDaoUsuarios dao = new clsDaoUsuarios();
        #endregion

        #region Metodos auxiliares
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Validaciones
        /// <summary>
        /// Valida si los campos usuario y contraseña están llenos.
        /// </summary>
        private bool ValidarDatos()
        {
            bool valido = true;

            
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Focus();
                txtUsuario.BackColor = Color.IndianRed;
                errUsuario.SetError(txtUsuario, "El nombre de usuario es obligatorio");
                valido = false;
            }
            else
            {
                txtUsuario.BackColor = Color.White;
                errUsuario.Clear();
            }

            
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                txtContrasenia.Focus();
                txtContrasenia.BackColor = Color.IndianRed;
                errpass.SetError(txtContrasenia, "Debes ingresar la contraseña");
                valido = false;
            }
            else
            {
                txtContrasenia.BackColor = Color.White;
                errpass.Clear();
            }

            return valido;
        }

        #endregion

        #region ObjetosInterfaz 

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

           
            Usuario u = dao.Login(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());

            if (u == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show($"Bienvenido: {u.Nombre}\nRol: {u.Rol}", "Acceso permitido");

           
            frmMenu frm = new frmMenu(u); 
            frm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
       
        #endregion



    }
}
