using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Pastikan NuGet MySql.Data sudah terinstall

namespace lapor
{
    public class User
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Nim { get; set; }
        public string Faculty { get; set; }
        public string Role { get; set; }
    }

    public static class DbHelper
    {
        // Sesuaikan nama database Anda di sini
        private static string connectionString = "server=localhost;database=db_lapor_kampus;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // PERBAIKAN: Saya tambahkan 'params' disini
        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                // Cek jika parameter ada isinya
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                var dt = new DataTable();
                try
                {
                    conn.Open();
                    using (var da = new MySqlDataAdapter(cmd)) { da.Fill(dt); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error DB: " + ex.Message);
                }
                return dt;
            }
        }

        // PERBAIKAN: Saya tambahkan 'params' disini juga
        public static void ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                // Cek jika parameter ada isinya
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error DB: " + ex.Message);
                }
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
    }
}