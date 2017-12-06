using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Modifier
    {
        Type Tasker = typeof(Tasker);
        Type SubTask = typeof(SubTask);

        object _origin;
        object _other;
        object _result = null;

        public Modifier(object origin, object other)
        {
            _origin = origin;
            _other = other;
        }
        public object AcceptTheNew()
        {
            if (_origin.GetType() == Tasker)
            {
                AcceptForTasks();
                return _result;
            }
            else if (_origin.GetType() == SubTask)
            {
                AcceptForSubTasks();
                return _result;
            }
            throw new Exception("Objects you tried to Modify cannot be modified due to types.");
            
        }


        private Tasker AcceptForTasks()
        {
            Tasker origin = (Tasker)_origin;
            Tasker other = (Tasker)_other;

            other.Project = origin.Project;

            _result = other;
            return (Tasker)_result;

        }
        private void AcceptForSubTasks()
        {

        }
    }
}
