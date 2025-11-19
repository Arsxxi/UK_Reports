using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace lapor
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text)) return;

            string q = "INSERT INTO users (username, password, full_name, nim, faculty, role) VALUES (@u, @p, @n, @ni, @f, 'STUDENT')";
            MySqlParameter[] p = {
                new MySqlParameter("@u", txtUser.Text), new MySqlParameter("@p", txtPass.Text),
                new MySqlParameter("@n", txtName.Text), new MySqlParameter("@ni", txtNim.Text),
                new MySqlParameter("@f", txtFac.Text)
            };

            DbHelper.ExecuteNonQuery(q, p);
            MessageBox.Show("Pendaftaran Berhasil! Silahkan Login.");
            this.Close();
        }
    }
}
