using LoggingAuthCatchMiddilewareWithClassApp.Middlewares;
using Microsoft.AspNetCore.Authentication;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<LoggingAuthCatchMiddilewareWithClassApp.Middlewares.AuthenticationMiddleware>();
app.UseMiddleware<CatchingMiddleware>();

app.MapDefaultControllerRoute();

app.Run();
