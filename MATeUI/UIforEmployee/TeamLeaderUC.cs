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
using MATeUI.UIforEmployee;

namespace MATeUI
{
    public partial class TeamLeaderUC : UserControl
    {
        Project p;
        public TeamLeaderUC()
        {
            InitializeComponent();
        }
        //public event ButtonClickedEventHandler ChangeSubTaskButtonClicked;
        private void NewTaskBtn_Click(object sender, EventArgs e)
        {
            var newtask = new NewTaskForm(p);
            newtask.ShowDialog();
        }

        private void NewSubBtn_Click(object sender, EventArgs e)
        {
            var newstask = new NewSubTaskForm(p);
            newstask.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //ChangeStateBtn.Click += new EventHandler(SubTaskChangeButtonClicked);
        }

        //private void SubTaskChangeButtonClicked(object sender, EventArgs e) => ChangeSubTaskButtonClicked?.Invoke(this, e);
    }
}
