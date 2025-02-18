var webAppBuilder = WebApplication.CreateBuilder(args);
var webApp = webAppBuilder.Build();//before build register service

//webApp.MapGet("/", () => "Hello World!");//minimal code

webApp.MapGet("/", () => {

    Console.WriteLine("http request came ");
    return new { CompanyName = "RRD", Location = "Chennai" };
});//multiline code

webApp.Run();//before the run register middleware
