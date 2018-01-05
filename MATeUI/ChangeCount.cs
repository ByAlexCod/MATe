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
namespace MATeUI
{
    public partial class ChangeCount : Form
    {        
        public ChangeCount(Person user)
        {
            InitializeComponent();

        }
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        private void changeCount21_Load(object sender, EventArgs e)
        {
            changeCount21.ChangeButton += new ChangeCount2.ButtonClickedEventHandler(ChangeCount22);
            changeCount21.txtName.Text = Authentification.CurrentCtxUser.CurrentUser.Firstname; ;
            changeCount21.txtLastName.Text = Authentification.CurrentCtxUser.CurrentUser.Lastname;
          
        }

        private void ChangeCount22(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                var s = Authentification.CurrentCtxUser.CurrentUser;
                s.ModifyProfile(changeCount21.txtName.Text, changeCount21.txtLastName.Text);
                _ctxuser.SaveAs("-Context.MATe");
                MessageBox.Show("Saved data");                 
                this.Close();
            } 
        }

    }
}
