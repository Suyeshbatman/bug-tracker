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
    public partial class Signup : Form
    {
        string query;
        Connectiondb conn = new Connectiondb();
      

        public Signup()
        {
            InitializeComponent();
            txt_fname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname, lastname, username, password, email, usertype;
            firstname = txt_fname.Text;
            lastname = txt_lname.Text;
            username = txt_uname.Text;
            password = txt_pw.Text;
            email = txt_mail.Text;
            usertype = cmb_type.Text;

            if (String.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("First name cannot be empty!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_fname.Focus();
            }
            else if (String.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Last name cannot be empty!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lname.Focus();
            }
            else if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_uname.Focus();
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_pw.Focus();
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Usertype cannot be empty!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_type.Focus();
            }

            else
            {
                string temp;
                temp = txt_uname.Text;
                query = query = "select Username from [Signupdata] where Username='" + temp + "'";
                DataTable dt = conn.retrieve(query);
                //checking wether rows/data are selected or not
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(temp + " cannot be used. Because it is already used", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_uname.Clear();
                    txt_pw.Clear();
                    
                }
                else
                {
                    //try catch to confirm the value is inserted
                    try
                    {

                        query = "insert into Signupdata(First_name,Last_name,Username,Password,Email,Usertype) values('" + firstname + "','" + lastname + "','" + username + "','" + password + "','" + email + "','" + usertype + "')";
                        conn.manipulate(query);
                        MessageBox.Show("Registration Successfull!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 login_form = new Form1();
                        login_form.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Data Cannot be inserted due to the internal application problem!! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string query;
            query = "select Usertype from  Signupdata ";
            DataTable dt = conn.retrieve(query);
            cmb_type.DataSource = dt;
            cmb_type.DisplayMember = "Usertype";

        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Form1 login_form = new Form1();
            login_form.Show();
            this.Hide();
        }

        
    }
}

