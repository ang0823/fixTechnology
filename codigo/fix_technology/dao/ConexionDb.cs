using System;
using System.Data.SqlClient;

namespace fix_technology.dao
{

    /// <summary>
    /// Lógica de interacción para abrir o cerrar la conexion 
    /// a la base de datos del negocio Fix Technology
    /// </summary>
    class ConexionDb
    {
        string credenciales = @"Server = localhost; Database = fix_technology; Trusted_Connection = True;";
        SqlConnection conexion;

        /// <summary>
        /// Establece una conexión a la base de datos.
        /// </summary>
        /// <returns>True: si se esableció la conexión de forma exitosa o False en caso contrario.</returns>
        /// <exception cref="InvalidOperationException">Lanzada cuando una llamada al método no es válida para el estado actual del objeto.</exception>
        ///  /// <exception cref="SqlException">Lanzada cuando hay un error en SQL al cerrar la conexión.</exception>
        /// <exception cref="Exception">Lanzada cuando ocurre un error no reconocido.</exception>
        public bool abrir()
        {
            bool conectada = false;

            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = credenciales;
                conexion.Open();
                conectada = true;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conectada;
        }

        /// <summary>
        /// Comprueba si la conexión a base de datos ha sido establecida previamente y
        /// en caso afirmativo, la finaliza.
        /// </summary>
        /// <returns>True: si se cerró la conexión de forma exitosa o False en caso contrario.</returns>
        /// <exception cref="SqlException">Lanzada cuando hay un error en SQL al cerrar la conexión.</exception>
        /// <exception cref="Exception">Lanzada cuando ocurre un error no reconocido.</exception>
        public bool cerrar()
        {
            bool cerrada = false;

            if (conexion != null)
            {
                try
                {
                    conexion.Close();
                    cerrada = true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return cerrada;
        }
    }
}
