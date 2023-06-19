using MassTransit.SingUp.Worker.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.SingUp.Worker.Application.Services.UserCreated
{
    public interface IUserCreatedEmailService
    {
        Task SendEmail(UserModel user);
    }
}
