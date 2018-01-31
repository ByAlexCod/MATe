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
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._validateProjectBtn = new System.Windows.Forms.Button();
            this._currentUserLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgMemberInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // _lastNameLbl
            // 
            this._lastNameLbl.AutoSize = true;
            this._lastNameLbl.Location = new System.Drawing.Point(248, 268);
            this._lastNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._lastNameLbl.Name = "_lastNameLbl";
            this._lastNameLbl.Size = new System.Drawing.Size(138, 25);
            this._lastNameLbl.TabIndex = 51;
            this._lastNameLbl.Text = "------------------";
            // 
            // _mailLbl
            // 
            this._mailLbl.AutoSize = true;
            this._mailLbl.Location = new System.Drawing.Point(414, 328);
            this._mailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._mailLbl.Name = "_mailLbl";
            this._mailLbl.Size = new System.Drawing.Size(117, 25);
            this._mailLbl.TabIndex = 50;
            this._mailLbl.Text = "---------------";
            // 
            // _addressIPLbl
            // 
            this._addressIPLbl.AutoSize = true;
            this._addressIPLbl.Location = new System.Drawing.Point(414, 383);
            this._addressIPLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._addressIPLbl.Name = "_addressIPLbl";
            this._addressIPLbl.Size = new System.Drawing.Size(117, 25);
            this._addressIPLbl.TabIndex = 49;
            this._addressIPLbl.Text = "---------------";
            // 
            // _firstNameLbl
            // 
            this._firstNameLbl.AutoSize = true;
            this._firstNameLbl.Location = new System.Drawing.Point(414, 268);
            this._firstNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._firstNameLbl.Name = "_firstNameLbl";
            this._firstNameLbl.Size = new System.Drawing.Size(145, 25);
            this._firstNameLbl.TabIndex = 48;
            this._firstNameLbl.Text = "-------------------";
            // 
            // _projectEndDate
            // 
            this._projectEndDate.Location = new System.Drawing.Point(227, 181);
            this._projectEndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._projectEndDate.Name = "_projectEndDate";
            this._projectEndDate.Size = new System.Drawing.Size(322, 31);
            this._projectEndDate.TabIndex = 47;
            // 
            // _projectBeginDate
            // 
            this._projectBeginDate.Location = new System.Drawing.Point(227, 131);
            this._projectBeginDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._projectBeginDate.Name = "_projectBeginDate";
            this._projectBeginDate.Size = new System.Drawing.Size(322, 31);
            this._projectBeginDate.TabIndex = 46;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(227, 81);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(322, 31);
            this.ProjectName.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Team Leader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Project Name";
            // 
            // _removeMemberInProjectBtn
            // 
            this._removeMemberInProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._removeMemberInProjectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._removeMemberInProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._removeMemberInProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._removeMemberInProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeMemberInProjectBtn.Location = new System.Drawing.Point(967, 889);
            this._removeMemberInProjectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._removeMemberInProjectBtn.Name = "_removeMemberInProjectBtn";
            this._removeMemberInProjectBtn.Size = new System.Drawing.Size(290, 44);
            this._removeMemberInProjectBtn.TabIndex = 54;
            this._removeMemberInProjectBtn.Text = "Remove From Project";
            this._removeMemberInProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(822, 462);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 25);
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
            this._dgMemberInProject.Location = new System.Drawing.Point(604, 517);
            this._dgMemberInProject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgMemberInProject.Name = "_dgMemberInProject";
            this._dgMemberInProject.Size = new System.Drawing.Size(690, 325);
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
            this._changeLeaderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._changeLeaderBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._changeLeaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._changeLeaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._changeLeaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._changeLeaderBtn.Location = new System.Drawing.Point(656, 889);
            this._changeLeaderBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._changeLeaderBtn.Name = "_changeLeaderBtn";
            this._changeLeaderBtn.Size = new System.Drawing.Size(202, 44);
            this._changeLeaderBtn.TabIndex = 57;
            this._changeLeaderBtn.Text = "Change Leader";
            this._changeLeaderBtn.UseVisualStyleBackColor = true;
            // 
            // _updateProjectBtn
            // 
            this._updateProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._updateProjectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._updateProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._updateProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._updateProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._updateProjectBtn.Location = new System.Drawing.Point(294, 456);
            this._updateProjectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._updateProjectBtn.Name = "_updateProjectBtn";
            this._updateProjectBtn.Size = new System.Drawing.Size(170, 37);
            this._updateProjectBtn.TabIndex = 56;
            this._updateProjectBtn.Text = "Modify project";
            this._updateProjectBtn.UseVisualStyleBackColor = true;
            // 
            // _addToProjectBtn
            // 
            this._addToProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._addToProjectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._addToProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._addToProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._addToProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addToProjectBtn.Location = new System.Drawing.Point(782, 383);
            this._addToProjectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._addToProjectBtn.Name = "_addToProjectBtn";
            this._addToProjectBtn.Size = new System.Drawing.Size(290, 44);
            this._addToProjectBtn.TabIndex = 60;
            this._addToProjectBtn.Text = "Add To Project";
            this._addToProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1584, -79);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Member In This Project";
            // 
            // _dgEmployees
            // 
            this._dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ip});
            this._dgEmployees.Location = new System.Drawing.Point(607, 54);
            this._dgEmployees.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgEmployees.Name = "_dgEmployees";
            this._dgEmployees.Size = new System.Drawing.Size(690, 299);
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
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(825, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 25);
            this.label12.TabIndex = 62;
            this.label12.Text = "Employee List";
            // 
            // _refreshPageBtn
            // 
            this._refreshPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._refreshPageBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._refreshPageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._refreshPageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._refreshPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._refreshPageBtn.Location = new System.Drawing.Point(6, 690);
            this._refreshPageBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._refreshPageBtn.Name = "_refreshPageBtn";
            this._refreshPageBtn.Size = new System.Drawing.Size(266, 62);
            this._refreshPageBtn.TabIndex = 63;
            this._refreshPageBtn.Text = "Refresh Page";
            this._refreshPageBtn.UseVisualStyleBackColor = true;
            this._refreshPageBtn.Click += new System.EventHandler(this._refreshPageBtn_Click);
            // 
            // _dgTasks
            // 
            this._dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.endDate,
            this.project});
            this._dgTasks.Location = new System.Drawing.Point(1396, 54);
            this._dgTasks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgTasks.Name = "_dgTasks";
            this._dgTasks.Size = new System.Drawing.Size(679, 299);
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
            this.label11.Location = new System.Drawing.Point(1592, 477);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 25);
            this.label11.TabIndex = 66;
            this.label11.Text = "SubTasks Of The Selected Task";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1592, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 25);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tasks Of The Selected Project";
            // 
            // _dgSubTasks
            // 
            this._dgSubTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgSubTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTaskName,
            this.endDateSubTask,
            this.worker,
            this.status});
            this._dgSubTasks.Location = new System.Drawing.Point(1396, 517);
            this._dgSubTasks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgSubTasks.Name = "_dgSubTasks";
            this._dgSubTasks.Size = new System.Drawing.Size(679, 325);
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
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // _validateProjectBtn
            // 
            this._validateProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._validateProjectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._validateProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._validateProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._validateProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._validateProjectBtn.Location = new System.Drawing.Point(6, 764);
            this._validateProjectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._validateProjectBtn.Name = "_validateProjectBtn";
            this._validateProjectBtn.Size = new System.Drawing.Size(266, 62);
            this._validateProjectBtn.TabIndex = 68;
            this._validateProjectBtn.Text = "End project";
            this._validateProjectBtn.UseVisualStyleBackColor = true;
            // 
            // _currentUserLbl
            // 
            this._currentUserLbl.AutoSize = true;
            this._currentUserLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._currentUserLbl.Location = new System.Drawing.Point(38, 8);
            this._currentUserLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._currentUserLbl.Name = "_currentUserLbl";
            this._currentUserLbl.Size = new System.Drawing.Size(198, 25);
            this._currentUserLbl.TabIndex = 69;
            this._currentUserLbl.Text = "///////////////////////////////";
            // 
            // DetailProjectUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this._currentUserLbl);
            this.Controls.Add(this._validateProjectBtn);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DetailProjectUC";
            this.Size = new System.Drawing.Size(2092, 951);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        internal System.Windows.Forms.Button _validateProjectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        internal System.Windows.Forms.Label _currentUserLbl;
    }
}
