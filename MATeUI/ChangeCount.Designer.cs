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
            this.SuspendLayout();
            // 
            // changeCount21
            // 
            this.changeCount21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeCount21.Location = new System.Drawing.Point(0, 0);
            this.changeCount21.Name = "changeCount21";
            this.changeCount21.Size = new System.Drawing.Size(1242, 490);
            this.changeCount21.TabIndex = 0;
            // 
            // ChangeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 490);
            this.Controls.Add(this.changeCount21);
            this.Name = "ChangeCount";
            this.Text = "ChangeCount";
            this.ResumeLayout(false);

        }

        #endregion

        private ChangeCount2 changeCount21;
    }
}