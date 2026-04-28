using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for multiplication table: ");
            int num = int.Parse(Console.ReadLine());
            MultiplicationTab(num);
        }
        public static void MultiplicationTab(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} {"X"} {i} = {num * i}");
            }
        }
    }
}
