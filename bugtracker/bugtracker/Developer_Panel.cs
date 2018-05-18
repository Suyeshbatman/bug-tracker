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
        public static string code, id, error_line;
        Connectiondb conn = new Connectiondb();
        public static string val = "";
        string bugQuery, query;
        
        
       

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            devdgv.DataSource = null;
            query = "select * from tbl_project where project_name like '%" + txt_search.Text + "%'";
            DataTable src = conn.retrieve(query);
            devdgv.DataSource = src;
        }

        private void btn_checkcode_Click(object sender, EventArgs e)
        {
            if (devdgv.SelectedRows.Count > 0)
            {
                code = devdgv.SelectedRows[0].Cells[5].Value + string.Empty;
                id = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;


                check_code chk = new check_code();
                chk.Show();
            }
            else
            {
                MessageBox.Show("No Data Selected");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            devdgv.DataSource = null;
            //fetching user type from database
            bugQuery = "select * from tbl_developer";

            DataTable bugDt = conn.retrieve(bugQuery);

            devdgv.DataSource = bugDt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_totester_Click(object sender, EventArgs e)
        {
            if (devdgv.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string project_Id = devdgv.SelectedRows[0].Cells[1].Value + string.Empty;
                string code = devdgv.SelectedRows[0].Cells[5].Value + string.Empty;
                query = query = "select project_id from tbl_tester where project_id='" + project_Id + "'";
                DataTable dt = conn.retrieve(query);
                //checking wether rows/data are selected or not
                if (dt.Rows.Count > 0)
                {
                    string upqueryt = "update tbl_tester set code = '" + code + "' where project_id = '" + project_Id + "'";
                    conn.manipulate(upqueryt);
                    string upqueryd = "update tbl_developer set status = 'Sent to Tester' where project_id = '" + project_Id + "'";
                    conn.manipulate(upqueryd);
                    MessageBox.Show("Successfully sent to tester");
                }
                else
                {
                    string insquery = "insert into tbl_tester(project_id,project_name,start_date,completion_date,code,error_line,status, result) (select project_id,project_name,assign_date,completion_date,code,error_line,status, null as result from tbl_developer where project_id = '" + project_Id + "');";
                    conn.manipulate(insquery);
                    string upquery = "update tbl_developer set status = 'Sent to Tester' where project_id = '" + project_Id + "'";
                    conn.manipulate(upquery);
                    MessageBox.Show("Successfully sent to Tester!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Row has been selected");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Developer_Panel_Load(object sender, EventArgs e)
        {
            date1.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            display();
            lbluname.Text = Form1.user + "!!!!";
        }

       

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
}
