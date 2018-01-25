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
        int _status;
        Context _context;
        DateTime _projectManagerModifyTime;


        public Project(Context context, string name,DateTime datebegin,DateTime datelimit,Employee projectmanager)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
            _context = context;
            if (projectmanager != null)
            {
                _projectmanager = projectmanager;
                _members.Add(projectmanager.Mail, projectmanager);
                projectmanager.CurrentWorkingProject = this;
            }
        }
        public Project(Context context, string name, DateTime datebegin, DateTime datelimit)
        {
            Name = name;
            DateBegin = datebegin;
            DateLimit = datelimit;
        }

        public Tasker CreateTask(string name, DateTime datelimit)
        {
            Tasker a = new Tasker(this, name, datelimit);
            return a;
        }
        public void AddMember(Employee a)
        {
             _members.Add(a.Mail, a);
            

        }
        internal DateTime ProjectManagerModifyDate
        {
            get { return _projectManagerModifyTime; }
            set { _projectManagerModifyTime = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
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

        public Dictionary<string, Employee> Members => _members;

        public Dictionary<string, Tasker> Tasks => _tasks;

        
        public void ClearTasks()
        {
            _tasks.Clear();
        }
       
     
        public void ClearMembers()
        {
            _members.Clear();
        }
        public override string ToString()
        {
            return Name;
        }


        ///////////////////////////////////////////////
        ///////////// TASKER METHODS //////////////////
        ///////////////////////////////////////////////

        public Tasker CreateTask(Project p, string name, DateTime datelimit)
        {
            Tasker newtask = new Tasker(p, name, datelimit);
            return newtask;
        }

        public Tasker ModifyTask(Tasker t, string name)
        {
            t.Name = name;
            return t;
        }

        public Tasker ModifyTask(Tasker t, DateTime datelimit)
        {
            t.DateLimit = datelimit;
            return t;
        }

        public void DeleteTask(Tasker t)
        {
            t.DeleteTask();
        }

        internal void Merge(Project prj)
        {
            if (Name != prj.Name) return;
            if (prj == null) throw new ArgumentNullException("Given Project cannot be null", nameof(prj));
            //Projects info
            if (prj.Context.Owner.Mail == Context.Boss.Mail || prj.Context.BossModifyTime > Context.BossModifyTime)
            {
                DateBegin = prj.DateBegin;
                DateLimit = prj.DateLimit;
                if(prj.Projectmanager != null) Projectmanager = Context.FindEmployee(prj.Projectmanager.Mail);




                ClearMembers();
                foreach (var om in prj.Members)
                {
                    Context.PersonsDictionary.TryGetValue(om.Value.Mail, out Employee value);
                    if(value != null)
                    {
                        Members.Add(value.Mail, value);
                    }

                }
            }
            if (Projectmanager != null)
            {
                if (prj.Context.Owner.Mail == Projectmanager.Mail || prj.ProjectManagerModifyDate > ProjectManagerModifyDate)
                {
                    ClearTasks();
                    foreach (var ot in prj.Tasks)
                    {
                        Tasker ii = CreateTask(ot.Value.Name, ot.Value.DateLimit);
                        ii.IsValidated = ot.Value.IsValidated;
                    }
                }
            }

            if (prj.Context.Owner.Mail == Projectmanager.Mail || prj.ProjectManagerModifyDate > ProjectManagerModifyDate)
            {
                List<Tasker> toremove = new List<Tasker>();
                foreach(var tt in _tasks)
                {
                    if (!prj._tasks.ContainsKey(tt.Key)) toremove.Add(tt.Value);
                }
                foreach (var tr in toremove) DeleteTask(tr);
            }


            foreach (var tt in prj.Tasks)
            {
                if (!Tasks.ContainsKey(tt.Key) && prj.Context.Owner.Mail == Projectmanager.Mail)
                {
                    Tasker e = CreateTask(tt.Value.Name, tt.Value.DateLimit);
                    e.IsValidated = tt.Value.IsValidated;

                }
            }

            foreach (var tt in _tasks)
            {
                if(prj.Tasks.ContainsKey(tt.Key))
                {
                    prj.Tasks.TryGetValue(tt.Key, out Tasker value);
                    tt.Value.Merge(value);
                }
                    
            }
            
            //Init other merges



        }
    }
}
