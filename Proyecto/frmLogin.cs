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
        public frmLogin()
        {
            InitializeComponent();
        }
        #region ObjetosInterfaz 

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validaciones
        /// <summary>
        /// valida los datos ingresados por el usuario en el formulario.
        /// </summary>
        /// <returns></returns>
        /// 
        private bool ValidarDatos()
        {
           
            if (string.IsNullOrEmpty(txtNombre.Text) == true)
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.IndianRed;
                errUsuario.SetError(txtNombre, "El nombre de usuario es obligatorio");
                return false;

            }

            else if (string.IsNullOrEmpty(txtContrasenia.Text) == true)
            {
                txtContrasenia.Focus();
                txtContrasenia.BackColor = Color.IndianRed;
                errpass.SetError(txtContrasenia, "Debes de ingresar la contraseña");
                return false;

            }

             return true; 
            
        }
        #endregion

        
    }
}
