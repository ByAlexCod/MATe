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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestBoss));
            this.RequestBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPsCbx = new System.Windows.Forms.ComboBox();
            this.MailTbx = new System.Windows.Forms.TextBox();
            this.IPTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestBtn
            // 
            this.RequestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RequestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RequestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.Location = new System.Drawing.Point(152, 81);
            this.RequestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(81, 42);
            this.RequestBtn.TabIndex = 0;
            this.RequestBtn.Text = "Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(9, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(332, 67);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boss\'s IP";
            // 
            // IPsCbx
            // 
            this.IPsCbx.FormattingEnabled = true;
            this.IPsCbx.Location = new System.Drawing.Point(2, 48);
            this.IPsCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPsCbx.Name = "IPsCbx";
            this.IPsCbx.Size = new System.Drawing.Size(216, 21);
            this.IPsCbx.TabIndex = 2;
            // 
            // MailTbx
            // 
            this.MailTbx.Location = new System.Drawing.Point(2, 24);
            this.MailTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MailTbx.Name = "MailTbx";
            this.MailTbx.Size = new System.Drawing.Size(216, 20);
            this.MailTbx.TabIndex = 1;
            // 
            // IPTbx
            // 
            this.IPTbx.Location = new System.Drawing.Point(2, 2);
            this.IPTbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPTbx.Name = "IPTbx";
            this.IPTbx.Size = new System.Drawing.Size(216, 20);
            this.IPTbx.TabIndex = 0;
            // 
            // RequestBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 129);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.RequestBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RequestBoss";
            this.Text = "Request Access";
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