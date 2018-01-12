using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATeUI
{
    public partial class ProfilUC : UserControl
    {
        public ProfilUC()
        {
            InitializeComponent();
        }

        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ButtonCloseClicked;
        private void CloseFormProfil(object sender, EventArgs e)
        {
            ButtonCloseClicked?.Invoke(this, e);
        }
    }
}
