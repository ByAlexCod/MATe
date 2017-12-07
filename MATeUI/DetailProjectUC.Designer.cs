namespace MATeUI
{
    partial class DetailProjectUC
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
            this._lastNameLbl = new System.Windows.Forms.Label();
            this._mailLbl = new System.Windows.Forms.Label();
            this._addressIPLbl = new System.Windows.Forms.Label();
            this._firstNameLbl = new System.Windows.Forms.Label();
            this._projectEndDate = new System.Windows.Forms.DateTimePicker();
            this._projectBeginDate = new System.Windows.Forms.DateTimePicker();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._removeMemberInProjectBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this._dgMemberInProject = new System.Windows.Forms.DataGridView();
            this.columnFirstName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._changeLeaderBtn = new System.Windows.Forms.Button();
            this._updateProjectBtn = new System.Windows.Forms.Button();
            this._addToProjectBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._dgEmployees = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this._refreshPageBtn = new System.Windows.Forms.Button();
            this._dgTasks = new System.Windows.Forms.DataGridView();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._dgSubTasks = new System.Windows.Forms.DataGridView();
            this.subTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateSubTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgMemberInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // _lastNameLbl
            // 
            this._lastNameLbl.AutoSize = true;
            this._lastNameLbl.Location = new System.Drawing.Point(167, 212);
            this._lastNameLbl.Name = "_lastNameLbl";
            this._lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this._lastNameLbl.TabIndex = 51;
            this._lastNameLbl.Text = "------------------";
            // 
            // _mailLbl
            // 
            this._mailLbl.AutoSize = true;
            this._mailLbl.Location = new System.Drawing.Point(167, 246);
            this._mailLbl.Name = "_mailLbl";
            this._mailLbl.Size = new System.Drawing.Size(52, 13);
            this._mailLbl.TabIndex = 50;
            this._mailLbl.Text = "---------------";
            // 
            // _addressIPLbl
            // 
            this._addressIPLbl.AutoSize = true;
            this._addressIPLbl.Location = new System.Drawing.Point(167, 280);
            this._addressIPLbl.Name = "_addressIPLbl";
            this._addressIPLbl.Size = new System.Drawing.Size(52, 13);
            this._addressIPLbl.TabIndex = 49;
            this._addressIPLbl.Text = "---------------";
            // 
            // _firstNameLbl
            // 
            this._firstNameLbl.AutoSize = true;
            this._firstNameLbl.Location = new System.Drawing.Point(167, 179);
            this._firstNameLbl.Name = "_firstNameLbl";
            this._firstNameLbl.Size = new System.Drawing.Size(64, 13);
            this._firstNameLbl.TabIndex = 48;
            this._firstNameLbl.Text = "-------------------";
            // 
            // _projectEndDate
            // 
            this._projectEndDate.Location = new System.Drawing.Point(170, 102);
            this._projectEndDate.Name = "_projectEndDate";
            this._projectEndDate.Size = new System.Drawing.Size(163, 20);
            this._projectEndDate.TabIndex = 47;
            // 
            // _projectBeginDate
            // 
            this._projectBeginDate.Location = new System.Drawing.Point(170, 62);
            this._projectBeginDate.Name = "_projectBeginDate";
            this._projectBeginDate.Size = new System.Drawing.Size(163, 20);
            this._projectBeginDate.TabIndex = 46;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(170, 29);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(163, 20);
            this.ProjectName.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Team Leader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Project Name";
            // 
            // _removeMemberInProjectBtn
            // 
            this._removeMemberInProjectBtn.Location = new System.Drawing.Point(873, 325);
            this._removeMemberInProjectBtn.Name = "_removeMemberInProjectBtn";
            this._removeMemberInProjectBtn.Size = new System.Drawing.Size(145, 23);
            this._removeMemberInProjectBtn.TabIndex = 54;
            this._removeMemberInProjectBtn.Text = "Remove From Project";
            this._removeMemberInProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(805, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Member In This Project";
            // 
            // _dgMemberInProject
            // 
            this._dgMemberInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgMemberInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName2,
            this.columnLastName2,
            this.columnMail2});
            this._dgMemberInProject.Location = new System.Drawing.Point(696, 224);
            this._dgMemberInProject.Name = "_dgMemberInProject";
            this._dgMemberInProject.Size = new System.Drawing.Size(345, 95);
            this._dgMemberInProject.TabIndex = 52;
            // 
            // columnFirstName2
            // 
            this.columnFirstName2.HeaderText = "First Name";
            this.columnFirstName2.Name = "columnFirstName2";
            // 
            // columnLastName2
            // 
            this.columnLastName2.HeaderText = "Last Name";
            this.columnLastName2.Name = "columnLastName2";
            // 
            // columnMail2
            // 
            this.columnMail2.HeaderText = "Mail";
            this.columnMail2.Name = "columnMail2";
            // 
            // _changeLeaderBtn
            // 
            this._changeLeaderBtn.Location = new System.Drawing.Point(728, 325);
            this._changeLeaderBtn.Name = "_changeLeaderBtn";
            this._changeLeaderBtn.Size = new System.Drawing.Size(101, 23);
            this._changeLeaderBtn.TabIndex = 57;
            this._changeLeaderBtn.Text = "Change Leader";
            this._changeLeaderBtn.UseVisualStyleBackColor = true;
            // 
            // _updateProjectBtn
            // 
            this._updateProjectBtn.Location = new System.Drawing.Point(783, 448);
            this._updateProjectBtn.Name = "_updateProjectBtn";
            this._updateProjectBtn.Size = new System.Drawing.Size(197, 44);
            this._updateProjectBtn.TabIndex = 56;
            this._updateProjectBtn.Text = "Update Project";
            this._updateProjectBtn.UseVisualStyleBackColor = true;
            // 
            // _addToProjectBtn
            // 
            this._addToProjectBtn.Location = new System.Drawing.Point(785, 154);
            this._addToProjectBtn.Name = "_addToProjectBtn";
            this._addToProjectBtn.Size = new System.Drawing.Size(145, 23);
            this._addToProjectBtn.TabIndex = 60;
            this._addToProjectBtn.Text = "Add To Project";
            this._addToProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(792, -41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Member In This Project";
            // 
            // _dgEmployees
            // 
            this._dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this._dgEmployees.Location = new System.Drawing.Point(685, 53);
            this._dgEmployees.Name = "_dgEmployees";
            this._dgEmployees.Size = new System.Drawing.Size(345, 95);
            this._dgEmployees.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(805, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Employee List";
            // 
            // _refreshPageBtn
            // 
            this._refreshPageBtn.Location = new System.Drawing.Point(785, 498);
            this._refreshPageBtn.Name = "_refreshPageBtn";
            this._refreshPageBtn.Size = new System.Drawing.Size(195, 44);
            this._refreshPageBtn.TabIndex = 63;
            this._refreshPageBtn.Text = "Refresh Page";
            this._refreshPageBtn.UseVisualStyleBackColor = true;
            // 
            // _dgTasks
            // 
            this._dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.endDate,
            this.project});
            this._dgTasks.Location = new System.Drawing.Point(19, 410);
            this._dgTasks.Name = "_dgTasks";
            this._dgTasks.Size = new System.Drawing.Size(343, 149);
            this._dgTasks.TabIndex = 67;
            // 
            // taskName
            // 
            this.taskName.HeaderText = "Task Name";
            this.taskName.Name = "taskName";
            this.taskName.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End Date";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // project
            // 
            this.project.HeaderText = "Project";
            this.project.Name = "project";
            this.project.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "SubTasks Of The Selected Task";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tasks Of The Selected Project";
            // 
            // _dgSubTasks
            // 
            this._dgSubTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgSubTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTaskName,
            this.endDateSubTask,
            this.worker});
            this._dgSubTasks.Location = new System.Drawing.Point(434, 410);
            this._dgSubTasks.Name = "_dgSubTasks";
            this._dgSubTasks.Size = new System.Drawing.Size(343, 149);
            this._dgSubTasks.TabIndex = 64;
            // 
            // subTaskName
            // 
            this.subTaskName.HeaderText = "SubTask Name";
            this.subTaskName.Name = "subTaskName";
            this.subTaskName.ReadOnly = true;
            // 
            // endDateSubTask
            // 
            this.endDateSubTask.HeaderText = "End Date";
            this.endDateSubTask.Name = "endDateSubTask";
            this.endDateSubTask.ReadOnly = true;
            // 
            // worker
            // 
            this.worker.HeaderText = "Worker";
            this.worker.Name = "worker";
            this.worker.ReadOnly = true;
            // 
            // DetailProjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this._dgTasks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this._dgSubTasks);
            this.Controls.Add(this._refreshPageBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._addToProjectBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._dgEmployees);
            this.Controls.Add(this._removeMemberInProjectBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._dgMemberInProject);
            this.Controls.Add(this._changeLeaderBtn);
            this.Controls.Add(this._updateProjectBtn);
            this.Controls.Add(this._lastNameLbl);
            this.Controls.Add(this._mailLbl);
            this.Controls.Add(this._addressIPLbl);
            this.Controls.Add(this._firstNameLbl);
            this.Controls.Add(this._projectEndDate);
            this.Controls.Add(this._projectBeginDate);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailProjectUC";
            this.Size = new System.Drawing.Size(1004, 610);
            ((System.ComponentModel.ISupportInitialize)(this._dgMemberInProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _addressIPLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail2;
        public System.Windows.Forms.Label _firstNameLbl;
        public System.Windows.Forms.TextBox ProjectName;
        internal System.Windows.Forms.DateTimePicker _projectBeginDate;
        internal System.Windows.Forms.DateTimePicker _projectEndDate;
        internal System.Windows.Forms.Label _lastNameLbl;
        internal System.Windows.Forms.Label _mailLbl;
        internal System.Windows.Forms.DataGridView _dgMemberInProject;
        internal System.Windows.Forms.Button _updateProjectBtn;
        internal System.Windows.Forms.Button _removeMemberInProjectBtn;
        internal System.Windows.Forms.Button _addToProjectBtn;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.DataGridView _dgEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button _refreshPageBtn;
        internal System.Windows.Forms.Button _changeLeaderBtn;
        internal System.Windows.Forms.DataGridView _dgTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.DataGridView _dgSubTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateSubTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
    }
}
