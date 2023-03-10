using WebAppDI.BusinessLayer.Interfaces;
using WebAppDI.BusinessLayer.Services;
using WebAppDI.DataLayer.Interfaces;
using WebAppDI.DataLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Innjection
//Register Services
builder.Services.AddScoped<IPerdoruesService, PerdoruesService>();

//Register Repositories
builder.Services.AddScoped<IPerdoruesRepo, PerdoruesRepo>();

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
