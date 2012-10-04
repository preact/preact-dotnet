using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LessNeglect;

namespace TestLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started");

            var u = new UserInfo()
            {
                FullName = "Christopher Gooley",
                Email = "thegooley1@gmail.com",
                Username = "cgooley",
                AccountId = "cool_account",
                AccountName = "Cool Account",
                DateCreated = DateTime.Now
            };

            Neglect.LogEvent(u, "tester-launched", "1234");
            Console.WriteLine("What event would you like to log?\r\n(e.g. uploaded:picture, viewed:publisher, deleted:friend)\r\n");
                
            while (true)
            {
                Console.Write("Event Name: ");
                string eventName = Console.ReadLine();

                if (string.IsNullOrEmpty(eventName)) { break; }

                Neglect.LogEvent(u, eventName);
                Console.WriteLine("logged " + eventName);
            }

        }
    }
}
