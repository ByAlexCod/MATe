namespace MATeUI
{
    partial class ChangeCount
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
            this.changeCount21 = new MATeUI.ChangeCount2();
            this.head1 = new MATeUI.head();
            this.SuspendLayout();
            // 
            // changeCount21
            // 
            this.changeCount21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeCount21.Location = new System.Drawing.Point(0, 0);
            this.changeCount21.Name = "changeCount21";
            this.changeCount21.Size = new System.Drawing.Size(675, 413);
            this.changeCount21.TabIndex = 0;
            this.changeCount21.User = null;
            this.changeCount21.Load += new System.EventHandler(this.changeCount21_Load);
            // 
            // head1
            // 
            this.head1.CurrentUser = null;
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(675, 46);
            this.head1.TabIndex = 1;
            // 
            // ChangeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.changeCount21);
            this.Name = "ChangeCount";
            this.Text = "ChangeCount";
            this.ResumeLayout(false);

        }

        #endregion

        internal ChangeCount2 changeCount21;
        private head head1;
    }
}