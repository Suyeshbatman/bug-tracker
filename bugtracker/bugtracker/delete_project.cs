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
    public partial class delete_project : Form
    {
        public delete_project()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string query = "delete from tbl_project where project_id = '" + Admin_M_Panel.id + "'";
            Connectiondb conn = new Connectiondb();
            conn.manipulate(query);
            MessageBox.Show("Project " + Admin_M_Panel.name + " has been successfully deleted");
            this.Hide();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delete_project_Load(object sender, EventArgs e)
        {
            lblpro.Text = Admin_M_Panel.name;
        }
    }
}
