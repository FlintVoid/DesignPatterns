using System;
using DesignPatterns.Creational.AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        private static GUIFactory[] _factories = new GUIFactory[] { new MacFactory(), new WinFactory() };
        public static void Main(string[] args)
        {
            var factory = GetRandomFactory();
            Console.WriteLine(factory.CreateButton().Paint());
            Console.WriteLine(factory.CreateCheckBox().Paint());
        }

        private static GUIFactory GetRandomFactory()
        {
            return _factories[new Random().Next(0, _factories.Length)];
        }
    }
}