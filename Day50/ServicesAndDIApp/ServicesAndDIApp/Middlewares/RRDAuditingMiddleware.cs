using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServicesAndDIApp.Services;

namespace ServicesAndDIApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RRDAuditingMiddleware
    {
        private readonly RequestDelegate _next;

        public RRDAuditingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IRRDBlobService blobService)
        {
            Console.WriteLine("I am Auditor Middleware");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RRDAuditingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRRDAuditingMiddleware(this WebApplication builder)
        {
            return builder.UseMiddleware<RRDAuditingMiddleware>();
        }
    }
}
