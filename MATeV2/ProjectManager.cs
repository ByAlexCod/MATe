using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class ProjectManager: Employee
    {
        public ProjectManager(string firstname, string lastname, string mail, string pass) : base(firstname, lastname, mail, pass)
        {
        }
        /// <summary>
        /// need write after;
        /// </summary>
        /// <param name="p"></param>
        /// <param name="name"></param>
        /// <param name="datelimit"></param>
        /// <returns></returns>
        public Tasker CreateTask()//Project p, string name, DateTime datelimit)
        {
            return null;
        }
    }
}
