using ServicesAndDIApp.Middlewares;
using ServicesAndDIApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IRRDBlobService, AWSS3BucketBlobService>();

var app = builder.Build();//above build register the sevices

//app.UseMiddleware<RRDAuditingMiddleware>();
app.UseRRDAuditingMiddleware();
app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();//above run register the middleware
