using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
using MATe.Services;
using System.Net;
using System.Net.Sockets;

namespace MATeUI
{
    public partial class Authentification : Form
    {
        Socket socket;
        EndPoint ipLocal, ipRemote;
        byte[] buffer;

        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        static ContextAndUserManager _currentCtx;

        public Authentification()
        {
            InitializeComponent();
        }
        public static ContextAndUserManager CurrentCtxUser => _currentCtx;



        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


            foreach (IPAddress ip in localIPs)
            {
                ListIpCmb.Items.Add(ip.ToString());
            }
        }

        
        internal void CreateTestContext()
        {
            ContextAndUserManager ctt = new ContextAndUserManager("In'Tech", true);
            ctt.SaveAs("-Context.MATe");
        }
        private void ConnexionBtn_Click(object sender, EventArgs e)
        {
            if (userNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fill in the fields Mail address and Password");
                return;
            }

            _currentCtx = new ContextAndUserManager(userNameTbx.Text);
            _currentCtx.Load("-Context.MATe");
            bool good = _currentCtx.Login(userNameTbx.Text);

            
            
            if ( good == false)
            {
                MessageBox.Show("username or/and password invalid ");
                return;
            }
            if (_currentCtx.CurrentUser is Boss)
            {
                MATe.Services.Service.Start(_currentCtx, userNameTbx.Text.Trim(), ListIpCmb.SelectedIndex);
                this.Visible = false;    
                 ProjectManager pm = new ProjectManager();
                 pm.ShowDialog();
                 Close();
            }
            else if (_currentCtx.CurrentUser is Employee)
            {
                EmployeeUI eUI = new EmployeeUI();
                eUI.ShowDialog();
                Close();
            }
        }
    }
}
