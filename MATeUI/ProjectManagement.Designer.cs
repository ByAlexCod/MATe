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
            this._deleteProjectBtn = new System.Windows.Forms.Button();
            this._projectListCbx = new System.Windows.Forms.ComboBox();
            this._addProjectBtn = new System.Windows.Forms.Button();
            this._myAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _deleteProjectBtn
            // 
            this._deleteProjectBtn.Location = new System.Drawing.Point(421, 21);
            this._deleteProjectBtn.Name = "_deleteProjectBtn";
            this._deleteProjectBtn.Size = new System.Drawing.Size(75, 23);
            this._deleteProjectBtn.TabIndex = 1;
            this._deleteProjectBtn.Text = "Delete";
            this._deleteProjectBtn.UseVisualStyleBackColor = true;
            // 
            // _projectListCbx
            // 
            this._projectListCbx.FormattingEnabled = true;
            this._projectListCbx.Location = new System.Drawing.Point(40, 21);
            this._projectListCbx.Name = "_projectListCbx";
            this._projectListCbx.Size = new System.Drawing.Size(279, 21);
            this._projectListCbx.TabIndex = 2;
            // 
            // _addProjectBtn
            // 
            this._addProjectBtn.Location = new System.Drawing.Point(340, 21);
            this._addProjectBtn.Name = "_addProjectBtn";
            this._addProjectBtn.Size = new System.Drawing.Size(75, 23);
            this._addProjectBtn.TabIndex = 3;
            this._addProjectBtn.Text = "Add";
            this._addProjectBtn.UseVisualStyleBackColor = true;
            this._addProjectBtn.Click += new System.EventHandler(this._addProjectBtn_Click_1);
            // 
            // _myAccountBtn
            // 
            this._myAccountBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._myAccountBtn.Location = new System.Drawing.Point(956, 0);
            this._myAccountBtn.Name = "_myAccountBtn";
            this._myAccountBtn.Size = new System.Drawing.Size(75, 68);
            this._myAccountBtn.TabIndex = 4;
            this._myAccountBtn.Text = "My Account";
            this._myAccountBtn.UseVisualStyleBackColor = true;
            // 
            // ProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this._myAccountBtn);
            this.Controls.Add(this._addProjectBtn);
            this.Controls.Add(this._projectListCbx);
            this.Controls.Add(this._deleteProjectBtn);
            this.Name = "ProjectManagement";
            this.Size = new System.Drawing.Size(1031, 68);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox _projectListCbx;
        internal System.Windows.Forms.Button _addProjectBtn;
        internal System.Windows.Forms.Button _deleteProjectBtn;
        internal System.Windows.Forms.Button _myAccountBtn;
    }
}
