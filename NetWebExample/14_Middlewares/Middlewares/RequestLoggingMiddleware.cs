using System.Diagnostics;

namespace _14_Middlewares.Middlewares
{
    /* Sınıf tabanlı middleware (convertion-based):
     * public Task InvokeAsync(HttpContex context) methodu olmalı 
     * Middleware uygulama boyunca tek nesnedir (singleton gibi) bu yüzden constructor'a sadece singleton servisler
     * (ILogger gibi) verilier:Scoped servisler (Dbcontext) InvokeAsync parametresini olarak kullanılır.
     */
    public class RequestLoggingMiddleware(RequestDelegate next,ILogger<RequestDelegate> logger)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            var start = Stopwatch.GetTimestamp();
            context.Items["MiddlewareMessage"] = $"Middleware çalıştı: {context.Request.Method} {context.Request.Path}";
            //Httpcontext.Items aynı istek için middleware controller arası veri taşımak için kullanacağız.
            await next(context);
            var elapsed = Stopwatch.GetElapsedTime(start);
            logger.LogInformation("{Method} {Path} {StatusCode} {Elapsed:F1} ms",
                context.Request.Method, context.Request.Path, context.Response.StatusCode, elapsed.TotalMilliseconds);
        }
    }
}
