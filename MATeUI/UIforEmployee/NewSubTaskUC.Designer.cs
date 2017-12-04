namespace MATeUI.UIforEmployee
{
    partial class NewSubTaskUC
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
            this.CreateSubTaskBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubTaskNameTxtB = new System.Windows.Forms.TextBox();
            this.DeadLineDPick = new System.Windows.Forms.DateTimePicker();
            this.WorkerCBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateSubTaskBtn
            // 
            this.CreateSubTaskBtn.Location = new System.Drawing.Point(220, 230);
            this.CreateSubTaskBtn.Name = "CreateSubTaskBtn";
            this.CreateSubTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateSubTaskBtn.TabIndex = 0;
            this.CreateSubTaskBtn.Text = "Create";
            this.CreateSubTaskBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Worker";
            // 
            // SubTaskNameTxtB
            // 
            this.SubTaskNameTxtB.Location = new System.Drawing.Point(177, 65);
            this.SubTaskNameTxtB.Name = "SubTaskNameTxtB";
            this.SubTaskNameTxtB.Size = new System.Drawing.Size(271, 22);
            this.SubTaskNameTxtB.TabIndex = 4;
            // 
            // DeadLineDPick
            // 
            this.DeadLineDPick.Location = new System.Drawing.Point(177, 110);
            this.DeadLineDPick.Name = "DeadLineDPick";
            this.DeadLineDPick.Size = new System.Drawing.Size(271, 22);
            this.DeadLineDPick.TabIndex = 5;
            // 
            // WorkerCBx
            // 
            this.WorkerCBx.FormattingEnabled = true;
            this.WorkerCBx.Location = new System.Drawing.Point(177, 152);
            this.WorkerCBx.Name = "WorkerCBx";
            this.WorkerCBx.Size = new System.Drawing.Size(271, 24);
            this.WorkerCBx.TabIndex = 6;
            // 
            // NewSubTaskUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WorkerCBx);
            this.Controls.Add(this.DeadLineDPick);
            this.Controls.Add(this.SubTaskNameTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateSubTaskBtn);
            this.Name = "NewSubTaskUC";
            this.Size = new System.Drawing.Size(516, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateSubTaskBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubTaskNameTxtB;
        private System.Windows.Forms.DateTimePicker DeadLineDPick;
        private System.Windows.Forms.ComboBox WorkerCBx;
    }
}
