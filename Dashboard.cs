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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and=new AddNewDonor();
            and.Show();
        }

        private void upadateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress sba = new SearchBloodDonorAddress();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sd = new SearchDonorByBlood();
           sd.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease();
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockDecrease sd = new stockDecrease();
            sd.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockDetails sd = new stockDetails();
            sd.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        
      

    }
}
 