using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Anagram**");
            Console.WriteLine("Enter the 1st word");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd word");
            string str2 = Console.ReadLine();
            CheckAnagram(str1, str2);
        }
        public static void CheckAnagram(string str1, string str2)
        {
            //char[] chars1 = str1.ToCharArray();
            //char[] chars2 = str2.ToCharArray();
            SortedSet<char> set1 = new SortedSet<char>(str1);
            //we can write like this it will 
            /*
               Iterate through each character of the string
               Add them into the set
               Automatically remove duplicates
               Store them in sorted order
             */
            SortedSet<char> set2 = new SortedSet<char>(str2);
            string result1 = string.Join("", set1);
            string result2 = string.Join("", set2);
            if (result1.Equals(result2))//we can also write SetEquals() to compare then no need for above 2 lines
            {
                Console.WriteLine("it's anagram");
            }
            else
            {
                Console.WriteLine("it's not anagram");
            }
        }
    }
}
