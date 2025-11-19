using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto.Datos
{
    /// <summary>
    /// Clase DAO encargada de realizar operaciones CRUD para la tabla Reportes.
    /// Maneja conexión, lectura, inserción, actualización y eliminación.
    /// </summary>
    public class clsReportes
    {
        private readonly string conexion =
            "server=localhost; database=VentasBD; uid=root; pwd=2218914015;";

        /// <summary>
        /// Inserta un nuevo reporte en la base de datos.
        /// </summary>
        /// <param name="reporte">Objeto Reporte que se insertará.</param>
        /// <returns>True si se insertó correctamente; de lo contrario lanza excepción.</returns>
        public bool Insertar(Reporte reporte)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"INSERT INTO reportes 
                                (IdUsuario, IdProducto, tipo_reporte, cantidad, total)
                                VALUES 
                                (@IdUsuario, @IdProducto, @TipoReporte, @Cantidad, @Total)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", reporte.IdUsuario);
                cmd.Parameters.AddWithValue("@IdProducto", reporte.IdProducto);
                cmd.Parameters.AddWithValue("@TipoReporte", reporte.TipoReporte);
                cmd.Parameters.AddWithValue("@Cantidad", reporte.Cantidad);
                cmd.Parameters.AddWithValue("@Total", reporte.Total);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al insertar reporte.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene la lista completa de reportes existentes en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Reporte.</returns>
        public List<Reporte> ObtenerTodos()
        {
            List<Reporte> lista = new List<Reporte>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM reportes";
                cmd = new MySqlCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reporte r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(r);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reportes.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Actualiza la información de un reporte existente.
        /// </summary>
        /// <param name="reporte">Reporte con los datos actualizados.</param>
        /// <returns>True si se actualizó correctamente.</returns>
        public bool Actualizar(Reporte reporte)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"UPDATE reportes SET
                                IdUsuario = @IdUsuario,
                                IdProducto = @IdProducto,
                                tipo_reporte = @TipoReporte,
                                cantidad = @Cantidad,
                                total = @Total
                                WHERE IdReporte = @IdReporte";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdUsuario", reporte.IdUsuario);
                cmd.Parameters.AddWithValue("@IdProducto", reporte.IdProducto);
                cmd.Parameters.AddWithValue("@TipoReporte", reporte.TipoReporte);
                cmd.Parameters.AddWithValue("@Cantidad", reporte.Cantidad);
                cmd.Parameters.AddWithValue("@Total", reporte.Total);
                cmd.Parameters.AddWithValue("@IdReporte", reporte.IdReporte);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al actualizar reporte.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Elimina un reporte de la base de datos según su IdReporte.
        /// </summary>
        /// <param name="idReporte">ID del reporte a eliminar.</param>
        /// <returns>True si la eliminación fue correcta.</returns>
        public bool Eliminar(int idReporte)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "DELETE FROM reportes WHERE IdReporte = @IdReporte";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReporte", idReporte);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al eliminar reporte.", ex);
            }
            finally
            {
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene un reporte por su ID.
        /// </summary>
        /// <param name="id">ID del reporte a buscar.</param>
        /// <returns>Objeto Reporte si existe; de lo contrario null.</returns>
        public Reporte ObtenerPorId(int id)
        {
            Reporte r = null;

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM reportes WHERE IdReporte = @Id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };
                }

                return r;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reporte por ID.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene todos los reportes de un usuario específico.
        /// </summary>
        /// <param name="idUsuario">ID del usuario.</param>
        /// <returns>Lista de reportes del usuario.</returns>
        public List<Reporte> ObtenerPorUsuario(int idUsuario)
        {
            List<Reporte> lista = new List<Reporte>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM reportes WHERE IdUsuario = @IdUsuario";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reporte r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(r);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reportes por usuario.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene todos los reportes de un producto específico.
        /// </summary>
        /// <param name="idProducto">ID del producto.</param>
        /// <returns>Lista de reportes del producto.</returns>
        public List<Reporte> ObtenerPorProducto(int idProducto)
        {
            List<Reporte> lista = new List<Reporte>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM reportes WHERE IdProducto = @IdProducto";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reporte r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(r);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reportes por producto.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene reportes por tipo específico (Venta, Compra, Devolucion).
        /// </summary>
        /// <param name="tipoReporte">Tipo de reporte a filtrar.</param>
        /// <returns>Lista de reportes del tipo especificado.</returns>
        public List<Reporte> ObtenerPorTipo(string tipoReporte)
        {
            List<Reporte> lista = new List<Reporte>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = "SELECT * FROM reportes WHERE tipo_reporte = @TipoReporte";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TipoReporte", tipoReporte);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reporte r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(r);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reportes por tipo.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }

        /// <summary>
        /// Obtiene reportes dentro de un rango de fechas.
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del rango.</param>
        /// <param name="fechaFin">Fecha de fin del rango.</param>
        /// <returns>Lista de reportes en el rango de fechas.</returns>
        public List<Reporte> ObtenerPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Reporte> lista = new List<Reporte>();

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(conexion);
                conn.Open();

                string query = @"SELECT * FROM reportes 
                                WHERE fecha_reporte BETWEEN @FechaInicio AND @FechaFin";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reporte r = new Reporte
                    {
                        IdReporte = Convert.ToInt32(reader["IdReporte"]),
                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                        FechaReporte = Convert.ToDateTime(reader["fecha_reporte"]),
                        TipoReporte = reader["tipo_reporte"].ToString(),
                        Cantidad = Convert.ToInt32(reader["cantidad"]),
                        Total = Convert.ToDecimal(reader["total"])
                    };

                    lista.Add(r);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener reportes por rango de fechas.", ex);
            }
            finally
            {
                reader?.Close();
                cmd?.Dispose();
                conn?.Close();
            }
        }
    }
}