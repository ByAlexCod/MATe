using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Boss: Person
    {
        readonly Context _ctx;
        public Boss(Context c,string firstname, string lastname, string mail, string password) : base(c,firstname, lastname, mail, password)
        {
            _ctx = c;
        }

        public Employee CreateEmployee(string firstname,string lastname,string mail)
        {
            Employee e;
            string pass = RandomPassword();
            e = new Employee(_ctx,firstname, lastname, mail, pass);
            this.Contx.PersonList.Add(e.Mail, e);
            return e;
        }

        public Project CreateProject(string name, DateTime datebegin, DateTime datelimit, Employee leader = null)
        {
            if (this.Contx.ProjectsList.ContainsKey(name)) throw new ArgumentException("there is already a project with this name");
            Project newproject = new Project(name, datebegin, datelimit, leader);
            this.Contx.ProjectsList.Add(newproject.Name, newproject);
            return newproject;
        }

        /// <summary>
        /// accept a member in waiting list, action take value 0 if refuse and 1 if accept.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public Employee AcceptEmployee(Employee e,int action)
        {
            if (action == 0)
            {
                this.Contx.WaitingPersonList.Remove(e.Mail);
                return null;
            }
            else
            {
                this.Contx.WaitingPersonList.Remove(e.Mail);
                this.Contx.PersonList.Add(e.Mail, e);
                return e;
            }
        }
        /// <summary>
        /// Remove an employee in the company
        /// need add later: remove project,task,subtask linked with the employee
        /// </summary>
        /// <param name="e"></param>
        public void DeleteEmployee(Employee e)
        {
            this.Contx.PersonList.Remove(e.Mail);
        }

        private string RandomPassword()
        {
            Random r = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[r.Next(s.Length)]).ToArray());
        }
    }
}
