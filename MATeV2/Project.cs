using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Project
    {
        string _name;
        DateTime _datelimit;
        DateTime _datebegin;
        Employee _projectManager;
        List<Employee> _members;
        List<Tasker> _tasks;
        public Project(string name,DateTime datebegin,DateTime datelimit,Employee projectmanager)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
            _projectManager = projectmanager;
            _members = new List<Employee>();
            _tasks = new List<Tasker>();
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
            get { return _projectManager; }
            set { _projectManager = value; }
        }

        public List<Employee> Members => _members;

        public List<Tasker> Tasks => _tasks;

        public override string ToString()
        {
            return _name;
        }
    }
}
