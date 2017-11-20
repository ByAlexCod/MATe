using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Person
    {
        string _firstname;
        string _lastname;
        string _password;
        string _mail;
        string _ip;
        readonly Context _ctx;

        public Person(Context c, string firstname, string lastname, string mail, string password)
        {
            _ctx = c;
            _firstname = firstname;
            _lastname = lastname;
            _mail = mail;
            _password = password;
        }

        public Person()
        {
            
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
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
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Context Contx
        {
            get { return _ctx; }
        }

        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public void ModifyProfile(string firstname, string lastname, string mail, string password)
        {
            if (firstname != null) _firstname = firstname;
            if (lastname != null) _lastname = lastname;
            if (mail != null) _mail = mail;
            if (password != null) _password = password;
        }
    }
}
