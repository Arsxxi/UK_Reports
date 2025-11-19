using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace lapor
{
    public partial class StudentDashboard : Form
    {
        private User _user;

        // Hapus Constructor default, ganti dengan ini:
        public StudentDashboard(User user)
        {
            InitializeComponent();
            _user = user;
            this.Text = "Mahasiswa: " + user.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imgData = null;
            if (pbImage.Image != null) imgData = DbHelper.ImageToByteArray(pbImage.Image);

            string q = "INSERT INTO reports (student_username, student_name, faculty, title, location, priority, description, report_image) VALUES (@u, @n, @f, @t, @loc, @prio, @d, @img)";
            MySqlParameter[] p = {
                new MySqlParameter("@u", _user.Username), new MySqlParameter("@n", _user.FullName),
                new MySqlParameter("@f", _user.Faculty), new MySqlParameter("@t", txtTitle.Text),
                new MySqlParameter("@loc", txtLoc.Text), new MySqlParameter("@prio", cmbPrio.Text),
                new MySqlParameter("@d", txtDesc.Text), new MySqlParameter("@img", imgData ?? (object)DBNull.Value)
            };
            DbHelper.ExecuteNonQuery(q, p);
            MessageBox.Show("Terkirim!");
            LoadHistory();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK) pbImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void LoadHistory()
        {
            string q = "SELECT date_created, title, status, admin_feedback FROM reports WHERE student_username=@u ORDER BY date_created DESC";
            dgv.DataSource = DbHelper.ExecuteQuery(q, new MySqlParameter("@u", _user.Username));
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
