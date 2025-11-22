using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lapor
{
    public partial class AdminDashboard : Form
    {
        private int selectedId = -1;

        public AdminDashboard(User user)
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string q = "SELECT id, date_created, student_name, priority, location, title, status FROM reports ORDER BY date_created DESC";
            dgv.DataSource = DbHelper.ExecuteQuery(q);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id"].Value);

                string status = row.Cells["status"].Value.ToString();
                if (cmbStatus.Items.Contains(status)) cmbStatus.SelectedItem = status;

                // Ambil Detail & Gambar
                DataTable dt = DbHelper.ExecuteQuery("SELECT description, admin_feedback, report_image FROM reports WHERE id=" + selectedId);
                if (dt.Rows.Count > 0)
                {
                    txtFeed.Text = dt.Rows[0]["admin_feedback"].ToString();
                    lblInfo.Text = "Deskripsi: \n" + dt.Rows[0]["description"].ToString();

                    if (dt.Rows[0]["report_image"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])dt.Rows[0]["report_image"];
                        using (MemoryStream ms = new MemoryStream(imgBytes)) pbBukti.Image = Image.FromStream(ms);
                    }
                    else pbBukti.Image = null;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            string q = "UPDATE reports SET status=@s, admin_feedback=@f WHERE id=@id";
            MySqlParameter[] p = {
                new MySqlParameter("@s", cmbStatus.Text),
                new MySqlParameter("@f", txtFeed.Text),
                new MySqlParameter("@id", selectedId)
            };
            DbHelper.ExecuteNonQuery(q, p);
            MessageBox.Show("Berhasil!");
            LoadData();
        }

        private void txtFeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Validasi: Apakah sudah ada baris yang dipilih?
            if (selectedId == -1)
            {
                MessageBox.Show("Silahkan pilih data yang ingin dihapus pada tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Konfirmasi: Tanya user yakin atau tidak
            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin MENGHAPUS laporan ini secara permanen?\nData yang dihapus tidak bisa dikembalikan.",
                                                  "Konfirmasi Hapus",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // 3. Eksekusi Hapus jika user pilih YES
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string q = "DELETE FROM reports WHERE id = @id";
                    MySqlParameter[] p = { new MySqlParameter("@id", selectedId) };

                    DbHelper.ExecuteNonQuery(q, p);

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Reset Tampilan
                    LoadData();         // Refresh tabel
                    ResetForm();        // Kosongkan inputan kanan
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message);
                }
            }
        }
        //
        // Fungsi tambahan untuk membersihkan form kanan setelah hapus
        private void ResetForm()
        {
            selectedId = -1;
            txtFeed.Clear();
            pbBukti.Image = null;
            lblInfo.Text = "Pilih laporan...";
            cmbStatus.SelectedIndex = -1;
        }
    }
}