using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class CountVowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            VowelCounter(word);
        }
        public static void VowelCounter(string word)
        {
            string str = word.ToLower();
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                switch(ch)
                {
                    case 'a':aCount++;break;
                    case 'e':eCount++;break;
                    case 'i':iCount++;break;
                    case 'o':oCount++;break;
                    case 'u':uCount++;break;
                }
            }
            Console.WriteLine("Vowel Frequency :");
            Console.WriteLine($"a: {aCount}");
            Console.WriteLine($"e: {eCount}");
            Console.WriteLine($"i: {iCount}");
            Console.WriteLine($"o: {oCount}");
            Console.WriteLine($"u: {uCount}");
        }
    }
}
