var webAppBuilder = WebApplication.CreateBuilder(args);
var webApp = webAppBuilder.Build();//before build register service

//webApp.MapGet("/", () => "Hello World!");//minimal code
//function oriented or class oriented we use now we using lamda function bcoz minimal colde
webApp.MapGet("/", () => {

    Console.WriteLine("http request came ");
    return new { CompanyName = "RRD", Location = "Chennai" };
});//multiline code

webApp.Run();//before the run register middleware
