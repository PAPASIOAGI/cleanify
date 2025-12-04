namespace Cleanify
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnregular = new Button();
            btnnextday = new Button();
            btnextra = new Button();
            pnl1 = new Panel();
            txtnamapelanggan = new TextBox();
            label3 = new Label();
            txtalamat = new TextBox();
            label4 = new Label();
            txtnomortelepon = new TextBox();
            label5 = new Label();
            btnTambah = new Button();
            btnbatal = new Button();
            pnl4 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            numsatuan = new NumericUpDown();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            dtptanggalambil = new DateTimePicker();
            panel5 = new Panel();
            label2 = new Label();
            dtptanggalpesan = new DateTimePicker();
            lbl15000 = new Label();
            lbl10000 = new Label();
            lbl5000 = new Label();
            pnl2 = new Panel();
            pnl3 = new Panel();
            btnkembali = new Button();
            label7 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            txtcari = new TextBox();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            pnl1.SuspendLayout();
            pnl4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numsatuan).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            pnl2.SuspendLayout();
            pnl3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 12);
            label1.Name = "label1";
            label1.Size = new Size(336, 31);
            label1.TabIndex = 1;
            label1.Text = "TRANSAKSI PENJUALAN";
            label1.Click += label1_Click;
            // 
            // btnregular
            // 
            btnregular.BackColor = Color.White;
            btnregular.FlatStyle = FlatStyle.Flat;
            btnregular.Font = new Font("Georgia", 18F);
            btnregular.ForeColor = Color.FromArgb(10, 74, 122);
            btnregular.Location = new Point(13, 9);
            btnregular.Name = "btnregular";
            btnregular.Size = new Size(191, 67);
            btnregular.TabIndex = 2;
            btnregular.Text = "Regular";
            btnregular.UseVisualStyleBackColor = false;
            btnregular.Click += btnregular_Click;
            // 
            // btnnextday
            // 
            btnnextday.BackColor = Color.White;
            btnnextday.FlatStyle = FlatStyle.Flat;
            btnnextday.Font = new Font("Georgia", 18F);
            btnnextday.ForeColor = Color.FromArgb(10, 74, 122);
            btnnextday.Location = new Point(13, 9);
            btnnextday.Name = "btnnextday";
            btnnextday.Size = new Size(194, 67);
            btnnextday.TabIndex = 3;
            btnnextday.Text = "Next day";
            btnnextday.UseVisualStyleBackColor = false;
            btnnextday.Click += btnnextday_Click;
            // 
            // btnextra
            // 
            btnextra.BackColor = Color.White;
            btnextra.FlatStyle = FlatStyle.Flat;
            btnextra.Font = new Font("Georgia", 18F);
            btnextra.ForeColor = Color.FromArgb(10, 74, 122);
            btnextra.Location = new Point(10, 9);
            btnextra.Name = "btnextra";
            btnextra.Size = new Size(191, 67);
            btnextra.TabIndex = 4;
            btnextra.Text = "Express";
            btnextra.UseVisualStyleBackColor = false;
            btnextra.Click += btnextra_Click;
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.White;
            pnl1.BorderStyle = BorderStyle.Fixed3D;
            pnl1.Controls.Add(btnregular);
            pnl1.Location = new Point(65, 116);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(219, 100);
            pnl1.TabIndex = 7;
            pnl1.Paint += pnl1_Paint;
            // 
            // txtnamapelanggan
            // 
            txtnamapelanggan.Font = new Font("Georgia", 9F);
            txtnamapelanggan.Location = new Point(27, 37);
            txtnamapelanggan.Name = "txtnamapelanggan";
            txtnamapelanggan.Size = new Size(512, 21);
            txtnamapelanggan.TabIndex = 1;
            txtnamapelanggan.TextChanged += txtnamapelanggan_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F);
            label3.ForeColor = Color.FromArgb(10, 74, 122);
            label3.Location = new Point(7, 10);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 2;
            label3.Text = "Alamat Tempat Tinggal";
            // 
            // txtalamat
            // 
            txtalamat.Font = new Font("Georgia", 9F);
            txtalamat.Location = new Point(7, 28);
            txtalamat.Name = "txtalamat";
            txtalamat.Size = new Size(512, 21);
            txtalamat.TabIndex = 3;
            txtalamat.TextChanged += txtalamat_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F);
            label4.ForeColor = Color.FromArgb(10, 74, 122);
            label4.Location = new Point(27, 155);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "Nomor Telepon";
            // 
            // txtnomortelepon
            // 
            txtnomortelepon.Font = new Font("Georgia", 9F);
            txtnomortelepon.Location = new Point(27, 173);
            txtnomortelepon.Name = "txtnomortelepon";
            txtnomortelepon.Size = new Size(512, 21);
            txtnomortelepon.TabIndex = 5;
            txtnomortelepon.TextChanged += txtnomortelepon_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9F);
            label5.ForeColor = Color.FromArgb(10, 74, 122);
            label5.Location = new Point(7, 10);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Satuan (Kg)";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(10, 74, 122);
            btnTambah.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(422, 432);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(176, 50);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.FromArgb(10, 74, 122);
            btnbatal.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btnbatal.ForeColor = Color.White;
            btnbatal.Location = new Point(18, 432);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(176, 50);
            btnbatal.TabIndex = 9;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // pnl4
            // 
            pnl4.BackColor = Color.White;
            pnl4.BorderStyle = BorderStyle.Fixed3D;
            pnl4.Controls.Add(btnbatal);
            pnl4.Controls.Add(txtnamapelanggan);
            pnl4.Controls.Add(label6);
            pnl4.Controls.Add(btnTambah);
            pnl4.Controls.Add(label4);
            pnl4.Controls.Add(txtnomortelepon);
            pnl4.Controls.Add(panel4);
            pnl4.Controls.Add(panel3);
            pnl4.Controls.Add(panel2);
            pnl4.Controls.Add(panel1);
            pnl4.Controls.Add(panel6);
            pnl4.Controls.Add(panel5);
            pnl4.Location = new Point(65, 213);
            pnl4.Name = "pnl4";
            pnl4.Size = new Size(621, 499);
            pnl4.TabIndex = 10;
            pnl4.Paint += pnl4_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9F);
            label6.ForeColor = Color.FromArgb(10, 74, 122);
            label6.Location = new Point(27, 19);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 2;
            label6.Text = "Nama Pelanggan";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(numsatuan);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(18, 211);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 63);
            panel4.TabIndex = 14;
            // 
            // numsatuan
            // 
            numsatuan.Font = new Font("Georgia", 9F);
            numsatuan.Location = new Point(7, 33);
            numsatuan.Name = "numsatuan";
            numsatuan.Size = new Size(205, 21);
            numsatuan.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(18, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(596, 63);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtalamat);
            panel2.Location = new Point(18, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 63);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(18, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 63);
            panel1.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(dtptanggalambil);
            panel6.Location = new Point(18, 349);
            panel6.Name = "panel6";
            panel6.Size = new Size(596, 63);
            panel6.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9F);
            label8.ForeColor = Color.FromArgb(10, 74, 122);
            label8.Location = new Point(12, 10);
            label8.Name = "label8";
            label8.Size = new Size(135, 15);
            label8.TabIndex = 2;
            label8.Text = "Tanggal Pengambilan";
            // 
            // dtptanggalambil
            // 
            dtptanggalambil.Font = new Font("Georgia", 9F);
            dtptanggalambil.Location = new Point(12, 28);
            dtptanggalambil.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtptanggalambil.MinDate = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dtptanggalambil.Name = "dtptanggalambil";
            dtptanggalambil.Size = new Size(200, 21);
            dtptanggalambil.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dtptanggalpesan);
            panel5.Location = new Point(18, 280);
            panel5.Name = "panel5";
            panel5.Size = new Size(596, 63);
            panel5.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F);
            label2.ForeColor = Color.FromArgb(10, 74, 122);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "Tanggal Pemesanan";
            // 
            // dtptanggalpesan
            // 
            dtptanggalpesan.Font = new Font("Georgia", 9F);
            dtptanggalpesan.Location = new Point(12, 28);
            dtptanggalpesan.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtptanggalpesan.MinDate = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dtptanggalpesan.Name = "dtptanggalpesan";
            dtptanggalpesan.Size = new Size(200, 21);
            dtptanggalpesan.TabIndex = 10;
            // 
            // lbl15000
            // 
            lbl15000.AutoSize = true;
            lbl15000.Font = new Font("Georgia", 16F);
            lbl15000.ForeColor = Color.FromArgb(10, 74, 122);
            lbl15000.Location = new Point(202, 11);
            lbl15000.Name = "lbl15000";
            lbl15000.Size = new Size(142, 27);
            lbl15000.TabIndex = 13;
            lbl15000.Text = "Rp15.000/kg";
            lbl15000.Click += lbl15000_Click;
            // 
            // lbl10000
            // 
            lbl10000.AutoSize = true;
            lbl10000.Font = new Font("Georgia", 16F);
            lbl10000.ForeColor = Color.FromArgb(10, 74, 122);
            lbl10000.Location = new Point(202, 11);
            lbl10000.Name = "lbl10000";
            lbl10000.Size = new Size(144, 27);
            lbl10000.TabIndex = 13;
            lbl10000.Text = "Rp10.000/kg";
            // 
            // lbl5000
            // 
            lbl5000.AutoSize = true;
            lbl5000.Font = new Font("Georgia", 16F);
            lbl5000.ForeColor = Color.FromArgb(10, 74, 122);
            lbl5000.Location = new Point(202, 11);
            lbl5000.Name = "lbl5000";
            lbl5000.Size = new Size(127, 27);
            lbl5000.TabIndex = 2;
            lbl5000.Text = "Rp5000/kg";
            // 
            // pnl2
            // 
            pnl2.BackColor = Color.White;
            pnl2.BorderStyle = BorderStyle.Fixed3D;
            pnl2.Controls.Add(btnnextday);
            pnl2.Location = new Point(566, 116);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(225, 100);
            pnl2.TabIndex = 11;
            // 
            // pnl3
            // 
            pnl3.BackColor = Color.White;
            pnl3.BorderStyle = BorderStyle.Fixed3D;
            pnl3.Controls.Add(btnextra);
            pnl3.Location = new Point(1055, 116);
            pnl3.Name = "pnl3";
            pnl3.Size = new Size(219, 100);
            pnl3.TabIndex = 11;
            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.White;
            btnkembali.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btnkembali.ForeColor = Color.FromArgb(10, 74, 122);
            btnkembali.Location = new Point(12, 12);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(41, 41);
            btnkembali.TabIndex = 8;
            btnkembali.Text = "<<";
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 16F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(603, 66);
            label7.Name = "label7";
            label7.Size = new Size(145, 27);
            label7.TabIndex = 1;
            label7.Text = "PELAYANAN";
            label7.Click += label1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(lbl10000);
            panel7.Controls.Add(lbl5000);
            panel7.Controls.Add(lbl15000);
            panel7.Location = new Point(692, 213);
            panel7.Name = "panel7";
            panel7.Size = new Size(582, 60);
            panel7.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(txtcari);
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(692, 279);
            panel8.Name = "panel8";
            panel8.Size = new Size(582, 433);
            panel8.TabIndex = 14;
            // 
            // txtcari
            // 
            txtcari.Font = new Font("Georgia", 9F);
            txtcari.Location = new Point(51, 13);
            txtcari.Name = "txtcari";
            txtcari.Size = new Size(513, 21);
            txtcari.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(551, 365);
            dataGridView1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 9F);
            label9.ForeColor = Color.FromArgb(10, 74, 122);
            label9.Location = new Point(13, 13);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 4;
            label9.Text = "Cari";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 74, 122);
            ClientSize = new Size(1357, 749);
            Controls.Add(pnl3);
            Controls.Add(pnl1);
            Controls.Add(pnl2);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(pnl4);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnkembali);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            WindowState = FormWindowState.Minimized;
            Load += Form3_Load;
            pnl1.ResumeLayout(false);
            pnl4.ResumeLayout(false);
            pnl4.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numsatuan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnl2.ResumeLayout(false);
            pnl3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnregular;
        private Button btnnextday;
        private Button btnextra;
        private Panel pnl1;
        private TextBox txtnamapelanggan;
        private Label label3;
        private TextBox txtalamat;
        private Label label4;
        private TextBox txtnomortelepon;
        private Label label5;
        private Button btnTambah;
        private Button btnbatal;
        private Panel pnl4;
        private Label label6;
        private Panel pnl2;
        private Panel pnl3;
        private DateTimePicker dtptanggalpesan;
        private Label lbl15000;
        private Label lbl10000;
        private Label lbl5000;
        private Label label2;
        private Button btnkembali;
        private Label label7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Label label8;
        private DateTimePicker dtptanggalambil;
        private Panel panel7;
        private Panel panel8;
        private DataGridView dataGridView1;
        private NumericUpDown numsatuan;
        private TextBox txtcari;
        private Label label9;
    }
}