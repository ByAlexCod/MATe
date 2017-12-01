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
            changeCount21.txtName.Text = Authentification.CurrentCtxUser.CurrentUser.Firstname;
            changeCount21.txtLastName.Text = Authentification.CurrentCtxUser.CurrentUser.Lastname;
            changeCount21.txtMail.Text = Authentification.CurrentCtxUser.CurrentUser.Mail;
        }

        private void ChangeCount22(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                int i = 0;
                foreach (var item in ctx.PersonsDictionary.Values)
                {
                    if (item.Mail.Equals(Authentification.CurrentCtxUser.CurrentUser.Mail))
                    {
                        /*if (changeCount21.txtMail.Text == ctx.PersonsDictionary.Values.ElementAt(i).Mail && Authentification.CurrentCtxUser.CurrentUser.Mail != changeCount21.txtMail.Text)
                        {
                            MessageBox.Show("this mail is already exist");

                        }
                        else
                        {*/
                            ctx.PersonsDictionary.Values.ElementAt(i).Mail = changeCount21.txtMail.Text;
                            ctx.PersonsDictionary.Values.ElementAt(i).Firstname = changeCount21.txtName.Text;
                            ctx.PersonsDictionary.Values.ElementAt(i).Lastname = changeCount21.txtLastName.Text;
                            break;
                        //}
                    }
                    i++;
                }
                
                if (Authentification.CurrentCtxUser.CurrentUser is Boss)
                {
                    ctx.Boss.Mail = changeCount21.txtMail.Text;
                    ctx.Boss.Firstname = changeCount21.txtName.Text;
                    ctx.Boss.Lastname = changeCount21.txtLastName.Text;
                }
                MessageBox.Show("Profile Change");
            }
            
        }

        private void head1_Load(object sender, EventArgs e)
        {

           
        }
    }
}
