using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public partial class Employee : Person
    {
        ///////////////////////////////////////////////
        ///////////// TASKER METHODS //////////////////
        ///////////////////////////////////////////////

        public Tasker CreateTask(Project p, string name, DateTime datelimit)
        {
            Tasker newtask = new Tasker(p, name, datelimit);
            return newtask;
        }

        public Tasker ModifyTask(Tasker t,string name)
        {
            t.Name = name;
            return t;
        }

        public Tasker ModifyTask(Tasker t,DateTime datelimit)
        {
            t.DateLimit = datelimit;
            return t;
        }

        public void DeleteTask(Tasker t)
        {
            t.DeleteTask();
        }

        ///////////////////////////////////////////////
        ///////////// SUBTASK METHODS /////////////////
        ///////////////////////////////////////////////

        public SubTask CreateSubtask(Tasker t,string name,DateTime datelimit,Employee worker=null)
        {
            SubTask newsubtask = new SubTask(name, datelimit, worker);
            t.SubTasks.Add(newsubtask.Name, newsubtask);
            return newsubtask;
        }

        public SubTask ModifySubTask(SubTask s,string name)
        {
            s.Name = name;
            return s;
        }

        public SubTask ModifySubTask(SubTask s, DateTime d)
        {
            s.DateLimit = d;
            return s;
        }

        public SubTask ModifySubTask(SubTask s,Employee worker)
        {
            s.Worker = worker;
            return s;
        }

        public SubTask ModifySubtask(SubTask s, int b)
        {
            s.State = b;
            return null;
        }
    }
}
