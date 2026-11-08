namespace _14_Middlewares.Middlewares
{
    public static class RequestLoggingMiddlewareExtension
    {
        /* Extension Method:app.UseMiddleware<RequestLoggingMiddleware>(); yerine okulaklı bir app.RequestLogging yapısını 
         * Sunar Framework'teki UseRouting usesession vb de aynı kalıpla yazılmıştır.
         */
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggingMiddleware>();
        }
    }
}
