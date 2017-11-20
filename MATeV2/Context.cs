using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Context
    {
        readonly Dictionary<string, Employee> _personsList = new Dictionary<string, Employee>();
        readonly Dictionary<string, Project> _projectsList = new Dictionary<string, Project>();
        Boss _boss;
        string _name;
        readonly int _firstExchangePort;
        static Context _ctx;
        readonly Dictionary<string, Employee> _waitingPersonsList = new Dictionary<string, Employee>();
        /// <summary>
        /// Create context and create initialize first Exchange port as a random number.
        /// </summary>
        public Context(string name)
        {
            _name = name;
            _firstExchangePort = new Random().Next(1, 6666);
            _boss = getBoss();
        }

        public Dictionary<string, Employee> PersonList => _personsList;
        public Dictionary<string, Project> ProjectsList => _projectsList;
        public Dictionary<string, Employee> WaitingPersonList => _waitingPersonsList;
        public int FirstExchangePort => _firstExchangePort;
        public string Name => _name;

        /// <summary>
        /// Login user (Boss or Employee) and return person or null if mail or password is not correct
        /// </summary>
        /// <param name="mail">Mail to Tes</param>
        /// <param name="password">Password to Test</param>
        /// <returns></returns>
        public Person Login(string mail, string password)
        {
            Employee value;
            if (mail == Context.GetContext().Boss.Mail && password == Context.GetContext().Boss.Password) return _boss;
            else if (_personsList.TryGetValue(mail, out value) && value.Password == password) return value;
            return null;
        }

        public Boss getBoss()
        {
            if (_boss != null) return _boss;
            _boss = new Boss(this,"default", "boss", "b", "b");
            return _boss;
        }

        public Boss Boss
        {
            get { return _boss; }
            set { _boss = value; }
        }

        public static Context GetContext()
        {
            if (_ctx != null) return _ctx;
            _ctx = new Context("default");
            _ctx.Boss = _ctx.getBoss();
            return _ctx;
        }

        internal void Tester()
        {

        }
    }
}
