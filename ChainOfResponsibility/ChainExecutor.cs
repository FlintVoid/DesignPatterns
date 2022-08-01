namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public class ChainExecutor : Modifier
    {
        public override Creature Handle(Creature creature)
        {
            var nextModifier = Next;
            while (nextModifier != null)
            {
                creature = nextModifier.Handle(creature);
                nextModifier = nextModifier.Next;
            }

            return creature;
        }
    }
}