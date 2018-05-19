namespace bugtracker
{
    partial class delete_project
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
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.lbl_doyou = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(35, 97);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(134, 66);
            this.btn_yes.TabIndex = 0;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(198, 97);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(138, 66);
            this.btn_no.TabIndex = 1;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // lbl_doyou
            // 
            this.lbl_doyou.AutoSize = true;
            this.lbl_doyou.Location = new System.Drawing.Point(32, 54);
            this.lbl_doyou.Name = "lbl_doyou";
            this.lbl_doyou.Size = new System.Drawing.Size(177, 13);
            this.lbl_doyou.TabIndex = 2;
            this.lbl_doyou.Text = "Do you want to delete Project?????";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(205, 54);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(0, 13);
            this.lblpro.TabIndex = 3;
            // 
            // delete_project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 212);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.lbl_doyou);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Name = "delete_project";
            this.Text = "delete_project";
            this.Load += new System.EventHandler(this.delete_project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label lbl_doyou;
        private System.Windows.Forms.Label lblpro;
    }
}