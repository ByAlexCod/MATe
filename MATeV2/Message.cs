using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATeV2
{
    internal class Message
    {
        readonly string _text;
        readonly Person _sender;
        readonly Person _receiver;
        readonly Conversation _conversation;

        Message(Conversation conversation, string text, Person sender, Person receiver)
        {
            _text = text;
            _sender = sender;
            _receiver = receiver;
            _conversation = conversation;
        }

        public string Text => _text;
        public Person Sender => _sender;
        public Person Receiver => _receiver;
        public Conversation Conversation => _conversation;
    }
}
