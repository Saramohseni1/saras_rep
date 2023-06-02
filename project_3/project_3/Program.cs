using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the n sequence of the fibonacci sequence you want: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("the " + n + "th sequence of the fibonacci sequence is: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fibonacci(i) + " ");
            }
            
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();

        }

        static int fibonacci(int n) 
        {
            if (n <= 1) ;
                return n;

            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
