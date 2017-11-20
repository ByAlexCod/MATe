namespace MATeUI
{
    partial class AcceuilBoss
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
            this.memberBtn = new System.Windows.Forms.Button();
            this.teamBtn = new System.Windows.Forms.Button();
            this.projetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberBtn
            // 
            this.memberBtn.Location = new System.Drawing.Point(35, 158);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(213, 68);
            this.memberBtn.TabIndex = 0;
            this.memberBtn.Text = "Member Manager";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // teamBtn
            // 
            this.teamBtn.Location = new System.Drawing.Point(325, 158);
            this.teamBtn.Name = "teamBtn";
            this.teamBtn.Size = new System.Drawing.Size(226, 68);
            this.teamBtn.TabIndex = 1;
            this.teamBtn.Text = "Team Manager";
            this.teamBtn.UseVisualStyleBackColor = true;
            // 
            // projetBtn
            // 
            this.projetBtn.Location = new System.Drawing.Point(620, 158);
            this.projetBtn.Name = "projetBtn";
            this.projetBtn.Size = new System.Drawing.Size(225, 68);
            this.projetBtn.TabIndex = 2;
            this.projetBtn.Text = "Project Manager";
            this.projetBtn.UseVisualStyleBackColor = true;
            this.projetBtn.Click += new System.EventHandler(this.projetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOME PAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AcceuilBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projetBtn);
            this.Controls.Add(this.teamBtn);
            this.Controls.Add(this.memberBtn);
            this.Name = "AcceuilBoss";
            this.Text = "AcceuilBoss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button teamBtn;
        private System.Windows.Forms.Button projetBtn;
        private System.Windows.Forms.Label label1;
    }
}