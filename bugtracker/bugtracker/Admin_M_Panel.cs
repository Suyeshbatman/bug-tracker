using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugtracker
{
    public partial class Admin_M_Panel : Form
    {
        public static string id, name;
        public Admin_M_Panel()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Panel panel = new Admin_Panel();
            panel.Show();
        }

        private void Admin_M_Panel_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            string query = "select * from tbl_project_complete";
            Connectiondb conn = new Connectiondb();
            DataTable bugDt = conn.retrieve(query);

            completed.DataSource = bugDt;

            string pendings = "select * from tbl_project";
            DataTable test = conn.retrieve(pendings);

            pending.DataSource = test;
        }

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Panel panel = new Admin_Panel();
            panel.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_refresh1_Click(object sender, EventArgs e)
        {
            string pendings = "select * from tbl_project";
            Connectiondb conn = new Connectiondb();
            DataTable test = conn.retrieve(pendings);

            pending.DataSource = test;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (pending.SelectedRows.Count > 0)
            {
                id = pending.SelectedRows[0].Cells[0].Value + string.Empty;
                name = pending.SelectedRows[0].Cells[1].Value + string.Empty;
                delete_project dlt = new delete_project();
                dlt.Show();
            }
            else
            {
                MessageBox.Show("No Project has been selected");
            }
        }

        private void completed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string query = "select * from tbl_project_complete";
            Connectiondb conn = new Connectiondb();
            DataTable bugDt = conn.retrieve(query);

            completed.DataSource = bugDt;
        }
    }
}
