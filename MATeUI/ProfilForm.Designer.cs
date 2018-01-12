namespace MATeUI
{
    partial class ProfilForm
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
            this.profilUC1 = new MATeUI.ProfilUC();
            this.SuspendLayout();
            // 
            // profilUC1
            // 
            this.profilUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilUC1.Location = new System.Drawing.Point(0, 0);
            this.profilUC1.Name = "profilUC1";
            this.profilUC1.Size = new System.Drawing.Size(382, 261);
            this.profilUC1.TabIndex = 0;
            // 
            // ProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.profilUC1);
            this.Name = "ProfilForm";
            this.Text = "ProfilForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ProfilUC profilUC1;
    }
}