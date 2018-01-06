namespace MATeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.connexionBtn = new System.Windows.Forms.Button();
            this.userNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IpLb = new System.Windows.Forms.Label();
            this.ListIpCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connexionBtn
            // 
            this.connexionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connexionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connexionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.connexionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.connexionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionBtn.Location = new System.Drawing.Point(551, 217);
            this.connexionBtn.Name = "connexionBtn";
            this.connexionBtn.Size = new System.Drawing.Size(77, 30);
            this.connexionBtn.TabIndex = 0;
            this.connexionBtn.Text = "Log In";
            this.connexionBtn.UseVisualStyleBackColor = true;
            this.connexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(469, 91);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(233, 20);
            this.userNameTbx.TabIndex = 1;
            this.userNameTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Email Address";
            // 
            // IpLb
            // 
            this.IpLb.AutoSize = true;
            this.IpLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpLb.Location = new System.Drawing.Point(527, 142);
            this.IpLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IpLb.Name = "IpLb";
            this.IpLb.Size = new System.Drawing.Size(121, 20);
            this.IpLb.TabIndex = 6;
            this.IpLb.Text = "Select your IP";
            // 
            // ListIpCmb
            // 
            this.ListIpCmb.FormattingEnabled = true;
            this.ListIpCmb.Location = new System.Drawing.Point(469, 164);
            this.ListIpCmb.Margin = new System.Windows.Forms.Padding(2);
            this.ListIpCmb.Name = "ListIpCmb";
            this.ListIpCmb.Size = new System.Drawing.Size(233, 21);
            this.ListIpCmb.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 452);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(709, 351);
            this.Controls.Add(this.ListIpCmb);
            this.Controls.Add(this.IpLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTbx);
            this.Controls.Add(this.connexionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(725, 390);
            this.MinimumSize = new System.Drawing.Size(725, 390);
            this.Name = "Authentification";
            this.Text = "MATe - By IN\'TECH";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexionBtn;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IpLb;
        private System.Windows.Forms.ComboBox ListIpCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

