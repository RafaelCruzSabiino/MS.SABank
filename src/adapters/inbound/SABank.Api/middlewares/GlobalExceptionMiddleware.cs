using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SABank.Interfaces.Outbound;
using System.Text.Json;

namespace SABank.Api.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next)
            => _next = next;

        public async Task Invoke(HttpContext httpContext, ILoggerAdapter<GlobalExceptionMiddleware> logger)
        {
            try
            {
                await _next(httpContext);
            }
            //catch (NaoEncontradoException ex)
            //{
            //    logger.LogError(ex, ex.Message);
            //    httpContext.Response.ContentType = "application/json; charset=utf-8";
            //    httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            //    await httpContext.Response.WriteAsync(
            //        SetErrorResponseBody(StatusCodes.Status404NotFound, ex, httpContext));
            //}            
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                httpContext.Response.ContentType = "application/json; charset=utf-8";
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsync(
                    SetErrorResponseBody(StatusCodes.Status500InternalServerError, ex, httpContext));
            }
        }

        private static string SetErrorResponseBody(int statusCode, Exception ex, HttpContext httpContext)
        {
            ProblemDetails problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Detail = ex.Message,
                Instance = httpContext.Request.GetEncodedPathAndQuery()
            };

            return JsonSerializer.Serialize(problemDetails);
        }
    }
}
