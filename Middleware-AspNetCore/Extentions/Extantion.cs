using Middleware_AspNetCore.Middlewares;

namespace Middleware_AspNetCore.Extentions
{
    static public class Extantion
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
