﻿namespace MATeUI
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.connexionBtn = new System.Windows.Forms.Button();
            this.userNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IpLb = new System.Windows.Forms.Label();
            this.ListIpCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // connexionBtn
            // 
            this.connexionBtn.Location = new System.Drawing.Point(265, 228);
            this.connexionBtn.Name = "connexionBtn";
            this.connexionBtn.Size = new System.Drawing.Size(75, 23);
            this.connexionBtn.TabIndex = 0;
            this.connexionBtn.Text = "Log In";
            this.connexionBtn.UseVisualStyleBackColor = true;
            this.connexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(203, 53);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(233, 20);
            this.userNameTbx.TabIndex = 1;
            this.userNameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Email Address";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = global::MATeUI.Properties.Resources.LOGO_MATe;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 300);
            this.label3.TabIndex = 5;
            // 
            // IpLb
            // 
            this.IpLb.AutoSize = true;
            this.IpLb.Location = new System.Drawing.Point(82, 115);
            this.IpLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IpLb.Name = "IpLb";
            this.IpLb.Size = new System.Drawing.Size(17, 13);
            this.IpLb.TabIndex = 6;
            this.IpLb.Text = "IP";
            // 
            // ListIpCmb
            // 
            this.ListIpCmb.FormattingEnabled = true;
            this.ListIpCmb.Location = new System.Drawing.Point(203, 115);
            this.ListIpCmb.Margin = new System.Windows.Forms.Padding(2);
            this.ListIpCmb.Name = "ListIpCmb";
            this.ListIpCmb.Size = new System.Drawing.Size(233, 21);
            this.ListIpCmb.TabIndex = 7;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 300);
            this.Controls.Add(this.ListIpCmb);
            this.Controls.Add(this.IpLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTbx);
            this.Controls.Add(this.connexionBtn);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Authentification";
            this.Text = "MATe - By IN\'TECH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexionBtn;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IpLb;
        private System.Windows.Forms.ComboBox ListIpCmb;
    }
}

