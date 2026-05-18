using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;

namespace attendance.PAL.FORMS
{
    public static class DatabaseHelper
    {
        private static string databasePath = Path.Combine(Application.StartupPath, "schoolattendance.db");
        private static string connectionString = $"Data Source={databasePath}";

        public static string Login(string username, string password)
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
