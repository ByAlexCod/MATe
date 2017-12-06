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
        Boolean _isValidated;
        public Project(string name,DateTime datebegin,DateTime datelimit,Employee projectmanager)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
            if (projectmanager != null)
            {
                _projectmanager = projectmanager;
                _members.Add(projectmanager.Mail, projectmanager);
                projectmanager.CurrentWorkingProject = this;
            }
        }
        public Project(string name, DateTime datebegin, DateTime datelimit)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
        }

        public Boolean IsValidated
        {
            get { return _isValidated; }
            set { _isValidated = value; }
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

        public override string ToString()
        {
            return Name;
        }
    }
}
