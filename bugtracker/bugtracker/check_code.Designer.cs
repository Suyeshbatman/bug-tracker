namespace bugtracker
{
    partial class check_code
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_upcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(12, 12);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(776, 288);
            this.txtcode.TabIndex = 20;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 350);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 21;
            this.lbl_status.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(96, 350);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(204, 20);
            this.txt_status.TabIndex = 22;
            // 
            // btn_upcode
            // 
            this.btn_upcode.Location = new System.Drawing.Point(459, 340);
            this.btn_upcode.Name = "btn_upcode";
            this.btn_upcode.Size = new System.Drawing.Size(158, 30);
            this.btn_upcode.TabIndex = 23;
            this.btn_upcode.Text = "Update Code";
            this.btn_upcode.UseVisualStyleBackColor = true;
            this.btn_upcode.Click += new System.EventHandler(this.btn_upcode_Click);
            // 
            // check_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_upcode);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.txtcode);
            this.Name = "check_code";
            this.Text = "check_code";
            this.Load += new System.EventHandler(this.check_code_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl txtcode;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_upcode;
    }
}