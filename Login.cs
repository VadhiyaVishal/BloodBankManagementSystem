using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnhideshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnhideshow.Text == "Show")
            {
                btnhideshow.Text = "Hide";
                txtpassword.PasswordChar = '\0';
            }
          
            else
            {
                btnhideshow.Text = "show";
                txtpassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtpassword.Text == "admin")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
