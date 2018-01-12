using MATeV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATeUI
{
    public partial class ProfilForm : Form
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public ProfilForm()
        {
            InitializeComponent();
            Text = "Profil";
        }

        protected override void OnLoad(EventArgs e)
        {
            profilUC1._closeBtn.Click += new EventHandler(CloseForm);

            profilUC1.firstnameLbl.Text = _ctxuser.CurrentUser.Firstname;
            profilUC1.lastName.Text = _ctxuser.CurrentUser.Lastname;
            profilUC1.mailLbl.Text = _ctxuser.CurrentUser.Mail.ToString();
            profilUC1.ipLbl.Text = _ctxuser.CurrentUser.IP.ToString();


            base.OnLoad(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
