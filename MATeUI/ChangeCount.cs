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
            //this.changeCount21.User = user;            
            InitializeComponent();
        }

        private void changeCount21_Load(object sender, EventArgs e)
        {
            changeCount21.ChangeButton += new ChangeCount2.ButtonClickedEventHandler(ChangeCount22);
        }

        private void ChangeCount22(object sender, EventArgs e)
        {
            Person p = Authentification.p;
            //Authentification.p.ModifyProfile(changeCount21.txtName.Text, changeCount21.txtLastName.Text, changeCount21.txtMail.Text, changeCount21.txtpwd.Text);
            
            MessageBox.Show("Profile Change");
        }
    }
}
