using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace MATeUI
{
    public partial class DetailProjectEmployeeUC : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public delegate void AddListItem(Conversation send);
        public AddListItem myDelegate;
        public static DetailProjectEmployeeUC detail;
        public static Dictionary<Person, ChatWDF> _dicform;
        //bool _passed = false;

        public DetailProjectEmployeeUC()
        {
            detail = this;
            //_passed = true;
            myDelegate = new AddListItem(RefreshChat);
            _dicform = new Dictionary<Person, ChatWDF>();
            InitializeComponent();
        }

        public void RefreshChat(Conversation send)
        {
            ChatWDF chatform;
            if (!_dicform.ContainsKey(send.TheOtherOne))
            {
                chatform = new ChatWDF(send, _ctxuser.CurrentUser);
                _dicform.Add(send.TheOtherOne, chatform);
                if (send.ToSee) sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(send.TheOtherOne.Mail, "new message");
                else sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(send.TheOtherOne.Mail, "nothing new");
                chatform.ShowDialog();
                chatform.TopMost = true;
            }
            else
            {
                chatform = _dicform[send.TheOtherOne];
                chatform.ListChat.Clear();
                foreach (MessageP2P me in send.MessageList)
                {
                    if (me.Sender.Mail == _ctxuser.CurrentUser.Mail)
                        chatform.ListChat.Items.Add("You write on " + me.DateTime.ToString() + " : " + me.Text);
                    else chatform.ListChat.Items.Add(me.Sender.Mail + " write on " + me.DateTime.ToString() + " : " + me.Text);
                }
                if (!chatform.Visible)
                {
                    chatform.ShowDialog();
    
                }
            }
        }


        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void DataGridViewCellMouseEventHandler(object sender, EventArgs e);


        public event DataGridViewCellMouseEventHandler CellTaskClick;
        public event DataGridViewCellMouseEventHandler CellSubTaskClick;

        
        public event ButtonClickedEventHandler ChangeSubTaskButtonClicked;
        public event ButtonClickedEventHandler CreateTaskButtonClicked;
        public event ButtonClickedEventHandler CreateSubTaskButtonClicked;
        public event ButtonClickedEventHandler ValidateTaskButtonClicked;
        public event ButtonClickedEventHandler ValidateProjectButtonClicked;
        public event ButtonClickedEventHandler DeleteTaskButtonClicked;
        public event ButtonClickedEventHandler DeleteSubTaskButtonClicked;
        public event ButtonClickedEventHandler ModifyTaskButtonClickeds;
        public event ButtonClickedEventHandler ModifySubTaskButtonClicked;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            sendFileOrMessageUCOnDetailUIEmployee._sendFileRbtn.CheckedChanged += new EventHandler(CheckedOption);
            _dgTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellTaskChanged);
            _changeSubTaskBtn.Click += new EventHandler(SubTaskChangeButtonClicked);
            _dgSubTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellSubTaskChanged);
            sendFileOrMessageUCOnDetailUIEmployee._sendBtn.Click += new EventHandler(SendFileOrMessage);
            sendFileOrMessageUCOnDetailUIEmployee._chooseFolderLbl.Click += new EventHandler(OpenDialogue);
            _createTaskBtn.Click += new EventHandler(ButtonCreateTaskClicked);
            _createSubTaskBtn.Click += new EventHandler(ButtonCreateSubTaskClicked);
            _validateTaskBtn.Click += new EventHandler(ButtonValidateTaskClicked);
            _validateProjectBtn.Click += new EventHandler(ButtonValidateProjectClicked);
            _deleteTaskBtn.Click += new EventHandler(ButtonDeleteTaskClicked);
            _deleteSubTaskBtn.Click += new EventHandler(ButtonDeleteSubTaskClicked);
            _modifySubTaskBtn.Click += new EventHandler(ButtonModifySubTaskClicked);
            _modifyTaskBtn.Click += new EventHandler(ButtonModifyTaskClicked);
            sendFileOrMessageUCOnDetailUIEmployee._sendFileRbtn.Checked = true;
            sendFileOrMessageUCOnDetailUIEmployee.ListConversation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(LoadConver);
           
            if (_ctxuser == null) return;
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                Person p = _ctxuser.CurrentUser;
                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    if(p.Mail != item.Mail)
                    sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail, item.IP);
                }
                sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Clear();
                foreach (var con in _ctxuser.CurrentUser.ConversationDictionary.Values)
                {
                    if (con.ToSee) sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(con.TheOtherOne.Mail, "new message");
                    else sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(con.TheOtherOne.Mail, "nothing new");
                }
            }
        }

       internal void RefreshDetail()
       {
            this.Refresh();
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                Person p = _ctxuser.CurrentUser;
                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    if (p.Mail != item.Mail)
                        sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail, item.IP);
                }
                foreach (var con in Authentification.CurrentCtxUser.CurrentUser.ConversationDictionary.Values)
                {
                    ChatWDF newwdf = new ChatWDF(con, _ctxuser.CurrentUser);
                    if(!_dicform.ContainsKey(con.TheOtherOne)) _dicform.Add(con.TheOtherOne, newwdf);
                    if (con.ToSee) sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(con.TheOtherOne.Mail, "new message");
                    else sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(con.TheOtherOne.Mail, "nothing new");
                }
            }
       }

        void LoadConver(object sender, EventArgs e)
        {
            int rowindex = sendFileOrMessageUCOnDetailUIEmployee.ListConversation.CurrentCell.RowIndex;
            string name = sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows[rowindex].Cells[0].Value.ToString();
            if (name != "") 
            {
                Person SelectedPerson = _ctxuser.ObtainAccessor().Context.FindEmployee(name);
                ChatWDF SelectedChat = _dicform[SelectedPerson];
                SelectedChat.Conversation.ToSee = false;
                int i = 0;
                bool continuesearch = true;
                while (continuesearch) 
                {
                    if (sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows[i].Cells[0].Value.ToString() == SelectedPerson.Mail)
                    {
                        sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows[i].Cells[1].Value = "nothing new";
                        continuesearch = false;
                    }
                    else i++;
                }
                if(!SelectedChat.Visible) SelectedChat.ShowDialog();
            }
        }

        private void OpenDialogue(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Texte (*.txt)|*.txt|Zip (*.zip)|*.zip|Tous (*.*)|*.*",
                CheckFileExists = true
            };
            DialogResult res = open.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                Stream flux = open.OpenFile();
                StreamReader fichier = new StreamReader(flux);
                sendFileOrMessageUCOnDetailUIEmployee._pathFolderLbl.Text = fichier.ReadToEnd();
                fichier.Close();
                flux.Close();
                Text = open.FileName;
            }
        }

        private void SubTaskChangeButtonClicked(object sender, EventArgs e) => ChangeSubTaskButtonClicked?.Invoke(this, e);

        //private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);

        private void CellSubTaskChanged(object sender, EventArgs e) => CellSubTaskClick?.Invoke(this, e);

        private void CellTaskChanged(object sender, EventArgs e) => CellTaskClick?.Invoke(this, e);

        private void ButtonCreateTaskClicked(object sender, EventArgs e) => CreateTaskButtonClicked?.Invoke(this, e);

        private void ButtonCreateSubTaskClicked(object sender, EventArgs e) => CreateSubTaskButtonClicked?.Invoke(this, e);

        private void ButtonValidateTaskClicked(object sender, EventArgs e) => ValidateTaskButtonClicked?.Invoke(this, e);

        private void ButtonValidateProjectClicked(object sender, EventArgs e) => ValidateProjectButtonClicked?.Invoke(this, e);

        private void ButtonDeleteTaskClicked(object sender, EventArgs e) => DeleteTaskButtonClicked?.Invoke(this, e);

        private void ButtonDeleteSubTaskClicked(object sender, EventArgs e) => DeleteSubTaskButtonClicked?.Invoke(this, e);

        private void ButtonModifyTaskClicked(object sender, EventArgs e) => ModifyTaskButtonClickeds?.Invoke(this, e);

        private void ButtonModifySubTaskClicked(object sender, EventArgs e) => ModifySubTaskButtonClicked?.Invoke(this, e);



        /// <summary>
        /// Methode de l'evenement des changement des buttons radio Send File et Send Message 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedOption(object sender, EventArgs e)
        {
            if (sendFileOrMessageUCOnDetailUIEmployee._sendFileRbtn.Checked == true)
            {
                sendFileOrMessageUCOnDetailUIEmployee._panelMessage.Visible = false;
                sendFileOrMessageUCOnDetailUIEmployee._panelSendFile.Visible = true;
            }
            if (sendFileOrMessageUCOnDetailUIEmployee._sendMessageRbtn.Checked == true)
            {
                sendFileOrMessageUCOnDetailUIEmployee._panelMessage.Visible = true;
                sendFileOrMessageUCOnDetailUIEmployee._panelSendFile.Visible = false;

            }
        }

        private void SendFileOrMessage(object sender, EventArgs e)
        {
            int rowindex = sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.CurrentCell.RowIndex;

            string userselected = sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.Rows[rowindex].Cells[2].Value.ToString();
            Person selectedPerson = _ctxuser.Context.PersonsDictionary[userselected];

            if (sendFileOrMessageUCOnDetailUIEmployee._sendMessageRbtn.Checked)
            {
                Conversation conver;
                string message;
                if (!_ctxuser.CurrentUser.ConversationDictionary.ContainsKey(selectedPerson))
                {
                    message = "";
                    conver = _ctxuser.CurrentUser.CreateConversation(selectedPerson, 1807);
                    message = sendFileOrMessageUCOnDetailUIEmployee._messageText.Text;
                }
                else
                {
                    message = "";
                    conver = _ctxuser.CurrentUser.ConversationDictionary[selectedPerson];
                    message = sendFileOrMessageUCOnDetailUIEmployee._messageText.Text;
                }
                if (!_dicform.ContainsKey(selectedPerson))
                {
                    ChatWDF newchat = new ChatWDF(conver, _ctxuser.CurrentUser);
                    _dicform.Add(selectedPerson, newchat);
                    newchat.SendMessage(message + "#" + _ctxuser.CurrentUser.Mail);
                    sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(conver.TheOtherOne.Mail, "new message");
                    newchat.ListChat.Clear();
                    newchat.ShowDialog();
                    newchat.TopMost = true;
                }
                else
                {
                    ChatWDF yourwdf = _dicform[selectedPerson];
                    yourwdf.SendMessage(message + "#" + _ctxuser.CurrentUser.Mail);
                    yourwdf.ListChat.Clear();
                    yourwdf.ShowDialog();
                    yourwdf.TopMost = true;
                }
            }
            return;
        }

        
    }
}
