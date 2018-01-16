namespace MATeUI
{
    partial class ColaboratorsTab
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
            this.ListEmployee = new System.Windows.Forms.ListView();
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this._goToProjectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListEmployee
            // 
            this.ListEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mail,
            this.FirstName,
            this.LastName,
            this.Status});
            this.ListEmployee.HideSelection = false;
            this.ListEmployee.Location = new System.Drawing.Point(11, 54);
            this.ListEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.ListEmployee.Name = "ListEmployee";
            this.ListEmployee.Size = new System.Drawing.Size(414, 286);
            this.ListEmployee.TabIndex = 0;
            this.ListEmployee.UseCompatibleStateImageBehavior = false;
            this.ListEmployee.View = System.Windows.Forms.View.Details;
            this.ListEmployee.SelectedIndexChanged += new System.EventHandler(this.ListEmployee_SelectedIndexChanged);
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 128;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 145;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 207;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current Working Project";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(562, 54);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProjectTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LastNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.FirstNameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(424, 119);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 6;
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(3, 87);
            this.ProjectTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(272, 20);
            this.ProjectTextBox.TabIndex = 3;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(3, 58);
            this.MailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(272, 20);
            this.MailTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(3, 32);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(272, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Location = new System.Drawing.Point(11, 362);
            this.AddEmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(125, 25);
            this.AddEmployeeBtn.TabIndex = 8;
            this.AddEmployeeBtn.Text = "Create New Employee";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeleteEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DeleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(297, 362);
            this.DeleteEmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(128, 25);
            this.DeleteEmployeeBtn.TabIndex = 9;
            this.DeleteEmployeeBtn.Text = "Delete Employee";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // _goToProjectBtn
            // 
            this._goToProjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._goToProjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this._goToProjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._goToProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._goToProjectBtn.Location = new System.Drawing.Point(764, 194);
            this._goToProjectBtn.Margin = new System.Windows.Forms.Padding(2);
            this._goToProjectBtn.Name = "_goToProjectBtn";
            this._goToProjectBtn.Size = new System.Drawing.Size(155, 25);
            this._goToProjectBtn.TabIndex = 10;
            this._goToProjectBtn.Text = "Go to Project";
            this._goToProjectBtn.UseVisualStyleBackColor = true;
            
            // 
            // ColaboratorsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._goToProjectBtn);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListEmployee);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColaboratorsTab";
            this.Size = new System.Drawing.Size(999, 469);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListEmployee;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.Button _goToProjectBtn;
    }
}
