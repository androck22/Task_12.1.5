using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Login
    {
        public delegate void AdsDelegate();
        public event AdsDelegate AdsEvent;

        public void Greetings(User user)
        {
            Console.WriteLine($"{user.Name}, добро пожаловать!"); 
        }

        public void IsPremium(User user)
        {
            if (user.IsPremium)
            {
                Console.WriteLine("");
            }
            else
            {
                AdsEvent.Invoke();
            }
        }
    }
}
