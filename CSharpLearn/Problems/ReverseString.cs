using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            ReverseStr("deepak");
        }
        public static void ReverseStr(string str) {
            string rev = "";
            char[] srr = new char[str.Length];
            char[] chars = str.ToCharArray();
            int a = 0;
            for (int i = chars.Length-1; i >= 0; i--)
            {
                srr[a] = chars[i];
                a++;
            }
            rev = new string(srr);
            Console.WriteLine(rev);
        }
    }
}
