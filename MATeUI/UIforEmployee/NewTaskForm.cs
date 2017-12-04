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
    public partial class NewTaskForm : Form
    {
        public NewTaskForm(Project p)
        {
            InitializeComponent();
            this.newTaskUC1.CurrentProject = p;
        }
    }
}
