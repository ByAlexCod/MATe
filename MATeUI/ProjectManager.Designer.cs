﻿namespace MATeUI
{
    partial class ProjectManager
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
            this.bodyUC1 = new MATeUI.BodyUC();
            this.head1 = new MATeUI.head();
            this.SuspendLayout();
            // 
            // bodyUC1
            // 
            this.bodyUC1.Location = new System.Drawing.Point(0, 64);
            this.bodyUC1.Margin = new System.Windows.Forms.Padding(5);
            this.bodyUC1.Name = "bodyUC1";
            this.bodyUC1.Size = new System.Drawing.Size(1407, 623);
            this.bodyUC1.TabIndex = 0;
            this.bodyUC1.Load += new System.EventHandler(this.bodyUC1_Load_1);
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1407, 56);
            this.head1.TabIndex = 1;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1407, 701);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.bodyUC1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectManager";
            this.Text = "ProjectManager";
            this.Load += new System.EventHandler(this.ProjectManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BodyUC bodyUC1;
        private head head1;
    }
}