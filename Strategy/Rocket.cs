using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Rocket : IStrategyAmmo
    {
        public void Activate()
        {
            Console.WriteLine("Shoot by rockets");
        }
    }
}