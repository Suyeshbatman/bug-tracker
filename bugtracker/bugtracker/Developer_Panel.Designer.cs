namespace bugtracker
{
    partial class Developer_Panel
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_totester = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_checkcode = new System.Windows.Forms.Button();
            this.devdgv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(723, 56);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(73, 31);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_totester
            // 
            this.btn_totester.Location = new System.Drawing.Point(702, 98);
            this.btn_totester.Name = "btn_totester";
            this.btn_totester.Size = new System.Drawing.Size(93, 30);
            this.btn_totester.TabIndex = 1;
            this.btn_totester.Text = "to Tester";
            this.btn_totester.UseVisualStyleBackColor = true;
            this.btn_totester.Click += new System.EventHandler(this.btn_totester_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(340, 106);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(103, 21);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(12, 106);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 3;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(80, 99);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(156, 20);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_checkcode
            // 
            this.btn_checkcode.Location = new System.Drawing.Point(538, 107);
            this.btn_checkcode.Name = "btn_checkcode";
            this.btn_checkcode.Size = new System.Drawing.Size(108, 20);
            this.btn_checkcode.TabIndex = 5;
            this.btn_checkcode.Text = "Check Code";
            this.btn_checkcode.UseVisualStyleBackColor = true;
            this.btn_checkcode.Click += new System.EventHandler(this.btn_checkcode_Click);
            // 
            // devdgv
            // 
            this.devdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devdgv.Location = new System.Drawing.Point(12, 134);
            this.devdgv.Name = "devdgv";
            this.devdgv.Size = new System.Drawing.Size(776, 399);
            this.devdgv.TabIndex = 6;
            this.devdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(663, 6);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 7;
            this.time.Text = "Time";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Location = new System.Drawing.Point(465, 9);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(30, 13);
            this.date1.TabIndex = 8;
            this.date1.Text = "Date";
            // 
            // Developer_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.devdgv);
            this.Controls.Add(this.btn_checkcode);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_totester);
            this.Controls.Add(this.btn_logout);
            this.Name = "Developer_Panel";
            this.Text = "Developer_Panel";
            this.Load += new System.EventHandler(this.Developer_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_totester;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_checkcode;
        private System.Windows.Forms.DataGridView devdgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date1;
    }
}