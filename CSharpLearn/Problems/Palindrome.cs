using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Check Plaindrome--");
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            CheckPalindrome(word);
        }
        public static void CheckPalindrome(string sen)
        {
            string sb = new string(sen.Reverse().ToArray());
            if (sb.Equals(sen))
            {
                Console.WriteLine($"{sen} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{sen} is not a palindrome");
            }
        }
    }
}
