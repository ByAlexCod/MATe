namespace MATeUI
{
    partial class RequestBoss
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
            this.RequestBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.IPTbx = new System.Windows.Forms.TextBox();
            this.MailTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPsCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(202, 100);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(75, 52);
            this.RequestBtn.TabIndex = 0;
            this.RequestBtn.Text = "Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.IPsCbx);
            this.splitContainer1.Panel2.Controls.Add(this.MailTbx);
            this.splitContainer1.Panel2.Controls.Add(this.IPTbx);
            this.splitContainer1.Size = new System.Drawing.Size(443, 82);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 1;
            // 
            // IPTbx
            // 
            this.IPTbx.Location = new System.Drawing.Point(3, 3);
            this.IPTbx.Name = "IPTbx";
            this.IPTbx.Size = new System.Drawing.Size(286, 22);
            this.IPTbx.TabIndex = 0;
            // 
            // MailTbx
            // 
            this.MailTbx.Location = new System.Drawing.Point(3, 29);
            this.MailTbx.Name = "MailTbx";
            this.MailTbx.Size = new System.Drawing.Size(286, 22);
            this.MailTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boss\'s IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your IP";
            // 
            // IPsCbx
            // 
            this.IPsCbx.FormattingEnabled = true;
            this.IPsCbx.Location = new System.Drawing.Point(3, 54);
            this.IPsCbx.Name = "IPsCbx";
            this.IPsCbx.Size = new System.Drawing.Size(286, 24);
            this.IPsCbx.TabIndex = 2;
            // 
            // RequestBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 159);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.RequestBtn);
            this.Name = "RequestBoss";
            this.Text = "RequestBoss";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MailTbx;
        private System.Windows.Forms.TextBox IPTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IPsCbx;
    }
}