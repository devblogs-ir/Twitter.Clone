using System.Net;
using Microsoft.AspNetCore.Http;

namespace Twitter.Clone.Tweet.Infrastructure.Middlewares;

public class ExceptionMiddleware(RequestDelegate _next)
{
    public async Task InvokeAsync(HttpContext _httpContext)
    {
        try
        { 
            await _next(_httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(_httpContext, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        var errorMessage = "Something went wrong"; 
        var response = ApiResult.Fail("100", errorMessage).ToString();
        return context.Response.WriteAsync(response);
    }
}