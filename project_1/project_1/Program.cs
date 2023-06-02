using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("press any key to continue!");
            Console.ReadKey();
        }
    }
}
