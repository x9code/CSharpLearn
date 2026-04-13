using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.ExceptionPrograms
{
    internal class ThrowKeyword
    {
        static void Main(string[] args)
        {
            int num = -6;
            if (num < 0)
            {
                throw new ArgumentException("Code says Number cannot be negative");
            }
        }
    }
}
