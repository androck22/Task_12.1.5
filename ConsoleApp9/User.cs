using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class User
    {
        public string Login { get; private set; }
        public string Name { get; private set; }
        public bool IsPremium { get; private set; }

        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        
    }
}
