namespace MATeUI
{
    partial class CreatProject
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
            this.valid = new System.Windows.Forms.Button();
            this.CreatPN = new System.Windows.Forms.TextBox();
            this.checkEmployee = new System.Windows.Forms.CheckedListBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.limitDate = new System.Windows.Forms.DateTimePicker();
            this.pN = new System.Windows.Forms.Label();
            this.Emp = new System.Windows.Forms.Label();
            this.ED = new System.Windows.Forms.Label();
            this.SD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valid
            // 
            this.valid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.valid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.valid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valid.Location = new System.Drawing.Point(124, 361);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(352, 23);
            this.valid.TabIndex = 0;
            this.valid.Text = "Create";
            this.valid.UseVisualStyleBackColor = true;
            this.valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // CreatPN
            // 
            this.CreatPN.Location = new System.Drawing.Point(124, 22);
            this.CreatPN.Name = "CreatPN";
            this.CreatPN.Size = new System.Drawing.Size(352, 20);
            this.CreatPN.TabIndex = 1;
            // 
            // checkEmployee
            // 
            this.checkEmployee.FormattingEnabled = true;
            this.checkEmployee.Location = new System.Drawing.Point(124, 141);
            this.checkEmployee.Name = "checkEmployee";
            this.checkEmployee.Size = new System.Drawing.Size(352, 199);
            this.checkEmployee.TabIndex = 2;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(124, 57);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(352, 20);
            this.StartDate.TabIndex = 3;
            // 
            // limitDate
            // 
            this.limitDate.Location = new System.Drawing.Point(124, 100);
            this.limitDate.Name = "limitDate";
            this.limitDate.Size = new System.Drawing.Size(352, 20);
            this.limitDate.TabIndex = 4;
            // 
            // pN
            // 
            this.pN.AutoSize = true;
            this.pN.Location = new System.Drawing.Point(31, 22);
            this.pN.Name = "pN";
            this.pN.Size = new System.Drawing.Size(71, 13);
            this.pN.TabIndex = 6;
            this.pN.Text = "Project Name";
            // 
            // Emp
            // 
            this.Emp.AutoSize = true;
            this.Emp.Location = new System.Drawing.Point(35, 141);
            this.Emp.Name = "Emp";
            this.Emp.Size = new System.Drawing.Size(53, 13);
            this.Emp.TabIndex = 7;
            this.Emp.Text = "Employee";
            // 
            // ED
            // 
            this.ED.AutoSize = true;
            this.ED.Location = new System.Drawing.Point(36, 100);
            this.ED.Name = "ED";
            this.ED.Size = new System.Drawing.Size(52, 13);
            this.ED.TabIndex = 8;
            this.ED.Text = "End Date";
            // 
            // SD
            // 
            this.SD.AutoSize = true;
            this.SD.Location = new System.Drawing.Point(32, 57);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(55, 13);
            this.SD.TabIndex = 9;
            this.SD.Text = "Start Date";
            // 
            // CreatProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 404);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.ED);
            this.Controls.Add(this.Emp);
            this.Controls.Add(this.pN);
            this.Controls.Add(this.limitDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.checkEmployee);
            this.Controls.Add(this.CreatPN);
            this.Controls.Add(this.valid);
            this.Name = "CreatProject";
            this.Text = "Creat Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valid;
        private System.Windows.Forms.TextBox CreatPN;
        private System.Windows.Forms.CheckedListBox checkEmployee;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker limitDate;
        private System.Windows.Forms.Label pN;
        private System.Windows.Forms.Label Emp;
        private System.Windows.Forms.Label ED;
        private System.Windows.Forms.Label SD;
    }
}