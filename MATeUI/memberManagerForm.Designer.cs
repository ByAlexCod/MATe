namespace MATeUI
{
    partial class memberManagerForm
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
            this.memberList = new System.Windows.Forms.DataGridView();
            this.membersInWait = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.refuseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTbx = new System.Windows.Forms.TextBox();
            this.firstNameTbx = new System.Windows.Forms.TextBox();
            this.teamTbx = new System.Windows.Forms.TextBox();
            this.mailTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersInWait)).BeginInit();
            this.SuspendLayout();
            // 
            // memberList
            // 
            this.memberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberList.Location = new System.Drawing.Point(693, 49);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(309, 150);
            this.memberList.TabIndex = 0;
            this.memberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // membersInWait
            // 
            this.membersInWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersInWait.Location = new System.Drawing.Point(693, 276);
            this.membersInWait.Name = "membersInWait";
            this.membersInWait.Size = new System.Drawing.Size(309, 150);
            this.membersInWait.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(825, 227);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(749, 446);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // refuseBtn
            // 
            this.refuseBtn.Location = new System.Drawing.Point(906, 446);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(75, 23);
            this.refuseBtn.TabIndex = 4;
            this.refuseBtn.Text = "Refuse";
            this.refuseBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // lastNameTbx
            // 
            this.lastNameTbx.Location = new System.Drawing.Point(166, 49);
            this.lastNameTbx.Name = "lastNameTbx";
            this.lastNameTbx.Size = new System.Drawing.Size(100, 20);
            this.lastNameTbx.TabIndex = 8;
            // 
            // firstNameTbx
            // 
            this.firstNameTbx.Location = new System.Drawing.Point(166, 99);
            this.firstNameTbx.Name = "firstNameTbx";
            this.firstNameTbx.Size = new System.Drawing.Size(100, 20);
            this.firstNameTbx.TabIndex = 9;
            // 
            // teamTbx
            // 
            this.teamTbx.Location = new System.Drawing.Point(166, 202);
            this.teamTbx.Name = "teamTbx";
            this.teamTbx.Size = new System.Drawing.Size(100, 20);
            this.teamTbx.TabIndex = 10;
            // 
            // mailTbx
            // 
            this.mailTbx.Location = new System.Drawing.Point(166, 150);
            this.mailTbx.Name = "mailTbx";
            this.mailTbx.Size = new System.Drawing.Size(100, 20);
            this.mailTbx.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail ";
            // 
            // memberManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 481);
            this.Controls.Add(this.mailTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamTbx);
            this.Controls.Add(this.firstNameTbx);
            this.Controls.Add(this.lastNameTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refuseBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.membersInWait);
            this.Controls.Add(this.memberList);
            this.Name = "memberManagerForm";
            this.Text = "memberManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.memberList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersInWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberList;
        private System.Windows.Forms.DataGridView membersInWait;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button refuseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTbx;
        private System.Windows.Forms.TextBox firstNameTbx;
        private System.Windows.Forms.TextBox teamTbx;
        private System.Windows.Forms.TextBox mailTbx;
        private System.Windows.Forms.Label label4;
    }
}