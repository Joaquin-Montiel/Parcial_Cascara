using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public static class AccesoDatos
    {
        private static SqlConnection connection;
        private static SqlCommand comamand;

        static AccesoDatos()
        {
            string connectionString = "[20240701-SP].dbo.series"; 
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public static List<Serie> ObtenerBacklog()
        {
            List<Serie> series = new List<Serie>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM series";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string genero = reader["genero"].ToString();
                        string nombre = reader["nombre"].ToString();

                        Serie serie = new Serie(genero, nombre);
                        series.Add(serie);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error al obtener el backlog: " + ex.Message);
                throw new BackLogException("Error al obtener el backlog de series.", ex);
            }
            finally
            {
                connection.Close();
            }

            return series;
        }

        public static void ActualizarSerie(Serie serie)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE series SET alumno = @alumno WHERE nombre = @nombre";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@alumno", Environment.UserName); // Ejemplo: nombre del alumno actual
                command.Parameters.AddWithValue("@nombre", serie.Nombre);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.Log("Error al actualizar la serie: " + ex.Message);
                throw new BackLogException("Error al actualizar la serie.", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
