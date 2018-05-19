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
    public partial class Tester_Panel : Form
    {
        public static string id, pname, project_Id, project_name, project_date, project_complete, val, code, line;

        private void txt_search1_TextChanged(object sender, EventArgs e)
        {
            devdgv.DataSource = null;
            query = "select * from tbl_project where project_name like '%" + txt_search1.Text + "%'";
            DataTable src = conn.retrieve(query);
            devdgv.DataSource = src;
        }

        private void devdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_todeveloper_Click(object sender, EventArgs e)
        {
            if (devdgv.SelectedRows.Count > 0)
            {
                project_Id = devdgv.SelectedRows[0].Cells[0].Value + string.Empty;
                project_name = devdgv.SelectedRows[0].Cells[2].Value + string.Empty;
                code = devdgv.SelectedRows[0].Cells[7].Value + string.Empty;
                project_date = devdgv.SelectedRows[0].Cells[3].Value + string.Empty;
                project_complete = devdgv.SelectedRows[0].Cells[4].Value + string.Empty;
                count = devdgv.SelectedRows.Count;

                id = devdgv.SelectedRows[0].Cells[0].Value + string.Empty;
                pname = devdgv.SelectedRows[0].Cells[2].Value + string.Empty;
                to_developer tod = new to_developer();
                tod.Show();
            }
            else
            {
                MessageBox.Show("You need a select a row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_2developer_Click(object sender, EventArgs e)
        {
            if (testdgv.SelectedRows.Count > 0)
            {
                project_Id = testdgv.SelectedRows[0].Cells[1].Value + string.Empty;
                code = testdgv.SelectedRows[0].Cells[5].Value + string.Empty;
                line = testdgv.SelectedRows[0].Cells[6].Value + string.Empty;
                to_developer_again ag = new to_developer_again();
                ag.Show();
            }
            else
            {
                MessageBox.Show("No Row Selected");
            }
        }

        private void btn_testok_Click(object sender, EventArgs e)
        {
            if (testdgv.SelectedRows.Count > 0)
            {
                project_Id = testdgv.SelectedRows[0].Cells[1].Value + string.Empty;
                project_name = testdgv.SelectedRows[0].Cells[2].Value + string.Empty;
                project_date = testdgv.SelectedRows[0].Cells[3].Value + string.Empty;
                project_complete = testdgv.SelectedRows[0].Cells[4].Value + string.Empty;
                count = testdgv.SelectedRows.Count;
                testok test = new testok();
                test.Show();
            }
            else
            {
                MessageBox.Show("You need to select a Row");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tester_display();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void devdgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            val = devdgv.SelectedRows[0].Cells[0].Value + string.Empty;
            string userId = devdgv.SelectedRows[0].Cells[2].Value + string.Empty;
            Update_status__Tester up = new Update_status__Tester();
            up.Show();
        }

        private void Tester_Panel_Load(object sender, EventArgs e)
        {
            date2.Text = DateTime.Now.ToLongDateString();
            time1.Text = DateTime.Now.ToLongTimeString();
            tester_display();
            display();
            lbluname.Text = Form1.user + "!!!!";
        }

        private void display()
        {
            devdgv.DataSource = null;
            //fetching user type from database
            bugQuery = "select * from tbl_project";

            DataTable bugDt = conn.retrieve(bugQuery);

            devdgv.DataSource = bugDt;
        }

        private void tester_display()
        {
            testdgv.DataSource = null;
            //fetching user type from database
            select = "select * from tbl_tester";

            DataTable testDt = conn.retrieve(select);

            testdgv.DataSource = testDt;
        }

        public static int count;
        string bugQuery, query, select;

        Connectiondb conn = new Connectiondb();
        public Tester_Panel()
        {
            InitializeComponent();
        }

        private void btn_refresh2_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
