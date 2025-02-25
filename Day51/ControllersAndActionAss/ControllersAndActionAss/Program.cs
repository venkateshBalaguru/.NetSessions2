namespace ControllersAndActionAss
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
             pattern: "{controller=home}/{action=index}/{myid?}"

          );

                app.Run();
            }
        }
    }
