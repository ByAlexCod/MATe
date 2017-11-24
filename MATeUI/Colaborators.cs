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

namespace MATeUI
{
    public partial class Colaborators : UserControl
    {
        public Context ctx = Context.GetContext();
        public Colaborators()
        {
            InitializeComponent();
        }

        private void ListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListEmployee.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = ListEmployee.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string mail = ListEmployee.SelectedItems[0].Text.ToString();
                Employee employ = ctx.PersonList[mail];
                FirstNameTextBox.Text = employ.Firstname;
                LastNameTextBox.Text = employ.Lastname;
                MailTextBox.Text = employ.Mail;
                if (employ.CurrentWorkingProject != null) ProjectTextBox.Text = employ.CurrentWorkingProject.Name;
                else ProjectTextBox.Clear();
            }


        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Refreshtable();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm pm = new CreateEmployeeForm();
            pm.FormClosing += new FormClosingEventHandler(CreateEmployeeForm_FormClosing);
            pm.ShowDialog();
        }
        private void CreateEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Refreshtable();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (ListEmployee.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = ListEmployee.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string mail = ListEmployee.SelectedItems[0].Text.ToString();
                Employee employ = ctx.PersonList[mail];
                ctx.Boss = ctx.GetBoss();
                ctx.Boss.DeleteEmployee(employ);
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                MailTextBox.Clear();
                ProjectTextBox.Clear();
                Refreshtable();
            }
        }

        private void Refreshtable()
        {
            ListEmployee.Items.Clear();
            
            foreach (Employee emp in ctx.PersonList.Values.ToList())
            {
                ListViewItem newitem = new ListViewItem(emp.Mail);
                newitem.SubItems.Add(emp.Firstname);
                newitem.SubItems.Add(emp.Lastname);
                if (emp.CurrentWorkingProject == null) newitem.SubItems.Add("free");
                else newitem.SubItems.Add("busy");
                ListEmployee.Items.Add(newitem);
            }
        }
        
    }
}
