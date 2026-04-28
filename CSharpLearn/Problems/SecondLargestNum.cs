using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class SecondLargestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**2nd Largest Number**");
            int[] nums = { 12, 24, 83, 83, 55, 16, 47 };
            SecondLN(nums);
        }
        public static void SecondLN(int[] nums)
        {
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            foreach (int i in set)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            int num = set.ElementAt(set.Count-2);
            Console.WriteLine(num);
        }
    }
}
