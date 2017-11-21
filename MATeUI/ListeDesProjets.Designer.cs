namespace MATeUI
{
    partial class ListeDesProjets
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
            this.DgProjects = new System.Windows.Forms.DataGridView();
            this.showProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // DgProjects
            // 
            this.DgProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectName,
            this.beginDate,
            this.endDate,
            this.leader});
            this.DgProjects.Location = new System.Drawing.Point(525, 74);
            this.DgProjects.Name = "DgProjects";
            this.DgProjects.Size = new System.Drawing.Size(443, 150);
            this.DgProjects.TabIndex = 0;
            // 
            // showProject
            // 
            this.showProject.Location = new System.Drawing.Point(714, 253);
            this.showProject.Name = "showProject";
            this.showProject.Size = new System.Drawing.Size(75, 23);
            this.showProject.TabIndex = 1;
            this.showProject.Text = "Show";
            this.showProject.UseVisualStyleBackColor = true;
            this.showProject.Click += new System.EventHandler(this.showProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projects List";
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Name";
            this.projectName.Name = "projectName";
            // 
            // beginDate
            // 
            this.beginDate.HeaderText = "Start";
            this.beginDate.Name = "beginDate";
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End";
            this.endDate.Name = "endDate";
            // 
            // leader
            // 
            this.leader.HeaderText = "Leader";
            this.leader.Name = "leader";
            // 
            // ListeDesProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showProject);
            this.Controls.Add(this.DgProjects);
            this.Name = "ListeDesProjets";
            this.Text = "ListeDesProjets";
            this.Load += new System.EventHandler(this.ListeDesProjets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgProjects;
        private System.Windows.Forms.Button showProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn leader;
    }
}