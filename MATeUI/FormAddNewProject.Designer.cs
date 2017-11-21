namespace MATeUI
{
    partial class FormAddNewProject
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
            this._createBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._changeLeaderBtn = new System.Windows.Forms.Button();
            this.columnMail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._removeMemberInProjectBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this._dgEmployees = new System.Windows.Forms.DataGridView();
            this._lastNameLbl = new System.Windows.Forms.Label();
            this._mailLbl = new System.Windows.Forms.Label();
            this._addressIPLbl = new System.Windows.Forms.Label();
            this._firstNameLbl = new System.Windows.Forms.Label();
            this._projectEndDate = new System.Windows.Forms.DateTimePicker();
            this._projectBeginDate = new System.Windows.Forms.DateTimePicker();
            this._projectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._dgMembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // _createBtn
            // 
            this._createBtn.Location = new System.Drawing.Point(136, 410);
            this._createBtn.Name = "_createBtn";
            this._createBtn.Size = new System.Drawing.Size(75, 23);
            this._createBtn.TabIndex = 3;
            this._createBtn.Text = "Create";
            this._createBtn.UseVisualStyleBackColor = true;
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Location = new System.Drawing.Point(256, 410);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(75, 23);
            this._cancelBtn.TabIndex = 4;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // _changeLeaderBtn
            // 
            this._changeLeaderBtn.Location = new System.Drawing.Point(691, 381);
            this._changeLeaderBtn.Name = "_changeLeaderBtn";
            this._changeLeaderBtn.Size = new System.Drawing.Size(101, 23);
            this._changeLeaderBtn.TabIndex = 78;
            this._changeLeaderBtn.Text = "Change Leader";
            this._changeLeaderBtn.UseVisualStyleBackColor = true;
            // 
            // columnMail2
            // 
            this.columnMail2.HeaderText = "Mail";
            this.columnMail2.Name = "columnMail2";
            // 
            // columnLastName2
            // 
            this.columnLastName2.HeaderText = "Last Name";
            this.columnLastName2.Name = "columnLastName2";
            // 
            // columnFirstName2
            // 
            this.columnFirstName2.HeaderText = "First Name";
            this.columnFirstName2.Name = "columnFirstName2";
            // 
            // _removeMemberInProjectBtn
            // 
            this._removeMemberInProjectBtn.Location = new System.Drawing.Point(824, 381);
            this._removeMemberInProjectBtn.Name = "_removeMemberInProjectBtn";
            this._removeMemberInProjectBtn.Size = new System.Drawing.Size(145, 23);
            this._removeMemberInProjectBtn.TabIndex = 75;
            this._removeMemberInProjectBtn.Text = "Remove From Project";
            this._removeMemberInProjectBtn.UseVisualStyleBackColor = true;
            this._removeMemberInProjectBtn.Click += new System.EventHandler(this._removeMemberInProjectBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Member In This Project";
            // 
            // _dgEmployees
            // 
            this._dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName2,
            this.columnLastName2,
            this.columnMail2});
            this._dgEmployees.Location = new System.Drawing.Point(647, 72);
            this._dgEmployees.Name = "_dgEmployees";
            this._dgEmployees.Size = new System.Drawing.Size(345, 95);
            this._dgEmployees.TabIndex = 73;
            // 
            // _lastNameLbl
            // 
            this._lastNameLbl.AutoSize = true;
            this._lastNameLbl.Location = new System.Drawing.Point(150, 201);
            this._lastNameLbl.Name = "_lastNameLbl";
            this._lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this._lastNameLbl.TabIndex = 72;
            this._lastNameLbl.Text = "------------------";
            // 
            // _mailLbl
            // 
            this._mailLbl.AutoSize = true;
            this._mailLbl.Location = new System.Drawing.Point(150, 235);
            this._mailLbl.Name = "_mailLbl";
            this._mailLbl.Size = new System.Drawing.Size(52, 13);
            this._mailLbl.TabIndex = 71;
            this._mailLbl.Text = "---------------";
            // 
            // _addressIPLbl
            // 
            this._addressIPLbl.AutoSize = true;
            this._addressIPLbl.Location = new System.Drawing.Point(150, 269);
            this._addressIPLbl.Name = "_addressIPLbl";
            this._addressIPLbl.Size = new System.Drawing.Size(52, 13);
            this._addressIPLbl.TabIndex = 70;
            this._addressIPLbl.Text = "---------------";
            // 
            // _firstNameLbl
            // 
            this._firstNameLbl.AutoSize = true;
            this._firstNameLbl.Location = new System.Drawing.Point(150, 168);
            this._firstNameLbl.Name = "_firstNameLbl";
            this._firstNameLbl.Size = new System.Drawing.Size(64, 13);
            this._firstNameLbl.TabIndex = 69;
            this._firstNameLbl.Text = "-------------------";
            // 
            // _projectEndDate
            // 
            this._projectEndDate.Location = new System.Drawing.Point(153, 91);
            this._projectEndDate.Name = "_projectEndDate";
            this._projectEndDate.Size = new System.Drawing.Size(163, 20);
            this._projectEndDate.TabIndex = 68;
            // 
            // _projectBeginDate
            // 
            this._projectBeginDate.Location = new System.Drawing.Point(153, 51);
            this._projectBeginDate.Name = "_projectBeginDate";
            this._projectBeginDate.Size = new System.Drawing.Size(163, 20);
            this._projectBeginDate.TabIndex = 67;
            // 
            // _projectName
            // 
            this._projectName.Location = new System.Drawing.Point(153, 18);
            this._projectName.Name = "_projectName";
            this._projectName.Size = new System.Drawing.Size(163, 20);
            this._projectName.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Team Leader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Project Name";
            // 
            // _dgMembers
            // 
            this._dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this._dgMembers.Location = new System.Drawing.Point(647, 269);
            this._dgMembers.Name = "_dgMembers";
            this._dgMembers.Size = new System.Drawing.Size(345, 95);
            this._dgMembers.TabIndex = 79;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "Add To Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Employee List";
            // 
            // FormAddNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._dgMembers);
            this.Controls.Add(this._changeLeaderBtn);
            this.Controls.Add(this._removeMemberInProjectBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._dgEmployees);
            this.Controls.Add(this._lastNameLbl);
            this.Controls.Add(this._mailLbl);
            this.Controls.Add(this._addressIPLbl);
            this.Controls.Add(this._firstNameLbl);
            this.Controls.Add(this._projectEndDate);
            this.Controls.Add(this._projectBeginDate);
            this.Controls.Add(this._projectName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._createBtn);
            this.Name = "FormAddNewProject";
            this.Text = "FormAddNewProject";
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _createBtn;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.Button _changeLeaderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName2;
        private System.Windows.Forms.Button _removeMemberInProjectBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView _dgEmployees;
        private System.Windows.Forms.Label _lastNameLbl;
        private System.Windows.Forms.Label _mailLbl;
        private System.Windows.Forms.Label _addressIPLbl;
        private System.Windows.Forms.Label _firstNameLbl;
        private System.Windows.Forms.DateTimePicker _projectEndDate;
        private System.Windows.Forms.DateTimePicker _projectBeginDate;
        private System.Windows.Forms.TextBox _projectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dgMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}