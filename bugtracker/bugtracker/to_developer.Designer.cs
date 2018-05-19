namespace bugtracker
{
    partial class to_developer
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
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lineno = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_status1 = new System.Windows.Forms.TextBox();
            this.btn_sendtodeveloper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(3, 1);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(776, 260);
            this.txtcode.TabIndex = 20;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Line NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_lineno
            // 
            this.txt_lineno.Location = new System.Drawing.Point(103, 316);
            this.txt_lineno.Name = "txt_lineno";
            this.txt_lineno.Size = new System.Drawing.Size(80, 20);
            this.txt_lineno.TabIndex = 22;
            this.txt_lineno.TextChanged += new System.EventHandler(this.txt_lineno_TextChanged);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(216, 316);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 23;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.Click += new System.EventHandler(this.lbl_Status_Click);
            // 
            // txt_status1
            // 
            this.txt_status1.Location = new System.Drawing.Point(291, 316);
            this.txt_status1.Name = "txt_status1";
            this.txt_status1.Size = new System.Drawing.Size(100, 20);
            this.txt_status1.TabIndex = 24;
            this.txt_status1.TextChanged += new System.EventHandler(this.txt_status1_TextChanged);
            // 
            // btn_sendtodeveloper
            // 
            this.btn_sendtodeveloper.Location = new System.Drawing.Point(506, 316);
            this.btn_sendtodeveloper.Name = "btn_sendtodeveloper";
            this.btn_sendtodeveloper.Size = new System.Drawing.Size(180, 33);
            this.btn_sendtodeveloper.TabIndex = 25;
            this.btn_sendtodeveloper.Text = "Send To Developer";
            this.btn_sendtodeveloper.UseVisualStyleBackColor = true;
            this.btn_sendtodeveloper.Click += new System.EventHandler(this.btn_sendtodeveloper_Click);
            // 
            // to_developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sendtodeveloper);
            this.Controls.Add(this.txt_status1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_lineno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.Name = "to_developer";
            this.Text = "to_developer";
            this.Load += new System.EventHandler(this.to_developer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lineno;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_status1;
        private System.Windows.Forms.Button btn_sendtodeveloper;
    }
}