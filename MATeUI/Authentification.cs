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
using Network;
using System.IO;
using System.Threading;

namespace MATeUI
{
    public partial class Authentification : Form
    {
        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        static ContextAndUserManager _currentCtx;

        public Authentification()
        {
            InitializeComponent();
        }
        public static ContextAndUserManager CurrentCtxUser => _currentCtx;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
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
           
            bool newUser = false;
            
            if (userNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fill in the fields Mail address and Password");
                return;
            }

            if(!File.Exists("-Context.MATe"))
            {
                newUser = true;
                //nouvelle fenetre
                //demande de l ip + mail
                //lancement du requester avec mdp beurk
                var req = new RequestBoss();
                req.ShowDialog();
            }
            if (newUser == true) Thread.Sleep(4000);
            _currentCtx = new ContextAndUserManager(userNameTbx.Text);
            _currentCtx.Load("-Context.MATe");
            bool good = _currentCtx.Login(userNameTbx.Text);
            IPAddress CurrentIp = localIPs[ListIpCmb.SelectedIndex];

            if ( good == false)
            {
                MessageBox.Show("username or/and password invalid ");
                return;
            }
            if (_currentCtx.CurrentUser is MATeV2.Boss)
            {
                using (var ct = _currentCtx.ObtainAccessor())
                {
                    Context CTX = ct.Context;
                    //MessageBox.Show(CTX.PersonsDictionary["a@ex.com"].IP.ToString());
                    MATe.Services.Service.Start(_currentCtx, userNameTbx.Text.Trim(), ListIpCmb.SelectedIndex);
                    this.Visible = false;
                    _currentCtx.CurrentUser.IP = CurrentIp;
                }
                BossWindow pm = new BossWindow();
                pm.ShowDialog();
                Hide();
                
            }
            else if (_currentCtx.CurrentUser is Employee)
            {
                EmployeeUI eUI = new EmployeeUI();
                MATe.Services.Service.Start(_currentCtx, userNameTbx.Text.Trim(), ListIpCmb.SelectedIndex);
                ChatWDF.InitializeListener(_currentCtx.CurrentUser,1807);
                _currentCtx.CurrentUser.IP = CurrentIp;
                eUI.ShowDialog();
                Hide();
            }
        }
    }
}
