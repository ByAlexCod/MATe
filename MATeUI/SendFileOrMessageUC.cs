using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATeUI
{
    public partial class SendFileOrMessageUC : UserControl
    {
        public SendFileOrMessageUC()
        {
            InitializeComponent();
        }

        //Delegate declaration
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void RadioEventHandler(object sender, EventArgs e);

        //Event declaration
        public event RadioEventHandler CheckedOption;
        public event ButtonClickedEventHandler SendButtonClicked;
        public event EventHandler FolderBrowser;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _sendFileRbtn.CheckedChanged += new EventHandler(ShowPanel);
            _sendBtn.Click += new EventHandler(ButtonSendClicked);
            _chooseFolderLbl.Click += new EventHandler(OpenDialogueBrowser);
        }

        private void OpenDialogueBrowser(object sender, EventArgs e) => FolderBrowser?.Invoke(this, e);

        private void ShowPanel(object sender, EventArgs e) => CheckedOption?.Invoke(this, e);
        
        private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);
    }
}
