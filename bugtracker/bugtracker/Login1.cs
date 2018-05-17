using bugtracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace bugtracker
{
    public partial class Form1 : Form
    {
        public static string user = "";
        Connectiondb conn = new Connectiondb();

        public Form1()
        {
            InitializeComponent();
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string username, password, query;

            username = txt_uname.Text;
            password = txt_pw.Text; ;
            // query for selecting user from database
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Username and Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_uname.Focus();

            }
            else
            {
                //for checking if the respetive username exists for not
                query = "select Username from Signupdata where Username='" + username + "'";
                DataTable dt = conn.retrieve(query);

                if (dt.Rows.Count > 0)
                {
                    query = "select Usertype, Username, Password from Signupdata where Username='" + username + "' and Password='" + password + "'";
                    DataTable dts = conn.retrieve(query);
                    if (dts.Rows.Count > 0)
                    {
                        query = "select Usertype from Signupdata where Username = '" + username + "'";
                        DataTable typ = conn.retrieve(query);

                        if (dts.Rows.Count > 0)
                        {
                            //retrive and store user type in string type
                            string type;
                            type = typ.Rows[0][0].ToString();
                            if (type == "Developer")
                            {
                                username = txt_uname.Text;
                                Developer_Panel panel = new Developer_Panel();
                                panel.Show();
                                this.Hide();
                            }
                            else if (type == "Tester")
                            {
                                username = txt_uname.Text;
                                Tester_Panel panel = new Tester_Panel();
                                panel.Show();
                                this.Hide();
                            }
                            else if (type == "Admin")
                            {
                                username = txt_uname.Text;
                                //Admin_Panel panel = new Admin_Panel();
                                //panel.Show();
                                Admin_Panel panel = new Admin_Panel();
                                panel.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            //system error no usertype error throw later
                            MessageBox.Show("Error from the system");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_pw.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No such username exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_uname.Clear();
                    txt_pw.Clear();
                }
            }
        }




        private void Signup1_Click(object sender, EventArgs e)
        {
            Signup reg_form = new Signup();
            reg_form.Show();
            this.Hide();
        }
    }
}

        
    