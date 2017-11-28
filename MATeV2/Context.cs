using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Context
    {
        DateTime _modifyTime;
        readonly Dictionary<string, Employee> _personsList ;
        readonly Dictionary<string, Project> _projectsList ;
        Boss _boss;
        string _companyName;
        readonly int _firstExchangePort;
        bool _isDirty;
        static Context _ctx;
        readonly Dictionary<string, Employee> _waitingPersonsList = new Dictionary<string, Employee>();
        /// <summary>
        /// Create context and create initialize first Exchange port as a random number.
        /// </summary>
        internal Context(string name)
        {
            _companyName = name;
            _firstExchangePort = new Random().Next(1, 6666);
            _boss = new Boss(this, "default", "boss", "b", "b");
            _personsList = new Dictionary<string, Employee>();
            _projectsList = new Dictionary<string, Project>();
        }

        public DateTime SetDirty( bool reset = false )
        {
            if( reset )
            {
                _isDirty = false;
            }
            else
            {
                _modifyTime = DateTime.Now;
                _isDirty = true;
            }
            return _modifyTime;
        }

        public bool IsDirty => _isDirty;

        public DateTime ModifyDate => _modifyTime;
        public Dictionary<string, Employee> PersonList => _personsList;
        public Dictionary<string, Project> ProjectsList => _projectsList;
        public Dictionary<string, Employee> WaitingPersonList => _waitingPersonsList;
        public int FirstExchangePort => _firstExchangePort;
        public string CompanyName => _companyName;

        /// <summary>
        /// Login user (Boss or Employee) and return person or null if mail or password is not correct
        /// </summary>
        /// <param name="mail">Mail to Tes</param>
        /// <param name="password">Password to Test</param>
        /// <returns></returns>
        public Person Login(string mail, string password)
        {
            Employee value;
            if (mail == this.Boss.Mail && password == this.Boss.Password) return _boss;
            else if (_personsList.TryGetValue(mail, out value) && value.Password == password) return value;
            return null;
        }

        public Boss Boss
        {
            get { return _boss; }
        }

    }
    




}
