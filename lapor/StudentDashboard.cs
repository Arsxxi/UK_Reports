using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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
            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Judul tidak boleh kosong!");
                return;
            }

            byte[] imgData = null;
            if (pbImage.Image != null) imgData = DbHelper.ImageToByteArray(pbImage.Image);

            string q = "INSERT INTO reports (student_username, student_name, faculty, title, location, priority, description, report_image) VALUES (@u, @n, @f, @t, @loc, @prio, @d, @img)";

            MySqlParameter[] p = {
                new MySqlParameter("@u", _user.Username),
                new MySqlParameter("@n", _user.FullName),
                new MySqlParameter("@f", _user.Faculty),
                new MySqlParameter("@t", txtTitle.Text),
                new MySqlParameter("@loc", txtLoc.Text),
                new MySqlParameter("@prio", cmbPrio.Text),
                new MySqlParameter("@d", txtDesc.Text),
                new MySqlParameter("@img", imgData ?? (object)DBNull.Value)
            };

            DbHelper.ExecuteNonQuery(q, p);
            MessageBox.Show("Laporan Terkirim!");

            // Reset Form agar bersih kembali
            txtTitle.Clear();
            txtLoc.Clear();
            txtDesc.Clear();
            pbImage.Image = null;

            LoadHistory(); // Refresh tampilan kartu

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

            // A. Bersihkan wadah (hapus kartu lama)
            flpHistory.Controls.Clear();

            // B. Ambil data dari database
            string q = "SELECT date_created, title, location, status, admin_feedback, report_image FROM reports WHERE student_username=@u ORDER BY date_created DESC";
            DataTable dt = DbHelper.ExecuteQuery(q, new MySqlParameter("@u", _user.Username));

            // C. Looping: Untuk setiap baris data, buat satu kartu
            foreach (DataRow row in dt.Rows)
            {
                // 1. Buat Panel Utama (Kertas Kartunya)
                Panel card = new Panel();
                card.Width = flpHistory.Width - 50; // Lebar menyesuaikan layar
                card.Height = 140;                  // Tinggi kartu
                card.BackColor = Color.WhiteSmoke;  // Warna dasar
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(0, 0, 0, 15); // Jarak antar kartu

                // 2. Indikator Warna Status (Garis di kiri)
                Panel colorStrip = new Panel();
                colorStrip.Width = 10;
                colorStrip.Dock = DockStyle.Left;

                string status = row["status"].ToString();
                if (status == "Selesai") colorStrip.BackColor = Color.SeaGreen;
                else if (status == "Sedang Proses") colorStrip.BackColor = Color.Orange;
                else if (status == "Ditolak") colorStrip.BackColor = Color.Red;
                else colorStrip.BackColor = Color.Gray; // Menunggu

                // 3. Label Judul
                Label lblTitle = new Label();
                lblTitle.Text = row["title"].ToString();
                lblTitle.Location = new Point(20, 10);
                lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblTitle.AutoSize = true;

                // 4. Label Info (Lokasi & Tanggal)
                Label lblInfo = new Label();
                lblInfo.Text = "📅 " + row["date_created"] + " | 📍 " + row["location"];
                lblInfo.Location = new Point(20, 35);
                lblInfo.ForeColor = Color.DimGray;
                lblInfo.AutoSize = true;

                // 5. Label Status (Badge Teks)
                Label lblStatus = new Label();
                lblStatus.Text = status.ToUpper();
                lblStatus.Location = new Point(20, 60);
                lblStatus.ForeColor = colorStrip.BackColor; // Warna teks sama dengan garis
                lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblStatus.AutoSize = true;

                // 6. Label Feedback Admin
                Label lblFeed = new Label();
                string feedback = row["admin_feedback"].ToString();
                lblFeed.Text = string.IsNullOrEmpty(feedback) ? "..." : "💬 Admin: " + feedback;
                lblFeed.Location = new Point(20, 85);
                lblFeed.Width = 400; // Batasi lebar agar tidak nabrak foto
                lblFeed.Font = new Font("Segoe UI", 9, FontStyle.Italic);

                // 7. Gambar Thumbnail (Jika ada)
                if (row["report_image"] != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row["report_image"];
                    PictureBox pbThumb = new PictureBox();
                    pbThumb.Image = DbHelper.ByteArrayToImage(imgBytes);
                    pbThumb.SizeMode = PictureBoxSizeMode.Zoom;
                    pbThumb.Size = new Size(100, 100);
                    pbThumb.Location = new Point(card.Width - 120, 15); // Taruh di kanan
                    pbThumb.BorderStyle = BorderStyle.FixedSingle;

                    card.Controls.Add(pbThumb); // Masukkan foto ke kartu
                }

                // 8. RAKIT SEMUA: Masukkan komponen ke dalam Kartu
                card.Controls.Add(colorStrip);
                card.Controls.Add(lblTitle);
                card.Controls.Add(lblInfo);
                card.Controls.Add(lblStatus);
                card.Controls.Add(lblFeed);

                // 9. FINAL: Masukkan Kartu yang sudah jadi ke Wadah (FlowLayoutPanel)
                flpHistory.Controls.Add(card);
            }

            // Cek jika data kosong
            if (flpHistory.Controls.Count == 0)
            {
                Label lblEmpty = new Label { Text = "Belum ada riwayat laporan.", AutoSize = true, Font = new Font("Segoe UI", 14) };
                flpHistory.Controls.Add(lblEmpty);
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }
        // Event kosong (Jangan dihapus jika Designer sudah membuatnya)

        private void flpHistory_Paint(object sender, PaintEventArgs e) { }

        private void txtLoc_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Tampilkan konfirmasi dulu
            DialogResult dialog = MessageBox.Show("Yakin ingin keluar akun?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close(); // Menutup Dashboard ini
                              // Karena di LoginForm kita pakai .ShowDialog(),
                              // maka saat ini ditutup, otomatis akan kembali ke Login Form.
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
