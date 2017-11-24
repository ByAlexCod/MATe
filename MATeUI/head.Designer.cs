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
            this.ModifyProfileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 50);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ModifyProfileBtn
            // 
            this.ModifyProfileBtn.Location = new System.Drawing.Point(331, 3);
            this.ModifyProfileBtn.Name = "ModifyProfileBtn";
            this.ModifyProfileBtn.Size = new System.Drawing.Size(92, 50);
            this.ModifyProfileBtn.TabIndex = 2;
            this.ModifyProfileBtn.Text = "Modify your profile";
            this.ModifyProfileBtn.UseVisualStyleBackColor = true;
            // 
            // head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyProfileBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveBtn);
            this.Name = "head";
            this.Size = new System.Drawing.Size(874, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ModifyProfileBtn;
    }
}
