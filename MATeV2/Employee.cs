using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public partial class Employee: Person
    {
        Project _workingproject;

        public Employee(Context c,string firstname, string lastname, string mail, string pass) : base(c,firstname, lastname, mail, pass)
        {
            _workingproject = null;
        }

        public Project CurrentWorkingProject
        {
            get { return _workingproject; }
            set { _workingproject = value; }
        }

        bool IsProjectManager => Context.ProjectsList.Values.Any(p => p.Projectmanager == this);
        
        public override string ToString()
        {
            return Firstname +" "+Lastname+" ";
        }
    }
}
