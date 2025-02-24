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
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            string query = "SELECT MAX(did) FROM newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();
            
        }
     
        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodgroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "") 
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDOB.Text;
                string mobile = txtMobile.Text;
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bgroup = txtBloodgroup.Text;
                string city = txtCity.Text;
                string address = txtAddress.Text;

                string query = "INSERT INTO newDonor (dname, fname, mname, dob, mobile, gender, email, bloodgroup, city, daddress) VALUES ('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                fn.setDate(query);
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtDOB.ResetText();
            txtMobile.ResetText();
            txtGender.ResetText();
            txtEmail.Clear();
            txtBloodgroup.ResetText();
            txtCity.Clear();
            txtAddress.Clear();

        }
        
    }
}
