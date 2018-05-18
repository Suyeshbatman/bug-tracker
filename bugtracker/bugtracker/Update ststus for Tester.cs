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
    public partial class Update_ststus_for_Tester : Form
    {
        public Update_ststus_for_Tester()
        {
            InitializeComponent();
        }

        private void btn_update2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_upstat1.Text))
            {
                MessageBox.Show("Please write something", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connectiondb conn = new Connectiondb();
                string query = "UPDATE tbl_project SET status = '" + txt_upstat1.Text + "' WHERE project_id = '" + Tester_Panel.val + "' ";
                conn.manipulate(query);
                MessageBox.Show("Status Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
    }
}
