using SDA_DependencyInjection.BusinessLayer.Interfaces;
using SDA_DependencyInjection.BusinessLayer.Services;
using SDA_DependencyInjection.DataLayer.Interfaces;
using SDA_DependencyInjection.DataLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection

//Inject Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

//Inject Services
builder.Services.AddScoped<IUserService, UserService>();


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
