using System;
using System.Linq;
using System.Windows.Forms;
using MATeV2;
using static MATeUI.DetailProjectEmployeeUC;


namespace MATeUI
{
    public partial class BodyUIEmployeeUC : UserControl
    {
        public BodyUIEmployeeUC()
        {
            InitializeComponent();
        }
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
     
        public Person CurrentUser { get; set; }
        
        Project p = null;
        Tasker task = null;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                
                foreach (Project item in ctx.ProjectsDictionary.Values)
                {
                    Employee emp = item.Members.Where(em => em.Mail.Equals(_ctxuser.CurrentUser.Mail)).FirstOrDefault();
                    if(emp != null)
                    {
                        projectManagement1._projectListCbx.Items.Add(item);
                    }
                    
                }
            }
            

            projectManagement1._addProjectBtn.Visible = false;
            projectManagement1._deleteProjectBtn.Visible = false;

            projectManagement1.ProjectItemChanged += new EventHandler(ShowDetailProject);
            detailProjectEmployeeUC1.CellTaskClick += new DetailProjectEmployeeUC.DataGridViewCellMouseEventHandler(ShowDetailTask);
            detailProjectEmployeeUC1.CellSubTaskClick += new DetailProjectEmployeeUC.DataGridViewCellMouseEventHandler(ChangeSubTaskItem);
            detailProjectEmployeeUC1.ChangeSubTaskButtonClicked += new ButtonClickedEventHandler(ChangeStateSubTaskButtonClicked);
            projectManagement1.MyAccountManagementEvent += new ProjectManagement.ButtonClickedEvent(ShowFormChangeAccount);
        }

        
        private void ChangeSubTaskItem(object sender, EventArgs e)
        {
            int index = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
            if (task == null) return;
            SubTask sub = task.SubTasks[index];
            if (p == null) return;
            if (sub == null) return;

            detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
            detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
            detailProjectEmployeeUC1._doRbtn.Enabled = true;

            if (sub.State == 0)
            {
                detailProjectEmployeeUC1._toDoRbtn.Checked = true;
            }

            if (sub.State == 2)
            {
                detailProjectEmployeeUC1._inProgressRbtn.Enabled = false;
                detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                detailProjectEmployeeUC1._doRbtn.Checked = true;
            }

            if (sub.State == 1)
            {
                detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                detailProjectEmployeeUC1._inProgressRbtn.Checked = true;
            }

        }

        private void ChangeStateSubTaskButtonClicked(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                int index = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
                if (task == null) return;
                SubTask sub = task.SubTasks[index];
                if (p == null) return;
                if(!Authentification.CurrentCtxUser.CurrentUser.Mail.Equals(sub.Worker.Mail))
                {
                    MessageBox.Show("This subtask did not give you");
                    return;
                }
                int currentState = p.Tasks.ElementAt(indexTask).SubTasks.ElementAt(index).State;

                if (detailProjectEmployeeUC1._toDoRbtn.Checked)
                {
                    p.Tasks[indexTask].SubTasks[index].State = 0;
                }
                if (detailProjectEmployeeUC1._doRbtn.Checked)
                {
                    if (currentState == 0)
                    {
                        MessageBox.Show("The subtask must start first");
                        detailProjectEmployeeUC1._toDoRbtn.Checked = true;
                        return;
                    }
                    p.Tasks.ElementAt(indexTask).SubTasks.ElementAt(index).State = 2;
                    detailProjectEmployeeUC1._inProgressRbtn.Enabled = false;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
                if (detailProjectEmployeeUC1._inProgressRbtn.Checked)
                {
                    p.Tasks.ElementAt(indexTask).SubTasks.ElementAt(index).State = 1;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
            }
        }

        int indexTask;
        private void ShowDetailTask(object sender, EventArgs e)
        {
            indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            if(indexTask >= 0)
            {
                task = p.Tasks.ElementAt(indexTask);
                //task = p.Tasks.Where(tt => tt.Name.Equals(name)).FirstOrDefault();
                if(task != null)
                {
                    detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                    detailProjectEmployeeUC1._doRbtn.Enabled = true;

                    detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                    foreach (var item in task.SubTasks)
                    {
                        detailProjectEmployeeUC1._dgSubTasks.Rows.Add(item.Name, item.DateLimit, item.Worker);
                    }
                }
            }
        }

        
        private void ShowDetailProject(object sender, EventArgs e)
        {
            p = sender as Project;
            
            if(p != null)
            {

                detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                detailProjectEmployeeUC1._doRbtn.Enabled = true;

                detailProjectEmployeeUC1._dgTasks.Rows.Clear();
                detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                foreach (Tasker item in p.Tasks)
                {
                    detailProjectEmployeeUC1._dgTasks.Rows.Add(item.Name, item.DateLimit,item.Project);
                }
            }
        }

        private void ShowFormChangeAccount(object sender,EventArgs e)
        {
            ChangeCount changeCount = new ChangeCount(Authentification.CurrentCtxUser.CurrentUser);
            changeCount.ShowDialog();
        }
    }
}
