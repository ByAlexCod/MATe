namespace MATeUI
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
            this.subTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateSubTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendFileOrMessageUCOnDetailUIEmployee = new MATeUI.SendFileOrMessageUC();
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).BeginInit();
            this.panelStateSubTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgSubTasks
            // 
            this._dgSubTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgSubTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTaskName,
            this.endDateSubTask,
            this.worker});
            this._dgSubTasks.Location = new System.Drawing.Point(17, 292);
            this._dgSubTasks.Name = "_dgSubTasks";
            this._dgSubTasks.Size = new System.Drawing.Size(343, 148);
            this._dgSubTasks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tasks Of The Selected Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTasks Of The Selected Task";
            // 
            // _toDoRbtn
            // 
            this._toDoRbtn.AutoSize = true;
            this._toDoRbtn.Location = new System.Drawing.Point(9, 73);
            this._toDoRbtn.Name = "_toDoRbtn";
            this._toDoRbtn.Size = new System.Drawing.Size(55, 17);
            this._toDoRbtn.TabIndex = 4;
            this._toDoRbtn.TabStop = true;
            this._toDoRbtn.Text = "To Do";
            this._toDoRbtn.UseVisualStyleBackColor = true;
            // 
            // _doRbtn
            // 
            this._doRbtn.AutoSize = true;
            this._doRbtn.Location = new System.Drawing.Point(234, 73);
            this._doRbtn.Name = "_doRbtn";
            this._doRbtn.Size = new System.Drawing.Size(51, 17);
            this._doRbtn.TabIndex = 5;
            this._doRbtn.TabStop = true;
            this._doRbtn.Text = "Done";
            this._doRbtn.UseVisualStyleBackColor = true;
            // 
            // _inProgressRbtn
            // 
            this._inProgressRbtn.AutoSize = true;
            this._inProgressRbtn.Location = new System.Drawing.Point(112, 73);
            this._inProgressRbtn.Name = "_inProgressRbtn";
            this._inProgressRbtn.Size = new System.Drawing.Size(78, 17);
            this._inProgressRbtn.TabIndex = 6;
            this._inProgressRbtn.TabStop = true;
            this._inProgressRbtn.Text = "In Progress";
            this._inProgressRbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "States of The Selected  SubTask";
            // 
            // _changeSubTaskBtn
            // 
            this._changeSubTaskBtn.Location = new System.Drawing.Point(70, 113);
            this._changeSubTaskBtn.Name = "_changeSubTaskBtn";
            this._changeSubTaskBtn.Size = new System.Drawing.Size(183, 23);
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
            this.panelStateSubTask.Location = new System.Drawing.Point(42, 446);
            this.panelStateSubTask.Name = "panelStateSubTask";
            this.panelStateSubTask.Size = new System.Drawing.Size(305, 148);
            this.panelStateSubTask.TabIndex = 10;
            // 
            // _dgTasks
            // 
            this._dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.endDate,
            this.project});
            this._dgTasks.Location = new System.Drawing.Point(17, 66);
            this._dgTasks.Name = "_dgTasks";
            this._dgTasks.Size = new System.Drawing.Size(343, 150);
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
            // sendFileOrMessageUC1
            // 
            this.sendFileOrMessageUCOnDetailUIEmployee.Location = new System.Drawing.Point(476, 34);
            this.sendFileOrMessageUCOnDetailUIEmployee.Name = "sendFileOrMessageUC1";
            this.sendFileOrMessageUCOnDetailUIEmployee.Size = new System.Drawing.Size(840, 477);
            this.sendFileOrMessageUCOnDetailUIEmployee.TabIndex = 12;
            // 
            // DetailProjectEmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendFileOrMessageUCOnDetailUIEmployee);
            this.Controls.Add(this._dgTasks);
            this.Controls.Add(this.panelStateSubTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dgSubTasks);
            this.Name = "DetailProjectEmployeeUC";
            this.Size = new System.Drawing.Size(1050, 586);
            ((System.ComponentModel.ISupportInitialize)(this._dgSubTasks)).EndInit();
            this.panelStateSubTask.ResumeLayout(false);
            this.panelStateSubTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgTasks)).EndInit();
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
        private SendFileOrMessageUC sendFileOrMessageUCOnDetailUIEmployee;
    }
}
