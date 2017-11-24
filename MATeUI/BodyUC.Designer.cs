namespace MATeUI
{
    partial class BodyUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainPage = new System.Windows.Forms.TabControl();
            this._pageProjects = new System.Windows.Forms.TabPage();
            this.detailProjectOnBody = new MATeUI.DetailProjectUC();
            this.projectManagementOnBody = new MATeUI.ProjectManagement();
            this._pageCollaborators = new System.Windows.Forms.TabPage();
            this.colaborators1 = new MATeUI.Colaborators();
            this._mainPage.SuspendLayout();
            this._pageProjects.SuspendLayout();
            this._pageCollaborators.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPage
            // 
            this._mainPage.Controls.Add(this._pageProjects);
            this._mainPage.Controls.Add(this._pageCollaborators);
            this._mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPage.Location = new System.Drawing.Point(0, 0);
            this._mainPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._mainPage.Name = "_mainPage";
            this._mainPage.SelectedIndex = 0;
            this._mainPage.Size = new System.Drawing.Size(1371, 633);
            this._mainPage.TabIndex = 0;
            // 
            // _pageProjects
            // 
            this._pageProjects.Controls.Add(this.detailProjectOnBody);
            this._pageProjects.Controls.Add(this.projectManagementOnBody);
            this._pageProjects.Location = new System.Drawing.Point(4, 25);
            this._pageProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pageProjects.Name = "_pageProjects";
            this._pageProjects.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pageProjects.Size = new System.Drawing.Size(1363, 604);
            this._pageProjects.TabIndex = 0;
            this._pageProjects.Text = "Project";
            this._pageProjects.UseVisualStyleBackColor = true;
            // 
            // detailProjectOnBody
            // 
            this.detailProjectOnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailProjectOnBody.Location = new System.Drawing.Point(4, 87);
            this.detailProjectOnBody.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.detailProjectOnBody.Name = "detailProjectOnBody";
            this.detailProjectOnBody.Size = new System.Drawing.Size(1352, 510);
            this.detailProjectOnBody.TabIndex = 1;
            this.detailProjectOnBody.Load += new System.EventHandler(this.DetailProjectOnBody_Load);
            // 
            // projectManagementOnBody
            // 
            this.projectManagementOnBody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.projectManagementOnBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectManagementOnBody.Location = new System.Drawing.Point(4, 4);
            this.projectManagementOnBody.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.projectManagementOnBody.Name = "projectManagementOnBody";
            this.projectManagementOnBody.Size = new System.Drawing.Size(1352, 84);
            this.projectManagementOnBody.TabIndex = 0;
            this.projectManagementOnBody.Load += new System.EventHandler(this.ProjectManagementOnBody_Load);
            // 
            // _pageCollaborators
            // 
            this._pageCollaborators.Controls.Add(this.colaborators1);
            this._pageCollaborators.Location = new System.Drawing.Point(4, 25);
            this._pageCollaborators.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pageCollaborators.Name = "_pageCollaborators";
            this._pageCollaborators.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pageCollaborators.Size = new System.Drawing.Size(1363, 604);
            this._pageCollaborators.TabIndex = 1;
            this._pageCollaborators.Text = "Collaborators";
            this._pageCollaborators.UseVisualStyleBackColor = true;
            // 
            // colaborators1
            // 
            this.colaborators1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colaborators1.Location = new System.Drawing.Point(4, 4);
            this.colaborators1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colaborators1.Name = "colaborators1";
            this.colaborators1.Size = new System.Drawing.Size(1352, 593);
            this.colaborators1.TabIndex = 0;
            // 
            // BodyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._mainPage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BodyUC";
            this.Size = new System.Drawing.Size(1371, 633);
            this._mainPage.ResumeLayout(false);
            this._pageProjects.ResumeLayout(false);
            this._pageCollaborators.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _mainPage;
        private System.Windows.Forms.TabPage _pageProjects;
        private System.Windows.Forms.TabPage _pageCollaborators;
        public ProjectManagement projectManagementOnBody;
        public DetailProjectUC detailProjectOnBody;
        private Colaborators colaborators1;
    }
}
