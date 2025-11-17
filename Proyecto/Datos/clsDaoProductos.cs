using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    /// <summary>
    /// Se encarga de manejar la conexión a la base de datos y realizar operaciones CRUD
    /// sobre los productos registrados en el sistema.
    /// </summary>
    public class clsDaoProductos
    {
        private readonly string conexion =
            "server=localhost; database=ventasbd; uid=root; pwd=;";


        /// <summary>
        /// Inserta un nuevo producto en la base de datos.
        /// </summary>
        /// <param name="producto">Objeto Producto que contiene
        /// los datos del producto a registrar.</param>
        /// <returns>
        /// <c>true</c> si la inserción fue exitosa; de lo contrario,
        /// lanza una <see cref="ApplicationException"/>.
        /// </returns>
        public bool InsertarProducto(Producto producto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query =
                    "INSERT INTO productos (Nombre, Descripcion, Existencia, PrecioUnitario) " +
                    "VALUES (@Nombre, @Descripcion, @Existencia, @PrecioUnitario)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar el producto.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }


        /// <summary>
        /// Actualiza los datos de un producto existente en la base de datos.
        /// </summary>
        /// <param name="producto">Objeto Producto con los datos actualizados.</param>
        /// <returns>
        /// <c>true</c> si la actualización fue exitosa; de lo contrario,
        /// lanza una <see cref="ApplicationException"/>.
        /// </returns>
        public bool ActualizarProducto(Producto producto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query =
                    "UPDATE productos " +
                    "SET Nombre = @Nombre, Descripcion = @Descripcion, Existencia = @Existencia, PrecioUnitario = @PrecioUnitario " +
                    "WHERE IdProducto = @IdProducto";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar el producto.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }


        /// <summary>
        /// Elimina un producto de la base de datos mediante su ID.
        /// </summary>
        /// <param name="idProducto">ID del producto a eliminar.</param>
        /// <returns>
        /// <c>true</c> si la eliminación fue exitosa; de lo contrario,
        /// lanza una <see cref="ApplicationException"/>.
        /// </returns>
        public bool EliminarProducto(int idProducto)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "DELETE FROM productos WHERE IdProducto = @IdProducto";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar el producto.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }


        /// <summary>
        /// Obtiene la lista completa de productos registrados en la base de datos.
        /// </summary>
        /// <returns>
        /// Una lista de objetos <see cref="Producto"/> con todos los productos encontrados.
        /// </returns>
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM productos ORDER BY Nombre ASC";

                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto
                    {
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Existencia = Convert.ToInt32(reader["Existencia"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                    };

                    productos.Add(p);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los productos.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Busca productos cuyo nombre contenga el texto especificado.
        /// </summary>
        /// <param name="nombre">Texto a buscar dentro del nombre del producto.</param>
        /// <returns>
        /// Una lista de <see cref="Producto"/> que coincidan con la búsqueda.
        /// </returns>
        public List<Producto> BuscarPorNombre(string nombre)
        {
            List<Producto> productos = new List<Producto>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query =
                    "SELECT * FROM productos " +
                    "WHERE Nombre LIKE CONCAT('%', @Nombre, '%') " +
                    "ORDER BY Nombre ASC";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto
                    {
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Existencia = Convert.ToInt32(reader["Existencia"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                    };

                    productos.Add(p);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al buscar productos por nombre.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        /// <summary>
        /// Obtiene la lista completa de productos desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Producto"/> con todos los productos encontrados.</returns>
        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> productos = new List<Producto>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT IdProducto, Nombre, Descripcion, Existencia, PrecioUnitario FROM productos ORDER BY Nombre ASC";
                cmd = new MySqlCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Producto p = new Producto
                    {
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Existencia = reader["Existencia"] != DBNull.Value ? Convert.ToInt32(reader["Existencia"]) : 0,
                        PrecioUnitario = reader["PrecioUnitario"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioUnitario"]) : 0m
                    };

                    productos.Add(p);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los productos.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

    }
}
