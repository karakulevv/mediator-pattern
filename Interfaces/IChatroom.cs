using MediatorPattern.Models;

namespace MediatorPattern.Interfaces;

// Mediator Interface
interface IChatroom
{
    void SendMessage(string message, Participant sender);
}