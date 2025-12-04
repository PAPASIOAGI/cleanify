using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cleanify
{
    internal class koneksi
    {
        public string connectionString = "Host=localhost;Port=5552;Username=postgres;Password=123;Database=cleanify";

        public NpgsqlConnection GetConnection() => new NpgsqlConnection(connectionString);

        /// <summary>
        /// Try to authenticate a user against tbllogin (columns: id, nama_pengguna, password).
        /// Returns true and sets id when authentication succeeds.
        /// </summary>
        public bool TryLogin(string username, string password, out int id)
        {
            id = -1;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            using var conn = GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT id FROM tbllogin WHERE nama_pengguna = @u AND password = @p LIMIT 1",
                conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);

            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                id = Convert.ToInt32(result);
                return true;
            }

            return false;
        }
    }
}
