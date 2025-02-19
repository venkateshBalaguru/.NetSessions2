using System.Text.RegularExpressions;

var webAppBuilder = WebApplication.CreateBuilder(args);
var webApp = webAppBuilder.Build();//before build register service

// Configure the path base
//webApp.UsePathBase("/basepath");

//webApp.MapGet("/", () => "Hello World!");//minimal code
//function oriented or class oriented we use now we using lamda function bcoz minimal colde
webApp.MapGet("/", () => 
{
    Console.WriteLine("http request came ");
    return new { CompanyName = "RRD", Location = "Chennai" };
});//multiline code

webApp.MapGet("/howdy", () =>
{
    Console.WriteLine("This is for check howdy");
    return "Hi welcome to RRD....";
});


webApp.MapGet("/students", () =>
{
    var students = new[]
    {
                new { Name = "Venkatesh",Id = 10571, Bgroup = "AB+" },
                new { Name = "Akhilesh",Id = 10254, Bgroup = "A+" },
                new { Name = "Sachin", Id = 5421, Bgroup = "O+"}
    };
    return students;
});

webApp.Run();//before the run register middleware
