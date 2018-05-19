namespace bugtracker
{
    partial class Tester_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_search1 = new System.Windows.Forms.Label();
            this.txt_search1 = new System.Windows.Forms.TextBox();
            this.btn_refresh2 = new System.Windows.Forms.Button();
            this.btn_todeveloper = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.testdgv = new System.Windows.Forms.DataGridView();
            this.btn_testok = new System.Windows.Forms.Button();
            this.btn_2developer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.devdgv = new System.Windows.Forms.DataGridView();
            this.lbluname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_search1
            // 
            this.lbl_search1.AutoSize = true;
            this.lbl_search1.Location = new System.Drawing.Point(1, 49);
            this.lbl_search1.Name = "lbl_search1";
            this.lbl_search1.Size = new System.Drawing.Size(41, 13);
            this.lbl_search1.TabIndex = 0;
            this.lbl_search1.Text = "Search";
            // 
            // txt_search1
            // 
            this.txt_search1.Location = new System.Drawing.Point(75, 49);
            this.txt_search1.Name = "txt_search1";
            this.txt_search1.Size = new System.Drawing.Size(141, 20);
            this.txt_search1.TabIndex = 1;
            this.txt_search1.TextChanged += new System.EventHandler(this.txt_search1_TextChanged);
            // 
            // btn_refresh2
            // 
            this.btn_refresh2.Location = new System.Drawing.Point(470, 49);
            this.btn_refresh2.Name = "btn_refresh2";
            this.btn_refresh2.Size = new System.Drawing.Size(81, 20);
            this.btn_refresh2.TabIndex = 2;
            this.btn_refresh2.Text = "Refresh";
            this.btn_refresh2.UseVisualStyleBackColor = true;
            this.btn_refresh2.Click += new System.EventHandler(this.btn_refresh2_Click);
            // 
            // btn_todeveloper
            // 
            this.btn_todeveloper.Location = new System.Drawing.Point(563, 49);
            this.btn_todeveloper.Name = "btn_todeveloper";
            this.btn_todeveloper.Size = new System.Drawing.Size(98, 19);
            this.btn_todeveloper.TabIndex = 3;
            this.btn_todeveloper.Text = "To Developer";
            this.btn_todeveloper.UseVisualStyleBackColor = true;
            this.btn_todeveloper.Click += new System.EventHandler(this.btn_todeveloper_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(667, 48);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(97, 20);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // testdgv
            // 
            this.testdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testdgv.Location = new System.Drawing.Point(4, 282);
            this.testdgv.Name = "testdgv";
            this.testdgv.Size = new System.Drawing.Size(770, 143);
            this.testdgv.TabIndex = 11;
            // 
            // btn_testok
            // 
            this.btn_testok.Location = new System.Drawing.Point(667, 255);
            this.btn_testok.Name = "btn_testok";
            this.btn_testok.Size = new System.Drawing.Size(97, 20);
            this.btn_testok.TabIndex = 10;
            this.btn_testok.Text = "Test Ok";
            this.btn_testok.UseVisualStyleBackColor = true;
            this.btn_testok.Click += new System.EventHandler(this.btn_testok_Click);
            // 
            // btn_2developer
            // 
            this.btn_2developer.Location = new System.Drawing.Point(563, 256);
            this.btn_2developer.Name = "btn_2developer";
            this.btn_2developer.Size = new System.Drawing.Size(98, 19);
            this.btn_2developer.TabIndex = 9;
            this.btn_2developer.Text = "To Developer";
            this.btn_2developer.UseVisualStyleBackColor = true;
            this.btn_2developer.Click += new System.EventHandler(this.btn_2developer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 20);
            this.button3.TabIndex = 8;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(75, 256);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(141, 20);
            this.txt_search2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Location = new System.Drawing.Point(467, 8);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(30, 13);
            this.date2.TabIndex = 12;
            this.date2.Text = "Date";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(638, 6);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(30, 13);
            this.time1.TabIndex = 13;
            this.time1.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // devdgv
            // 
            this.devdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devdgv.Location = new System.Drawing.Point(12, 75);
            this.devdgv.Name = "devdgv";
            this.devdgv.Size = new System.Drawing.Size(673, 155);
            this.devdgv.TabIndex = 14;
            this.devdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devdgv_CellContentClick);
            this.devdgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devdgv_CellContentDoubleClick);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(293, 11);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(0, 13);
            this.lbluname.TabIndex = 15;
            // 
            // Tester_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.devdgv);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.testdgv);
            this.Controls.Add(this.btn_testok);
            this.Controls.Add(this.btn_2developer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_search2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_todeveloper);
            this.Controls.Add(this.btn_refresh2);
            this.Controls.Add(this.txt_search1);
            this.Controls.Add(this.lbl_search1);
            this.Name = "Tester_Panel";
            this.Text = "Tester_Panel";
            this.Load += new System.EventHandler(this.Tester_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search1;
        private System.Windows.Forms.TextBox txt_search1;
        private System.Windows.Forms.Button btn_refresh2;
        private System.Windows.Forms.Button btn_todeveloper;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridView testdgv;
        private System.Windows.Forms.Button btn_testok;
        private System.Windows.Forms.Button btn_2developer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView devdgv;
        private System.Windows.Forms.Label lbluname;
    }
}