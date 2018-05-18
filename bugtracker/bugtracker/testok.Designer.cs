namespace bugtracker
{
    partial class testok
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
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_submit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(40, 25);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(60, 13);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "Description";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(43, 41);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(210, 209);
            this.txt_desc.TabIndex = 1;
            // 
            // btn_submit1
            // 
            this.btn_submit1.Location = new System.Drawing.Point(293, 115);
            this.btn_submit1.Name = "btn_submit1";
            this.btn_submit1.Size = new System.Drawing.Size(58, 45);
            this.btn_submit1.TabIndex = 2;
            this.btn_submit1.Text = "Submit";
            this.btn_submit1.UseVisualStyleBackColor = true;
            this.btn_submit1.Click += new System.EventHandler(this.btn_submit1_Click);
            // 
            // testok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 286);
            this.Controls.Add(this.btn_submit1);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_desc);
            this.Name = "testok";
            this.Text = "testok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_submit1;
    }
}