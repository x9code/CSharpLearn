using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Check if the number is prime or not-");
            Console.WriteLine("Enter the number");

            int num = int.Parse(Console.ReadLine());

            CheckPrime(num);
        }
        public static void CheckPrime(int n)
        {
            
            int count = 0;
            if(n == 0)
            {
                Console.WriteLine("you entered 0 and it is neutral😂");
            }
            for (int i = 1; i<= n; i++)
            {
                if(n % i == 0)
                {
                    count++;
                   
                }
            }
            if( count > 2 )
            {
                Console.WriteLine($"{n} is not a prime number");
            }
            else
            {
                Console.WriteLine($"{n} is a prime number");
            }

        }
    }
}
