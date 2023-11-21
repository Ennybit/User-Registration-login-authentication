using Authorisation;
using Authorisation.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();  
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Datacontext>(q =>
{
    q.UseSqlServer(builder.Configuration.GetConnectionString("regidter"));
});

builder.Services.AddIdentity<UserRegistration, IdentityRole>()
    .AddEntityFrameworkStores<Datacontext>()
    .AddDefaultTokenProviders();
    
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
