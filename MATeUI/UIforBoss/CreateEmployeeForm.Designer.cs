namespace MATeUI
{
    partial class CreateEmployeeForm
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
            this.createEmployeeUC1 = new MATeUI.CreateEmployeeUC();
            this.SuspendLayout();
            // 
            // createEmployeeUC1
            // 
            this.createEmployeeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createEmployeeUC1.Location = new System.Drawing.Point(0, 0);
            this.createEmployeeUC1.Name = "createEmployeeUC1";
            this.createEmployeeUC1.Size = new System.Drawing.Size(700, 387);
            this.createEmployeeUC1.TabIndex = 0;
            this.createEmployeeUC1.Load += new System.EventHandler(this.createEmployeeUC1_Load);
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 387);
            this.Controls.Add(this.createEmployeeUC1);
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CreateEmployeeUC createEmployeeUC1;
    }
}