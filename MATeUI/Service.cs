using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeV2;

namespace MATeUI
{
    public class Service
    {
        public static Person GetPersonByID(string mail,string password)
        {
            if(mail.Equals(Context.GetContext().getBoss().Mail) && password.Equals(Context.GetContext().getBoss().Password))
            {
                return Context.GetContext().getBoss();
            }
            else
            {
                foreach (Employee emp in Context.GetContext().PersonList.Values)
                {
                    if(mail.Equals(emp.Mail) && password.Equals(emp.Password))
                    {
                        return emp;
                    }
                }
            }
            return null;
        }
    }
}
