using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class CommonPrefix
    {
        static void Main(string[] args)
        {
            string[] str = ["flower", "flow", "flight"];
            string newstr =  LongestCommonPrefix(str);
            Console.WriteLine(newstr);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string newstr = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = i; j < strs[1].Length; j++)
                {
                    for (int k = i; k < strs[2].Length; k++)
                    {
                        if (strs[0][i] == strs[1][j] && strs[0][i] == strs[2][k])
                        {
                            newstr+=strs[0][i];
                        }
                        break;
                    }
                    break;
                }
            }
            return newstr;
        }
    }
}
