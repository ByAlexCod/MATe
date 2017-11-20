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
        List<Employee> employeesFree = null;
        Project p = null;
        Context _context = Context.GetContext();
        ICollection<Project> _projects = new List<Project>();
        ICollection<Employee> _employeeInProject = new List<Employee>();
        ICollection<Employee> _employees = new List<Employee>();
        public BodyUC()
        {
            InitializeComponent();
        }

        
        private void DetailProjectOnBody_Load(object sender, EventArgs e)
        {
            projectManagementOnBody.ProjectItemChanged += new EventHandler(ShowDetailProject);
            projectManagementOnBody.DeleteSelectedProject += new ButtonClickedEventHandler(DeleteSelectedProject);
            detailProjectOnBody.UpdateProjectButtonClicked += new ButtonClickedEventHandler(OnUpdateButtonClicked);
            detailProjectOnBody.ButtonRemoveFromProjectClicked += new ButtonClickedEventHandler(OnRemoveButtonClicked);
            detailProjectOnBody.AddMemberInProjectButtonClicked += new ButtonClickedEventHandler(OnAddMemberInProject);
            detailProjectOnBody.RefreshPageButtonClicked += new ButtonClickedEventHandler(OnRefreshPage);
            detailProjectOnBody.ButtonChangeProjectManager += new ButtonClickedEventHandler(OnChangeProjectManger);
            detailProjectOnBody.AddTaskButton += new ButtonClickedEventHandler(OnAddTaskToProject);

            //if(projectManagementOnBody._projectListCbx.SelectedItem == null)

        }

        private void DeleteSelectedProject(object sender, EventArgs e)
        {
            
            if (p == null)
            {
                MessageBox.Show("FIRST SELECT A PROJECT", "WARNING");
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure you delete this Project", "Confirmation",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
                return;
            Context.GetContext().ProjectsList.Remove(p.Name);
            projectManagementOnBody._projectListCbx.DataSource = Context.GetContext().ProjectsList.Values.ToArray();
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
            p.Tasks.Add(tasker);
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._dgTasks.Rows.Add(tasker.Name,tasker.DateLimit);
        }

        private void OnRefreshPage(object sender, EventArgs e)
        {
            projectManagementOnBody._projectListCbx.DataSource = Context.GetContext().ProjectsList.Values.ToArray();
            projectManagementOnBody._projectListCbx.SelectedItem = Context.GetContext().ProjectsList.Values.LastOrDefault();
            detailProjectOnBody._dgEmployees.Rows.Clear();
            employeesFree = new List<Employee>();
            foreach (Employee item in Context.GetContext().PersonList.Values)
            {
                //if (item.CurrentWorkingProject == null)
                    employeesFree.Add(item);
            }
            foreach (Employee item in Context.GetContext().PersonList.Values)
            {
                detailProjectOnBody._dgEmployees.Rows.Add(item.Firstname, item.Lastname, item.Mail);
            }
            

        }

        private void OnAddMemberInProject(object sender, EventArgs e)
        {
            if(p == null)
            {
                MessageBox.Show("FIRST SELECT A PROJECT");
                return;
            }
            int index = detailProjectOnBody._dgEmployees.CurrentRow.Index;
            Employee emp = employeesFree.ElementAt(index);
            if(emp.CurrentWorkingProject != null)
            {
                MessageBox.Show("THIS EMPLOYEE IS ALREADY IN A PROJECT");
                return;
            }
            
            //_employees.Add(emp);
            //_employeeInProject.Add(emp);
            p.Members.Add(emp);
            emp.CurrentWorkingProject = p;
            employeesFree.ElementAt(index).CurrentWorkingProject = p;
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            detailProjectOnBody._dgMemberInProject.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
           // detailProjectOnBody._dgEmployees.Rows.RemoveAt(index);
        }

        private void OnRemoveButtonClicked(object sender, EventArgs e)
        {
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
            p.Members.RemoveAt(index);
            //_employeeInProject.Remove(emp);
            detailProjectOnBody._dgMemberInProject.Rows.RemoveAt(index);
            projectManagementOnBody._projectListCbx.SelectedItem = p;
            int i = 0;
            foreach (Employee item in employeesFree)
            {
                if (item.Mail.Equals(emp.Mail))
                {
                    employeesFree.ElementAt(i).CurrentWorkingProject = null;
                    break;
                }
                i++;
            }
            //detailProjectOnBody._dgEmployees.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
            //detailProjectOnBody._dgMemberInProject.Rows.RemoveAt(index);
        }

        private void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            if (p == null)
            {
                MessageBox.Show("FIRST SELECT A PROJECT");
                return;
            }
            else
            {
                p.Name = detailProjectOnBody.ProjectName.Text;
                p.DateBegin = detailProjectOnBody._projectBeginDate.Value;
                p.DateLimit = detailProjectOnBody._projectEndDate.Value;
                projectManagementOnBody._projectListCbx.SelectedItem = p;

                bool trouve = false;
                foreach(Project pr in _context.ProjectsList.Values)
                {           
                    if (pr.Name.Equals(p.Name))
                    {
                        p = pr;
                        trouve = true;
                        break;
                    }
                }
                if(trouve)
                {
                    //_context.ProjectsList.Remove(p.Name);
                    //_context.ProjectsList.Add(p.Name, p);
                    _projects = _context.ProjectsList.Values;
                    //projectManagementOnBody._projectListCbx.SelectedItem = p;
                    
                    projectManagementOnBody._projectListCbx.DataSource = _projects.ToArray();
                    p.Members.Clear();
                    detailProjectOnBody._dgMemberInProject.Rows.Clear();
                    foreach (Employee emp in _employeeInProject)
                    {
                        p.Members.Add(emp);
                        detailProjectOnBody._dgMemberInProject.Rows.Add(emp.Firstname, emp.Lastname, emp.Mail);
                    }
                    foreach (Employee emp in _employees)
                    {
                        p.Members.Add(emp);
                    }
                   // projectManagementOnBody._projectListCbx.DataSource = _projects.ToArray();
                    MessageBox.Show("Update completed");
                    return;
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
                _employeeInProject.Clear();
                _employees.Clear();

                //detailProjectOnBody._dgMemberInProject.DataSource = p.Members;

                foreach (Tasker item in p.Tasks)
                {
                    detailProjectOnBody._dgTasks.Rows.Add(item.Name, item.DateLimit);
                }
                foreach (Employee emp in p.Members)
                {
                    _employeeInProject.Add(emp);
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
