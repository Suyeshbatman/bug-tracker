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
    public partial class Admin_Panel : Form
    {
        Connectiondb conn = new Connectiondb();
        string query;
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string a_to = txt_assignedto.Text;
            string pname = txt_projectname.Text;
            string a_by = txt_assignedby.Text;
            string desc = txtdesc.Text;
            string srt_date = dtp.Value.ToShortDateString();
            string end_date = dtp2.Value.ToShortDateString();
            string code = txtcode.Text;

            if (String.IsNullOrEmpty(a_to) || String.IsNullOrEmpty(a_by) || String.IsNullOrEmpty(desc) || String.IsNullOrEmpty(pname) || String.IsNullOrEmpty(code))
            {
                MessageBox.Show("Any of the field cannot be empty");
            }
            else
            {
                query = "insert into tbl_project(assigned_to,project_name,assigned_date,completion_date,assigned_by,description, code) values('" + a_to + "','" + pname + "','" + srt_date + "','" + end_date + "','" + a_by + "','" + desc + "','" + code + "')";
                conn.manipulate(query);
                MessageBox.Show("Registration Successfull!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void txtcode_Load(object sender, EventArgs e)
        {

        }


        private void textEditorControl1_Load(object sender, EventArgs e)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}

