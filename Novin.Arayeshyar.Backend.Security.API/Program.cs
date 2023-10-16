using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Novin.Arayeshyar.Backend.Core.Entities;
using Novin.Arayeshyar.Backend.infrastructure.Database;
using Novin.Arayeshyar.Backend.Security.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArayeshyarDB>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});
builder.Services.AddCors(m=>m
.AddDefaultPolicy(n=>n
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.MapPost("/adminlogin", (ArayeshyarDB db, LoginRequestDTO login) =>
{
    if (!db.SystemManagers.Any()) 
    {
        var firstadmin = new SystemManager("09182139705" ,"@Moha1368" ,"222" );
        db.SystemManagers.Add(firstadmin);
        db.SaveChanges();
    }
    
    var result=db.SystemManagers
    .Where(m=>m.Password == login.Password && m.Username==login.Username)
    .FirstOrDefault();
    if (result!=null)
    {
        return new
        {
           Isok = true,
            Message = "modir jan salam"
        };

    }
    return new
    {
        Isok = false,
        Message = "bebakhshid shoma"
};
});

app.Run();

