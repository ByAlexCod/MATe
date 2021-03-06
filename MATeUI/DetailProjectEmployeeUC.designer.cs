﻿namespace MATeUI
{
    partial class DetailProjectEmployeeUC
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
            this._dgSubTasks = new System.Windows.Forms.DataGridView();
            this.subTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateSubTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._toDoRbtn = new System.Windows.Forms.RadioButton();
            this._doRbtn = new System.Windows.Forms.RadioButton();
            this._inProgressRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this._changeSubTaskBtn = new System.Windows.Forms.Button();
            this.panelStateSubTask = new System.Windows.Forms.Panel();
            this._dgTasks = new System.Windows.Forms.DataGridView();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._taskGbx = new System.Windows.Forms.GroupBox();
            this._modifyTaskBtn = new System.Windows.Forms.Button();
            this._deleteTaskBtn = new System.Windows.Forms.Button();
            this.endDateTaskDpk = new System.Windows.Forms.DateTimePicker();
            this._validateTaskBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._taskNameTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._createTaskBtn = new System.Windows.Forms.Button();
            this._subTaskGbx = new System.Windows.Forms.GroupBox();
            this._modifySubTaskBtn = new System.Windows.Forms.Button();
            this._deleteSubTaskBtn = new System.Windows.Forms.Button();
            this._validateProjectBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this._projectMembers = new System.Windows.Forms.ComboBox();
            this.endSubTaskDpk = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.subTaskNameTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._createSubTaskBtn = new System.Windows.Forms.Button();
            this.sendFileOrMessageUCOnDetailUIEmployee = new MATeUI.SendFileOrMessageUC();
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).BeginInit();
            this.panelStateSubTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).BeginInit();
            this._taskGbx.SuspendLayout();
            this._subTaskGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgSubTasks
            // 
            this._dgSubTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgSubTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTaskName,
            this.endDateSubTask,
            this.worker});
            this._dgSubTasks.Location = new System.Drawing.Point(34, 562);
            this._dgSubTasks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgSubTasks.Name = "_dgSubTasks";
            this._dgSubTasks.Size = new System.Drawing.Size(686, 285);
            this._dgSubTasks.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasks Of The Selected Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTasks Of The Selected Task";
            // 
            // _toDoRbtn
            // 
            this._toDoRbtn.AutoSize = true;
            this._toDoRbtn.Location = new System.Drawing.Point(18, 140);
            this._toDoRbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._toDoRbtn.Name = "_toDoRbtn";
            this._toDoRbtn.Size = new System.Drawing.Size(101, 29);
            this._toDoRbtn.TabIndex = 4;
            this._toDoRbtn.TabStop = true;
            this._toDoRbtn.Text = "To Do";
            this._toDoRbtn.UseVisualStyleBackColor = true;
            // 
            // _doRbtn
            // 
            this._doRbtn.AutoSize = true;
            this._doRbtn.Location = new System.Drawing.Point(468, 140);
            this._doRbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._doRbtn.Name = "_doRbtn";
            this._doRbtn.Size = new System.Drawing.Size(94, 29);
            this._doRbtn.TabIndex = 5;
            this._doRbtn.TabStop = true;
            this._doRbtn.Text = "Done";
            this._doRbtn.UseVisualStyleBackColor = true;
            // 
            // _inProgressRbtn
            // 
            this._inProgressRbtn.AutoSize = true;
            this._inProgressRbtn.Location = new System.Drawing.Point(224, 140);
            this._inProgressRbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._inProgressRbtn.Name = "_inProgressRbtn";
            this._inProgressRbtn.Size = new System.Drawing.Size(152, 29);
            this._inProgressRbtn.TabIndex = 6;
            this._inProgressRbtn.TabStop = true;
            this._inProgressRbtn.Text = "In Progress";
            this._inProgressRbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "States of The Selected  SubTask";
            // 
            // _changeSubTaskBtn
            // 
            this._changeSubTaskBtn.Location = new System.Drawing.Point(140, 217);
            this._changeSubTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._changeSubTaskBtn.Name = "_changeSubTaskBtn";
            this._changeSubTaskBtn.Size = new System.Drawing.Size(366, 44);
            this._changeSubTaskBtn.TabIndex = 8;
            this._changeSubTaskBtn.Text = "Change State Of The  SubTask";
            this._changeSubTaskBtn.UseVisualStyleBackColor = true;
            // 
            // panelStateSubTask
            // 
            this.panelStateSubTask.Controls.Add(this.label3);
            this.panelStateSubTask.Controls.Add(this._toDoRbtn);
            this.panelStateSubTask.Controls.Add(this._changeSubTaskBtn);
            this.panelStateSubTask.Controls.Add(this._doRbtn);
            this.panelStateSubTask.Controls.Add(this._inProgressRbtn);
            this.panelStateSubTask.Location = new System.Drawing.Point(84, 858);
            this.panelStateSubTask.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelStateSubTask.Name = "panelStateSubTask";
            this.panelStateSubTask.Size = new System.Drawing.Size(610, 285);
            this.panelStateSubTask.TabIndex = 10;
            // 
            // _dgTasks
            // 
            this._dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.endDate,
            this.project});
            this._dgTasks.Location = new System.Drawing.Point(34, 127);
            this._dgTasks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._dgTasks.Name = "_dgTasks";
            this._dgTasks.Size = new System.Drawing.Size(686, 288);
            this._dgTasks.TabIndex = 11;
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
            // _taskGbx
            // 
            this._taskGbx.Controls.Add(this._modifyTaskBtn);
            this._taskGbx.Controls.Add(this._deleteTaskBtn);
            this._taskGbx.Controls.Add(this.endDateTaskDpk);
            this._taskGbx.Controls.Add(this._validateTaskBtn);
            this._taskGbx.Controls.Add(this.label5);
            this._taskGbx.Controls.Add(this._taskNameTbx);
            this._taskGbx.Controls.Add(this.label4);
            this._taskGbx.Controls.Add(this._createTaskBtn);
            this._taskGbx.Location = new System.Drawing.Point(732, 127);
            this._taskGbx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._taskGbx.Name = "_taskGbx";
            this._taskGbx.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._taskGbx.Size = new System.Drawing.Size(556, 373);
            this._taskGbx.TabIndex = 13;
            this._taskGbx.TabStop = false;
            this._taskGbx.Text = "Create New Task";
            // 
            // _modifyTaskBtn
            // 
            this._modifyTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._modifyTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._modifyTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._modifyTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._modifyTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._modifyTaskBtn.Location = new System.Drawing.Point(202, 204);
            this._modifyTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._modifyTaskBtn.Name = "_modifyTaskBtn";
            this._modifyTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._modifyTaskBtn.TabIndex = 17;
            this._modifyTaskBtn.Text = "Modify";
            this._modifyTaskBtn.UseVisualStyleBackColor = true;
            // 
            // _deleteTaskBtn
            // 
            this._deleteTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._deleteTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._deleteTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._deleteTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._deleteTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._deleteTaskBtn.Location = new System.Drawing.Point(376, 204);
            this._deleteTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._deleteTaskBtn.Name = "_deleteTaskBtn";
            this._deleteTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._deleteTaskBtn.TabIndex = 16;
            this._deleteTaskBtn.Text = "Delete";
            this._deleteTaskBtn.UseVisualStyleBackColor = true;
            // 
            // endDateTaskDpk
            // 
            this.endDateTaskDpk.Location = new System.Drawing.Point(202, 131);
            this.endDateTaskDpk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.endDateTaskDpk.Name = "endDateTaskDpk";
            this.endDateTaskDpk.Size = new System.Drawing.Size(320, 31);
            this.endDateTaskDpk.TabIndex = 4;
            // 
            // _validateTaskBtn
            // 
            this._validateTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._validateTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._validateTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._validateTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._validateTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._validateTaskBtn.Location = new System.Drawing.Point(164, 288);
            this._validateTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._validateTaskBtn.Name = "_validateTaskBtn";
            this._validateTaskBtn.Size = new System.Drawing.Size(362, 73);
            this._validateTaskBtn.TabIndex = 15;
            this._validateTaskBtn.Text = "Validate Selected Task";
            this._validateTaskBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "End Date";
            // 
            // _taskNameTbx
            // 
            this._taskNameTbx.Location = new System.Drawing.Point(202, 54);
            this._taskNameTbx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._taskNameTbx.Name = "_taskNameTbx";
            this._taskNameTbx.Size = new System.Drawing.Size(320, 31);
            this._taskNameTbx.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Task Name";
            // 
            // _createTaskBtn
            // 
            this._createTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._createTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._createTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._createTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._createTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._createTaskBtn.Location = new System.Drawing.Point(18, 204);
            this._createTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._createTaskBtn.Name = "_createTaskBtn";
            this._createTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._createTaskBtn.TabIndex = 0;
            this._createTaskBtn.Text = "Create";
            this._createTaskBtn.UseVisualStyleBackColor = true;
            // 
            // _subTaskGbx
            // 
            this._subTaskGbx.Controls.Add(this._modifySubTaskBtn);
            this._subTaskGbx.Controls.Add(this._deleteSubTaskBtn);
            this._subTaskGbx.Controls.Add(this.label8);
            this._subTaskGbx.Controls.Add(this._projectMembers);
            this._subTaskGbx.Controls.Add(this.endSubTaskDpk);
            this._subTaskGbx.Controls.Add(this.label6);
            this._subTaskGbx.Controls.Add(this.subTaskNameTbx);
            this._subTaskGbx.Controls.Add(this.label7);
            this._subTaskGbx.Controls.Add(this._createSubTaskBtn);
            this._subTaskGbx.Location = new System.Drawing.Point(732, 562);
            this._subTaskGbx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._subTaskGbx.Name = "_subTaskGbx";
            this._subTaskGbx.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._subTaskGbx.Size = new System.Drawing.Size(556, 333);
            this._subTaskGbx.TabIndex = 14;
            this._subTaskGbx.TabStop = false;
            this._subTaskGbx.Text = "Create New Sub Task";
            // 
            // _modifySubTaskBtn
            // 
            this._modifySubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._modifySubTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._modifySubTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._modifySubTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._modifySubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._modifySubTaskBtn.Location = new System.Drawing.Point(202, 275);
            this._modifySubTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._modifySubTaskBtn.Name = "_modifySubTaskBtn";
            this._modifySubTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._modifySubTaskBtn.TabIndex = 18;
            this._modifySubTaskBtn.Text = "Modify";
            this._modifySubTaskBtn.UseVisualStyleBackColor = true;
            // 
            // _deleteSubTaskBtn
            // 
            this._deleteSubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._deleteSubTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._deleteSubTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._deleteSubTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._deleteSubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._deleteSubTaskBtn.Location = new System.Drawing.Point(376, 275);
            this._deleteSubTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._deleteSubTaskBtn.Name = "_deleteSubTaskBtn";
            this._deleteSubTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._deleteSubTaskBtn.TabIndex = 17;
            this._deleteSubTaskBtn.Text = "Delete";
            this._deleteSubTaskBtn.UseVisualStyleBackColor = true;
            // 
            // _validateProjectBtn
            // 
            this._validateProjectBtn.Location = new System.Drawing.Point(1879, 1028);
            this._validateProjectBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._validateProjectBtn.Name = "_validateProjectBtn";
            this._validateProjectBtn.Size = new System.Drawing.Size(308, 69);
            this._validateProjectBtn.TabIndex = 16;
            this._validateProjectBtn.Text = "Validate Selected Project";
            this._validateProjectBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Project Members";
            // 
            // _projectMembers
            // 
            this._projectMembers.FormattingEnabled = true;
            this._projectMembers.Location = new System.Drawing.Point(202, 194);
            this._projectMembers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._projectMembers.Name = "_projectMembers";
            this._projectMembers.Size = new System.Drawing.Size(320, 33);
            this._projectMembers.TabIndex = 5;
            // 
            // endSubTaskDpk
            // 
            this.endSubTaskDpk.Location = new System.Drawing.Point(202, 121);
            this.endSubTaskDpk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.endSubTaskDpk.Name = "endSubTaskDpk";
            this.endSubTaskDpk.Size = new System.Drawing.Size(320, 31);
            this.endSubTaskDpk.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "End Date";
            // 
            // subTaskNameTbx
            // 
            this.subTaskNameTbx.Location = new System.Drawing.Point(202, 50);
            this.subTaskNameTbx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.subTaskNameTbx.Name = "subTaskNameTbx";
            this.subTaskNameTbx.Size = new System.Drawing.Size(320, 31);
            this.subTaskNameTbx.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sub Task Name";
            // 
            // _createSubTaskBtn
            // 
            this._createSubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._createSubTaskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._createSubTaskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._createSubTaskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._createSubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._createSubTaskBtn.Location = new System.Drawing.Point(18, 275);
            this._createSubTaskBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._createSubTaskBtn.Name = "_createSubTaskBtn";
            this._createSubTaskBtn.Size = new System.Drawing.Size(150, 44);
            this._createSubTaskBtn.TabIndex = 0;
            this._createSubTaskBtn.Text = "Create";
            this._createSubTaskBtn.UseVisualStyleBackColor = true;
            // 
            // sendFileOrMessageUCOnDetailUIEmployee
            // 
            this.sendFileOrMessageUCOnDetailUIEmployee.Location = new System.Drawing.Point(952, 65);
            this.sendFileOrMessageUCOnDetailUIEmployee.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.sendFileOrMessageUCOnDetailUIEmployee.Name = "sendFileOrMessageUCOnDetailUIEmployee";
            this.sendFileOrMessageUCOnDetailUIEmployee.Size = new System.Drawing.Size(1680, 917);
            this.sendFileOrMessageUCOnDetailUIEmployee.TabIndex = 12;
            // 
            // DetailProjectEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._subTaskGbx);
            this.Controls.Add(this._taskGbx);
            this.Controls.Add(this._validateProjectBtn);
            this.Controls.Add(this.sendFileOrMessageUCOnDetailUIEmployee);
            this.Controls.Add(this._dgTasks);
            this.Controls.Add(this.panelStateSubTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dgSubTasks);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DetailProjectEmployeeUC";
            this.Size = new System.Drawing.Size(2718, 1127);
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).EndInit();
            this.panelStateSubTask.ResumeLayout(false);
            this.panelStateSubTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).EndInit();
            this._taskGbx.ResumeLayout(false);
            this._taskGbx.PerformLayout();
            this._subTaskGbx.ResumeLayout(false);
            this._subTaskGbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView _dgSubTasks;
        internal System.Windows.Forms.Panel panelStateSubTask;
        internal System.Windows.Forms.Button _changeSubTaskBtn;
        internal System.Windows.Forms.RadioButton _toDoRbtn;
        internal System.Windows.Forms.RadioButton _doRbtn;
        internal System.Windows.Forms.RadioButton _inProgressRbtn;
        internal System.Windows.Forms.DataGridView _dgTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateSubTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        internal System.Windows.Forms.GroupBox _taskGbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button _createTaskBtn;
        internal System.Windows.Forms.GroupBox _subTaskGbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button _createSubTaskBtn;
        internal System.Windows.Forms.DateTimePicker endDateTaskDpk;
        internal System.Windows.Forms.TextBox _taskNameTbx;
        internal System.Windows.Forms.DateTimePicker endSubTaskDpk;
        internal System.Windows.Forms.TextBox subTaskNameTbx;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox _projectMembers;
        internal System.Windows.Forms.Button _validateTaskBtn;
        internal System.Windows.Forms.Button _validateProjectBtn;
        internal System.Windows.Forms.Button _deleteTaskBtn;
        internal System.Windows.Forms.Button _deleteSubTaskBtn;
        internal System.Windows.Forms.Button _modifyTaskBtn;
        internal System.Windows.Forms.Button _modifySubTaskBtn;
        internal SendFileOrMessageUC sendFileOrMessageUCOnDetailUIEmployee;
    }
}
