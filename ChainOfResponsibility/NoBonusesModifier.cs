using System;

namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public class NoBonusesModifier : Modifier
    {
        public override Creature Handle(Creature creature)
        {
            Console.WriteLine("I cant do anything with it");
            Console.WriteLine(creature);
            return creature;
        }
    }
}