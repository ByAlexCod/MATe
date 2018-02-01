using System.Threading;
using MATeV2;
using System.Windows;

namespace MATeUI
{
    public class Item
    {
        public string strText;
        public Conversation strValue;
        public override string ToString()
        {
            return this.strText;
        }
    }
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
        internal void InitializeComponent()
        {
            this._sendBtn = new System.Windows.Forms.Button();
            this._panelMessage = new System.Windows.Forms.Panel();
            this._messageText = new System.Windows.Forms.RichTextBox();
            this._panelSelectedFolder = new System.Windows.Forms.Panel();
            this._pathFolderLbl = new System.Windows.Forms.Label();
            this._chooseFolderLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._sendMessageRbtn = new System.Windows.Forms.RadioButton();
            this._sendFileRbtn = new System.Windows.Forms.RadioButton();
            this._dgEmployees = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListConversation = new System.Windows.Forms.DataGridView();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.ListFile = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this._panelSendFile = new System.Windows.Forms.Panel();
            this._panelMessage.SuspendLayout();
            this._panelSelectedFolder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListConversation)).BeginInit();
            this._panelSendFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // _sendBtn
            // 
            this._sendBtn.Location = new System.Drawing.Point(340, 415);
            this._sendBtn.Name = "_sendBtn";
            this._sendBtn.Size = new System.Drawing.Size(114, 23);
            this._sendBtn.TabIndex = 19;
            this._sendBtn.Text = "Send";
            this._sendBtn.UseVisualStyleBackColor = true;
            // 
            // _panelMessage
            // 
            this._panelMessage.Controls.Add(this._messageText);
            this._panelMessage.Controls.Add(this._panelSelectedFolder);
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
            // _panelSelectedFolder
            // 
            this._panelSelectedFolder.Controls.Add(this._pathFolderLbl);
            this._panelSelectedFolder.Controls.Add(this._chooseFolderLbl);
            this._panelSelectedFolder.Location = new System.Drawing.Point(0, 1);
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
            this.label2.Location = new System.Drawing.Point(687, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Conversations";
            // 
            // ListConversation
            // 
            this.ListConversation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListConversation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListConversation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destination,
            this.LastMessage});
            this.ListConversation.Location = new System.Drawing.Point(622, 42);
            this.ListConversation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListConversation.Name = "ListConversation";
            this.ListConversation.RowTemplate.Height = 24;
            this.ListConversation.Size = new System.Drawing.Size(215, 355);
            this.ListConversation.TabIndex = 24;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destiation";
            this.Destination.Name = "Destination";
            this.Destination.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Destination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastMessage
            // 
            this.LastMessage.HeaderText = "Last Message";
            this.LastMessage.Name = "LastMessage";
            this.LastMessage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(82, 12);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(62, 27);
            this.OpenFileBtn.TabIndex = 25;
            this.OpenFileBtn.Text = "Browser ...";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // ListFile
            // 
            this.ListFile.Location = new System.Drawing.Point(82, 43);
            this.ListFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListFile.Name = "ListFile";
            this.ListFile.Size = new System.Drawing.Size(174, 80);
            this.ListFile.TabIndex = 26;
            this.ListFile.UseCompatibleStateImageBehavior = false;
            this.ListFile.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Send File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Check again";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(82, 127);
            this.DltBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(62, 31);
            this.DltBtn.TabIndex = 29;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // _panelSendFile
            // 
            this._panelSendFile.Controls.Add(this.ListFile);
            this._panelSendFile.Controls.Add(this.DltBtn);
            this._panelSendFile.Controls.Add(this.OpenFileBtn);
            this._panelSendFile.Controls.Add(this.button2);
            this._panelSendFile.Controls.Add(this.button1);
            this._panelSendFile.Location = new System.Drawing.Point(233, 249);
            this._panelSendFile.Name = "_panelSendFile";
            this._panelSendFile.Size = new System.Drawing.Size(324, 198);
            this._panelSendFile.TabIndex = 2;
            // 
            // SendFileOrMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelSendFile);
            this.Controls.Add(this.ListConversation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._panelMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._sendBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dgEmployees);
            this.Name = "SendFileOrMessageUC";
            this.Size = new System.Drawing.Size(840, 477);
            this._panelMessage.ResumeLayout(false);
            this._panelSelectedFolder.ResumeLayout(false);
            this._panelSelectedFolder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListConversation)).EndInit();
            this._panelSendFile.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        internal System.Windows.Forms.Panel _panelSelectedFolder;
        internal System.Windows.Forms.Label _pathFolderLbl;
        internal System.Windows.Forms.Label _chooseFolderLbl;
        internal System.Windows.Forms.DataGridView ListConversation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastMessage;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.ListView ListFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DltBtn;
        internal System.Windows.Forms.Panel _panelSendFile;
    }
}
