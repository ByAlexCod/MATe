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
    public partial class ModifyAccount2 : UserControl
    {
        public ModifyAccount2()
        {
            InitializeComponent();
        }     
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ChangeButton;
        private void ButtonChange(object sender, EventArgs e) {
            if(ChangeButton != null)
            {
                ChangeButton(this, e);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            btnChange.Click += new EventHandler(ButtonChange);
        }
        public Person User { get; set; }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
