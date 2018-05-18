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
    public partial class to_developer_again : Form
    {
        public to_developer_again()
        {
            InitializeComponent();
        }

        private void btn_send2developer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text) || String.IsNullOrEmpty(txt_lineno1.Text))
            {
                MessageBox.Show("Any of the field cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connectiondb conn = new Connectiondb();
                string upquery = "update tbl_developer set status = 'Sent from Tester Again', code = '" + txtcode.Text + "', error_line = '" + txt_lineno1.Text + "' where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(upquery);
                string upqueryt = "update tbl_tester set status = 'Sent to Developer Again', code = '" + txtcode.Text + "', error_line = '" + txt_lineno1.Text + "' where project_id = '" + Tester_Panel.project_Id + "'";
                conn.manipulate(upqueryt);
                this.Close();
                MessageBox.Show("Successfully sent to Tester", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void to_developer_again_Load(object sender, EventArgs e)
        {
            txtcode.Text = Tester_Panel.code;
            txt_lineno1.Text = Tester_Panel.line;
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
    }
}
