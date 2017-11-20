namespace MATeUI
{
    partial class GestionProjet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DgMembers = new System.Windows.Forms.DataGridView();
            this.columnFirstName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddressIP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.addMemberToProjectBtn = new System.Windows.Forms.Button();
            this.DgMemberInProject = new System.Windows.Forms.DataGridView();
            this.columnFirstName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.removeMemberInProjectBtn = new System.Windows.Forms.Button();
            this.projectName = new System.Windows.Forms.TextBox();
            this.projectBeginDate = new System.Windows.Forms.DateTimePicker();
            this.projectEndDate = new System.Windows.Forms.DateTimePicker();
            this.DgTasks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.addressIPLbl = new System.Windows.Forms.Label();
            this.mailLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.changeLeaderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMemberInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTasks)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Begin Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team Leader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "IP Address";
            // 
            // DgMembers
            // 
            this.DgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName1,
            this.columnLastName1,
            this.columnMail1,
            this.columnAddressIP1});
            this.DgMembers.Location = new System.Drawing.Point(560, 59);
            this.DgMembers.Name = "DgMembers";
            this.DgMembers.Size = new System.Drawing.Size(448, 106);
            this.DgMembers.TabIndex = 8;
            // 
            // columnFirstName1
            // 
            this.columnFirstName1.HeaderText = "First Name";
            this.columnFirstName1.Name = "columnFirstName1";
            // 
            // columnLastName1
            // 
            this.columnLastName1.HeaderText = "Last Name";
            this.columnLastName1.Name = "columnLastName1";
            // 
            // columnMail1
            // 
            this.columnMail1.HeaderText = "Mail";
            this.columnMail1.Name = "columnMail1";
            // 
            // columnAddressIP1
            // 
            this.columnAddressIP1.HeaderText = "Adresse IP";
            this.columnAddressIP1.Name = "columnAddressIP1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Member\'s List";
            // 
            // addMemberToProjectBtn
            // 
            this.addMemberToProjectBtn.Location = new System.Drawing.Point(747, 187);
            this.addMemberToProjectBtn.Name = "addMemberToProjectBtn";
            this.addMemberToProjectBtn.Size = new System.Drawing.Size(108, 23);
            this.addMemberToProjectBtn.TabIndex = 10;
            this.addMemberToProjectBtn.Text = "Add To Project";
            this.addMemberToProjectBtn.UseVisualStyleBackColor = true;
            this.addMemberToProjectBtn.Click += new System.EventHandler(this.addMemberToProjectBtn_Click);
            // 
            // DgMemberInProject
            // 
            this.DgMemberInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMemberInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFirstName2,
            this.columnLastName2,
            this.columnMail2});
            this.DgMemberInProject.Location = new System.Drawing.Point(632, 274);
            this.DgMemberInProject.Name = "DgMemberInProject";
            this.DgMemberInProject.Size = new System.Drawing.Size(345, 95);
            this.DgMemberInProject.TabIndex = 11;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Member In This Project";
            // 
            // removeMemberInProjectBtn
            // 
            this.removeMemberInProjectBtn.Location = new System.Drawing.Point(732, 386);
            this.removeMemberInProjectBtn.Name = "removeMemberInProjectBtn";
            this.removeMemberInProjectBtn.Size = new System.Drawing.Size(145, 23);
            this.removeMemberInProjectBtn.TabIndex = 13;
            this.removeMemberInProjectBtn.Text = "Remove From Project";
            this.removeMemberInProjectBtn.UseVisualStyleBackColor = true;
            this.removeMemberInProjectBtn.Click += new System.EventHandler(this.removeMemberInProjectBtn_Click);
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(166, 37);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(163, 20);
            this.projectName.TabIndex = 26;
            // 
            // projectBeginDate
            // 
            this.projectBeginDate.Location = new System.Drawing.Point(166, 70);
            this.projectBeginDate.Name = "projectBeginDate";
            this.projectBeginDate.Size = new System.Drawing.Size(163, 20);
            this.projectBeginDate.TabIndex = 27;
            // 
            // projectEndDate
            // 
            this.projectEndDate.Location = new System.Drawing.Point(166, 110);
            this.projectEndDate.Name = "projectEndDate";
            this.projectEndDate.Size = new System.Drawing.Size(163, 20);
            this.projectEndDate.TabIndex = 28;
            // 
            // DgTasks
            // 
            this.DgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTasks.Location = new System.Drawing.Point(16, 70);
            this.DgTasks.Name = "DgTasks";
            this.DgTasks.Size = new System.Drawing.Size(380, 161);
            this.DgTasks.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.DgTasks);
            this.panel2.Location = new System.Drawing.Point(24, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 264);
            this.panel2.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Task List";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(163, 187);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(64, 13);
            this.firstNameLbl.TabIndex = 33;
            this.firstNameLbl.Text = "-------------------";
            // 
            // addressIPLbl
            // 
            this.addressIPLbl.AutoSize = true;
            this.addressIPLbl.Location = new System.Drawing.Point(163, 288);
            this.addressIPLbl.Name = "addressIPLbl";
            this.addressIPLbl.Size = new System.Drawing.Size(52, 13);
            this.addressIPLbl.TabIndex = 34;
            this.addressIPLbl.Text = "---------------";
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(163, 254);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(52, 13);
            this.mailLbl.TabIndex = 35;
            this.mailLbl.Text = "---------------";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(163, 220);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameLbl.TabIndex = 36;
            this.lastNameLbl.Text = "------------------";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 69);
            this.button3.TabIndex = 37;
            this.button3.Text = "Modify Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // changeLeaderBtn
            // 
            this.changeLeaderBtn.Location = new System.Drawing.Point(143, 315);
            this.changeLeaderBtn.Name = "changeLeaderBtn";
            this.changeLeaderBtn.Size = new System.Drawing.Size(101, 23);
            this.changeLeaderBtn.TabIndex = 38;
            this.changeLeaderBtn.Text = "Change Leader";
            this.changeLeaderBtn.UseVisualStyleBackColor = true;
            // 
            // GestionProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 652);
            this.Controls.Add(this.changeLeaderBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.addressIPLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.projectEndDate);
            this.Controls.Add(this.projectBeginDate);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.removeMemberInProjectBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgMemberInProject);
            this.Controls.Add(this.addMemberToProjectBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgMembers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionProjet";
            this.Text = "GestionProjet";
            this.Load += new System.EventHandler(this.GestionProjet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMemberInProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTasks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgMembers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addMemberToProjectBtn;
        private System.Windows.Forms.DataGridView DgMemberInProject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button removeMemberInProjectBtn;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.DateTimePicker projectBeginDate;
        private System.Windows.Forms.DateTimePicker projectEndDate;
        private System.Windows.Forms.DataGridView DgTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label addressIPLbl;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button changeLeaderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddressIP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail2;
    }
}