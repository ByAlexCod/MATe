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


        
        ICollection<Project> _projects = new List<Project>();
        ICollection<Employee> _employees = new List<Employee>();
        Context _context = Context.GetContext();
        public ProjectManagement()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            _deleteProjectBtn.Click += new EventHandler(DeleteSelectItem);

            base.OnLoad(e);
            //Project p4 = new Project("Dev web", new DateTime(2017, 11, 11), new DateTime(2017, 12, 15));
            //Project p1 = new Project("ITI world", new DateTime(2016, 10, 09), new DateTime(2016, 12, 15));
            //Project p2 = new Project("Dev C#", new DateTime(2014, 07, 01), new DateTime(2015, 03, 07));
            //Project p3 = new Project("First Project", new DateTime(2013, 02, 18), new DateTime(2014, 09, 15));
            //ICollection<Project> projects = new List<Project>();

            //Employee emp1 = new Employee(Context.GetContext(), "Boua", "Tra", "mate@1.com", "bla");
            //Employee emp2 = new Employee(Context.GetContext(), "Fat", "Simp", "mate@116.com", "bla");
            //Employee emp3 = new Employee(Context.GetContext(), "Baba", "tra", "mate@56.com", "bla");
            //Employee emp4 = new Employee(Context.GetContext(), "Moustpah", "Ngom", "mate@11.com", "bla");
            //Employee emp5 = new Employee(Context.GetContext(), "Amadou", "Tra", "mate@12.com", "bla");
            //Employee emp6 = new Employee(Context.GetContext(), "Bad", "Simp", "mate@67.com", "bla");
            //Employee emp7 = new Employee(Context.GetContext(), "Aly", "Cam", "mate@9.com", "bla");
            //Employee emp8 = new Employee(Context.GetContext(), "Mamou", "konate", "mate10@.com", "bla");
            //Employee emp9 = new Employee(Context.GetContext(), "Aich", "Zio", "azio@.com", "bla");
            //Employee emp10 = new Employee(Context.GetContext(), "Dado", "Kouma", "dkom@.com", "bla");
            //_employees.Add(emp1); _employees.Add(emp3); _employees.Add(emp5); _employees.Add(emp7); _employees.Add(emp9);
            //_employees.Add(emp2); _employees.Add(emp4); _employees.Add(emp6); _employees.Add(emp8); _employees.Add(emp10);


            //p1.Members.Add(emp1);
            //p1.Members.Add(emp3);
            //p1.Members.Add(emp5);
            //p1.Projectmanager = emp1;
            //p1.Tasks.Add(new Tasker("First Task", DateTime.Now));
            //p1.Tasks.Add(new Tasker("Second Task ", DateTime.Now));
            //p1.Tasks.Add(new Tasker("Thirst Task ", DateTime.Now));



            //p2.Members.Add(emp4);
            //p2.Members.Add(emp6);
            //p2.Projectmanager = emp6;
            //p2.Tasks.Add(new Tasker("Fourth Task ", DateTime.Now));
            //p2.Tasks.Add(new Tasker("Fith Task ", DateTime.Now));


            //p3.Members.Add(emp2);
            //p3.Members.Add(emp7);
            //p3.Projectmanager = emp2;
            //p3.Tasks.Add(new Tasker("sixth Task ", DateTime.Now));
            //p3.Tasks.Add(new Tasker("Seventh Task ", DateTime.Now));
            //p3.Tasks.Add(new Tasker("Eigth Task ", DateTime.Now));


            //p4.Members.Add(emp8);
            //p4.Members.Add(emp10);
            //p4.Projectmanager = emp10;
            //p4.Tasks.Add(new Tasker("nineth Task ", DateTime.Now));
            //p4.Tasks.Add(new Tasker("Tenth Task ", DateTime.Now));
            //_projects.Add(p1);
            //_projects.Add(p2);
            //_projects.Add(p3);
            //_projects.Add(p4);


            //foreach (Project p in _projects)
            //{
            //    _context.ProjectsList.Add(p.Name, p);
            //}
            //foreach (Employee emp in _employees)
            //{
            //    _context.PersonList.Add(emp.Mail, emp);
            //}



            _projectListCbx.DataSource = Context.GetContext().ProjectsList.Values.ToArray();
            _projectListCbx.SelectedItem = null;
            _projectListCbx.SelectedIndexChanged += new EventHandler(ItemProjectChanged);

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

        //private void _projectListCbx_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void ProjectManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void _projectListCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Project p = (Project)_projectListCbx.SelectedItem;
            if(p != null)
            {
                DetailProjectUC body = new DetailProjectUC();

            }
        }

        private void _addProjectBtn_Click_1(object sender, EventArgs e)
        {
            CreatProject creatProject = new CreatProject();
            creatProject.ShowDialog();
        }
    }
}
