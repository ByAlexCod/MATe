using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class SubTask
    {
        string _name;
        DateTime _datelimit;
        Employee _worker;
        Boolean _status;
        Tasker _currenttask;
        
        public SubTask(string name,DateTime datelimit,Employee worker = null)
        {
            Name = name;
            DateLimit = datelimit;
            Worker = worker;
            _status = false;
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

        public Employee Worker
        {
            get { return _worker; }
            set { _worker = value; }
        }

        public Boolean State
        {
            get { return _status; }
            set { _status = value; }
        }

        public Tasker CurrentTask
        {
            get { return _currenttask; }
            set { _currenttask = value; }
        }
        /// <summary>
        /// to write after 
        /// </summary>
        internal void DeleteSubTask()
        {
            throw new NotImplementedException();
        }
    }
}
