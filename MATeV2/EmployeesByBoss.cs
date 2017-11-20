using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public partial class Boss : Person
    {
        /// <summary>
        /// boss create a new employee. Fill in first name, lastname and email of the employee
        /// and get a random password made by fonction RandomPassword();
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        public Employee CreateEmployee(string firstname, string lastname, string mail)
        {
            Employee e;
            string pass = RandomPassword();
            e = new Employee(firstname, lastname, mail, pass);
            this.Contx.PersonList.Add(e.Mail, e);
            return e;
        }

        /// <summary>
        /// Remove an employee in the company
        /// need add later: remove task,subtask linked with the employee
        /// </summary>
        /// <param name="e"></param>
        public void DeleteEmployee(Employee e)
        {
            this.Contx.PersonList.Remove(e.Mail);
            if (e.Project != null) 
            {
                if (e.Project.Projectmanager == e) this.DeleteProjectManager(e.Project, e);
                else this.DeleteMember(e.Project, e);
            }
        }

        /// <summary>
        /// create a random password with the length of 6
        /// </summary>
        /// <returns></returns>
        private string RandomPassword()
        {
            const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var builder = new StringBuilder();
            Random r = new Random();

            for (var i = 0; i < 6; i++)
            {
                var c = pool[r.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
