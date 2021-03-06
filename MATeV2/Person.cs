﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        readonly string _mail;
        string _ipString;
        IPAddress _ip;
        readonly Dictionary<Person, Conversation> _conversationsDictionary;

        public Person(Context c, string firstname, string lastname, string mail)
        {
            _ctx = c;
            _firstname = firstname;
            _lastname = lastname;
            _mail = mail;
            _conversationsDictionary = new Dictionary<Person, Conversation>();
        }
        public Dictionary<Person, Conversation> ConversationDictionary => _conversationsDictionary;
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    _ctx.SetDirty();
                }
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string Mail
        {
            get { return _mail; }
        }
        public string IPString
        {
            get { return _ipString; }
            set
            {
                _ipString = value;
                IP = IPAddress.Parse(value);
            }
        }

        public IPAddress IP
        {
            get { return _ip; }
            set { _ip = value; _ctx.SetDirty(); }
        }
        public Context Context
        {
            get { return _ctx; }
        }
            
      
        public void ModifyProfile(string firstname, string lastname)
        {
            
            if (firstname != null) _firstname = firstname;
            if (lastname != null) _lastname = lastname;
        }

        public Conversation CreateConversation(Person theOtherOne, int port)
        {
            Conversation conv = new Conversation(this, theOtherOne, port);
            _conversationsDictionary.Add(theOtherOne, conv);
            return conv;
        }

        public override string ToString()
        {
            return Mail;
        }

    }
}
