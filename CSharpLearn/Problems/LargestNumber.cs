using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.Problems
{
    internal class LargestNumber
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2, 9 ,7,0,23,34};
            LargestNum(nums);
        }
        public static void LargestNum(int[] nums)
        {
            int large = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                    
                if (nums[i] > large)
                {
                    large = nums[i];
                    
                }
            }
            Console.WriteLine(large);
        }
    }
}
