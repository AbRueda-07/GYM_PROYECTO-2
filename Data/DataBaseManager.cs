using Microsoft.Data.SqlClient;

namespace GYM_Proyecto2_Forms_Ext.Data
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            // Asegúrate de que tu cadena de conexión es correcta
            _connectionString = "Server=DESKTOP-T3ECS92\\SQLEXPRESS;Database=DB_Gym_parcial2;Integrated Security=True;TrustServerCertificate=True;";
        }

        /// <summary>
        /// Devuelve una nueva conexión abierta a la base de datos.
        /// </summary>
        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Devuelve una nueva conexión (sin abrir) para usar en bloques using.
        /// </summary>
        public SqlConnection GetNewConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}