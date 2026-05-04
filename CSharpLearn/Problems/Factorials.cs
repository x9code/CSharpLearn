using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class Factorials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num =  int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorials(num));
        }
        public static int FindFactorials(int num)
        {

            if(num < 0)
            {
                Console.WriteLine("Can't find factorial for negative integer");
            }
            int result = 1;
             for (int i = 2; i <= num; i++)
             {
                 result *= i;
             }
            return result;
        }
    }
}
