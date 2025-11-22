using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace lapor
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM users WHERE username=@u AND password=@p";
            MySqlParameter[] p = { new MySqlParameter("@u", txtUser.Text), new MySqlParameter("@p", txtPass.Text) };
            DataTable dt = DbHelper.ExecuteQuery(q, p);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                User user = new User
                {
                    Username = r["username"].ToString(),
                    FullName = r["full_name"].ToString(),
                    Role = r["role"].ToString(),
                    Nim = r["nim"].ToString(),
                    Faculty = r["faculty"].ToString()
                };

                this.Hide();
                if (user.Role == "ADMIN") new AdminDashboard(user).ShowDialog();
                else new StudentDashboard(user).ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Login Gagal!"); }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegist().ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string q = "SELECT * FROM users WHERE username=@u AND password=@p";
            MySqlParameter[] p = { new MySqlParameter("@u", txtUser.Text), new MySqlParameter("@p", txtPass.Text) };
            DataTable dt = DbHelper.ExecuteQuery(q, p);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                User user = new User
                {
                    Username = r["username"].ToString(),
                    FullName = r["full_name"].ToString(),
                    Role = r["role"].ToString(),
                    Nim = r["nim"].ToString(),
                    Faculty = r["faculty"].ToString()
                };

                this.Hide();
                if (user.Role == "ADMIN") new AdminDashboard(user).ShowDialog();
                else new StudentDashboard(user).ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Login Gagal!"); }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegist().ShowDialog();
            this.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
