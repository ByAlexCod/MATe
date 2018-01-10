namespace MATeUI
{
    partial class ProjectManagement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;       /// <summary> 
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagement));
            this._deleteProjectBtn = new System.Windows.Forms.Button();
            this._projectListCbx = new System.Windows.Forms.ComboBox();
            this._addProjectBtn = new System.Windows.Forms.Button();
            this._projectStatusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _deleteProjectBtn
            // 
            this._deleteProjectBtn.BackColor = System.Drawing.Color.IndianRed;
            this._deleteProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._deleteProjectBtn.Location = new System.Drawing.Point(474, 20);
            this._deleteProjectBtn.Name = "_deleteProjectBtn";
            this._deleteProjectBtn.Size = new System.Drawing.Size(75, 23);
            this._deleteProjectBtn.TabIndex = 1;
            this._deleteProjectBtn.Text = "Delete";
            this._deleteProjectBtn.UseVisualStyleBackColor = false;
            // 
            // _projectListCbx
            // 
            this._projectListCbx.FormattingEnabled = true;
            this._projectListCbx.Location = new System.Drawing.Point(93, 20);
            this._projectListCbx.Name = "_projectListCbx";
            this._projectListCbx.Size = new System.Drawing.Size(279, 21);
            this._projectListCbx.TabIndex = 2;
            // 
            // _addProjectBtn
            // 
            this._addProjectBtn.BackColor = System.Drawing.Color.PaleGreen;
            this._addProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._addProjectBtn.FlatAppearance.BorderSize = 2;
            this._addProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addProjectBtn.Location = new System.Drawing.Point(393, 20);
            this._addProjectBtn.Name = "_addProjectBtn";
            this._addProjectBtn.Size = new System.Drawing.Size(75, 23);
            this._addProjectBtn.TabIndex = 3;
            this._addProjectBtn.Text = "Add ...";
            this._addProjectBtn.UseVisualStyleBackColor = false;
            this._addProjectBtn.Click += new System.EventHandler(this._addProjectBtn_Click_1);
            // 
            // _projectStatusLbl
            // 
            this._projectStatusLbl.AutoSize = true;
            this._projectStatusLbl.BackColor = System.Drawing.Color.Transparent;
            this._projectStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._projectStatusLbl.Location = new System.Drawing.Point(878, 31);
            this._projectStatusLbl.Name = "_projectStatusLbl";
            this._projectStatusLbl.Size = new System.Drawing.Size(109, 13);
            this._projectStatusLbl.TabIndex = 6;
            this._projectStatusLbl.Text = "/////////////////";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Projects List";
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this._projectStatusLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._addProjectBtn);
            this.Controls.Add(this._projectListCbx);
            this.Controls.Add(this._deleteProjectBtn);
            this.Name = "ProjectManagement";
            this.Size = new System.Drawing.Size(1031, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox _projectListCbx;
        internal System.Windows.Forms.Button _addProjectBtn;
        internal System.Windows.Forms.Button _deleteProjectBtn;
        internal System.Windows.Forms.Label _projectStatusLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
