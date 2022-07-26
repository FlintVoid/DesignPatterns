namespace DesignPatterns.BehavioralCommand
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}