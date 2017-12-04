namespace MATeUI
{
    partial class EmployeeUI
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
            this.bodyUIEmployeeUC1 = new MATeUI.BodyUIEmployeeUC();
            this.SuspendLayout();
            // 
            // head1
            // 
            this.head1.Dock = System.Windows.Forms.DockStyle.Top;
            this.head1.Location = new System.Drawing.Point(0, 0);
            this.head1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(1028, 46);
            this.head1.TabIndex = 0;
            // 
            // bodyUIEmployeeUC1
            // 
            this.bodyUIEmployeeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyUIEmployeeUC1.Location = new System.Drawing.Point(0, 46);
            this.bodyUIEmployeeUC1.Name = "bodyUIEmployeeUC1";
            this.bodyUIEmployeeUC1.Size = new System.Drawing.Size(1028, 394);
            this.bodyUIEmployeeUC1.TabIndex = 1;
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 440);
            this.Controls.Add(this.bodyUIEmployeeUC1);
            this.Controls.Add(this.head1);
            this.Name = "EmployeeUI";
            this.Text = "EmployeeUI";
            this.ResumeLayout(false);

        }

        #endregion

        private head head1;
        private BodyUIEmployeeUC bodyUIEmployeeUC1;
    }
}