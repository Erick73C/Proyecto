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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        #region elementos Ui

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos() == false)
            {
                MessageBox.Show("Error al registrar");
            }
            else
            {
                //Lógica para registrar al usuario en la base de datos

                //clsDAO.registrarUsuario();

                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                Hide();
            }
        }

        #endregion

        #region ValidacionCampos
        /// <summary>
        /// valida que los campos no esten vacios.
        /// </summary>
        /// <returns></returns>
        public bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) == true)
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.IndianRed;
                errnombre.SetError(txtNombre, "El nombre de usuario es obligatorio");
                return false;
            }
            if (string.IsNullOrEmpty(txtContrasenia.Text) == true)
            {
                txtContrasenia.Focus();
                txtContrasenia.BackColor = Color.IndianRed;
                errorpass.SetError(txtContrasenia, "La contraseña es obligatoria");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text) == true)
            {
                txtApellido.Focus();
                txtApellido.BackColor = Color.IndianRed;
                errapellido.SetError(txtApellido, "Debes confirmar la contraseña");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                txtEmail.Focus();
                txtEmail.BackColor = Color.IndianRed;
                erremail.SetError(txtEmail, "El correo electrónico es obligatorio");
                return false;
            }
            if(string.IsNullOrEmpty(txtUsuario.Text) == true)
            {
                txtUsuario.Focus();
                txtUsuario.BackColor = Color.IndianRed;
                errorusuario.SetError(txtUsuario, "El usuario es obligatorio");
                return false;
            }
            return true;
        }



        #endregion


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
