using System;

namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public class IncreaseDefenseModifier : Modifier
    {
        public override Creature Handle(Creature creature)
        {
            creature.AddHealth(3);
            Console.WriteLine("Increasing goblin's defense");
            Console.WriteLine(creature);
            return creature;
        }
    }
}