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
        string _password;
        string _mail;
        string _ip;

        public Person( Context c, string firstname, string lastname, string mail, string password)
        {
            _ctx = c;
            _firstname = firstname;
            _lastname = lastname;
            _mail = mail;
            _password = password;
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
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public Context Contx => _ctx;
      

        static public void ModifyProfile(Person own, string firstname, string lastname, string mail, string password)
        {
            // modifier les information de la person own

            if (firstname != null) own.Firstname = firstname;
            if (lastname != null) own.Lastname = lastname;
            if (mail != null) own.Mail = mail;
            if (password != null) own.Password = password;
        }
    }
}
