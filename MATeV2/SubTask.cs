using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class SubTask
    {
        string _name;
        DateTime _datelimit;
        Employee _worker;
        int _status;
        Tasker _currenttask;
        
        
        public SubTask(Tasker task, string name,DateTime datelimit,Employee worker = null)
        {
            Name = name;
            DateLimit = datelimit;
            Worker = worker;
            _status = 0;
            CurrentTask = task;
        }

        void SetProjectManagerMD()
        {
            if (CurrentTask != null) CurrentTask.Project.ProjectManagerModifyDate = DateTime.Now;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value;  SetProjectManagerMD(); }
        }

        void SetDirty()
        {
            _datelimit = DateTime.Now;
        }

        public DateTime DateLimit
        {
            get { return _datelimit; }
            set { _datelimit = value; SetProjectManagerMD(); }
        }

        public Employee Worker
        {
            get { return _worker; }
            set { _worker = value; /* SetProjectManagerMD();*/ }
        }

        public int State
        {
            get { return _status; }
            set { _status = value; SetDirty(); }
        }

        public Tasker CurrentTask
        {
            get { return _currenttask; }
            set { _currenttask = value; /* SetProjectManagerMD();*/ }
        }
        /// <summary>
        /// to write after 
        /// </summary>
        internal void DeleteSubTask()
        {
            CurrentTask = null;
            Worker = null;
        }

        internal void Merge(SubTask oSubTask)
        {
            if (oSubTask == null) throw new ArgumentNullException("Other subtask cannot be null.", nameof(oSubTask));
            if (DateLimit < oSubTask.DateLimit) State = oSubTask.State;
            if (oSubTask.CurrentTask.Project.Context.Owner.Mail == oSubTask.CurrentTask.Project.Projectmanager.Mail && oSubTask.CurrentTask.Project.ProjectManagerModifyDate > CurrentTask.Project.ProjectManagerModifyDate)
            {
                DateLimit = oSubTask.DateLimit;

                Employee aa = CurrentTask.Project.Context.FindEmployee(Worker.Mail);
                Worker = aa;


            }
        }
    }
}
