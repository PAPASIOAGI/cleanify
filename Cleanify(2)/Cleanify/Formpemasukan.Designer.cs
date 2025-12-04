namespace Cleanify
{
    partial class Formpemasukan
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
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            cmbbulantransaksi = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            pnllaporan = new Panel();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            btnpdf = new Button();
            btncsv = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnllaporan.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 22);
            label1.Name = "label1";
            label1.Size = new Size(284, 29);
            label1.TabIndex = 9;
            label1.Text = "LAPORAN PEMASUKAN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 74, 122);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1056, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 353);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 74, 122);
            button1.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 78);
            button1.Name = "button1";
            button1.Size = new Size(109, 86);
            button1.TabIndex = 7;
            button1.Text = "Impor dari...";
            button1.UseVisualStyleBackColor = false;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Georgia", 16F);
            label5.ForeColor = Color.FromArgb(10, 74, 122);
            label5.Location = new Point(39, 9);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 3;
            label5.Text = "Impor";
            // 
            // cmbbulantransaksi
            // 
            cmbbulantransaksi.BackColor = Color.FromArgb(10, 74, 122);
            cmbbulantransaksi.FlatStyle = FlatStyle.System;
            cmbbulantransaksi.Font = new Font("Georgia", 9F);
            cmbbulantransaksi.ForeColor = Color.White;
            cmbbulantransaksi.FormattingEnabled = true;
            cmbbulantransaksi.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            cmbbulantransaksi.Location = new Point(254, 116);
            cmbbulantransaksi.Margin = new Padding(5);
            cmbbulantransaksi.Name = "cmbbulantransaksi";
            cmbbulantransaksi.Size = new Size(300, 23);
            cmbbulantransaksi.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(10, 74, 122);
            label3.Font = new Font("Georgia", 16F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(862, 75);
            label3.Name = "label3";
            label3.Size = new Size(76, 27);
            label3.TabIndex = 11;
            label3.Text = "Tahun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(10, 74, 122);
            label2.Font = new Font("Georgia", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(371, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 12;
            label2.Text = "Bulan";
            // 
            // pnllaporan
            // 
            pnllaporan.BackColor = Color.White;
            pnllaporan.BorderStyle = BorderStyle.Fixed3D;
            pnllaporan.Controls.Add(comboBox1);
            pnllaporan.Location = new Point(240, 105);
            pnllaporan.Name = "pnllaporan";
            pnllaporan.Size = new Size(810, 47);
            pnllaporan.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(10, 74, 122);
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Georgia", 9F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(493, 9);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(240, 158);
            panel5.Name = "panel5";
            panel5.Size = new Size(810, 300);
            panel5.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(68, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 53);
            panel4.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Georgia", 16F);
            label4.ForeColor = Color.FromArgb(10, 74, 122);
            label4.Location = new Point(28, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 27);
            label4.TabIndex = 3;
            label4.Text = "Ekspor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 74, 122);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnpdf);
            panel1.Controls.Add(btncsv);
            panel1.Location = new Point(68, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 353);
            panel1.TabIndex = 17;
            // 
            // btnpdf
            // 
            btnpdf.BackColor = Color.FromArgb(10, 74, 122);
            btnpdf.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btnpdf.ForeColor = Color.White;
            btnpdf.Location = new Point(17, 78);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(109, 39);
            btnpdf.TabIndex = 8;
            btnpdf.Text = "PDF";
            btnpdf.UseVisualStyleBackColor = false;
            // 
            // btncsv
            // 
            btncsv.BackColor = Color.FromArgb(10, 74, 122);
            btncsv.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            btncsv.ForeColor = Color.White;
            btncsv.Location = new Point(17, 125);
            btncsv.Name = "btncsv";
            btncsv.Size = new Size(109, 39);
            btncsv.TabIndex = 8;
            btncsv.Text = "CSV";
            btncsv.UseVisualStyleBackColor = false;
            // 
            // Formpemasukan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 74, 122);
            ClientSize = new Size(1274, 533);
            Controls.Add(panel2);
            Controls.Add(cmbbulantransaksi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnllaporan);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Formpemasukan";
            Text = "Formpemasukan";
            Load += Formpemasukan_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnllaporan.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label label5;
        private ComboBox cmbbulantransaksi;
        private Label label3;
        private Label label2;
        private Panel pnllaporan;
        private ComboBox comboBox1;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Panel panel1;
        private Button btnpdf;
        private Button btncsv;
    }
}