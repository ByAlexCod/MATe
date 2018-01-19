using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;

namespace MATeUI
{
    class UIUseSyncer : IUseNetwork
    {
        public bool IsNewSync()
        {
        
            return Network.SyncerReceiver._newReceive;
        }
    }
}
