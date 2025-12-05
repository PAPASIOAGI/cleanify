namespace Cleanify
{
    partial class Form4
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            cmbbulantransaksi = new ComboBox();
            btncsv = new Button();
            pnllaporan = new Panel();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            btnpdf = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            label4 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnllaporan.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(146, 22);
            label1.Name = "label1";
            label1.Size = new Size(471, 31);
            label1.TabIndex = 2;
            label1.Text = "LAPORAN TRANSAKSI PENJUALAN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 16F);
            label2.ForeColor = Color.FromArgb(10, 74, 122);
            label2.Location = new Point(105, -2);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 3;
            label2.Text = "Bulan";
            // 
            // cmbbulantransaksi
            // 
            cmbbulantransaksi.BackColor = Color.FromArgb(10, 74, 122);
            cmbbulantransaksi.FlatStyle = FlatStyle.System;
            cmbbulantransaksi.Font = new Font("Georgia", 9F);
            cmbbulantransaksi.ForeColor = Color.White;
            cmbbulantransaksi.FormattingEnabled = true;
            cmbbulantransaksi.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            cmbbulantransaksi.Location = new Point(12, 23);
            cmbbulantransaksi.Margin = new Padding(5);
            cmbbulantransaksi.Name = "cmbbulantransaksi";
            cmbbulantransaksi.Size = new Size(300, 23);
            cmbbulantransaksi.TabIndex = 4;
            cmbbulantransaksi.SelectedIndexChanged += cmbbulantransaksi_SelectedIndexChanged;
            // 
            // btncsv
            // 
            btncsv.BackColor = Color.FromArgb(10, 74, 122);
            btncsv.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btncsv.ForeColor = Color.White;
            btncsv.Location = new Point(17, 115);
            btncsv.Name = "btncsv";
            btncsv.Size = new Size(109, 39);
            btncsv.TabIndex = 8;
            btncsv.Text = "CSV";
            btncsv.UseVisualStyleBackColor = false;
            btncsv.Click += btncsv_Click;
            // 
            // pnllaporan
            // 
            pnllaporan.BackColor = Color.White;
            pnllaporan.BorderStyle = BorderStyle.Fixed3D;
            pnllaporan.Controls.Add(comboBox1);
            pnllaporan.Controls.Add(cmbbulantransaksi);
            pnllaporan.Controls.Add(label2);
            pnllaporan.Controls.Add(label3);
            pnllaporan.Location = new Point(179, 124);
            pnllaporan.Name = "pnllaporan";
            pnllaporan.Size = new Size(810, 50);
            pnllaporan.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(10, 74, 122);
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Georgia", 9F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(488, 22);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += cmbbulantransaksi_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 16F);
            label3.ForeColor = Color.FromArgb(10, 74, 122);
            label3.Location = new Point(599, -2);
            label3.Name = "label3";
            label3.Size = new Size(76, 27);
            label3.TabIndex = 3;
            label3.Text = "Tahun";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 74, 122);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnpdf);
            panel1.Controls.Add(btncsv);
            panel1.Location = new Point(12, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 409);
            panel1.TabIndex = 9;
            // 
            // btnpdf
            // 
            btnpdf.BackColor = Color.FromArgb(10, 74, 122);
            btnpdf.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btnpdf.ForeColor = Color.White;
            btnpdf.Location = new Point(17, 70);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(109, 39);
            btnpdf.TabIndex = 8;
            btnpdf.Text = "PDF";
            btnpdf.UseVisualStyleBackColor = false;
            btnpdf.Click += btncsv_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 74, 122);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(1000, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 409);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(-2, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 53);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Georgia", 16F);
            label5.ForeColor = Color.FromArgb(10, 74, 122);
            label5.Location = new Point(35, 9);
            label5.Name = "label5";
            label5.Size = new Size(82, 27);
            label5.TabIndex = 3;
            label5.Text = "Import";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 74, 122);
            button1.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 70);
            button1.Name = "button1";
            button1.Size = new Size(109, 83);
            button1.TabIndex = 7;
            button1.Text = "Import file";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnexpor_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 53);
            panel4.TabIndex = 9;
            panel4.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Georgia", 16F);
            label4.ForeColor = Color.FromArgb(10, 74, 122);
            label4.Location = new Point(30, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 27);
            label4.TabIndex = 3;
            label4.Text = "Ekspor";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.Image = Properties.Resources.logocleanify;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(59, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(81, 77);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 11;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(179, 180);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(810, 353);
            guna2DataGridView1.TabIndex = 12;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.LightSteelBlue;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 11;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.CornflowerBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.angle_double_small_left;
            guna2Button1.Location = new Point(12, 22);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.SteelBlue;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.Size = new Size(39, 37);
            guna2Button1.TabIndex = 13;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1162, 545);
            Controls.Add(guna2Button1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnllaporan);
            Name = "Form4";
            Text = "Form4";
            pnllaporan.ResumeLayout(false);
            pnllaporan.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbbulantransaksi;
        private Button btncsv;
        private Panel pnllaporan;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Button button1;
        private Button btnpdf;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}