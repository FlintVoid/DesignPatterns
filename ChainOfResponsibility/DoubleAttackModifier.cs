using System;

namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public class DoubleAttackModifier : Modifier
    {
        public override Creature Handle(Creature creature)
        {
            creature.MultiplyDamage(2);
            Console.WriteLine($"Doubling {creature.Name}'s attack");
            Console.WriteLine(creature);
            return creature;
        }
    }
}