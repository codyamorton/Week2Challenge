using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterWeek1Challenge
{
    class Greeter
    {
        public void HelloThere(string name)
        {
            Console.WriteLine("Hello there, " + name);
        }

        public void ByeBye(string name)
        {
            Console.WriteLine("See ya," + name + ".");
        }

        public void TimeBased(string name)
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)

            {
                Console.WriteLine("Good Morning" + name + ".");
            }

            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
            {
                Console.WriteLine("Good Afternoon" + name + ".");
            }

            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Good Evening" + name + ".");
            }

            else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 24)
            {
                Console.WriteLine("Good Night" + name + ".");
            }
        }
    }
}
