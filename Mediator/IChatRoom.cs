namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}