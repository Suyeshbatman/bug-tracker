namespace bugtracker
{
    partial class to_developer_again
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
            this.btn_send2developer = new System.Windows.Forms.Button();
            this.txt_status2 = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_lineno1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // btn_send2developer
            // 
            this.btn_send2developer.Location = new System.Drawing.Point(496, 304);
            this.btn_send2developer.Name = "btn_send2developer";
            this.btn_send2developer.Size = new System.Drawing.Size(180, 33);
            this.btn_send2developer.TabIndex = 31;
            this.btn_send2developer.Text = "Send To Developer";
            this.btn_send2developer.UseVisualStyleBackColor = true;
            this.btn_send2developer.Click += new System.EventHandler(this.btn_send2developer_Click);
            // 
            // txt_status2
            // 
            this.txt_status2.Location = new System.Drawing.Point(281, 304);
            this.txt_status2.Name = "txt_status2";
            this.txt_status2.Size = new System.Drawing.Size(100, 20);
            this.txt_status2.TabIndex = 30;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(206, 304);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 29;
            this.lbl_Status.Text = "Status";
            // 
            // txt_lineno1
            // 
            this.txt_lineno1.Location = new System.Drawing.Point(93, 304);
            this.txt_lineno1.Name = "txt_lineno1";
            this.txt_lineno1.Size = new System.Drawing.Size(80, 20);
            this.txt_lineno1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Line NO";
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(5, 0);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(776, 260);
            this.txtcode.TabIndex = 26;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // to_developer_again
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send2developer);
            this.Controls.Add(this.txt_status2);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_lineno1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcode);
            this.Name = "to_developer_again";
            this.Text = "to_developer_again";
            this.Load += new System.EventHandler(this.to_developer_again_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send2developer;
        private System.Windows.Forms.TextBox txt_status2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_lineno1;
        private System.Windows.Forms.Label label1;
        private ICSharpCode.TextEditor.TextEditorControl txtcode;
    }
}