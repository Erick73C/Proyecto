using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    /// <summary>
    /// DAO encargado de gestionar el CRUD de ventas en la base de datos "ventasbd".
    /// Respeta el mismo estilo y estructura que clsDaoDatos.
    /// </summary>
    public class clsDaoVentas
    {
        private readonly string conexion =
            "server=localhost; database=VentasBD; uid=root; pwd=2218914015;";

        #region INSERTAR VENTA

        /// <summary>
        /// Inserta una nueva venta en la base de datos.
        /// </summary>
        /// <param name="venta">Objeto Venta que contiene los datos de la venta.</param>
        /// <returns>Verdadero si la inserción fue exitosa.</returns>
        public bool InsertarVenta(Venta venta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"INSERT INTO ventas
                                (Fecha, Cliente, Producto, Cantidad, PrecioUnitario)
                                VALUES
                                (@Fecha, @Cliente, @Producto, @Cantidad, @PrecioUnitario);";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
                cmd.Parameters.AddWithValue("@Producto", venta.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", venta.PrecioUnitario);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar la venta.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        #endregion

        #region OBTENER TODAS LAS VENTAS

        /// <summary>
        /// Obtiene todas las ventas registradas en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Venta.</returns>
        public List<Venta> ObtenerTodasLasVentas()
        {
            List<Venta> lista = new List<Venta>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM ventas ORDER BY Fecha DESC;";
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Venta v = new Venta
                    {
                        IdVenta = Convert.ToInt32(reader["IdVenta"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Cliente = reader["Cliente"].ToString(),
                        Producto = reader["Producto"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(v);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener las ventas.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        #endregion

        #region BUSCAR VENTA POR ID

        /// <summary>
        /// Obtiene una venta específica mediante su ID.
        /// </summary>
        /// <param name="id">ID de la venta.</param>
        /// <returns>Objeto Venta o null si no existe.</returns>
        public Venta ObtenerVentaPorId(int id)
        {
            Venta venta = null;

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM ventas WHERE IdVenta = @Id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    venta = new Venta
                    {
                        IdVenta = Convert.ToInt32(reader["IdVenta"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Cliente = reader["Cliente"].ToString(),
                        Producto = reader["Producto"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };
                }

                return venta;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener la venta.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        #endregion

        #region ACTUALIZAR VENTA

        /// <summary>
        /// Actualiza los datos de una venta existente.
        /// </summary>
        /// <param name="venta">Objeto Venta con los datos actualizados.</param>
        /// <returns>Verdadero si la actualización fue exitosa.</returns>
        public bool ActualizarVenta(Venta venta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"UPDATE ventas 
                                SET Cliente = @Cliente,
                                    Producto = @Producto,
                                    Cantidad = @Cantidad,
                                    PrecioUnitario = @PrecioUnitario
                                WHERE IdVenta = @IdVenta";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cliente", venta.Cliente);
                cmd.Parameters.AddWithValue("@Producto", venta.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", venta.PrecioUnitario);
                cmd.Parameters.AddWithValue("@IdVenta", venta.IdVenta);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar la venta.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        #endregion

        #region ELIMINAR VENTA

        /// <summary>
        /// Elimina una venta de la base de datos.
        /// </summary>
        /// <param name="idVenta">ID de la venta a eliminar.</param>
        /// <returns>Verdadero si la eliminación fue exitosa.</returns>
        public bool EliminarVenta(int idVenta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "DELETE FROM ventas WHERE IdVenta = @IdVenta";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar la venta.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
                conn?.Dispose();
            }
        }

        #endregion
    }
}
