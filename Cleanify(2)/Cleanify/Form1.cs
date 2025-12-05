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
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
        }
    }
}