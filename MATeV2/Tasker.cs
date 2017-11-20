using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Tasker
    {
        string _name;
        DateTime _datelimit; 
        readonly List<SubTask> _subtasks;
        Boolean _state;

        public Tasker(string name,DateTime datelimit)
        {
            Name = name;
            DateLimit = datelimit;
            _subtasks = new List<SubTask>();
            _state = false;
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

        public List<SubTask> SubTasks => _subtasks;

        public Boolean State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
