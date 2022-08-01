namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public abstract class Modifier
    {
        public Modifier Next { get; private set; }
        
        public abstract Creature Handle(Creature creature);
        public void Add(Modifier cm)
        {
            if (Next != null) Next.Add(cm);
            else Next = cm;
        }
    }
}