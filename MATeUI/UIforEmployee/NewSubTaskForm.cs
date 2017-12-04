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

namespace MATeUI.UIforEmployee
{
    public partial class NewSubTaskForm : Form
    {
        public NewSubTaskForm(Project p)
        {
            InitializeComponent();
            this.newSubTaskUC1.CurrentProject = p;
        }
    }
}
