using System;
using DesignPatterns.Creational.AbstractFactory.Factory;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Program
    {
        private static IFactory[] _factories = new IFactory[] { new MacFactory(), new WinFactory() };
        public static void Main(string[] args)
        {
            var factory = GetRandomFactory();
            Console.WriteLine(factory.CreateButton().Paint());
            Console.WriteLine(factory.CreateCheckBox().Paint());
        }

        private static IFactory GetRandomFactory()
        {
            return _factories[new Random().Next(0, _factories.Length)];
        }
    }
}