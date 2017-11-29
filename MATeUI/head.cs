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
    public partial class head : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public head()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _ctxuser.SaveAs("-Context.MATe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProjectManagement.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void modify_Click(object sender, EventArgs e)
        {
            ChangeCount pm = new ChangeCount(CurrentUser);
            pm.ShowDialog();
        }

        public Person CurrentUser { get; set; }
    }
}
