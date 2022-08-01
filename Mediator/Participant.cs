using System;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Participant
    {
        private IChatRoom _chatroom;
        private string _name;
        // Constructor
        public Participant(string name)
        {
            _name = name;
        }
        // Gets participant name
        public string Name
        {
            get { return _name; }
        }
        // Gets chatroom
        public Chatroom Chatroom
        {
            set { _chatroom = value; }
        }
        // Sends message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }
        // Receives message from given participant
        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}