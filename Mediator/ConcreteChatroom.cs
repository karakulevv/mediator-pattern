using MediatorPattern.Interfaces;
using MediatorPattern.Models;

namespace MediatorPattern.Mediator
{
    // Concrete Mediator
    class ConcreteChatroom : IChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            participants[participant.Name] = participant;
        }

        public void SendMessage(string message, Participant sender)
        {
            foreach (var participant in participants.Values)
            {
                if (participant != sender)
                {
                    participant.Receive(message);
                }
            }
        }
    }
}