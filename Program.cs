using MediatorPattern.Mediator;
using MediatorPattern.Models;

namespace MediatorPattern;

class Program
{
    public static void Main(string[] args)
    {
        ConcreteChatroom chatroom = new ConcreteChatroom();

        Participant alice = new Participant("Alice", chatroom);
        Participant bob = new Participant("Bob", chatroom);
        Participant charlie = new Participant("Charlie", chatroom);

        chatroom.Register(alice);
        chatroom.Register(bob);
        chatroom.Register(charlie);

        alice.Send("Hello, everyone!");
        bob.Send("Hey, Alice!");
        charlie.Send("Nice to meet you all!");
    }
}