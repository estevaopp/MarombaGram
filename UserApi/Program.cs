using UserApi.Data;
using Microsoft.EntityFrameworkCore;
using UserApi.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("UserMarombaDb");
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddIdentity<User, Role>
    (
        opt => 
        {
            opt.SignIn.RequireConfirmedEmail = true;
        }
    ).AddEntityFrameworkStores<UserDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
