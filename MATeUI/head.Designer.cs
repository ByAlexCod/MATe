namespace MATeUI
{
    partial class head
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(2, 3);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 41);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(284, 7);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 2;
            this.modify.Text = "modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "head";
            this.Size = new System.Drawing.Size(656, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modify;
    }
}
