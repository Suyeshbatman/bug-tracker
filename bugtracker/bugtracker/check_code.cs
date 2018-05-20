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
    public partial class check_code : Form
    {
        public check_code()
        {
            InitializeComponent();
        }

        private void btn_upcode_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcode.Text))
            {
                MessageBox.Show("Please coding cannot be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Connectiondb conn = new Connectiondb();
                string query = "UPDATE tbl_developer SET code = '" + txtcode.Text + "' WHERE project_id = '" + Developer_Panel.Id + "' ";
                conn.manipulate(query);
                MessageBox.Show("Code Successfully updated!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
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

        private void check_code_Load(object sender, EventArgs e)
        {
            txtcode.Text = Developer_Panel.Code;
        }
    }
}
