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
using static MATeUI.DetailProjectUC;

namespace MATeUI
{
    public partial class ProjectManagement : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public ProjectManagement()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _deleteProjectBtn.Click += new EventHandler(DeleteSelectItem);
            _myAccountBtn.Click += new EventHandler(MyAccountButtonClicked);
            base.OnLoad(e);
            
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                //_projectListCbx.DataSource = ctx.ProjectsDictionary.Values.ToArray();
                _projectListCbx.SelectedItem = null;
                _projectListCbx.SelectedIndexChanged += new EventHandler(ItemProjectChanged);
            }

        }

        public delegate void ButtonClickedEvent(object sender, EventArgs e);
        public event ButtonClickedEvent MyAccountManagementEvent;
        private void MyAccountButtonClicked(object sender, EventArgs e)
        {
            if (MyAccountManagementEvent != null)
                MyAccountManagementEvent(this, e);
        }

        public event EventHandler ProjectItemChanged;
        private void ItemProjectChanged(object sender, EventArgs e)
        {
            if (ProjectItemChanged != null)
                this.ProjectItemChanged(_projectListCbx.SelectedItem, e);
        }
        public event ButtonClickedEventHandler DeleteSelectedProject;
        private void DeleteSelectItem(object sender, EventArgs e)
        {
            if (DeleteSelectedProject != null)
                DeleteSelectedProject(this, e);
        }

        private void _addProjectBtn_Click_1(object sender, EventArgs e)
        {
            CreatProject creatProject = new CreatProject();
            creatProject.ShowDialog();
        }
    }
}
