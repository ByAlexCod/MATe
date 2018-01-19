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
        Boolean _isValidated;
        Project _project;

        internal Tasker(Project p,string name, DateTime datelimit)
        {
            Project = p;
            Name = name;
            DateLimit = datelimit;
            _isValidated = false;
            if (p.Tasks.ContainsKey(Name)){ throw new ArgumentException("this name of task already existe"); }
            else
            {
                p.Tasks.Add(this.Name, this);
            }
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

        public Boolean IsValidated
        {
            get { return _isValidated; }
            set { _isValidated = value; }
        }

        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }

        internal void DeleteTask()
        {
            foreach(SubTask st in SubTasks.Values.ToList())
            {
                st.DeleteSubTask();
                SubTasks.Remove(st.Name);
            }
        }

        ///////////////////////////////////////////////
        ///////////// SUBTASK METHODS /////////////////
        ///////////////////////////////////////////////

        public SubTask CreateSubtask(Tasker t, string name, DateTime datelimit, Employee worker)
        {
            SubTask newsubtask = new SubTask(t, name, datelimit, worker);
            t.SubTasks.Add(newsubtask.Name, newsubtask);
            return newsubtask;
        }

        public SubTask CreateSubTask(string name, DateTime datelimit, Employee worker)
        {
            SubTask newsubtask = new SubTask(this, name, datelimit, worker);
            SubTasks.Add(newsubtask.Name, newsubtask);
            return newsubtask;
        }

        public SubTask ModifySubTask(SubTask s, string name)
        {
            s.Name = name;
            return s;
        }

        public SubTask ModifySubTask(SubTask s, DateTime d)
        {
            s.DateLimit = d;
            return s;
        }

        public SubTask ModifySubTask(SubTask s, Employee worker)
        {
            s.Worker = worker;
            return s;
        }

        public SubTask ModifySubtask(SubTask s, int b)
        {
            s.State = b;
            return null;
        }

        internal void Merge(Tasker oTask)
        {
            if (oTask.Project.Context.Owner != null && Project.Projectmanager != null)
            {
                if (oTask.Project.Context.Owner.Mail == Project.Projectmanager.Mail || oTask.Project.ProjectManagerModifyDate > Project.ProjectManagerModifyDate) // if other context owner is the project manager
                {
                    Name = oTask.Name;
                    IsValidated = oTask.IsValidated;
                    Project.ProjectManagerModifyDate = oTask.Project.ProjectManagerModifyDate;
                    DateLimit = oTask.DateLimit;

                }
            }
            foreach (var ost in oTask.SubTasks)
            {
                if (!SubTasks.ContainsKey(ost.Key))
                {
                    SubTask aa = CreateSubTask(ost.Value.Name, ost.Value.DateLimit, ost.Value.Worker);
                    aa.State = ost.Value.State;

                }
            }

            List<string> toremove = new List<string>();

            foreach (var st in SubTasks)
            {
                oTask.SubTasks.TryGetValue(st.Key, out SubTask value);
                if(value != null) st.Value.Merge(value);
                else
                {
                    toremove.Add(st.Key);
                }
            }

            


            foreach(var att in toremove)
            {
                SubTasks.Remove(att);
            }
        }
    }
}
