using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.StructsApp
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
        public override string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }
    }
    internal class AboutStructs
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3);
            Console.WriteLine(p1); // Output: Point(X: 2, Y: 3)
            p1.Move(1, -1);
            Console.WriteLine(p1); // Output: Point(X: 3, Y: 2)
            // Structs are value types, so they are copied when assigned
            Point p2 = p1;
            p2.Move(2, 2);
            Console.WriteLine(p1); // Output: Point(X: 3, Y: 2)
            Console.WriteLine(p2); // Output: Point(X: 5, Y: 4)
        }
    }
}
