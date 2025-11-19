using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto.Datos
{
    /// <summary>
    /// Clase DAO encargada de realizar operaciones CRUD para la tabla Usuarios.
    /// Maneja conexión, lectura, inserción, actualización y eliminación.
    /// </summary>
    public class clsDaoUsuarios
    {
        private readonly string conexion =
            "server=localhost; database=VentasBD; uid=root; pwd= ;";

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto Usuario que se insertará.</param>
        /// <returns>True si se insertó correctamente; de lo contrario lanza excepción.</returns>
        public bool Insertar(Usuario usuario)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                if (ExisteUsuarioPorDatos(usuario.Nombre.Trim(),
                    usuario.ApellidoPaterno.Trim(),
                    usuario.ApellidoMaterno?.Trim() ?? string.Empty,
                    usuario.Correo.Trim()))
                {
                    throw new ApplicationException("Ya existe un usuario con el mismo nombre, apellidos o correo.");
                }
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"INSERT INTO usuarios 
                                (Nombre, ApellidoPaterno, ApellidoMaterno, Correo, Usuario, Contrasena, Rol, FechaRegistro)
                                VALUES 
                                (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Correo, @Usuario, @Contrasena, @Rol, @FechaRegistro)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@Usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar usuario.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene la lista completa de usuarios existentes en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Usuario.</returns>
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM usuarios";
                cmd = new MySqlCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Usuario u = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        UsuarioNombre = reader["Usuario"].ToString(),
                        Contrasena = reader["Contrasena"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    };

                    lista.Add(u);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener usuarios.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Actualiza la información de un usuario existente.
        /// </summary>
        /// <param name="usuario">Usuario con los datos actualizados.</param>
        /// <returns>True si se actualizó correctamente.</returns>
        public bool Actualizar(Usuario usuario)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"UPDATE usuarios SET
                                Nombre = @Nombre,
                                ApellidoPaterno = @ApellidoPaterno,
                                ApellidoMaterno = @ApellidoMaterno,
                                Correo = @Correo,
                                Usuario = @Usuario,
                                Contrasena = @Contrasena,
                                Rol = @Rol
                                WHERE IdUsuario = @IdUsuario";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@Usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar usuario.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Elimina un usuario de la base de datos según su IdUsuario.
        /// </summary>
        /// <param name="idUsuario">ID del usuario a eliminar.</param>
        /// <returns>True si la eliminación fue correcta.</returns>
        public bool Eliminar(int idUsuario)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "DELETE FROM usuarios WHERE IdUsuario = @IdUsuario";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar usuario.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Valida login buscando coincidencia de usuario y contraseña.
        /// </summary>
        /// <param name="usuario">Usuario/correo ingresado.</param>
        /// <param name="contrasena">Contraseña ingresada.</param>
        /// <returns>Objeto Usuario si coincide; de lo contrario null.</returns>
        public Usuario Login(string usuario, string contrasena)
        {
            Usuario u = null;

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"SELECT * FROM usuarios 
                                 WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    u = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        UsuarioNombre = reader["Usuario"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    };
                }

                return u;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al validar el login.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario u = null;

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM usuarios WHERE IdUsuario = @Id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    u = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        Nombre = reader["Nombre"].ToString(),
                        ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        UsuarioNombre = reader["Usuario"].ToString(),
                        Contrasena = reader["Contrasena"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    };
                }

                return u;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener usuario por ID.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        public bool ExisteUsuario(string usuarioNombre)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @Usuario";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuarioNombre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al verificar usuario existente.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }
        public bool ExisteUsuarioPorDatos(string nombre, string apellidoPaterno, string apellidoMaterno, string correo)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"SELECT COUNT(*) FROM usuarios
                 WHERE Nombre = @Nombre
                   AND ApellidoPaterno = @ApellidoPaterno
                   AND ApellidoMaterno = @ApellidoMaterno
                   AND Correo = @Correo";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", correo);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al verificar existencia del usuario.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }


    }
}