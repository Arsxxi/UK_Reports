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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
