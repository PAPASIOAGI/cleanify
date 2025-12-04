using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Cleanify
{
    public partial class Form3 : Form
    {
        private readonly koneksi db = new koneksi();

        public class CenteredDateTimePicker : DateTimePicker
        {
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == 0x000F) // WM_PAINT
                {
                    using (Graphics g = Graphics.FromHwnd(Handle))
                    {
                        TextRenderer.DrawText(
                            g,
                            this.Text,
                            this.Font,
                            this.ClientRectangle,
                            this.ForeColor,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                        );
                    }
                }
            }
        }

        public Form3()
        {
            InitializeComponent();

            // wire the insert button which wasn't wired in designer
            btnTambah.Click += btnTambah_Click;

            // load existing data
            LoadData();
        }

        public void Extra()
        {
            btnextra.Text = "Express (2 jam)";
            pnl3.BackColor = Color.White;
            btnextra.BackColor = Color.White;
            btnextra.ForeColor = Color.FromArgb(10, 74, 122);
            btnregular.Text = "Regular";
            btnnextday.Text = "Next Day";
            pnl1.BackColor = Color.FromArgb(10, 74, 122);
            pnl2.BackColor = Color.FromArgb(10, 74, 122);
            btnnextday.BackColor = Color.FromArgb(10, 74, 122);
            btnregular.BackColor = Color.FromArgb(10, 74, 122);
            btnnextday.ForeColor = Color.White;
            btnregular.ForeColor = Color.White;
            lbl5000.Visible = false;
            lbl10000.Visible = false;
            lbl15000.Visible = true;
        }

        public void NextDay()
        {
            btnnextday.Text = "Next Day (1 hari)";
            pnl2.BackColor = Color.White;
            btnnextday.BackColor = Color.White;
            btnnextday.ForeColor = Color.FromArgb(10, 74, 122);
            btnregular.Text = "Regular";
            btnextra.Text = "Express";
            pnl1.BackColor = Color.FromArgb(10, 74, 122);
            pnl3.BackColor = Color.FromArgb(10, 74, 122);
            btnregular.BackColor = Color.FromArgb(10, 74, 122);
            btnextra.BackColor = Color.FromArgb(10, 74, 122);
            btnregular.ForeColor = Color.White;
            btnextra.ForeColor = Color.White;
            lbl5000.Visible = false;
            lbl10000.Visible = true;
            lbl15000.Visible = false;
        }

        public void Regular()
        {
            btnregular.Text = "Regular (3 hari)";
            pnl1.BackColor = Color.White;
            btnregular.BackColor = Color.White;
            btnregular.ForeColor = Color.FromArgb(10, 74, 122);
            btnextra.Text = "Express";
            btnnextday.Text = "Next Day";
            pnl2.BackColor = Color.FromArgb(10, 74, 122);
            pnl3.BackColor = Color.FromArgb(10, 74, 122);
            btnnextday.BackColor = Color.FromArgb(10, 74, 122);
            btnextra.BackColor = Color.FromArgb(10, 74, 122);
            btnnextday.ForeColor = Color.White;
            btnextra.ForeColor = Color.White;
            lbl5000.Visible = true;
            lbl10000.Visible = false;
            lbl15000.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Regular();
            dtptanggalpesan.Format = DateTimePickerFormat.Custom;
            dtptanggalpesan.ForeColor = Color.FromArgb(10, 74, 122);
        }

        private void txtnamapelanggan_TextChanged(object sender, EventArgs e) { }
        private void txtalamat_TextChanged(object sender, EventArgs e) { }
        private void txtnomortelepon_TextChanged(object sender, EventArgs e) { }
        private void txsatuan_TextChanged(object sender, EventArgs e) { }
        private void datagridpenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            // reset inputs
            txtnamapelanggan.Clear();
            txtalamat.Clear();
            txtnomortelepon.Clear();
            numsatuan.Value = 0;
            Regular();
        }

        private void btnextra_Click(object sender, EventArgs e) => Extra();
        private void btnnextday_Click(object sender, EventArgs e) => NextDay();
        private void btnregular_Click(object sender, EventArgs e) => Regular();
        private void label1_Click(object sender, EventArgs e) { }
        private void pnl4_Paint(object sender, PaintEventArgs e) { }
        private void pnl1_Paint(object sender, PaintEventArgs e) { }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void lbl15000_Click(object sender, EventArgs e) { }

        // ----- Database methods -----
        private void LoadData()
        {
            try
            {
                using var conn = db.GetConnection();
                conn.Open();

                using var cmd = new NpgsqlCommand(@"
                    SELECT id_pemesanan, nama_pelanggan, nomor_telepon, alamat, pelayanan, satuan, harga, tanggal_pesan, tanggal_ambil
                    FROM tbltransaksipenjualan
                    ORDER BY id_pemesanan DESC
                ", conn);

                using var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // optional: set nicer column headers
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id_pemesanan"].HeaderText = "ID";
                    dataGridView1.Columns["nama_pelanggan"].HeaderText = "Nama Pelanggan";
                    dataGridView1.Columns["nomor_telepon"].HeaderText = "Nomor Telepon";
                    dataGridView1.Columns["alamat"].HeaderText = "Alamat";
                    dataGridView1.Columns["pelayanan"].HeaderText = "Pelayanan";
                    dataGridView1.Columns["satuan"].HeaderText = "Satuan (kg)";
                    dataGridView1.Columns["harga"].HeaderText = "Harga (Rp)";
                    dataGridView1.Columns["tanggal_pesan"].HeaderText = "Tanggal Pesan";
                    dataGridView1.Columns["tanggal_ambil"].HeaderText = "Tanggal Ambil";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object? sender, EventArgs e)
        {
            var nama = txtnamapelanggan.Text.Trim();
            var nomor_telepon = txtnomortelepon.Text.Trim();
            var alamat = txtalamat.Text.Trim();
            var satuan = (int)numsatuan.Value;
            var tanggalPesan = dtptanggalpesan.Value;
            var tanggalAmbil = dtptanggalambil.Value;

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Masukkan nama pelanggan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnamapelanggan.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nomor_telepon))
            {
                MessageBox.Show("Masukkan nomor telepon.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomortelepon.Focus();
                return;
            }

            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Masukkan alamat.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtalamat.Focus();
                return;
            }

            if (satuan <= 0)
            {
                MessageBox.Show("Masukkan satuan (kg) lebih dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numsatuan.Focus();
                return;
            }

            // Determine pelayanan and price per kg (use base labels, not time range in UI)
            string pelayanan;
            int hargaPerKg;
            if (lbl15000.Visible)
            {
                pelayanan = "Express";
                hargaPerKg = 15000;
            }
            else if (lbl10000.Visible)
            {
                pelayanan = "Next Day";
                hargaPerKg = 10000;
            }
            else
            {
                pelayanan = "Regular";
                hargaPerKg = 5000;
            }

            var harga = hargaPerKg * satuan;

            try
            {
                using var conn = db.GetConnection();
                conn.Open();

                using var cmd = new NpgsqlCommand(@"
                    INSERT INTO tbltransaksipenjualan
                        (nama_pelanggan, nomor_telepon, alamat, pelayanan, satuan, harga, tanggal_pesan, tanggal_ambil)
                    VALUES
                        (@nama, @nomor_telepon, @alamat, @pelayanan, @satuan, @harga, @tanggal_pesan, @tanggal_ambil)
                ", conn);

                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("nomor_telepon", nomor_telepon);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.Parameters.AddWithValue("pelayanan", pelayanan);
                cmd.Parameters.AddWithValue("satuan", satuan);
                cmd.Parameters.AddWithValue("harga", harga);
                cmd.Parameters.AddWithValue("tanggal_pesan", tanggalPesan);
                cmd.Parameters.AddWithValue("tanggal_ambil", tanggalAmbil);

                var rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data pemesanan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear inputs and refresh list
                    txtnamapelanggan.Clear();
                    txtalamat.Clear();
                    txtnomortelepon.Clear();
                    numsatuan.Value = 0;
                    Regular();

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
