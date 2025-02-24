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
    public partial class UpdateDonorDetails : Form
    {
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }
        function fn = new function();

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            string query = "select * from newDonor where did=" + id + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                   txtName2.Text = ds.Tables[0].Rows[0][1].ToString();
                   txtfather1.Text = ds.Tables[0].Rows[0][2].ToString();
                   txtMother1.Text = ds.Tables[0].Rows[0][3].ToString();
                   txtDOB1.Text = ds.Tables[0].Rows[0][4].ToString();
                   txtMobile1.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtGender1.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtEmail1.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtBloodGroup1.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCity1.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAddress1.Text = ds.Tables[0].Rows[0][10].ToString();
                    
            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorID.Text == "")
            {
                txtName2.Clear();
                txtfather1.Clear();
                txtMother1.Clear();
                txtDOB1.ResetText();
                txtMobile1.Clear();
                txtGender1.ResetText();
                txtEmail1.Clear();
                txtBloodGroup1.ResetText();
                txtCity1.Clear();
                txtAddress1.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update newDonor set dname='" + txtName2.Text + "',fname='" + txtfather1.Text + "',mname='" + txtMother1.Text + "',dob='" + txtDOB1.Text + "',mobile=" + txtMobile1.Text + ",gender='" + txtGender1.Text + "',email='" + txtEmail1.Text + "',bloodgroup='" + txtBloodGroup1.Text + "',city='" + txtCity1.Text + "',daddress='" + txtAddress1.Text + "' where did=" + txtDonorID.Text + "";
            fn.setDate(query);
            UpdateDonorDetails_Load(this, null);
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }
    }
}
