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
        ContextAndUserManager ctxuser = Authentification.CurrentCtxUser;
        public CreateEmployeeUC()
        {
            InitializeComponent();
        }

        private void CreateEmployeeBtn_Click(object sender, EventArgs e)
        {
            using(var ct = ctxuser.ObtainAccessor())
            {

            Context ctx = ct.Context;
            Employee emp = ctx.CreateEmployee(FirstNameTextBox.Text, LastNameTextBox.Text, MailTextBox.Text);
            // Context.GetContext().PersonList.Add(emp.Mail, emp);
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
            }
        }
    }
}
