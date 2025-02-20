using ServicesAndDIApp.Middlewares;
using ServicesAndDIApp.Services;

var builder = WebApplication.CreateBuilder(args);

//DI container
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IRRDEmailService, TwilioEmailService>();
builder.Services.AddSingleton<IRRDEmailService, TwilioEmailService>();


var app = builder.Build();//above build register the sevices

//app.MapGet("/", () => "Hello World!");

app.UseMiddleware<RrdLogAndEmailingService>();
app.MapDefaultControllerRoute();
//{controller}/{action} , /Customer/GetDetails
// {controller=home}/{action=Index}

app.Run();//above run register the middleware
