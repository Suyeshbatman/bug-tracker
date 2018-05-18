namespace bugtracker
{
    partial class Updatestatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_upstat = new System.Windows.Forms.TextBox();
            this.txt_line1 = new System.Windows.Forms.TextBox();
            this.lbl_lineno1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update status for Project";
            // 
            // txt_upstat
            // 
            this.txt_upstat.Location = new System.Drawing.Point(162, 23);
            this.txt_upstat.Name = "txt_upstat";
            this.txt_upstat.Size = new System.Drawing.Size(135, 20);
            this.txt_upstat.TabIndex = 1;
            // 
            // txt_line1
            // 
            this.txt_line1.Location = new System.Drawing.Point(162, 61);
            this.txt_line1.Name = "txt_line1";
            this.txt_line1.Size = new System.Drawing.Size(79, 20);
            this.txt_line1.TabIndex = 2;
            // 
            // lbl_lineno1
            // 
            this.lbl_lineno1.AutoSize = true;
            this.lbl_lineno1.Location = new System.Drawing.Point(2, 68);
            this.lbl_lineno1.Name = "lbl_lineno1";
            this.lbl_lineno1.Size = new System.Drawing.Size(46, 13);
            this.lbl_lineno1.TabIndex = 3;
            this.lbl_lineno1.Text = "Line NO";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(81, 122);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 36);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Updatestatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 224);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_lineno1);
            this.Controls.Add(this.txt_line1);
            this.Controls.Add(this.txt_upstat);
            this.Controls.Add(this.label1);
            this.Name = "Updatestatus";
            this.Text = "Updatestatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_upstat;
        private System.Windows.Forms.TextBox txt_line1;
        private System.Windows.Forms.Label lbl_lineno1;
        private System.Windows.Forms.Button btn_update;
    }
}