using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Shield : IStrategyAmmo
    {
        public void Activate()
        {
            Console.WriteLine("Activate shield");
        }
    }
}