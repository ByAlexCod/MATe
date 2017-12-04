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


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            sendFileOrMessageUCOnDetailUIEmployee._sendFileRbtn.CheckedChanged += new EventHandler(CheckedOption);
            _dgTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellTaskChanged);
            _changeSubTaskBtn.Click += new EventHandler(SubTaskChangeButtonClicked);
            _dgSubTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellSubTaskChanged);
            sendFileOrMessageUCOnDetailUIEmployee._sendBtn.Click += new EventHandler(SendFileOrMessage);
            sendFileOrMessageUCOnDetailUIEmployee._chooseFolderLbl.Click += new EventHandler(OpenDialogue);
            sendFileOrMessageUCOnDetailUIEmployee._sendFileRbtn.Checked = true;
            if (_ctxuser != null)
            {
                using (var ct = _ctxuser.ObtainAccessor())
                {
                    Context ctx = ct.Context;
                    foreach (Employee item in ctx.PersonsDictionary.Values)
                    {
                        sendFileOrMessageUCOnDetailUIEmployee._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail, item.IP);
                    }
                }
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

        private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);

        private void CellSubTaskChanged(object sender, EventArgs e) => CellSubTaskClick?.Invoke(this, e);

        private void CellTaskChanged(object sender, EventArgs e) => CellTaskClick?.Invoke(this, e);

      
        
        /// <summary>
        /// Methode de l'evenement des changement des button radion Send File et Send Message 
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
            MessageBox.Show("NOT IMPLEMENTED YET");
            return;
        }

        private void sendFileOrMessageUCOnDetailUIEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
