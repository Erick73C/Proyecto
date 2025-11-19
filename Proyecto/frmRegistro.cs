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
    public partial class frmRegistro : Form
    {
        #region Variables Globales
        clsDaoUsuarios dao = new clsDaoUsuarios();

        #endregion

        #region metodos auxiliares
        public frmRegistro()
        {
            InitializeComponent();
        }

        #endregion

        #region ValidacionCampos
        /// <summary>
        /// valida que los campos no esten vacios.
        /// </summary>
        /// <returns></returns>
        private bool ValidarTodo()
        {
            validarNombre();
            validarApellido();
            validarCorreo();
            validarUsuario();
            validarContra();

            if (!string.IsNullOrEmpty(errnombre.GetError(txtNombre))) return false;
            if (!string.IsNullOrEmpty(errapellido.GetError(txtApellidoPaterno))) return false;
            if (!string.IsNullOrEmpty(erremail.GetError(txtEmail))) return false;
            if (!string.IsNullOrEmpty(errorusuario.GetError(txtUsuario))) return false;
            if (!string.IsNullOrEmpty(errorpass.GetError(txtContrasenia))) return false;

            return true;
        }

        private void validarNombre()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.IndianRed;
                errnombre.SetError(txtNombre, "Debe escribir el nombre");
            }
            else if (!Regex.IsMatch(txtNombre.Text, patron))
            {
                txtNombre.BackColor = Color.IndianRed;
                errnombre.SetError(txtNombre, "El nombre no puede contener números ni símbolos");
            }
            else
            {
                errnombre.Clear();
                txtNombre.BackColor = Color.White;
            }
        }

        private void validarApellido()
        {
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ'\s]+$";

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errapellido.SetError(txtApellidoPaterno, "Debe escribir el apellido");
            }
            else if (!Regex.IsMatch(txtApellidoPaterno.Text, patron))
            {
                txtApellidoPaterno.BackColor = Color.IndianRed;
                errapellido.SetError(txtApellidoPaterno, "El apellido no puede contener números ni símbolos");
            }
            else
            {
                errapellido.Clear();
                txtApellidoPaterno.BackColor = Color.White;
            }
        }

        private void validarCorreo()
        {
            string patron = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.IndianRed;
                erremail.SetError(txtEmail, "Debe escribir el correo");
            }
            else if (!Regex.IsMatch(txtEmail.Text, patron))
            {
                txtEmail.BackColor = Color.IndianRed;
                erremail.SetError(txtEmail, "Formato de correo inválido");
            }
            else
            {
                erremail.Clear();
                txtEmail.BackColor = Color.White;
            }
        }

        private void validarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.BackColor = Color.IndianRed;
                errorusuario.SetError(txtUsuario, "Debe escribir el usuario");
            }
            else if (txtUsuario.Text.Length > 20)
            {
                txtUsuario.BackColor = Color.IndianRed;
                errorusuario.SetError(txtUsuario, "Debe ser menor a 20 caracteres");
            }
            else
            {
                errorusuario.Clear();
                txtUsuario.BackColor = Color.White;
            }
        }

        private void validarContra()
        {
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                txtContrasenia.BackColor = Color.IndianRed;
                errorpass.SetError(txtContrasenia, "Debe escribir la contraseña");
            }
            else if (txtContrasenia.Text.Length < 4)
            {
                txtContrasenia.BackColor = Color.IndianRed;
                errorpass.SetError(txtContrasenia, "Debe tener al menos 4 caracteres");
            }
            else
            {
                errorpass.Clear();
                txtContrasenia.BackColor = Color.White;
            }
        }

        #endregion

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
            if (!ValidarTodo())
            {
                MessageBox.Show("Corrige los errores antes de continuar.");
                return;
            }

            // Verificar si el usuario ya existe
            if (dao.ExisteUsuario(txtUsuario.Text))
            {
                MessageBox.Show("El usuario ya existe. Intenta con otro nombre.");
                return;
            }

            Usuario nuevo = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                ApellidoPaterno = txtApellidoPaterno.Text.Trim(),
                ApellidoMaterno = txtApellidoMaterno.Text.Trim(),
                Correo = txtEmail.Text.Trim(),
                UsuarioNombre = txtUsuario.Text.Trim(),
                Contrasena = txtContrasenia.Text.Trim(),
                Rol = "Cliente", //Rol por defecto de cliente
                FechaRegistro = DateTime.Now
            };

            // Insertar en BD
            bool exito = dao.Insertar(nuevo);

            if (exito)
            {
                MessageBox.Show("Usuario registrado correctamente.");
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }


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

        #endregion

        private void frmRegistro_Load_1(object sender, EventArgs e)
        {

        }
    }
}
