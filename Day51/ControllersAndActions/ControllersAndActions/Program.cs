namespace ControllersAndActions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();
            //app.MapControllerRoute(name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{myid?}"
            app.MapControllerRoute(name: "default",
         pattern: "{controller=Customer}/{action=index}/{myid?}"

      );

            app.Run();
        }
    }
}
//void Foo(string firstname,string lastName,string location="") { 

//}

//Foo(lastName: "hello lastname", firstname: "my lastName");