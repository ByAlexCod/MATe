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
    public partial class BodyUC : UserControl
    {
       
        Project p = null;
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        ICollection<Project> _projects = new List<Project>();
        public BodyUC()
        {
            InitializeComponent();
        }

        
        private void DetailProjectOnBody_Load(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                
                Context ctx = ct.Context;
                //Fill Combox Projects
                foreach (Project item in ctx.ProjectsDictionary.Values)
                {
                   projectManagementOnBody._projectListCbx.Items.Add(item);
                }
                // Fill DataGrid Employees

                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    detailProjectOnBody._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail, item.IP);
                }
            }


            projectManagementOnBody.ProjectItemChanged += new EventHandler(ShowDetailProject);
            projectManagementOnBody.DeleteSelectedProject += new ButtonClickedEventHandler(DeleteSelectedProject);
            detailProjectOnBody.UpdateProjectButtonClicked += new ButtonClickedEventHandler(OnUpdateButtonClicked);
            detailProjectOnBody.ButtonRemoveFromProjectClicked += new ButtonClickedEventHandler(OnRemoveButtonClicked);
            detailProjectOnBody.AddMemberInProjectButtonClicked += new ButtonClickedEventHandler(OnAddMemberInProject);
            detailProjectOnBody.RefreshPageButtonClicked += new ButtonClickedEventHandler(OnRefreshPage);
            detailProjectOnBody.ButtonChangeProjectManager += new ButtonClickedEventHandler(OnChangeProjectManger);
            detailProjectOnBody.AddTaskButton += new ButtonClickedEventHandler(OnAddTaskToProject);
            projectManagementOnBody.MyAccountManagementEvent += new ProjectManagement.ButtonClickedEvent(ShowFormChangeAccount);
            
        }

        private void ShowFormChangeAccount(object sender, EventArgs e)
        {
            ChangeCount changeCount = new ChangeCount(Authentification.CurrentCtxUser.CurrentUser);
            changeCount.ShowDialog();
        }

        private void DeleteSelectedProject(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())

            {
                Context ctx = ct.Context;
                if (p == null)
                {
                    MessageBox.Show("FIRST SELECT A PROJECT", "WARNING");
                    return;
                }
                DialogResult res = MessageBox.Show("Are you sure you delete this Project", "Confirmation",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return;
                ctx.ProjectsDictionary.Remove(p.Name);
                projectManagementOnBody._projectListCbx.DataSource = ctx.ProjectsDictionary.Values.ToArray();
                detailProjectOnBody._dgMemberInProject.Rows.Clear();
                detailProjectOnBody._dgTasks.Rows.Clear();
                detailProjectOnBody._lastNameLbl.Text = "---------------";
                detailProjectOnBody._mailLbl.Text = "---------------";
                detailProjectOnBody._firstNameLbl.Text = "---------------";
                detailProjectOnBody.ProjectName.Text = "";
                detailProjectOnBody._projectBeginDate.Value = DateTime.Now;
                detailProjectOnBody._projectEndDate.Value = DateTime.Now;
                projectManagementOnBody._projectListCbx.SelectedItem = null;
                p = null;
            }
        }
        private void OnChangeProjectManger(object sender, EventArgs e)
        {
            if(p == null)
            {
                MessageBox.Show("FIRST SELECT A PROJECT", "WARNING");
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you change the Project Manager", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                return;
            int index = detailProjectOnBody._dgMemberInProject.CurrentRow.Index;
            p.Projectmanager = p.Members.ElementAt(index);
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._firstNameLbl.Text = p.Projectmanager.Firstname;
            detailProjectOnBody._lastNameLbl.Text = p.Projectmanager.Lastname;
            detailProjectOnBody._mailLbl.Text = p.Projectmanager.Mail;
        }

        private void OnAddTaskToProject(object sender, EventArgs e)
        {
            if(p == null)
            {
                MessageBox.Show("FIRST SELECT A PROJECT", "WARNING");
                return;
            }
            if(detailProjectOnBody._taskNameTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("THE NAME OF A TASK MUST NOT BE EMPTY", "WARNING");
                return;
            }
            if (detailProjectOnBody._taskDate.Value > p.DateLimit)
            {
                MessageBox.Show("THE DATE OF THE END OF THE TASK MUST NOT EXCEED THE PROJECT", "WARNING");
                return;
            }
            Tasker tasker = new Tasker(detailProjectOnBody._taskNameTbx.Text, detailProjectOnBody._taskDate.Value);
            SubTask sub = new SubTask("Gestion UI", DateTime.Now,p.Members.ElementAt(0));
            SubTask sub2 = new SubTask("Gestion Rx", DateTime.Now, p.Members.ElementAt(0));
            sub.CurrentTask = tasker;
            sub2.CurrentTask = tasker;
            tasker.Project = p;
            tasker.SubTasks.Add(sub);
            tasker.SubTasks.Add(sub2);
            p.Tasks.Add(tasker);
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._dgTasks.Rows.Add(tasker.Name,tasker.DateLimit);
        }

        private void OnRefreshPage(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                projectManagementOnBody._projectListCbx.DataSource = ctx.ProjectsDictionary.Values.ToArray();
                projectManagementOnBody._projectListCbx.SelectedItem = ctx.ProjectsDictionary.Values.LastOrDefault();
                detailProjectOnBody._dgEmployees.Rows.Clear();
                
                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    detailProjectOnBody._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail);
                }

            }
        }

        private void OnAddMemberInProject(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                if (p == null)
                {
                    MessageBox.Show("FIRST SELECT A PROJECT");
                    return;
                }
                int index = detailProjectOnBody._dgEmployees.CurrentRow.Index;
                Employee emp = ctx.PersonsDictionary.Values.ElementAt(index);
                if (emp.CurrentWorkingProject != null)
                {
                    MessageBox.Show("THIS EMPLOYEE IS ALREADY IN A PROJECT");
                    return;
                }
                p.Members.Add(emp);
                emp.CurrentWorkingProject = p;
                ctx.PersonsDictionary.Values.ElementAt(index).CurrentWorkingProject = p;
                projectManagementOnBody._projectListCbx.SelectedItem = p;
                detailProjectOnBody._dgMemberInProject.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
            }
        }

        private void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                if (p == null)
                {
                    MessageBox.Show("FIRST SELECT A PROJECT");
                    return;
                }
                int index = detailProjectOnBody._dgMemberInProject.CurrentRow.Index;
                Employee emp = p.Members.ElementAt(index);
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return;
                if (emp.Firstname.Equals(p.Projectmanager.Firstname) && emp.Lastname.Equals(p.Projectmanager.Lastname))
                {
                    MessageBox.Show("CAN NOT DELETE THE PROJECT MANAGER");
                    return;
                }
                foreach (Tasker item in p.Tasks)
                {
                    foreach (SubTask sub in item.SubTasks)
                    {
                        if(p.Members.Where(member => member.Mail.Equals(sub.Worker.Mail)) != null && sub.State == 1)
                        {
                            MessageBox.Show("THIS EMPLOYEE CAN NOT BE DELETED BECAUSE HE IS WORKING ON A CURRENT SUB-TASK");
                            return;
                        }
                        if (p.Members.Where(member => member.Mail.Equals(sub.Worker.Mail)) != null && sub.State == 0)
                        {
                            sub.Worker = null;
                        }
                    }
                }
                p.Members.RemoveAt(index);
                detailProjectOnBody._dgMemberInProject.Rows.RemoveAt(index);
                projectManagementOnBody._projectListCbx.SelectedItem = p;
                int i = 0;
                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    if (item.Mail.Equals(emp.Mail))
                    {
                        ctx.PersonsDictionary.Values.ElementAt(index).CurrentWorkingProject = null;
                        break;
                    }
                    i++;
                }
            }
        }

        private void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                if (p == null)
                {
                    MessageBox.Show("FIRST SELECT A PROJECT");
                    return;
                }
                else
                {
                    bool trouve = false;
                    foreach (Project pr in ctx.ProjectsDictionary.Values)
                    {
                        if (pr.Name.Equals(p.Name))
                        {
                            p = pr;
                            trouve = true;
                            break;
                        }
                    }
                    if (trouve)
                    {
                        p.Name = detailProjectOnBody.ProjectName.Text;
                        p.DateBegin = detailProjectOnBody._projectBeginDate.Value;
                        p.DateLimit = detailProjectOnBody._projectEndDate.Value;
                        projectManagementOnBody._projectListCbx.SelectedItem = p;
                        
                        MessageBox.Show("Update completed");
                        return;
                    }

                }
            }

        }

        private void ShowDetailProject(object sender, EventArgs e)
        {
            p = sender as Project;
            if ((p != null))
            {
                detailProjectOnBody.ProjectName.Text = p.Name;
                detailProjectOnBody._projectBeginDate.Value = p.DateBegin;
                detailProjectOnBody._projectEndDate.Value = p.DateLimit;

                if (p.Projectmanager != null)
                {
                    detailProjectOnBody._firstNameLbl.Text = p.Projectmanager.Firstname;
                    detailProjectOnBody._mailLbl.Text = p.Projectmanager.Mail;
                    detailProjectOnBody._lastNameLbl.Text = p.Projectmanager.Lastname;
                }

                detailProjectOnBody._dgTasks.Rows.Clear();
                detailProjectOnBody._dgMemberInProject.Rows.Clear();
                
                foreach (Tasker item in p.Tasks)
                {
                    detailProjectOnBody._dgTasks.Rows.Add(item.Name, item.DateLimit);
                }
                foreach (Employee emp in p.Members)
                {
                    detailProjectOnBody._dgMemberInProject.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
                }
            }
            
        }

        private void ProjectManagementOnBody_Load(object sender, EventArgs e)
        {
            var tt = sender;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
