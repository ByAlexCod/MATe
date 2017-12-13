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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _ctxuser.SaveAs("-Context.MATe");
            MessageBox.Show("SUCCESS");
        }


    }
}
