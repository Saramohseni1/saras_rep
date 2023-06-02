using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("please enter your number:");
            string number = Console.ReadLine();
            num = int.Parse(number);
            num *= 3;
            Console.WriteLine(num);
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
