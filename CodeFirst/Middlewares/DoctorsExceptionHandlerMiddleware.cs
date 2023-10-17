namespace Cwiczenia9.Middlewares;

public class DoctorsExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public DoctorsExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch(Exception ex)
        {
            httpContext.Response.StatusCode = 500;
            await httpContext. Response.WriteAsync("Unexpected problem!");
        }
    }
}