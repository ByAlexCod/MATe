using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Person
    {
        readonly Context _ctx;
        string _firstname;
        string _lastname;
        string _mail;
        string _ip;

        public Person( Context c, string firstname, string lastname, string mail)
        {
            _ctx = c;
            _firstname = firstname;
            _lastname = lastname;
            _mail = mail;
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if( _firstname != value )
                {
                    _firstname = value;
                    _ctx.SetDirty();
                }
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public Context Context => _ctx;
      
        public void ModifyProfile(string firstname, string lastname, string mail )
        {
            if (firstname != null) _firstname = firstname;
            if (lastname != null) _lastname = lastname;
            if (mail != null)
            {
                if (this is Employee)
                {
                    _ctx.PersonsDictionary.Remove(_mail);
                    _mail = mail;
                    _ctx.PersonsDictionary.Add(_mail, (Employee)this);
                }
                if (this is Boss)
                {
                    _ctx.Boss.Mail = mail;
                }
            }
        }
    }
}
