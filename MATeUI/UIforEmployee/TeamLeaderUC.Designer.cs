namespace MATeUI
{
    partial class TeamLeaderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewTaskBtn = new System.Windows.Forms.Button();
            this.NewSubBtn = new System.Windows.Forms.Button();
            this.panelStateSubTask = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this._toDoRbtn = new System.Windows.Forms.RadioButton();
            this.ChangeStateBtn = new System.Windows.Forms.Button();
            this._doRbtn = new System.Windows.Forms.RadioButton();
            this._inProgressRbtn = new System.Windows.Forms.RadioButton();
            this.panelStateSubTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(48, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 183);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Limit";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 80;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Location = new System.Drawing.Point(48, 329);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(411, 167);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Limit";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Member working";
            this.columnHeader6.Width = 127;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView3.Location = new System.Drawing.Point(629, 76);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(398, 183);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mail";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "First Name";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Last Name";
            this.columnHeader9.Width = 122;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Position";
            this.columnHeader10.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sub-Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Members";
            // 
            // NewTaskBtn
            // 
            this.NewTaskBtn.Location = new System.Drawing.Point(466, 76);
            this.NewTaskBtn.Name = "NewTaskBtn";
            this.NewTaskBtn.Size = new System.Drawing.Size(115, 23);
            this.NewTaskBtn.TabIndex = 6;
            this.NewTaskBtn.Text = "New Task";
            this.NewTaskBtn.UseVisualStyleBackColor = true;
            this.NewTaskBtn.Click += new System.EventHandler(this.NewTaskBtn_Click);
            // 
            // NewSubBtn
            // 
            this.NewSubBtn.Location = new System.Drawing.Point(466, 106);
            this.NewSubBtn.Name = "NewSubBtn";
            this.NewSubBtn.Size = new System.Drawing.Size(115, 23);
            this.NewSubBtn.TabIndex = 7;
            this.NewSubBtn.Text = "New Sub-Task";
            this.NewSubBtn.UseVisualStyleBackColor = true;
            this.NewSubBtn.Click += new System.EventHandler(this.NewSubBtn_Click);
            // 
            // panelStateSubTask
            // 
            this.panelStateSubTask.Controls.Add(this.label4);
            this.panelStateSubTask.Controls.Add(this._toDoRbtn);
            this.panelStateSubTask.Controls.Add(this.ChangeStateBtn);
            this.panelStateSubTask.Controls.Add(this._doRbtn);
            this.panelStateSubTask.Controls.Add(this._inProgressRbtn);
            this.panelStateSubTask.Location = new System.Drawing.Point(52, 503);
            this.panelStateSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.panelStateSubTask.Name = "panelStateSubTask";
            this.panelStateSubTask.Size = new System.Drawing.Size(407, 182);
            this.panelStateSubTask.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "States of The Selected  SubTask";
            // 
            // _toDoRbtn
            // 
            this._toDoRbtn.AutoSize = true;
            this._toDoRbtn.Location = new System.Drawing.Point(12, 90);
            this._toDoRbtn.Margin = new System.Windows.Forms.Padding(4);
            this._toDoRbtn.Name = "_toDoRbtn";
            this._toDoRbtn.Size = new System.Drawing.Size(68, 21);
            this._toDoRbtn.TabIndex = 4;
            this._toDoRbtn.TabStop = true;
            this._toDoRbtn.Text = "To Do";
            this._toDoRbtn.UseVisualStyleBackColor = true;
            // 
            // ChangeStateBtn
            // 
            this.ChangeStateBtn.Location = new System.Drawing.Point(93, 139);
            this.ChangeStateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeStateBtn.Name = "ChangeStateBtn";
            this.ChangeStateBtn.Size = new System.Drawing.Size(244, 28);
            this.ChangeStateBtn.TabIndex = 8;
            this.ChangeStateBtn.Text = "Change State Of The  SubTask";
            this.ChangeStateBtn.UseVisualStyleBackColor = true;
            // 
            // _doRbtn
            // 
            this._doRbtn.AutoSize = true;
            this._doRbtn.Location = new System.Drawing.Point(312, 90);
            this._doRbtn.Margin = new System.Windows.Forms.Padding(4);
            this._doRbtn.Name = "_doRbtn";
            this._doRbtn.Size = new System.Drawing.Size(63, 21);
            this._doRbtn.TabIndex = 5;
            this._doRbtn.TabStop = true;
            this._doRbtn.Text = "Done";
            this._doRbtn.UseVisualStyleBackColor = true;
            // 
            // _inProgressRbtn
            // 
            this._inProgressRbtn.AutoSize = true;
            this._inProgressRbtn.Location = new System.Drawing.Point(149, 90);
            this._inProgressRbtn.Margin = new System.Windows.Forms.Padding(4);
            this._inProgressRbtn.Name = "_inProgressRbtn";
            this._inProgressRbtn.Size = new System.Drawing.Size(101, 21);
            this._inProgressRbtn.TabIndex = 6;
            this._inProgressRbtn.TabStop = true;
            this._inProgressRbtn.Text = "In Progress";
            this._inProgressRbtn.UseVisualStyleBackColor = true;
            // 
            // TeamLeaderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStateSubTask);
            this.Controls.Add(this.NewSubBtn);
            this.Controls.Add(this.NewTaskBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "TeamLeaderUC";
            this.Size = new System.Drawing.Size(1172, 722);
            this.panelStateSubTask.ResumeLayout(false);
            this.panelStateSubTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewTaskBtn;
        private System.Windows.Forms.Button NewSubBtn;
        internal System.Windows.Forms.Panel panelStateSubTask;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.RadioButton _toDoRbtn;
        internal System.Windows.Forms.Button ChangeStateBtn;
        internal System.Windows.Forms.RadioButton _doRbtn;
        internal System.Windows.Forms.RadioButton _inProgressRbtn;
    }
}
