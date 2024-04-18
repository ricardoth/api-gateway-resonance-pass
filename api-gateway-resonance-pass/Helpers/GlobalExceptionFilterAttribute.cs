namespace gateway_resonance_pass.Api.Helpers
{
    public class GlobalExceptionFilterAttribute : IMiddleware
    {
        private readonly ILogger<GlobalExceptionFilterAttribute> _logger;

        public GlobalExceptionFilterAttribute(ILogger<GlobalExceptionFilterAttribute> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            ErrorResponse error = new()
            {
                StatusCode = (int)HttpStatusCode.InternalServerError, 
                Message = exception.Message
            };

            switch (exception) 
            {
                case EntityAlreadyExistsException entityAlreadyExistsException:
                    error.Message = entityAlreadyExistsException.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case BadRequestException badRequestException:
                    error.Message = badRequestException.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case NotFoundException NotFoundException:   
                    error.Message = NotFoundException.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case ValidationResultException validationResultException:
                    error.Message = validationResultException.Message;
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;


                default:
                    _logger.LogError(exception, "Ha ocurrido un error inesperado en la API Gateway");
                    break;
            }

            error.StatusCode = context.Response.StatusCode;
            await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(error));
        }
    }
}
