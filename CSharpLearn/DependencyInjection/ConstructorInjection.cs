using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.DependencyInjection
{
    public class Hammer
    {
        public void Hit()
        {
            Console.WriteLine("Hammering nails...");
        }
    }
    public class Saw
    {
        public void Cut()
        {
            Console.WriteLine("Cutting wood...");
        }
    }
    public class Carpenter
    {
        private readonly Hammer _hammer;
        private readonly Saw _saw;
        // Constructor Injection
        public Carpenter(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }
        public void Build()
        {
            _saw.Cut();
            _hammer.Hit();
            Console.WriteLine("Building a piece of furniture...");
        }
    }
    internal class ConstructorInjection
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Carpenter carpenter = new Carpenter(hammer, saw);
            carpenter.Build();
        }
    }
}
