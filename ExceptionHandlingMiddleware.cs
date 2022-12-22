using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

       
        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
                _logger.LogError(ex.Message);
            }
        }
        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            // This is nothing but switch case and assign response.StatusCode value
            response.StatusCode = exception switch
            {
                 //ItemNotFoundException _ =>(int)HttpStatusCode.NotFound,
                ValidationException _ => (int)HttpStatusCode.BadRequest,
                _ => (int)HttpStatusCode.InternalServerError,// default unhandled error
            };

            return response.WriteAsync(JsonSerializer.Serialize(new ErrorResponseModel(exception)));
        }
    }
}