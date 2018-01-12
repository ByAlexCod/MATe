namespace MATeUI
{
    partial class ChatWDF
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
            this.ListChat = new System.Windows.Forms.ListView();
            this.Messagetxb = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListChat
            // 
            this.ListChat.Location = new System.Drawing.Point(12, 12);
            this.ListChat.Name = "ListChat";
            this.ListChat.Size = new System.Drawing.Size(614, 486);
            this.ListChat.TabIndex = 0;
            this.ListChat.UseCompatibleStateImageBehavior = false;
            this.ListChat.View = System.Windows.Forms.View.List;
            // 
            // Messagetxb
            // 
            this.Messagetxb.Location = new System.Drawing.Point(13, 518);
            this.Messagetxb.Name = "Messagetxb";
            this.Messagetxb.Size = new System.Drawing.Size(497, 22);
            this.Messagetxb.TabIndex = 1;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(517, 517);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(109, 23);
            this.sendbtn.TabIndex = 2;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // ChatWDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 552);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.Messagetxb);
            this.Controls.Add(this.ListChat);
            this.Name = "ChatWDF";
            this.Text = "ChatWDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Messagetxb;
        private System.Windows.Forms.Button sendbtn;
        public System.Windows.Forms.ListView ListChat;
    }
}