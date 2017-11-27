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

        public Authentification()
        {
            InitializeComponent();
        }

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

        private void connexionBtn_Click(object sender, EventArgs e)
        {
            if(userNameTbx.Text.Trim().Equals("") && passwordTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("Fill in the fields Mail address and Password");
                return;
            }
            Person person = Service.GetPersonByID(userNameTbx.Text, passwordTbx.Text);
            if ( person == null)
            {
                MessageBox.Show("username or/and password invalid ");
                return;
            }
            if (person is Boss)
            {
                p = person;
                MATe.Services.Service.Start(passwordTbx.Text.Trim(), userNameTbx.Text.Trim(), ListIpCmb.SelectedIndex);
                this.Visible = false;
                //ChangeCount pm = new ChangeCount(p);
                ProjectManager pm = new ProjectManager(p);
                pm.ShowDialog();
                Close();
                /* ProjectManager pm = new ProjectManager(p);
                pm.ShowDialog();
                Close();*/
            } else if (person is Employee)
            {
                p = (Employee)person;
                ChangeCount pm = new ChangeCount(p);
                pm.ShowDialog();
                MessageBox.Show(person.Firstname + " vous êtes un employé.");
            }
        }
    }
}
