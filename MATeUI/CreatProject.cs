﻿using MATeV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATeUI
{
    public partial class CreatProject : Form
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        List<Employee> _members = new List<Employee>();

        Boss b;
        public CreatProject()
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                b = ctx.Boss;
                _members = ctx.PersonsDictionary.Values.ToList();
                InitializeComponent();

                foreach (Employee employee in _members)
                {
                    if(employee.CurrentWorkingProject == null)
                    checkEmployee.Items.Add(employee);
                }
            }

        }     
        private void Valid_Click(object sender, EventArgs e)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
               
                if (CreatPN.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter a valid Project Name.");
                }
                else if (StartDate.Value.Month == limitDate.Value.Month && StartDate.Value.Year == limitDate.Value.Year && StartDate.Value.Day == limitDate.Value.Day)
                {
                    MessageBox.Show("Impossible to put the same date!");
                }
                else if ((StartDate.Value.Year > limitDate.Value.Year) || (StartDate.Value.Year == limitDate.Value.Year & StartDate.Value.Month > limitDate.Value.Month) || (StartDate.Value.Year == limitDate.Value.Year & StartDate.Value.Month == limitDate.Value.Month & StartDate.Value.Day> limitDate.Value.Day))
                {
                    MessageBox.Show("Impossible to put the date of end befor the date of beginig!");
                }
                else
                {
                    Project p = ctx.CreateProject(CreatPN.Text, StartDate.Value.Date, limitDate.Value.Date);

                    foreach (Employee ind in checkEmployee.CheckedItems)
                    {
                        
                        ind.CurrentWorkingProject = p;
                        p.Members.Add(ind.Mail, ind);
                    }
                    
                    MessageBox.Show("Project is created with Project Name is " + CreatPN.Text + " start date " + StartDate.Value.Date.ToShortDateString() + " end date " + limitDate.Value.Date.ToShortDateString());
                    this.Close();
                }
                _ctxuser.SaveAs("-Context.MATe");
                
            }
        }
    }
}
