namespace Cwiczenia9.Middlewares;

public static class DoctorsMiddlewareExtensions
{
    public static IApplicationBuilder UseDoctorsErrorHandling(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<DoctorsExceptionHandlerMiddleware>();
    }
}