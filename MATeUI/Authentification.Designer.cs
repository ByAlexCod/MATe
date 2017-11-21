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
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IpLb = new System.Windows.Forms.Label();
            this.ListIpCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // connexionBtn
            // 
            this.connexionBtn.Location = new System.Drawing.Point(353, 280);
            this.connexionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connexionBtn.Name = "connexionBtn";
            this.connexionBtn.Size = new System.Drawing.Size(100, 28);
            this.connexionBtn.TabIndex = 0;
            this.connexionBtn.Text = "Log In";
            this.connexionBtn.UseVisualStyleBackColor = true;
            this.connexionBtn.Click += new System.EventHandler(this.connexionBtn_Click);
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(271, 65);
            this.userNameTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(309, 22);
            this.userNameTbx.TabIndex = 1;
            this.userNameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(271, 126);
            this.passwordTbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.PasswordChar = '*';
            this.passwordTbx.Size = new System.Drawing.Size(309, 22);
            this.passwordTbx.TabIndex = 2;
            this.passwordTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Password";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = global::MATeUI.Properties.Resources.LOGO_MATe;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(879, 369);
            this.label3.TabIndex = 5;
            // 
            // IpLb
            // 
            this.IpLb.AutoSize = true;
            this.IpLb.Location = new System.Drawing.Point(109, 208);
            this.IpLb.Name = "IpLb";
            this.IpLb.Size = new System.Drawing.Size(20, 17);
            this.IpLb.TabIndex = 6;
            this.IpLb.Text = "IP";
            // 
            // ListIpCmb
            // 
            this.ListIpCmb.FormattingEnabled = true;
            this.ListIpCmb.Location = new System.Drawing.Point(271, 199);
            this.ListIpCmb.Name = "ListIpCmb";
            this.ListIpCmb.Size = new System.Drawing.Size(309, 24);
            this.ListIpCmb.TabIndex = 7;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 369);
            this.Controls.Add(this.ListIpCmb);
            this.Controls.Add(this.IpLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.userNameTbx);
            this.Controls.Add(this.connexionBtn);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authentification";
            this.Text = "MATe - By IN\'TECH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexionBtn;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IpLb;
        private System.Windows.Forms.ComboBox ListIpCmb;
    }
}

