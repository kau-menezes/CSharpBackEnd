using Microsoft.EntityFrameworkCore;
using Server.Entities;
using Server.Services.Password;
using Server.Services.User;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services
    .AddDbContext<ParaLanchesDBContext>(options => {
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")
        );
    });

builder.Services
    .AddSingleton(builder.Configuration)
    .AddSingleton<IPasswordService, PBKDF2PasswordService>()
    .AddScoped<IUserService, EFUserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

