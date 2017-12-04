namespace MATeUI.UIforEmployee
{
    partial class NewSubTaskForm
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
            this.newSubTaskUC1 = new MATeUI.UIforEmployee.NewSubTaskUC();
            this.SuspendLayout();
            // 
            // newSubTaskUC1
            // 
            this.newSubTaskUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSubTaskUC1.Location = new System.Drawing.Point(0, 0);
            this.newSubTaskUC1.Name = "newSubTaskUC1";
            this.newSubTaskUC1.Size = new System.Drawing.Size(512, 332);
            this.newSubTaskUC1.TabIndex = 0;
            // 
            // NewSubTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 332);
            this.Controls.Add(this.newSubTaskUC1);
            this.Name = "NewSubTaskForm";
            this.Text = "NewSubTaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NewSubTaskUC newSubTaskUC1;
    }
}