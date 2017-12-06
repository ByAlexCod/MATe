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
        readonly List<Employee> _members;
        readonly List<Tasker> _tasks;
        Boolean _state;
        Context _context;


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


        public Context Context
        {
            get { return _context; }
            set { _context = value; }
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


        public void ClearTasks()
        {
            _tasks.Clear();
        }
        //public Context Contx
        //{
        //    get { return _ctx; }
        //    set { _ctx = value; }
        //}

        public override string ToString()
        {
            return Name;
        }


        public void Merge(Project prj)
        {
            if (prj == null) throw new ArgumentNullException("Given Project cannot be null", nameof(prj));
            if (prj.Context.Owner.Mail == Context.Boss.Mail)
            {
                DateBegin = prj.DateBegin;
                DateLimit = prj.DateLimit;
                Projectmanager = prj.Projectmanager;
                ClearTasks();

                

            }
        }
    }
}
