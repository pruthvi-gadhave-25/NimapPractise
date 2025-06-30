using Microsoft.AspNetCore.Diagnostics;

namespace EmployeeCrud_Sat
{
    public class GlobalExceptionHandle :IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandle> _logger;
        public GlobalExceptionHandle(ILogger<GlobalExceptionHandle> logger)
        {
            _logger = logger;
        }


        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {

            _logger.LogError(exception, "Unhadled exception ocuured {messgae}", exception.Message);
            httpContext.Response.StatusCode = 500;

            //_logger.Logx
            await httpContext.Response.WriteAsJsonAsync("Error Occured ");

            return true;
        }
    }
}
