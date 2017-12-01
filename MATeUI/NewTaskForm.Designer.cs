namespace MATeUI
{
    partial class NewTaskForm
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
            this.newTaskUC1 = new MATeUI.NewTaskUC();
            this.SuspendLayout();
            // 
            // newTaskUC1
            // 
            this.newTaskUC1.CurrentProject = null;
            this.newTaskUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTaskUC1.Location = new System.Drawing.Point(0, 0);
            this.newTaskUC1.Name = "newTaskUC1";
            this.newTaskUC1.Size = new System.Drawing.Size(416, 269);
            this.newTaskUC1.TabIndex = 0;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 269);
            this.Controls.Add(this.newTaskUC1);
            this.Name = "NewTaskForm";
            this.Text = "NewTaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NewTaskUC newTaskUC1;
    }
}