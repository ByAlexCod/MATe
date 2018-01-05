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
            if (_ctxuser != null)
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
            }

            projectManagementOnBody.ProjectItemChanged += new EventHandler(ShowDetailProject);
            projectManagementOnBody.DeleteSelectedProject += new ButtonClickedEventHandler(DeleteSelectedProject);
            detailProjectOnBody.UpdateProjectButtonClicked += new ButtonClickedEventHandler(OnUpdateButtonClicked);
            detailProjectOnBody.ValidatedProjectEvent += new ButtonClickedEventHandler(ValidatedProject);
            detailProjectOnBody.ButtonRemoveFromProjectClicked += new ButtonClickedEventHandler(OnRemoveButtonClicked);
            detailProjectOnBody.AddMemberInProjectButtonClicked += new ButtonClickedEventHandler(OnAddMemberInProject);
            detailProjectOnBody.RefreshPageButtonClicked += new ButtonClickedEventHandler(OnRefreshPage);
            detailProjectOnBody.ButtonChangeProjectManager += new ButtonClickedEventHandler(OnChangeProjectManger);
            detailProjectOnBody.CellTaskClick += new DetailProjectUC.DataGridViewCellMouseEventHandler(ShowDetailTask);
            projectManagementOnBody.MyAccountManagementEvent += new ProjectManagement.ButtonClickedEvent(ShowFormChangeAccount);
            
        }

        private void ValidatedProject(object sender, EventArgs e)
        {
            if (p == null) return;
            if (p.Tasks.Count <= 0) return;
            Tasker task = p.Tasks.Values.Where(tt => tt.IsValidated != true).FirstOrDefault();
            DialogResult res;
            if (p.Status != 1)
            {
                MessageBox.Show("This project is not validated by the project manager");
                return;
            }
            
                res = MessageBox.Show("Do you want to validate this Project ? " +
                                                       "", "Confirmation",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return;
            
            p.Status = 2;
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._validateProjectBtn.Enabled = false;
            projectManagementOnBody._projectStatusLbl.Text = "Project has been validated By The Boss";
        }

        int indexTask;
        Tasker task = null;
        private void ShowDetailTask(object sender, EventArgs e)
        {
            if (p != null)
            {
                if (p.Tasks.Count > 0)
                {
                    indexTask = detailProjectOnBody._dgTasks.CurrentRow.Index;
                    if (indexTask >= 0)
                    {
                        task = p.Tasks.Values.ToList().ElementAt(indexTask);
                        //task = p.Tasks.Where(tt => tt.Name.Equals(name)).FirstOrDefault();
                        if (task != null)
                        {
                            detailProjectOnBody._dgSubTasks.Rows.Clear();
                            foreach (var item in task.SubTasks.Values)
                            {
                                if(item.State== 0)
                                detailProjectOnBody._dgSubTasks.Rows.Add(item.Name, item.DateLimit.ToShortDateString(), item.Worker,"A Faire");
                                if (item.State == 1)
                                    detailProjectOnBody._dgSubTasks.Rows.Add(item.Name, item.DateLimit.ToShortDateString(), item.Worker, "En Cours");
                                if (item.State == 2)
                                    detailProjectOnBody._dgSubTasks.Rows.Add(item.Name, item.DateLimit.ToShortDateString(), item.Worker, "Fait");
                            }
                        }
                    }
                }
            }
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
            if(p.Members.Count == 0)
            {
                MessageBox.Show("THIS PROJECT CONTAINS ANY MEMBER", "WARNING");
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you change the Project Manager", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                return;
            int index = detailProjectOnBody._dgMemberInProject.CurrentRow.Index;
            p.Projectmanager = p.Members.Values.ToList().ElementAt(index);
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._firstNameLbl.Text = p.Projectmanager.Firstname;
            detailProjectOnBody._lastNameLbl.Text = p.Projectmanager.Lastname;
            detailProjectOnBody._mailLbl.Text = p.Projectmanager.Mail;
        }

       

        private void OnRefreshPage(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                DialogResult result = MessageBox.Show("Warning You Will Lose All Unsaved Data ", "Confirmation !", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) return;

                Context ctx = ct.Context;
                projectManagementOnBody._projectListCbx.DataSource = ctx.ProjectsDictionary.Values.ToArray();
                projectManagementOnBody._projectListCbx.SelectedItem = ctx.ProjectsDictionary.Values.LastOrDefault();
                detailProjectOnBody._dgEmployees.Rows.Clear();

                foreach (Employee item in ctx.PersonsDictionary.Values)
                {
                    detailProjectOnBody._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail,item.IP);
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
                p.Members.Add(emp.Mail, emp);
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
                if (p.Members.Count == 0)
                {
                    MessageBox.Show("The Project Contains Any Members");
                    return;
                }

                int index = detailProjectOnBody._dgMemberInProject.CurrentRow.Index;
                Employee emp = p.Members.Values.ToList().ElementAt(index);
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                    return;
                if (emp.Firstname.Equals(p.Projectmanager.Firstname) && emp.Lastname.Equals(p.Projectmanager.Lastname))
                {
                    MessageBox.Show("CAN NOT DELETE THE PROJECT MANAGER");
                    return;
                }
                foreach (Tasker item in p.Tasks.Values)
                {
                    foreach (SubTask sub in item.SubTasks.Values)
                    {
                        if(p.Members.Values.Where(member => member.Mail.Equals(sub.Worker.Mail)) != null && sub.State == 1)
                        {
                            MessageBox.Show("THIS EMPLOYEE CAN NOT BE DELETED BECAUSE HE IS WORKING ON A CURRENT SUB-TASK");
                            return;
                        }
                        if (p.Members.Values.Where(member => member.Mail.Equals(sub.Worker.Mail)) != null && sub.State == 0)
                        {
                            sub.Worker = null;
                        }
                    }
                }
                p.Members.Remove(p.Members.Values.ToList()[index].Mail);
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
                        //p.IsValidated = true;
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
                detailProjectOnBody._addToProjectBtn.Enabled = true;
                detailProjectOnBody._changeLeaderBtn.Enabled = true;
                detailProjectOnBody._removeMemberInProjectBtn.Enabled = true;
                detailProjectOnBody._updateProjectBtn.Enabled = true;
                detailProjectOnBody._validateProjectBtn.Enabled = true;

                int state = p.Status;
                if (state == 1)
                    projectManagementOnBody._projectStatusLbl.Text = "Project has been validated By The Project Manager";
                else if(state == 2)
                    projectManagementOnBody._projectStatusLbl.Text = "Project has been validated By The Boss";
                else
                    projectManagementOnBody._projectStatusLbl.Text = "Not Validated";
                
                if(state == 2 || state == 1)
                {
                    detailProjectOnBody._addToProjectBtn.Enabled = false;
                    detailProjectOnBody._changeLeaderBtn.Enabled = false;
                    detailProjectOnBody._removeMemberInProjectBtn.Enabled = false;
                    detailProjectOnBody._updateProjectBtn.Enabled = false;
                    detailProjectOnBody._validateProjectBtn.Enabled = false;
                }

                detailProjectOnBody.ProjectName.Text = p.Name;
                detailProjectOnBody._projectBeginDate.Value = p.DateBegin;
                detailProjectOnBody._projectEndDate.Value = p.DateLimit;

                if (p.Projectmanager != null)
                {
                    detailProjectOnBody._firstNameLbl.Text = p.Projectmanager.Firstname;
                    detailProjectOnBody._mailLbl.Text = p.Projectmanager.Mail;
                    detailProjectOnBody._lastNameLbl.Text = p.Projectmanager.Lastname;
                }
                detailProjectOnBody._dgSubTasks.Rows.Clear();
                detailProjectOnBody._dgTasks.Rows.Clear();
                detailProjectOnBody._dgMemberInProject.Rows.Clear();
                
                foreach (Tasker item in p.Tasks.Values)
                {
                    detailProjectOnBody._dgTasks.Rows.Add(item.Name, item.DateLimit.ToShortDateString(), item.Project);
                }
                foreach (Employee emp in p.Members.Values)
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
