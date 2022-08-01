using System;

namespace DesignPatterns.Behavioral.ChainOfCommand
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);
      
            var root = new ChainExecutor();

            root.Add(new NoBonusesModifier());
            root.Add(new DoubleAttackModifier());
            root.Add(new IncreaseDefenseModifier());

            // eventually...
            goblin = root.Handle(goblin);
            Console.WriteLine("Finally " + goblin);
        }
    }
}