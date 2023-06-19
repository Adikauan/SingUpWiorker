using MassTransit;
using MassTransit.SingUp.Application.IntegrationEvents.Consumers;
using MassTransit.SingUp.Worker.Application.Models;
using MassTransit.SingUp.Worker.Application.Services.UserCreated;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMassTransit(bus =>
{
    bus.AddConsumer<UserCreatedConsumer>();
    bus.UsingRabbitMq((context, cfg) =>
    {
        cfg.ConfigureEndpoints(context);
    });

});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => cfg.AllowNullCollections = true);
builder.Services.AddScoped<IUserCreatedEmailService, UserCreatedEmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
