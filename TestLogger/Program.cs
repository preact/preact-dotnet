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
            if (System.Configuration.ConfigurationManager.AppSettings["LessNeglectProjectCode"] == "RMso4Te6Atof")
            {
                Console.WriteLine("-------------\r\nNOTE: You should update the App.config to use your own code and key\r\n-------------\r\n");
            }

            var u = new UserInfo()
            {
                FullName = "Christopher Gooley",
                Email = "gooley@lessneglect.com",
                Username = "cgooley",

                AccountId = "1234",
                AccountName = "Account 1234",

                DateCreated = new DateTime(2012,5,1,13,5,22)
            };

            Neglect.LogEvent(u, "tester-launched");
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
