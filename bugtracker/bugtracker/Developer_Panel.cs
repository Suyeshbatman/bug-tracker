using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bugtracker
{
    public partial class Developer_Panel : Form
    {
        private string bugQuery;

        public static string Code, Id, Error, Query;

        private void Developer_Panel_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            display();
            lblUname.Text = Form1.user + "!";
        }
        private void display()
        {
            devdgv.DataSource = null;
            //fetching user type from database
            bugQuery = "select * from tbl_developer";

            DataTable bugDt = conn.retrieve(bugQuery);

            devdgv.DataSource = bugDt;

        }

        public static string val = "";

        private void btnsendtest_Click(object sender, EventArgs e)
        {
            if (devdgv.SelectedRows.Count > 0)
            {
                Code = devdgv.SelectedRows[0].Cells[5].Value + string.Empty;
                Id = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;


                check_code  chk = new check_code();
                chk.Show();
            }
            else
            {
                MessageBox.Show("No Data Selected");
            }
        }

        private void btncheckcode_Click(object sender, EventArgs e)
        {
            if (devdgv.SelectedRows.Count > 0)
            {
                Code = devdgv.SelectedRows[0].Cells[5].Value + string.Empty;
                Id = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;


                check_code chk = new check_code();
                chk.Show();
            }
            else
            {
                MessageBox.Show("No Data Selected");
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void devdgv_DoubleClick(object sender, EventArgs e)
        {
            val = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;
            string userId = devdgv.SelectedRows[0].Cells[2].Value + string.Empty;
            Error = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;
            Updatestatus up = new Updatestatus();
            up.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            devdgv.DataSource = null;
            Query = "select * from tbl_project where project_name like '%" + txtsearch.Text + "%'";
            DataTable src = conn.retrieve(Query);
            devdgv.DataSource = src;
        }

        private void devdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Connectiondb conn = new Connectiondb();
        public Developer_Panel()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
    
}
