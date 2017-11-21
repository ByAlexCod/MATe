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
    public partial class CreateEmployeeUC : UserControl
    {
        public CreateEmployeeUC()
        {
            InitializeComponent();
        }

        private void CreateEmployeeBtn_Click(object sender, EventArgs e)
        {
            Context ctx = Context.GetContext();
            ctx.Boss = ctx.getBoss();
            Employee emp = Context.GetContext().Boss.CreateEmployee(FirstNameTextBox.Text, LastNameTextBox.Text, MailTextBox.Text);
            // Context.GetContext().PersonList.Add(emp.Mail, emp);
            MessageBox.Show("LE MDP EST : " + emp.Password);
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
