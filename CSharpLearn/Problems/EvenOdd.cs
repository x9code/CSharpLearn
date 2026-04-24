using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            CheckEvenOdd(number);
        }
        public static void CheckEvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"You have entered {n} and it's Even number");
            }
            else
            {
                Console.WriteLine($"You have entered {n} and it's Odd number");
            }
        }
    }
}
