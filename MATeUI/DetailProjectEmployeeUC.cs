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

namespace MATeUI
{
    public partial class DetailProjectEmployeeUC : UserControl
    {
        public DetailProjectEmployeeUC()
        {
            InitializeComponent();
        }

        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void DataGridViewCellMouseEventHandler(object sender, EventArgs e);

        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;

        public event DataGridViewCellMouseEventHandler CellTaskClick;
        public event DataGridViewCellMouseEventHandler CellSubTaskClick;
        public event ButtonClickedEventHandler SendButtonClicked;
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
     
            if (_ctxuser == null) return;
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail, item.IP);
                }
                foreach(var con in Authentification.CurrentCtxUser.CurrentUser.ConversationDictionary.Values)
                {
                    sendFileOrMessageUCOnDetailUIEmployee.ListConversation.Rows.Add(con.Host, con.MessageList.Last());
                }
            }
        }

        private void OpenDialogue(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Texte (*.txt)|*.txt|Zip (*.zip)|*.zip|Tous (*.*)|*.*";
            open.CheckFileExists = true;
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

        private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);

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
                sendFileOrMessageUCOnDetailUIEmployee._panelSelectedFolder.Visible = true;
            }
            if (sendFileOrMessageUCOnDetailUIEmployee._sendMessageRbtn.Checked == true)
            {
                sendFileOrMessageUCOnDetailUIEmployee._panelMessage.Visible = true;
                sendFileOrMessageUCOnDetailUIEmployee._panelSelectedFolder.Visible = false;

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
                    conver = new Conversation(_ctxuser.CurrentUser, selectedPerson, 1807);
                    _ctxuser.CurrentUser.ConversationDictionary.Add(selectedPerson, conver);
                    message = sendFileOrMessageUCOnDetailUIEmployee._messageText.Text;

                }
                else
                {
                    message = "";
                    conver = _ctxuser.CurrentUser.ConversationDictionary[selectedPerson];
                    message = sendFileOrMessageUCOnDetailUIEmployee._messageText.Text;
                }
                MessageP2P aaa = conver.SendMessage(message);
                ChatWDF newchat = new ChatWDF(conver);
                newchat.ShowDialog();
            
            }

            return;
        }

        
    }
}
