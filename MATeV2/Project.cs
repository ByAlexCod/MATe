using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Project
    {
        string _name;
        DateTime _datelimit;
        DateTime _datebegin;
        Employee _projectmanager;
        readonly Dictionary<string, Tasker> _tasks = new Dictionary<string, Tasker>();
        readonly Dictionary<string, Employee> _members = new Dictionary<string, Employee>();
        Boolean _state;
        public Project(string name,DateTime datebegin,DateTime datelimit,Employee projectmanager)
        {
            _name = name;
            _datebegin = datebegin;
            _datelimit = datelimit;
            _projectmanager = projectmanager;
            if (projectmanager != null) projectmanager.CurrentWorkingProject = this;
        }
        public Project(string name, DateTime datebegin, DateTime datelimit)
        {
            _name = name;
            _datebegin = datebegin;
            _datelimit = datelimit;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateBegin
        {
            get { return _datebegin; }
            set { _datebegin = value; }
        }

        public DateTime DateLimit
        {
            get { return _datelimit; }
            set { _datelimit = value; }
        }

        public Employee Projectmanager
        {
            get { return _projectmanager; }
            set { _projectmanager = value; }
        }

        public Dictionary<string, Employee> Members => _members;

        public Dictionary<string, Tasker> Tasks => _tasks;

        //public Context Contx
        //{
        //    get { return _ctx; }
        //    set { _ctx = value; }
        //}

        public override string ToString()
        {
            return Name;
        }
    }
}
