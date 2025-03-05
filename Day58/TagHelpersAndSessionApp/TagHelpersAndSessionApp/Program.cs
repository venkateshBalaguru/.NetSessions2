var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
var app = builder.Build();

app.UseSession();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=session}/{action=index}/{id?}");
//app.MapGet("/", () => "Hello World!");


app.Run();
