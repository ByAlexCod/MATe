namespace MATeUI
{
    partial class SendFileOrMessageUC
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
            this._sendBtn = new System.Windows.Forms.Button();
            this._panelMessage = new System.Windows.Forms.Panel();
            this._messageText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._sendMessageRbtn = new System.Windows.Forms.RadioButton();
            this._sendFileRbtn = new System.Windows.Forms.RadioButton();
            this._dgEmployees = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lvMessages = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._panelSelectedFolder = new System.Windows.Forms.Panel();
            this._pathFolderLbl = new System.Windows.Forms.Label();
            this._chooseFolderLbl = new System.Windows.Forms.Label();
            this._panelMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            this._panelSelectedFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // _sendBtn
            // 
            this._sendBtn.Location = new System.Drawing.Point(340, 415);
            this._sendBtn.Name = "_sendBtn";
            this._sendBtn.Size = new System.Drawing.Size(75, 23);
            this._sendBtn.TabIndex = 19;
            this._sendBtn.Text = "Send";
            this._sendBtn.UseVisualStyleBackColor = true;
            // 
            // _panelMessage
            // 
            this._panelMessage.Controls.Add(this._messageText);
            this._panelMessage.Location = new System.Drawing.Point(230, 249);
            this._panelMessage.Name = "_panelMessage";
            this._panelMessage.Size = new System.Drawing.Size(327, 149);
            this._panelMessage.TabIndex = 18;
            // 
            // _messageText
            // 
            this._messageText.Location = new System.Drawing.Point(29, 14);
            this._messageText.Name = "_messageText";
            this._messageText.Size = new System.Drawing.Size(258, 123);
            this._messageText.TabIndex = 15;
            this._messageText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._sendMessageRbtn);
            this.groupBox1.Controls.Add(this._sendFileRbtn);
            this.groupBox1.Location = new System.Drawing.Point(289, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // _sendMessageRbtn
            // 
            this._sendMessageRbtn.AutoSize = true;
            this._sendMessageRbtn.Location = new System.Drawing.Point(97, 16);
            this._sendMessageRbtn.Name = "_sendMessageRbtn";
            this._sendMessageRbtn.Size = new System.Drawing.Size(96, 17);
            this._sendMessageRbtn.TabIndex = 1;
            this._sendMessageRbtn.TabStop = true;
            this._sendMessageRbtn.Text = "Send Message";
            this._sendMessageRbtn.UseVisualStyleBackColor = true;
            // 
            // _sendFileRbtn
            // 
            this._sendFileRbtn.AutoSize = true;
            this._sendFileRbtn.Location = new System.Drawing.Point(6, 16);
            this._sendFileRbtn.Name = "_sendFileRbtn";
            this._sendFileRbtn.Size = new System.Drawing.Size(69, 17);
            this._sendFileRbtn.TabIndex = 0;
            this._sendFileRbtn.TabStop = true;
            this._sendFileRbtn.Text = "Send File";
            this._sendFileRbtn.UseVisualStyleBackColor = true;
            // 
            // _dgEmployees
            // 
            this._dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.mail,
            this.ip});
            this._dgEmployees.Location = new System.Drawing.Point(178, 42);
            this._dgEmployees.Name = "_dgEmployees";
            this._dgEmployees.Size = new System.Drawing.Size(439, 150);
            this._dgEmployees.TabIndex = 16;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // _lvMessages
            // 
            this._lvMessages.Location = new System.Drawing.Point(649, 42);
            this._lvMessages.Name = "_lvMessages";
            this._lvMessages.Size = new System.Drawing.Size(149, 356);
            this._lvMessages.TabIndex = 20;
            this._lvMessages.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Employees\'s List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Messages\'s List";
            // 
            // _panelSelectedFolder
            // 
            this._panelSelectedFolder.Controls.Add(this._pathFolderLbl);
            this._panelSelectedFolder.Controls.Add(this._chooseFolderLbl);
            this._panelSelectedFolder.Location = new System.Drawing.Point(227, 249);
            this._panelSelectedFolder.Name = "_panelSelectedFolder";
            this._panelSelectedFolder.Size = new System.Drawing.Size(327, 149);
            this._panelSelectedFolder.TabIndex = 23;
            // 
            // _pathFolderLbl
            // 
            this._pathFolderLbl.AutoSize = true;
            this._pathFolderLbl.Location = new System.Drawing.Point(180, 67);
            this._pathFolderLbl.Name = "_pathFolderLbl";
            this._pathFolderLbl.Size = new System.Drawing.Size(89, 13);
            this._pathFolderLbl.TabIndex = 1;
            this._pathFolderLbl.Text = "Path of Te Folder";
            this._pathFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _chooseFolderLbl
            // 
            this._chooseFolderLbl.Location = new System.Drawing.Point(14, 58);
            this._chooseFolderLbl.Name = "_chooseFolderLbl";
            this._chooseFolderLbl.Size = new System.Drawing.Size(100, 23);
            this._chooseFolderLbl.TabIndex = 0;
            this._chooseFolderLbl.Text = "Browse";
            this._chooseFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendFileOrMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelSelectedFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._panelMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lvMessages);
            this.Controls.Add(this._sendBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dgEmployees);
            this.Name = "SendFileOrMessageUC";
            this.Size = new System.Drawing.Size(840, 477);
            this._panelMessage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).EndInit();
            this._panelSelectedFolder.ResumeLayout(false);
            this._panelSelectedFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button _sendBtn;
        internal System.Windows.Forms.Panel _panelMessage;
        internal System.Windows.Forms.RichTextBox _messageText;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton _sendMessageRbtn;
        internal System.Windows.Forms.RadioButton _sendFileRbtn;
        internal System.Windows.Forms.DataGridView _dgEmployees;
        internal System.Windows.Forms.ListView _lvMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        internal System.Windows.Forms.Panel _panelSelectedFolder;
        internal System.Windows.Forms.Label _pathFolderLbl;
        internal System.Windows.Forms.Label _chooseFolderLbl;
    }
}
