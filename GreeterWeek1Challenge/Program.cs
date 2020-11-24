using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterWeek1Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Greeter userInput = new Greeter();

            userInput.HelloThere(name);
            userInput.ByeBye(name);
            userInput.TimeBased(name);
            Console.ReadLine();

        }
    }
}

