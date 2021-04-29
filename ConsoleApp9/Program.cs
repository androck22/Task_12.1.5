using System;
using System.Threading;

namespace ConsoleApp9
{
    class Program
    {
        public delegate void UserDelegate(User user);
        public static event UserDelegate UserEvent;

        static void Main(string[] args)
        {
            User tom = new User("11111", "Tom", true);
            User jack = new User("22222", "Jack", false);
            User bob = new User("33333", "Bob", true);

            Login login = new Login();

            UserEvent += login.Greetings;
            UserEvent += login.IsPremium;

            login.AdsEvent += ShowAds;

            UserEvent?.Invoke(tom);
            UserEvent?.Invoke(jack);
            UserEvent?.Invoke(bob);

            Console.ReadLine();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);

            Console.WriteLine();
        }
    }
}
