using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServicesAndDIApp.Services;

namespace ServicesAndDIApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RrdLogAndEmailingService
    {
        private readonly RequestDelegate _next;

        public RrdLogAndEmailingService(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IRRDEmailService emailService)
        {
            //pre processing    
            Console.WriteLine("Pre Processing");
            await emailService.SendEmailAsync("admin@rrd", "from Middleware", "sending the email ");
            await _next(httpContext);
            //post processing
            Console.WriteLine("Post Processing");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class MiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RrdLogAndEmailingService>();
    //    }
    //}
}
