using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class RemoveDuplicatesFromArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Remove Duplicates**");
            char[] chars = { 'a', 'b', 'c', 'b' };
            Console.WriteLine("chars = { 'a', 'b', 'c', 'b' }");
            Console.Write($"After removal: ");
            RemoveDups(chars);
        }
        public static void RemoveDups(char[] arr)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char c in arr)
            {
                set.Add(c);
            }
            foreach (char c in set)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(set.ToArray());
        }
    }
}
