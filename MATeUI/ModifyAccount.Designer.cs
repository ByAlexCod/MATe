namespace MATeUI
{
    partial class ModifyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyAccount));
            this.changeCount21 = new MATeUI.ModifyAccount2();
            this.SuspendLayout();
            // 
            // changeCount21
            // 
            this.changeCount21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeCount21.Location = new System.Drawing.Point(0, 0);
            this.changeCount21.Name = "changeCount21";
            this.changeCount21.Size = new System.Drawing.Size(678, 341);
            this.changeCount21.TabIndex = 0;
            this.changeCount21.User = null;
            this.changeCount21.Load += new System.EventHandler(this.changeCount21_Load);
            // 
            // ModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 341);
            this.Controls.Add(this.changeCount21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyAccount";
            this.Text = "Modify Account";
            this.ResumeLayout(false);

        }

        #endregion
        internal ModifyAccount2 changeCount21;
    }
}