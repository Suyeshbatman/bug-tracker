namespace bugtracker
{
    partial class Update_status__Tester
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
            this.txt_upstat1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_upstat1
            // 
            this.txt_upstat1.Location = new System.Drawing.Point(184, 33);
            this.txt_upstat1.Name = "txt_upstat1";
            this.txt_upstat1.Size = new System.Drawing.Size(135, 20);
            this.txt_upstat1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update status for Project";
            // 
            // btn_update2
            // 
            this.btn_update2.Location = new System.Drawing.Point(106, 90);
            this.btn_update2.Name = "btn_update2";
            this.btn_update2.Size = new System.Drawing.Size(119, 47);
            this.btn_update2.TabIndex = 4;
            this.btn_update2.Text = "Update";
            this.btn_update2.UseVisualStyleBackColor = true;
            this.btn_update2.Click += new System.EventHandler(this.btn_update2_Click);
            // 
            // Update_status__Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 182);
            this.Controls.Add(this.btn_update2);
            this.Controls.Add(this.txt_upstat1);
            this.Controls.Add(this.label1);
            this.Name = "Update_status__Tester";
            this.Text = "Update_status_Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_upstat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update2;
    }
}