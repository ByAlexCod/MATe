using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network;
using System.Net;
using System.Threading;

namespace MATeUI
{
    public partial class RequestBoss : Form
    {
        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        List<string> _ips;
        public RequestBoss(string yourip,string mail)
        {
            InitializeComponent();
            MailTbx.Text = mail;
            _ips = new List<string>();
            foreach (IPAddress ip in localIPs)
            {
                IPsCbx.Items.Add(ip.ToString());
                _ips.Add(ip.ToString());
            }
            IPsCbx.SelectedIndex = _ips.IndexOf(yourip);
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            string ip = IPTbx.Text;
            string mail = MailTbx.Text;
            var Request = new Requester(ip, mail, "0000", IPsCbx.SelectedIndex);
            var abc = new Thread(Request.Send);
            abc.IsBackground = true;
            abc.Start();
            this.Close();
        }
    }
}
