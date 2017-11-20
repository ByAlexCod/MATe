namespace TestFichierBinaire
{
    partial class MainForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._firstNameTbx = new System.Windows.Forms.TextBox();
            this._mailTbx = new System.Windows.Forms.TextBox();
            this._lastNameTbx = new System.Windows.Forms.TextBox();
            this._createEmployeeBtn = new System.Windows.Forms.Button();
            this._createProjectBtn = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._dgEmployee = new System.Windows.Forms.DataGridView();
            this._firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgEmpolyeeInProject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgProjects = new System.Windows.Forms.DataGridView();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addToProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmpolyeeInProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create New Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // _firstNameTbx
            // 
            this._firstNameTbx.Location = new System.Drawing.Point(160, 66);
            this._firstNameTbx.Name = "_firstNameTbx";
            this._firstNameTbx.Size = new System.Drawing.Size(100, 20);
            this._firstNameTbx.TabIndex = 4;
            // 
            // _mailTbx
            // 
            this._mailTbx.Location = new System.Drawing.Point(160, 121);
            this._mailTbx.Name = "_mailTbx";
            this._mailTbx.Size = new System.Drawing.Size(100, 20);
            this._mailTbx.TabIndex = 5;
            // 
            // _lastNameTbx
            // 
            this._lastNameTbx.Location = new System.Drawing.Point(160, 95);
            this._lastNameTbx.Name = "_lastNameTbx";
            this._lastNameTbx.Size = new System.Drawing.Size(100, 20);
            this._lastNameTbx.TabIndex = 6;
            // 
            // _createEmployeeBtn
            // 
            this._createEmployeeBtn.Location = new System.Drawing.Point(160, 158);
            this._createEmployeeBtn.Name = "_createEmployeeBtn";
            this._createEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this._createEmployeeBtn.TabIndex = 7;
            this._createEmployeeBtn.Text = "Create";
            this._createEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // _createProjectBtn
            // 
            this._createProjectBtn.Location = new System.Drawing.Point(462, 158);
            this._createProjectBtn.Name = "_createProjectBtn";
            this._createProjectBtn.Size = new System.Drawing.Size(75, 23);
            this._createProjectBtn.TabIndex = 16;
            this._createProjectBtn.Text = "Create Project";
            this._createProjectBtn.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(462, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(462, 121);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(462, 66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Project Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Create New Employee";
            // 
            // _dgEmployee
            // 
            this._dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._firstName,
            this._lastName,
            this._mail});
            this._dgEmployee.Location = new System.Drawing.Point(36, 205);
            this._dgEmployee.Name = "_dgEmployee";
            this._dgEmployee.Size = new System.Drawing.Size(345, 94);
            this._dgEmployee.TabIndex = 20;
            // 
            // _firstName
            // 
            this._firstName.HeaderText = "First Name";
            this._firstName.Name = "_firstName";
            // 
            // _lastName
            // 
            this._lastName.HeaderText = "Last Name";
            this._lastName.Name = "_lastName";
            // 
            // _mail
            // 
            this._mail.HeaderText = "Mail";
            this._mail.Name = "_mail";
            // 
            // _dgEmpolyeeInProject
            // 
            this._dgEmpolyeeInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmpolyeeInProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this._dgEmpolyeeInProject.Location = new System.Drawing.Point(614, 66);
            this._dgEmpolyeeInProject.Name = "_dgEmpolyeeInProject";
            this._dgEmpolyeeInProject.Size = new System.Drawing.Size(345, 94);
            this._dgEmpolyeeInProject.TabIndex = 21;
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
            // _dgProjects
            // 
            this._dgProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._startDate,
            this._endDate});
            this._dgProjects.Location = new System.Drawing.Point(590, 240);
            this._dgProjects.Name = "_dgProjects";
            this._dgProjects.Size = new System.Drawing.Size(345, 94);
            this._dgProjects.TabIndex = 22;
            // 
            // _name
            // 
            this._name.HeaderText = "Project Name";
            this._name.Name = "_name";
            // 
            // _startDate
            // 
            this._startDate.HeaderText = "Start Date";
            this._startDate.Name = "_startDate";
            // 
            // _endDate
            // 
            this._endDate.HeaderText = "End Date";
            this._endDate.Name = "_endDate";
            // 
            // _addToProject
            // 
            this._addToProject.Location = new System.Drawing.Point(860, 17);
            this._addToProject.Name = "_addToProject";
            this._addToProject.Size = new System.Drawing.Size(75, 23);
            this._addToProject.TabIndex = 23;
            this._addToProject.Text = "Add To Project";
            this._addToProject.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(614, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 447);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._addToProject);
            this.Controls.Add(this._dgProjects);
            this.Controls.Add(this._dgEmpolyeeInProject);
            this.Controls.Add(this._dgEmployee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._createProjectBtn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._createEmployeeBtn);
            this.Controls.Add(this._lastNameTbx);
            this.Controls.Add(this._mailTbx);
            this.Controls.Add(this._firstNameTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmpolyeeInProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _firstNameTbx;
        private System.Windows.Forms.TextBox _mailTbx;
        private System.Windows.Forms.TextBox _lastNameTbx;
        private System.Windows.Forms.Button _createEmployeeBtn;
        private System.Windows.Forms.Button _createProjectBtn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView _dgEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn _firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mail;
        private System.Windows.Forms.DataGridView _dgEmpolyeeInProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView _dgProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _endDate;
        private System.Windows.Forms.Button _addToProject;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

