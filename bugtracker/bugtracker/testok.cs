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
    public partial class testok : Form
    {
        public testok()
        {
            InitializeComponent();
        }

        private void btn_submit1_Click(object sender, EventArgs e)
        {
            String test = DateTime.Now.ToString("dd/MM/yyy");
            if (Tester_Panel.count > 0)
            {
                Connectiondb conn = new Connectiondb();
                string upquery = "update tbl_tester set result = 'OK' where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(upquery);
                MessageBox.Show("The project has been completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string ins = "insert into tbl_project_complete values('" + Tester_Panel.project_Id + "','" + Tester_Panel.project_name + "','" + Tester_Panel.project_date + "', '" + Tester_Panel.project_complete + "','" + test.ToString() + "','" + txt_desc.Text + "')";
                conn.manipulate(ins);

                string dlt = "delete from tbl_project where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(dlt);
                string dlt_ = "delete from tbl_developer where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(dlt_);
                string dltt = "delete from tbl_tester where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(dltt);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to select a Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
