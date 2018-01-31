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
using System.Threading;
using System.IO;
using System.IO.Compression;
using Network;

namespace MATeUI
{
    public partial class SendFileOrMessageUC : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public SendFileOrMessageUC()
        {
            InitializeComponent();
        }

        //Delegate declaration
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void RadioEventHandler(object sender, EventArgs e);
        public delegate void DataGridViewCellMouseEventHandler(object sender, EventArgs e);

        //Event declaration
        public event RadioEventHandler CheckedOption;
        public event ButtonClickedEventHandler SendButtonClicked;
        public event EventHandler FolderBrowser;
        public event DataGridViewCellMouseEventHandler cellclicked;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _sendFileRbtn.CheckedChanged += new EventHandler(ShowPanel);
            _sendBtn.Click += new EventHandler(ButtonSendClicked);
            _chooseFolderLbl.Click += new EventHandler(OpenDialogueBrowser);
            ListConversation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(CellConversationClicked);
            string fileName;
            if (System.IO.Directory.Exists("Document"))
            {
                string[] files = System.IO.Directory.GetFiles("Document");
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    ListFile.Items.Add(fileName);
                }
            }
        }

        private void OpenDialogueBrowser(object sender, EventArgs e) => FolderBrowser?.Invoke(this, e);

        private void ShowPanel(object sender, EventArgs e) => CheckedOption?.Invoke(this, e);
        
        private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);

        private void CellConversationClicked(object sender, EventArgs e) => cellclicked?.Invoke(this, e);

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string targetPath = "Document";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((myStream = openFileDialog1.OpenFile() ) != null)
                    {
                        using (myStream)
                        {
                            string filename = Path.GetFileName(((FileStream)myStream).Name);
                            string destFile = System.IO.Path.Combine(targetPath, filename);
                            System.IO.File.Copy(((FileStream)myStream).Name, destFile, true);
                            MessageBox.Show(((FileStream)myStream).Name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("bonjour.zip"))
            {
                File.Delete("bonjour.zip");
            }
            ZipFile.CreateFromDirectory("Document", "bonjour.zip");
            SendFile a = new SendFile();
            int rowindex = _dgEmployees.CurrentCell.RowIndex;

            string userselected = _dgEmployees.Rows[rowindex].Cells[2].Value.ToString();
            Person selectedPerson = _ctxuser.Context.PersonsDictionary[userselected];
            a.SendTCP("bonjour.zip", selectedPerson.IPString, 18000);
            File.Delete("bonjour.zip");
        }
    }
}
