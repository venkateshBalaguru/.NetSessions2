var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("MW1-Pre");
    await next();
    Console.WriteLine("MW1-Post");
});
app.Use(async (context, next) =>
{
    Console.WriteLine("MW2-Pre");
    await next();
    Console.WriteLine("MW2-Post");
});



app.MapGet("/howdy", (appbuilder) => { 
    appbuilder.Run
    (" Welcome to howdy");
    });

app.MapGet("/", () => "Hello World!");


app.Run();
