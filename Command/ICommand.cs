namespace DesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}