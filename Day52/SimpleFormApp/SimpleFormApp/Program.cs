var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Customer2}/{action=Register}/{id?}");
//app.MapControllerRoute(name: "default",
//        pattern: "{controller=Customer}/{action=Register}/{id?}");



//app.MapGet("/", () => "Hello World!");

app.Run();
