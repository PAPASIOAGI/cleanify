namespace Cleanify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtnama = new TextBox();
            txtpassword = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(141, 264);
            label1.Name = "label1";
            label1.Size = new Size(83, 27);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Georgia", 9F);
            label2.ForeColor = Color.FromArgb(10, 74, 122);
            label2.Location = new Point(24, 11);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // txtnama
            // 
            txtnama.Font = new Font("Georgia", 9F);
            txtnama.ForeColor = Color.FromArgb(10, 74, 122);
            txtnama.Location = new Point(91, 5);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(211, 21);
            txtnama.TabIndex = 3;
            txtnama.TextChanged += txtnama_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Georgia", 9F);
            txtpassword.ForeColor = Color.FromArgb(10, 74, 122);
            txtpassword.Location = new Point(91, 6);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(211, 21);
            txtpassword.TabIndex = 3;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Georgia", 9F);
            label3.ForeColor = Color.FromArgb(10, 74, 122);
            label3.Location = new Point(24, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtnama);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 43);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtpassword);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(29, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 43);
            panel2.TabIndex = 5;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(10, 74, 122);
            guna2Button1.BorderRadius = 16;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(10, 74, 122);
            guna2Button1.Location = new Point(128, 428);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(102, 45);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 74, 122);
            ClientSize = new Size(374, 530);
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtnama;
        private TextBox txtpassword;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtid;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
