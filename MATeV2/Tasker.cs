using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Tasker
    {
        string _name;
        DateTime _datelimit; 
        readonly Dictionary<string, SubTask> _subtasks = new Dictionary<string, SubTask>();
        Boolean _state;
        Project _project;

        public Tasker(Project p,string name, DateTime datelimit)
        {
            Project = p;
            Name = name;
            DateLimit = datelimit;
            _state = false;
            p.Tasks.Add(this.Name, this);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime DateLimit
        {
            get { return _datelimit; }
            set { _datelimit = value; }
        }

        public Dictionary<string, SubTask> SubTasks => _subtasks;

        public Boolean State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }

        internal void DeleteTask()
        {
            foreach(SubTask st in this.SubTasks.Values)
            {
                st.DeleteSubTask();
                SubTasks.Remove(st.Name);
            }
        }
    }
}
