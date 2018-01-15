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
            this._panelMessage.SuspendLayout();
            this._panelSelectedFolder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListConversation)).BeginInit();
            this.SuspendLayout();
            // 
            // _sendBtn
            // 
            this._sendBtn.Location = new System.Drawing.Point(453, 511);
            this._sendBtn.Margin = new System.Windows.Forms.Padding(4);
            this._sendBtn.Name = "_sendBtn";
            this._sendBtn.Size = new System.Drawing.Size(152, 28);
            this._sendBtn.TabIndex = 19;
            this._sendBtn.Text = "Send";
            this._sendBtn.UseVisualStyleBackColor = true;
            // 
            // _panelMessage
            // 
            this._panelMessage.Controls.Add(this._messageText);
            this._panelMessage.Controls.Add(this._panelSelectedFolder);
            this._panelMessage.Location = new System.Drawing.Point(307, 306);
            this._panelMessage.Margin = new System.Windows.Forms.Padding(4);
            this._panelMessage.Name = "_panelMessage";
            this._panelMessage.Size = new System.Drawing.Size(436, 183);
            this._panelMessage.TabIndex = 18;
            // 
            // _messageText
            // 
            this._messageText.Location = new System.Drawing.Point(39, 17);
            this._messageText.Margin = new System.Windows.Forms.Padding(4);
            this._messageText.Name = "_messageText";
            this._messageText.Size = new System.Drawing.Size(343, 150);
            this._messageText.TabIndex = 15;
            this._messageText.Text = "";
            // 
            // _panelSelectedFolder
            // 
            this._panelSelectedFolder.Controls.Add(this._pathFolderLbl);
            this._panelSelectedFolder.Controls.Add(this._chooseFolderLbl);
            this._panelSelectedFolder.Location = new System.Drawing.Point(0, 1);
            this._panelSelectedFolder.Margin = new System.Windows.Forms.Padding(4);
            this._panelSelectedFolder.Name = "_panelSelectedFolder";
            this._panelSelectedFolder.Size = new System.Drawing.Size(436, 183);
            this._panelSelectedFolder.TabIndex = 23;
            // 
            // _pathFolderLbl
            // 
            this._pathFolderLbl.AutoSize = true;
            this._pathFolderLbl.Location = new System.Drawing.Point(240, 82);
            this._pathFolderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._pathFolderLbl.Name = "_pathFolderLbl";
            this._pathFolderLbl.Size = new System.Drawing.Size(118, 17);
            this._pathFolderLbl.TabIndex = 1;
            this._pathFolderLbl.Text = "Path of Te Folder";
            this._pathFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _chooseFolderLbl
            // 
            this._chooseFolderLbl.Location = new System.Drawing.Point(19, 71);
            this._chooseFolderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._chooseFolderLbl.Name = "_chooseFolderLbl";
            this._chooseFolderLbl.Size = new System.Drawing.Size(133, 28);
            this._chooseFolderLbl.TabIndex = 0;
            this._chooseFolderLbl.Text = "Browse";
            this._chooseFolderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._sendMessageRbtn);
            this.groupBox1.Controls.Add(this._sendFileRbtn);
            this.groupBox1.Location = new System.Drawing.Point(385, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 55);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // _sendMessageRbtn
            // 
            this._sendMessageRbtn.AutoSize = true;
            this._sendMessageRbtn.Location = new System.Drawing.Point(129, 20);
            this._sendMessageRbtn.Margin = new System.Windows.Forms.Padding(4);
            this._sendMessageRbtn.Name = "_sendMessageRbtn";
            this._sendMessageRbtn.Size = new System.Drawing.Size(123, 21);
            this._sendMessageRbtn.TabIndex = 1;
            this._sendMessageRbtn.TabStop = true;
            this._sendMessageRbtn.Text = "Send Message";
            this._sendMessageRbtn.UseVisualStyleBackColor = true;
            // 
            // _sendFileRbtn
            // 
            this._sendFileRbtn.AutoSize = true;
            this._sendFileRbtn.Location = new System.Drawing.Point(8, 20);
            this._sendFileRbtn.Margin = new System.Windows.Forms.Padding(4);
            this._sendFileRbtn.Name = "_sendFileRbtn";
            this._sendFileRbtn.Size = new System.Drawing.Size(88, 21);
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
            this._dgEmployees.Location = new System.Drawing.Point(237, 52);
            this._dgEmployees.Margin = new System.Windows.Forms.Padding(4);
            this._dgEmployees.Name = "_dgEmployees";
            this._dgEmployees.Size = new System.Drawing.Size(585, 185);
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
            this.label1.Location = new System.Drawing.Point(472, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Employees\'s List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
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
            this.ListConversation.Location = new System.Drawing.Point(830, 52);
            this.ListConversation.Name = "ListConversation";
            this.ListConversation.RowTemplate.Height = 24;
            this.ListConversation.Size = new System.Drawing.Size(287, 437);
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
            // SendFileOrMessageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListConversation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._panelMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._sendBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dgEmployees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendFileOrMessageUC";
            this.Size = new System.Drawing.Size(1120, 587);
            this._panelMessage.ResumeLayout(false);
            this._panelSelectedFolder.ResumeLayout(false);
            this._panelSelectedFolder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListConversation)).EndInit();
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
    }
}
