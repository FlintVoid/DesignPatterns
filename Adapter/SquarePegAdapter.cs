using System;

namespace DesignPatterns.Structural.Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg _squarePeg;
        
        public SquarePegAdapter(SquarePeg squarePeg) : base(Math.Sqrt(2 * Math.Pow(squarePeg.Width, 2)) / 2)
        {
            _squarePeg = squarePeg;
        }
    }
}