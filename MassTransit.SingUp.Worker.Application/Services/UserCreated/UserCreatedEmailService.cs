using MassTransit.SingUp.Worker.Application.Models;
using Microsoft.Extensions.Logging;

namespace MassTransit.SingUp.Worker.Application.Services.UserCreated
{
    public class UserCreatedEmailService : IUserCreatedEmailService
    {
        private readonly ILogger<UserCreatedEmailService> logger;

        public UserCreatedEmailService(ILogger<UserCreatedEmailService> logger)
        {
            this.logger = logger;
        }

        public Task SendEmail(UserModel user)
        {
            logger.LogInformation("Envio de email de boas vindas!");
            return Task.CompletedTask;
        }
    }
}
