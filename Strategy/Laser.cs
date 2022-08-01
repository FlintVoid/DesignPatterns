using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Laser : IStrategyAmmo
    {
        public void Activate()
        {
            Console.WriteLine("Shoot by laser");
        }
    }
}