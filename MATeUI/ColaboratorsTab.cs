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
    public partial class ColaboratorsTab : UserControl
    {
        ContextAndUserManager ctx = Authentification.CurrentCtxUser;
        public ColaboratorsTab()
        {
            InitializeComponent();
        }
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler GotoToProjectEvent;
        public static Employee employee = null;

        private void GoToProject(object sender, EventArgs e) => GotoToProjectEvent?.Invoke(this, e);
       
        private void ListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ct = ctx.ObtainAccessor())
            {
                Context context = ct.Context;
                if (ListEmployee.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = ListEmployee.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string mail = ListEmployee.SelectedItems[0].Text.ToString();
                    Employee employ = context.PersonsDictionary[mail];
                    employee = employ;
                    FirstNameTextBox.Text = employ.Firstname;
                    LastNameTextBox.Text = employ.Lastname;
                    MailTextBox.Text = employ.Mail;
                    if (employ.CurrentWorkingProject != null) ProjectTextBox.Text = employ.CurrentWorkingProject.ToString();
                    else ProjectTextBox.Clear();
                }
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Refreshtable();
            _goToProjectBtn.Click += new EventHandler(GoToProject);
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            CreateEmployee pm = new CreateEmployee();
            pm.FormClosing += new FormClosingEventHandler(CreateEmployeeForm_FormClosing);
            pm.ShowDialog();
        }
        private void CreateEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Refreshtable();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            using (var ct = ctx.ObtainAccessor())
            {
                Context context = ct.Context;
                if (ListEmployee.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = ListEmployee.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string mail = ListEmployee.SelectedItems[0].Text.ToString();
                    Employee employ = context.PersonsDictionary[mail];
                    context.DeleteEmployee(employ);
                    FirstNameTextBox.Clear();
                    LastNameTextBox.Clear();
                    MailTextBox.Clear();
                    ProjectTextBox.Clear();
                    Refreshtable();
                }
            }
        }

        private void Refreshtable()
        {
            ListEmployee.Items.Clear();
            if (ctx != null)
            {
                using (var ct = ctx.ObtainAccessor())
                {
                    Context context = ct.Context;

                    foreach (Employee emp in context.PersonsDictionary.Values)
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

        
    }
}
