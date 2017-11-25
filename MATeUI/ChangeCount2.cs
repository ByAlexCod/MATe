using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
namespace MATeUI
{
    public partial class ChangeCount2 : UserControl
    {
        public ChangeCount2()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {   
            //Authentification.p.ModifyProfile(txtName.Text, txtLastName.Text, txtMail.Text, txtpwd.Text);   
            User.ModifyProfile(txtName.Text, txtLastName.Text, txtMail.Text, txtpwd.Text);
        }

        public Person User { get; set; }
        
    }
}
