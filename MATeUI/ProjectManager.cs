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
    public partial class ProjectManager : Form
    {
        Person _actualUser;
        public ProjectManager(Person actualUser)
        {
            _actualUser = actualUser;
            InitializeComponent();
            this.head1.CurrentUser = _actualUser;
        }

        
        
        private void BodyUC1_Load(object sender, EventArgs e)
        {
            //this.bodyUC1. // projectItemChanged += ProjectManagement_projectItemChanged;
        }

        private void ProjectManagement_projectItemChanged(object sender, EventArgs e)
        {
            //this.detailProject._
        }

        private void bodyUC1_Load_1(object sender, EventArgs e)
        {

        }

        private void ProjectManager_Load(object sender, EventArgs e)
        {

        }
    }
}
