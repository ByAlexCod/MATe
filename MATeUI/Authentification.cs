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

namespace MATeUI
{
    public partial class Authentification : Form
    {
        public static Person p = null;
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
            foreach(IPAddress ip in localIPs)
            {
                ListIpCmb.Items.Add(ip.ToString());
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal void CreateTestContext()
        {
            ContextAndUserManager ctt = new ContextAndUserManager("In'Tech", true);
            ctt.SaveAs("-Context.MATe");
        }
        private void connexionBtn_Click(object sender, EventArgs e)
        {
            if (userNameTbx.Text.Trim().Equals("") && passwordTbx.Text.Trim().Equals(""))
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
                
                if(_currentCtx.Login(userNameTbx.Text) == true)
                {
                    ProjectManager pm = new ProjectManager();
                    pm.ShowDialog();
                    Close();
                }
                
            } else if (_currentCtx.CurrentUser is Employee)
            {
                
                //ChangeCount pm = new ChangeCount(p);
                //pm.ShowDialog();
                MessageBox.Show(_currentCtx.CurrentUser.Firstname + " vous êtes un employé.");
            }
        }
    }
}
