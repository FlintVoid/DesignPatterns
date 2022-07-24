using System;

namespace DesignPatterns.Structural.Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            Console.WriteLine(hole.Fits(rpeg));

            var smallSqpeg = new SquarePeg(2);
            var largeSqpeg = new SquarePeg(5);

           // hole.Fits(smallSqpeg); incompatible type
            
            var smallAdapter = new SquarePegAdapter(smallSqpeg);
            var largeAdapter = new SquarePegAdapter(largeSqpeg);
            Console.WriteLine(hole.Fits(smallAdapter));
            Console.WriteLine(hole.Fits(largeAdapter));
        }
    }
}