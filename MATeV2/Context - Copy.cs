using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Context
    {
        readonly Dictionary<string, Employee> _personsList = null;
        readonly Dictionary<string, Project> _projectsList = null;
        static Context _context;
        Boss _boss;
        string _name;
        readonly int _firstExchangePort;
        readonly Dictionary<string, Employee> _waitingPersonsList = new Dictionary<string, Employee>();
        /// <summary>
        /// Create context and create initialize first Exchange port as a random number.
        /// </summary>
        public Context(string name)
        {
            _name = name;
            _boss = getBoss();
            _personsList = new Dictionary<string, Employee>();
            _projectsList = new Dictionary<string, Project>();
            _firstExchangePort = new Random().Next(1, 6666);
        }

        public Dictionary<string, Employee> PersonList => _personsList;
        public Dictionary<string, Project> ProjectsList => _projectsList;
        public Dictionary<string, Employee> WaitingPersonList => _waitingPersonsList;
        public Boss Boss
        {
            get { return _boss; }
            set { _boss = value; }
        }
        public int FirstExchangePort => _firstExchangePort;
        public string Name => _name;

        /// <summary>
        /// Login user (Boss or Employee) and return person or null if mail or password is not correct
        /// </summary>
        /// <param name="mail">Mail to Tes</param>
        /// <param name="password">Password to Test</param>
        /// <returns></returns>
        public Boss getBoss()
        {
            if (_boss != null) return _boss;
            else
            {
                _boss = new Boss(this,"Boua","TRA","b","b");
                return _boss;
            }
        }
        public Person Login(string mail, string password)
        {
            if (mail == _boss.Mail && password == _boss.Password) return _boss;
            else if (_personsList.TryGetValue(mail, out Employee value) && value.Password == password) return value;
            return null;
        }

        public static Context GetContext()
        {
            if (_context != null) return _context;
            return _context = new Context("Default Context");
        }

        internal void Tester()
        {

        }
    }
}
