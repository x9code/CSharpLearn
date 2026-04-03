using System;
using System.Diagnostics;

namespace CSharpLearn.DebugLogs
{
    internal class DebugMessages
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started");

            // Basic debug message
            Debug.WriteLine("Debug: Application has entered Main method");

            int number = 10;

            // Debug with condition
            Debug.Assert(number > 0, "Number should be greater than zero");

            // Debug with formatted message
            Debug.WriteLine($"Debug: Current value of number = {number}");

            // Simulating a method call
            ProcessData(number);

            Console.WriteLine("Application finished");
        }

        static void ProcessData(int value)
        {
            Debug.WriteLine("Debug: Entered ProcessData method");

            if (value % 2 == 0)
            {
                Debug.WriteLine("Debug: Value is even");
            }
            else
            {
                Debug.WriteLine("Debug: Value is odd");
            }

            Debug.WriteLine("Debug: Exiting ProcessData method");
        }
    }
}