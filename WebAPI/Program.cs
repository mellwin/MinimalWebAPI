using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Data;
using WebAPI.Endpoints;
using WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddDbContext<ApplicationDataContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddAutoMapper(typeof(Program).Assembly); 

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapEndpoints();
app.Run();