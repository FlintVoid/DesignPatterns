using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public class Chatroom : IChatRoom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();
        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }
        public void Send(string from, string to, string message)
        {
            var participant = _participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}