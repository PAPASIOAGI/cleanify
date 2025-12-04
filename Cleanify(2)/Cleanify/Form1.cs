using System;
using System.Windows.Forms;

namespace Cleanify
{
    public partial class Form1 : Form
    {
        private readonly koneksi db = new koneksi();

        public Form1()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
            // panel3 is initially hidden in designer; no user input required for id because it's serial
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtnama.Text.Trim();
            var password = txtpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Masukkan nama pengguna dan password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.TryLogin(username, password, out int userId))
            {
                // id is serial in DB; show it read-only if you want or store it for later
                txtid.Text = userId.ToString();
                panel3.Visible = true;

                var frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
        }
    }
}