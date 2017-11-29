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
    public partial class ChangeCount: Form
    {
        public ChangeCount(Person user)
        {
            InitializeComponent();
        }
        
        private void changeCount21_Load(object sender, EventArgs e)
        {
            changeCount21.ChangeButton += new ChangeCount2.ButtonClickedEventHandler(ChangeCount22);
            changeCount21.txtName.Text = Authentification.p.Firstname;
            changeCount21.txtLastName.Text = Authentification.p.Lastname;
            changeCount21.txtMail.Text = Authentification.p.Mail;
        }

        private void ChangeCount22(object sender, EventArgs e)
        {
            //Person p = Authentification.p;
            //if (Authentification.p.Mail.Equals(Context.GetContext().getBoss().Mail)){
            //    Boss b = new Boss(Context.GetContext() , changeCount21.txtName.Text, changeCount21.txtLastName.Text, changeCount21.txtMail.Text, changeCount21.txtpwd.Text);
            //}
            //int i = 0;
            //foreach (var item in Context.GetContext().PersonList.Values)
            //{
            //    if(item.Mail.Equals(p.Mail))
            //    {
            //        Context.GetContext().PersonList.Values.ElementAt(i).Mail = changeCount21.txtMail.Text;
            //        Context.GetContext().PersonList.Values.ElementAt(i).Firstname = changeCount21.txtName.Text;
            //        Context.GetContext().PersonList.Values.ElementAt(i).Lastname = changeCount21.txtLastName.Text;
            //        Context.GetContext().PersonList.Values.ElementAt(i).Password = changeCount21.txtpwd.Text;
            //        break;
            //    }
            //    i++;
            //}

            MessageBox.Show("Profile Change");
        }
    }
}
