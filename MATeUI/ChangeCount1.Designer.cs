namespace MATeUI
{
    partial class ChangeCount1
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
            this.btnRefrech = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefrech
            // 
            this.btnRefrech.Location = new System.Drawing.Point(665, 12);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(75, 23);
            this.btnRefrech.TabIndex = 0;
            this.btnRefrech.Text = "Refresh";
            this.btnRefrech.UseVisualStyleBackColor = true;
            this.btnRefrech.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeCount1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefrech);
            this.Name = "ChangeCount1";
            this.Size = new System.Drawing.Size(772, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefrech;
    }
}
