using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugtracker
{
    public partial class to_developer : Form
    {
        public to_developer()
        {
            InitializeComponent();
        }

        private void btn_sendtodeveloper_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text) || String.IsNullOrEmpty(txt_lineno.Text))
            {
                MessageBox.Show("Any of the field cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connectiondb conn = new Connectiondb();
                string query = "select project_id from tbl_developer where project_id='" + Tester_Panel.project_Id + "'";
                DataTable dt = conn.retrieve(query);
                //checking wether rows/data are selected or not
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Project has already been sent to Developer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Connectiondb conn = new Connectiondb();
                    string insquery = "insert into tbl_developer values('" + Tester_Panel.project_Id + "','" + Tester_Panel.project_name + "','" + Tester_Panel.project_date + "','" + Tester_Panel.project_complete + "','" + txtcode.Text + "','" + txt_lineno.Text + "','" + txt_status1.Text + "')";
                    conn.manipulate(insquery);
                    MessageBox.Show("Successfully sent to Developer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string upquery = "update tbl_project set status = 'Send to Developer' where project_id = '" + Tester_Panel.project_Id + "'";
                    conn.manipulate(upquery);
                    this.Close();
                }
            }
        }
    

        private void txt_status1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Status_Click(object sender, EventArgs e)
        {

        }

        private void txt_lineno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcode_Load(object sender, EventArgs e)
        {
            string dirc = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dirc))
            {

                fsmp = new FileSyntaxModeProvider(dirc);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtcode.SetHighlighting("C#");

            }
        }

        private void to_developer_Load(object sender, EventArgs e)
        {
            txtcode.Text = Tester_Panel.code;
        }
    }
}
