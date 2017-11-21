namespace MATeUI
{
    partial class colaboratorstestform
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
            this.colaborators1 = new MATeUI.Colaborators();
            this.SuspendLayout();
            // 
            // colaborators1
            // 
            this.colaborators1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colaborators1.Location = new System.Drawing.Point(0, 0);
            this.colaborators1.Name = "colaborators1";
            this.colaborators1.Size = new System.Drawing.Size(981, 515);
            this.colaborators1.TabIndex = 0;
            // 
            // colaboratorstestform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.Controls.Add(this.colaborators1);
            this.Name = "colaboratorstestform";
            this.Text = "colaboratorstestform";
            this.ResumeLayout(false);

        }

        #endregion

        private Colaborators colaborators1;
    }
}