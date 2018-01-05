namespace MATeUI
{
    partial class BodyUIEmployeeUC
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
            this.projectManagement1 = new MATeUI.ProjectManagement();
            this.detailProjectEmployeeUC1 = new MATeUI.DetailProjectEmployeeUC();
            this.SuspendLayout();
            // 
            // projectManagement1
            // 
            this.projectManagement1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.projectManagement1.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectManagement1.Location = new System.Drawing.Point(0, 0);
            this.projectManagement1.Name = "projectManagement1";
            this.projectManagement1.Size = new System.Drawing.Size(1014, 68);
            this.projectManagement1.TabIndex = 0;
            // 
            // detailProjectEmployeeUC1
            // 
            this.detailProjectEmployeeUC1.AutoScroll = true;
            this.detailProjectEmployeeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailProjectEmployeeUC1.Location = new System.Drawing.Point(0, 68);
            this.detailProjectEmployeeUC1.Name = "detailProjectEmployeeUC1";
            this.detailProjectEmployeeUC1.Size = new System.Drawing.Size(1014, 346);
            this.detailProjectEmployeeUC1.TabIndex = 1;
            // 
            // BodyUIEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailProjectEmployeeUC1);
            this.Controls.Add(this.projectManagement1);
            this.Name = "BodyUIEmployeeUC";
            this.Size = new System.Drawing.Size(1014, 601);
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectManagement projectManagement1;
        private DetailProjectEmployeeUC detailProjectEmployeeUC1;
    }
}
