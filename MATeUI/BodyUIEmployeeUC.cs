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
                detailProjectEmployeeUC1._taskGbx.Visible = false;
                detailProjectEmployeeUC1._subTaskGbx.Visible = false;

                Context ctx = ct.Context;
                
                foreach (Project item in ctx.ProjectsDictionary.Values)
                {
                    Employee emp = item.Members.Values.Where(em => em.Mail.Equals(_ctxuser.CurrentUser.Mail)).FirstOrDefault();
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

            detailProjectEmployeeUC1.CreateTaskButtonClicked += new ButtonClickedEventHandler(CreateTask);
            detailProjectEmployeeUC1.CreateSubTaskButtonClicked += new ButtonClickedEventHandler(CreateSubTask);

            detailProjectEmployeeUC1.ValidateTaskButtonClicked += new ButtonClickedEventHandler(ValidateTask);
            detailProjectEmployeeUC1.ValidateProjectButtonClicked += new ButtonClickedEventHandler(ValidateProject);

        }

        private void ValidateProject(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ValidateTask(object sender, EventArgs e)
        {
            if (p == null) return;
            if (p.Tasks.Count <= 0) return;
            int indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
            if (p.Tasks.Values.ToList().ElementAt(indexTask).IsValidated == true)
            {
                MessageBox.Show("This task is already committed!!!");
                return;
            }
                p.Tasks.Values.ToList().ElementAt(indexTask).IsValidated = true;
            MessageBox.Show("TASK VALIDATED !!!");
        }

        private void CreateSubTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateTask(object sender, EventArgs e)
        {
            if (p == null)
            {
                MessageBox.Show("SELECT A PROJECT FIRST");
                return;
            }
            if (detailProjectEmployeeUC1._taskNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("fill in the field name of the task ");
                return;
            }
            Tasker task = new Tasker(p, detailProjectEmployeeUC1._taskNameTbx.Text, detailProjectEmployeeUC1.endDateTaskDpk.Value);
            detailProjectEmployeeUC1._dgTasks.Rows.Add(task.Name, task.DateLimit, task.Project);
        }

        private void ChangeSubTaskItem(object sender, EventArgs e)
        {
            int index = detailProjectEmployeeUC1._dgSubTasks.CurrentRow.Index;
            if (task == null) return;
            SubTask sub = task.SubTasks.Values.ToList()[index];
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
                SubTask sub = task.SubTasks.Values.ToList()[index];
                if (p == null) return;
                if(!Authentification.CurrentCtxUser.CurrentUser.Mail.Equals(sub.Worker.Mail))
                {
                    MessageBox.Show("This subtask did not give you");
                    return;
                }
                int currentState = p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State;

                if (detailProjectEmployeeUC1._toDoRbtn.Checked)
                {
                    p.Tasks.Values.ToList()[indexTask].SubTasks.Values.ToList()[index].State = 0;
                }
                if (detailProjectEmployeeUC1._doRbtn.Checked)
                {
                    if (currentState == 0)
                    {
                        MessageBox.Show("The subtask must start first");
                        detailProjectEmployeeUC1._toDoRbtn.Checked = true;
                        return;
                    }
                    p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State = 2;
                    detailProjectEmployeeUC1._inProgressRbtn.Enabled = false;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
                if (detailProjectEmployeeUC1._inProgressRbtn.Checked)
                {
                    p.Tasks.Values.ToList().ElementAt(indexTask).SubTasks.Values.ToList().ElementAt(index).State = 1;
                    detailProjectEmployeeUC1._toDoRbtn.Enabled = false;
                    projectManagement1._projectListCbx.SelectedItem = p;
                }
            }
        }

        int indexTask;
        private void ShowDetailTask(object sender, EventArgs e)
        {
            if(p != null)
            {
                indexTask = detailProjectEmployeeUC1._dgTasks.CurrentRow.Index;
                detailProjectEmployeeUC1._createSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateTaskBtn.Enabled = true;
                if (indexTask >= 0)
                {
                    task = p.Tasks.Values.ToList().ElementAt(indexTask);
                    //task = p.Tasks.Where(tt => tt.Name.Equals(name)).FirstOrDefault();
                    if (task != null)
                    {
                        if(task.IsValidated == true)
                        {
                            detailProjectEmployeeUC1._createSubTaskBtn.Enabled = false;
                            detailProjectEmployeeUC1._validateTaskBtn.Enabled = false;
                        }
                        detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                        detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                        detailProjectEmployeeUC1._doRbtn.Enabled = true;


                        detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                        foreach (var item in task.SubTasks.Values)
                        {
                            detailProjectEmployeeUC1._dgSubTasks.Rows.Add(item.Name, item.DateLimit, item.Worker);
                        }
                    }
                }
            }
        }

        
        private void ShowDetailProject(object sender, EventArgs e)
        {
            p = sender as Project;
            
            if(p != null)
            {
                detailProjectEmployeeUC1._createTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._createSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._createTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._changeSubTaskBtn.Enabled = true;
                detailProjectEmployeeUC1._validateProjectBtn.Enabled = true;
                if (p.IsValidated == true)
                {
                    detailProjectEmployeeUC1._createTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._createSubTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._createTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._validateTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._changeSubTaskBtn.Enabled = false;
                    detailProjectEmployeeUC1._validateProjectBtn.Enabled = false;
                }

                if (p.Projectmanager == null) return;
                detailProjectEmployeeUC1._taskGbx.Visible = false;
                detailProjectEmployeeUC1._subTaskGbx.Visible = false;
                if (p.Projectmanager.Mail.Equals(Authentification.CurrentCtxUser.CurrentUser.Mail))
                {
                    detailProjectEmployeeUC1._taskGbx.Visible = true;
                    detailProjectEmployeeUC1._subTaskGbx.Visible = true;
                    detailProjectEmployeeUC1._projectMembers.DataSource = p.Members.Values.ToArray();
                }

                detailProjectEmployeeUC1._inProgressRbtn.Enabled = true;
                detailProjectEmployeeUC1._toDoRbtn.Enabled = true;
                detailProjectEmployeeUC1._doRbtn.Enabled = true;

                detailProjectEmployeeUC1._dgTasks.Rows.Clear();
                detailProjectEmployeeUC1._dgSubTasks.Rows.Clear();
                foreach (Tasker item in p.Tasks.Values)
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
