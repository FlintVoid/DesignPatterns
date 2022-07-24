using System;
using DesignPatterns.Structural.Decorator.Beverage;
using DesignPatterns.Structural.Decorator.Condiment;

namespace DesignPatterns.Structural.Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Beverage.Beverage beverage = new Decaf(BeverageSize.TALL);
            Console.WriteLine(beverage.GetDescription() + " " + beverage.Cost());
            var firstCondiment = new Mocha(beverage);
            Console.WriteLine(firstCondiment.GetDescription() + " " + firstCondiment.Cost());
            var secondCondiment = new Whip(firstCondiment);
            Console.WriteLine(secondCondiment.GetDescription() + " " + secondCondiment.Cost());
        }
    }
}