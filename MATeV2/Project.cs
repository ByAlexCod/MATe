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
        List<Employee> _members;
        List<Tasker> _tasks;
        Boolean _state;
        public Project(string name,DateTime datebegin,DateTime datelimit,Employee projectmanager)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
            _projectmanager = projectmanager;
            _members = new List<Employee>();
            _tasks = new List<Tasker>();
            if (projectmanager != null) projectmanager.CurrentWorkingProject = this;
        }
        public Project(string name, DateTime datebegin, DateTime datelimit)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
            
            _members = new List<Employee>();
            _tasks = new List<Tasker>();
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

        public List<Employee> Members => _members;

        public List<Tasker> Tasks => _tasks;

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
