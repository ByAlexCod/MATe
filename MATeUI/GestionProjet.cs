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
    public partial class GestionProjet : Form
    {
        
        ICollection<Employee> _members = new List<Employee>();
        //ICollection<Project> _projects = new List<Project>();
        
        Project _project = null;

        public GestionProjet()
        {

            InitializeComponent();
        }

        private void GestionProjet_Load(object sender, EventArgs e)
        {

        }

        private void addMemberToProjectBtn_Click(object sender, EventArgs e)
        {
            if (DgMembers.Rows.Count < 0)
            {
                MessageBox.Show("LE PROJET DOIT CONTENIR AU MOINS UN MEMBRE");
                return;
            }
            int index = DgMembers.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("SELECTIONNEZ D'ABORD UNE LIGNE DANS LE TABLEAU DES MEMBRES");
                return;
            } 
            
            Employee member = _members.ElementAt(index);
            DgMembers.Rows.RemoveAt(index);
            DgMemberInProject.Rows.Add(member.Firstname,member.Lastname,member.Mail);
            _project.Members.Add(member);
            _members.Remove(member);
            
        }

        private void removeMemberInProjectBtn_Click(object sender, EventArgs e)
        {
            if(DgMemberInProject.Rows.Count <= 0)
            {
                MessageBox.Show("LE PROJET DOIT CONTENIR AU MOINS UN MEMBRE");
                return;
            }
            int index = DgMemberInProject.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("SELECTIONNEZ D'ABORD UNE LIGNE DANS LE TABLEAU DES MEMBRES DU PROJET");
                return;
            }
            DgMemberInProject.Rows.RemoveAt(index);
            _project.Members.RemoveAt(index);
        }

        /*protected override void OnLoad(EventArgs ev)
        {
            _project = new Project("MATe", DateTime.Now, new DateTime(2017, 12, 31));
            base.OnLoad(ev);
            for (int i = 6; i < 15; i++)
            {
                Employee employee = new Employee("employee" + i, i.ToString(), "mate@" + i.ToString() + ".com", i.ToString());
                employee.Project = _project;
                _project.Members.Add(employee);
                if (i == 0)
                {
                    //_project.Projectmanager = employee;
                }
                _project.Tasks.Add(new Tasker("Task " + i, DateTime.Now));
                _members.Add(employee);
            }
            foreach (Employee e in _members)
            {
                DgMembers.Rows.Add(e.Firstname, e.Lastname, e.Mail);
            }
            foreach (Employee e in _project.Members)
            {
                DgMemberInProject.Rows.Add(e.Firstname, e.Lastname, e.Mail);
            }
            firstNameLbl.Text = _project.Projectmanager.Firstname;
            lastNameLbl.Text = _project.Projectmanager.Lastname;
            mailLbl.Text = _project.Projectmanager.Mail;
            //DgMembers.DataSource = _members;

            //DgMemberInProject.DataSource = _project.Members;
            DgTasks.DataSource = _project.Tasks;
        }*/
    }
}
