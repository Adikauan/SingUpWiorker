using MassTransit.SingUp.Application.IntegrationEvents.Interfaces;
using MassTransit.SingUp.Worker.Application.Services.UserCreated;

namespace MassTransit.SingUp.Application.IntegrationEvents.Consumers
{
    public class UserCreatedConsumer : IConsumer<IUserCreatedEvent>
    {
        public readonly IUserCreatedEmailService? userCreatedEmailService;

        public UserCreatedConsumer(IUserCreatedEmailService userCreatedEmailService)
        {
            this.userCreatedEmailService = userCreatedEmailService;
        }

        public async Task Consume(ConsumeContext<IUserCreatedEvent> context)
        {
            var user = context.Message;
            await userCreatedEmailService?.SendEmail(user.Payload);
        }
    }
}
