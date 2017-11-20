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
    public partial class FormAddNewProject : Form
    {
        Context _ctx;
        ICollection<Employee> _employees;
        public FormAddNewProject()
        {
            InitializeComponent();
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_dgEmployees.Rows.Count < 0)
            {
                MessageBox.Show("LE PROJET DOIT CONTENIR AU MOINS UN MEMBRE");
                return;
            }
            int index = _dgEmployees.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("SELECTIONNEZ D'ABORD UNE LIGNE DANS LE TABLEAU DES MEMBRES");
                return;
            }

            Employee member = _employees.ElementAt(index);
            _dgMembers.Rows.RemoveAt(index);
            _dgMembers.Rows.Add(member.Firstname, member.Lastname, member.Mail);
            _project.Members.Add(member);
            _employees.Remove(member);
        }
        Project _project = null;
        protected override void OnLoad(EventArgs ev)
        {
            _ctx = new Context("Context 1");
            _employees = new List<Employee>();
            _project = new Project("MATe", DateTime.Now, new DateTime(2017, 12, 31));
            base.OnLoad(ev);
            for (int i = 6; i < 15; i++)
            {
                Employee employee = new Employee(_ctx,"employee" + i, i.ToString(), "mate@" + i.ToString() + ".com", i.ToString());
                _employees.Add(employee);
            }
            foreach (Employee e in _employees)
            {
                _dgEmployees.Rows.Add(e.Firstname, e.Lastname, e.Mail);
            }
        }

        private void _removeMemberInProjectBtn_Click(object sender, EventArgs e)
        {
            if (_dgMembers.Rows.Count <= 0)
            {
                MessageBox.Show("LE PROJET DOIT CONTENIR AU MOINS UN MEMBRE");
                return;
            }
            int index = _dgMembers.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("SELECTIONNEZ D'ABORD UNE LIGNE DANS LE TABLEAU DES MEMBRES DU PROJET");
                return;
            }
            _dgMembers.Rows.RemoveAt(index);
            _project.Members.RemoveAt(index);
        }
    }
}
