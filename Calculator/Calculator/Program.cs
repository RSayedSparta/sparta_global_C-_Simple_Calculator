using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please enter second number:");

            string num2 = Console.ReadLine();

            int ans = Int32.Parse(num1) + Int32.Parse(num2);

            Console.WriteLine(ans);
            Console.Read();

        }
    }
}
