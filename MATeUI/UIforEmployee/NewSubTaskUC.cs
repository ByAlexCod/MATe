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

namespace MATeUI.UIforEmployee
{
    public partial class NewSubTaskUC : UserControl
    {
        public NewSubTaskUC()
        {
            InitializeComponent();
        }

        public Project CurrentProject { get; set; }
    }
}
