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
        readonly Dictionary<string, Employee> _personsList;
        readonly Dictionary<string, Project> _projectsList;
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
            _boss = GetBoss();
            _personsList = new Dictionary<string, Employee>();
            _projectsList = new Dictionary<string, Project>();
        }

        public DateTime SetModifyDate()
        {
            _modifyTime = DateTime.Now;
            return _modifyTime;
        }
        public DateTime ModifyDate => _modifyTime;
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
            if (mail == this.Boss.Mail && password == this.Boss.Password) return _boss;
            else if (_personsList.TryGetValue(mail, out Employee value) && value.Password == password) return value;
            return null;
        }

        public Boss GetBoss()
        {
            if (_boss != null) return _boss;
            _boss = new Boss(this,"default", "boss", "b", "b");
            return _boss;
        }

        public Boss Boss
        {
            get { return _boss; }
            set { _boss = value;
                _modifyTime = DateTime.Now;

            }
        }

        public static Context GetContext()
        {
            if (_ctx != null)
            {
                return _ctx;
            }
            if (File.Exists("-Context.MATe"))
            {

                _ctx = (Context)Serialization.Deserialize();
                return _ctx;
            }
            else
            {
                //_ctx = new Context("test new");
                //Serialization.Serialize(_ctx);
                return _ctx;
            }
        }

        internal void Tester()
        {

        }
    }
    

    public interface IContextAccessor : IDisposable
    {
        Context Context { get; }
    }


    public class ContextManager
    {
        readonly object _lock;
        Context _context;

        class ContextAccessor : IContextAccessor
        {
            readonly ContextManager _m;
            bool _disposed;

            internal ContextAccessor(ContextManager manager)
            {
                _m = manager;
                _m.Lock();
            }
            public Context Context
            {
                get
                {
                    if (_disposed) throw new ObjectDisposedException("ContextAccessor");
                    return _m._context;
                }
            }

            public void Dispose()
            {
                _disposed = true;
                _m.Unlock();
            }
        }

        public ContextManager()
        {
            _lock = new object();
        }

        public void Load(Context ctx)
        {
            Context newC = ctx;

            Lock();
            _context = newC;
            Unlock();
        }

        void Lock()
        {
            Monitor.Enter(_lock);
        }

        void Unlock()
        {
            Monitor.Exit(_lock);
        }

        public IContextAccessor ObtainAccessor()
        {
            return new ContextAccessor(this);
        }

        public void Save(string path)
        {
            Lock();
            try
            {
                //.... POF!!
            }
            finally
            {
                Unlock();
            }
        }
    }

}
