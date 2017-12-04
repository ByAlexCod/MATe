namespace MATeUI
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
            this.head1 = new MATeUI.head();
            this.bodyUC1 = new MATeUI.BodyUC();
            this.SuspendLayout();
            // 
            // head1
            // 
            //this.head1.CurrentUser = null;
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1022, 46);
            this.head1.TabIndex = 1;
            // 
            // bodyUC1
            // 
            this.bodyUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyUC1.Location = new System.Drawing.Point(0, 46);
            this.bodyUC1.Name = "bodyUC1";
            this.bodyUC1.Size = new System.Drawing.Size(1022, 524);
            this.bodyUC1.TabIndex = 2;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1022, 570);
            this.Controls.Add(this.bodyUC1);
            this.Controls.Add(this.head1);
            this.Name = "ProjectManager";
            this.Text = "BOSS 's INTERFACE";
            this.ResumeLayout(false);

        }

        #endregion
        private head head1;
        private BodyUC bodyUC1;
    }
}