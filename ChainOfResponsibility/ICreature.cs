namespace DesignPatterns.Behavioral.ChainOfCommand
{
    public interface ICreature
    {
        void MultiplyDamage(int multiply);
        void AddDamage(int value);
        void MultiplyHealth(int multiply);
        void AddHealth(int value);
        
        string Name { get; }
    }
}