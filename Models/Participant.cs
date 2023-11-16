using MediatorPattern.Interfaces;

namespace MediatorPattern.Models
{
    // Colleague Objects
    class Participant
    {
        private readonly IChatroom chatroom;

        public string Name { get; }

        public Participant(string name, IChatroom chatroom)
        {
            Name = name;
            this.chatroom = chatroom;
        }

        public void Send(string message)
        {
            chatroom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} received: {message}");
        }
    }
}