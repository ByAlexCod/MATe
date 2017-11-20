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
    public partial class ListeDesProjets : Form
    {
        ICollection<Project> _projects = new List<Project>();
        public ListeDesProjets()
        {
            
            InitializeComponent();
           /* for (int i = 0; i < 5; i++)
            {
                Project project = new Project("project"+i, DateTime.Now, new DateTime(2017, 12, 31));
                for (int j = 0; j < 6; j++)
                {
                    Employee employee = new Employee("employee" + i, i.ToString(), "mate@" + i.ToString() + ".com", i.ToString());
                    employee.Project = project;
                    project.Members.Add(employee);
                    if (j == 0)
                    {
                        //project.Projectmanager = (Proj)employee;
                    }
                    project.Tasks.Add(new Tasker("Task " + j, DateTime.Now));
                }
                _projects.Add(project);
            }
            foreach (Project p in _projects)
            {
                DgProjects.Rows.Add(p.Name, p.DateBegin, p.DateLimit,p.Projectmanager);
            }*/
            InitializeComponent();
        }

        private void showProject_Click(object sender, EventArgs e)
        {
            int index = DgProjects.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("SELECTIONNEZ D'ABORD UN PROJET");
                return;
            }
            Project selectedProject = _projects.ElementAt(index);
        }

        private void ListeDesProjets_Load(object sender, EventArgs e)
        {
            BodyUC bc = new BodyUC();
            bc.Show();
        }
    }
}
