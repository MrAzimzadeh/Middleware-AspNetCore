using System.Diagnostics.CodeAnalysis;

namespace Middleware_AspNetCore.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //custom 
            Console.WriteLine("Hello0000000 ............ ");
            await _next.Invoke(httpContext);
            Console.WriteLine("Byeeeeee  ............ ");

        }

    }
}
