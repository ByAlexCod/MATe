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
    public class ContextManager
    {
        readonly object _lock;
        readonly string _companyName;
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

        public ContextManager( string companyName, bool withNewContext = false )
        {
            if (string.IsNullOrWhiteSpace(companyName)) throw new ArgumentNullException(nameof(companyName));
            _companyName = companyName;
            if (withNewContext)
            {
                _context = new Context(_companyName);
            }
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
            if (!File.Exists(path)) return LoadContextResult.InvalidPath;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    Context loaded = null;
                    try
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        loaded = (Context)bf.Deserialize(fs);
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

    }

}
