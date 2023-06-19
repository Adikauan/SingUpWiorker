using MassTransit.SingUp.Worker.Application.Models;

namespace MassTransit.SingUp.Application.IntegrationEvents.Interfaces
{
    public interface IUserCreatedEvent
    {
        Guid TransactId { get; set; }
        UserModel? Payload { get; set; }
    }
}
