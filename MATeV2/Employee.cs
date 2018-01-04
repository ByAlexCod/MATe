using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public partial class Employee: Person
    {
        Project _workingproject;
        DateTime _modifyDate;
        DateTime _bossModifyDate;
        Context _ctx;

        public Employee(Context c,string firstname, string lastname, string mail) : base(c,firstname, lastname, mail)
        {
            _ctx = c;
            _workingproject = null;
            SetDirty();
        }

        public Project CurrentWorkingProject
        {
            get { return _workingproject; }
            set { SetDirty(); _workingproject = value; }
        }

        private DateTime ModifyDate => _modifyDate;
        private DateTime BossModifyDate => _bossModifyDate;


        private void SetDirty()
        {
            _modifyDate = DateTime.Now;
            //if (_ctx.Owner == _ctx.Boss) _bossModifyDate = DateTime.Now;
        }

        bool IsProjectManager => Context.ProjectsDictionary.Values.Any(p => p.Projectmanager == this);
        
        public override string ToString()
        {
            SetDirty();
            return Firstname +" "+Lastname+" ";
        }

        internal void Merge(Employee oEmployee)
        {

            if(oEmployee.Mail == oEmployee.Context.Owner.Mail)
            {
                Firstname = oEmployee.Firstname;
                Lastname = oEmployee.Lastname;
               
                    _ctx.FindEmployee(Mail).IPString = oEmployee.IP.ToString();
                
                //IPString = oEmployee.IP.ToString();
            }
            SetDirty();
        }
    }
}
