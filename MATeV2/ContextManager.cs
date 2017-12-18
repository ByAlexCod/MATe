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
    public class ContextAndUserManager
    {
        readonly object _lock;
        readonly string _companyName;
        Context _context;
        Person _currentUser;
        string _mail;
        public ContextAndUserManager(string mail)
        {
            _mail = mail;
            _lock = new object();
        }

        class ContextAccessor : IContextAccessor
        {
            readonly ContextAndUserManager _m;
            bool _disposed;

            internal ContextAccessor(ContextAndUserManager manager)
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

        public ContextAndUserManager( string companyName, bool withNewContext = false )
        {
            if (string.IsNullOrWhiteSpace(companyName)) throw new ArgumentNullException(nameof(companyName));
            _companyName = companyName;
            if (withNewContext)
            {
                _context = new Context(_companyName);
            }
            _lock = new object();
        }

        public Person CurrentUser
        {
            get { return _currentUser; }
        }

        public IContextAccessor ObtainAccessor()
        {
            return new ContextAccessor(this);
        }
        

        public string CompanyName => _companyName;

        public string Path { get; private set; }

        public bool IsContextAvailable => _context != null;

        public LoadContextResult Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException(nameof(path));
            if (!File.Exists(path))
            {
                return LoadContextResult.InvalidPath;
            }
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    Context loaded = null;
                    try
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        loaded = (Context)bf.Deserialize(fs);
                        _context = loaded;
                    }
                    catch
                    {
                        return LoadContextResult.UnableToReadContext;
                    }
                    if (loaded.CompanyName != _companyName)
                    {
                        return LoadContextResult.CompanyNameMismatch;
                    }
                    Lock();
                    try
                    {
                        _context = loaded;
                        Path = path;
                        return LoadContextResult.Success;
                    }
                    finally
                    {
                        Unlock();
                    }
                }
            }
            catch
            {
                return LoadContextResult.UnableToOpenFile;
            }
        }

        public void Save() => SaveAs(Path);

        public void SaveAs(string path)
        {
            Lock();
            try
            {
                if (_context == null) throw new InvalidOperationException( "Context is not available." );
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, _context);
                    if (Path == null) Path = path;
                }
            }
            finally
            {
                Unlock();
            }
        }



        void Lock()
        {
            Monitor.Enter(_lock);

        }

        void Unlock()
        {
            Monitor.Exit(_lock);
        }

        public bool Login(string mail)
        {
            if (_context == null)
            {


                throw new ArgumentNullException("Context cannot be null.", nameof(_context));
            }
            if (_context.Login(mail) == null) return false;
            else
            {
                _currentUser = _context.Login(mail);
                return true;
            }
        }

        private void RequestContext()
        {

        }
    }

}
