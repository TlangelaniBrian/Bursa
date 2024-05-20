using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace bursaAPI.Middleware
{
    public abstract class ResponseCreation
    {
        internal static WrapperResponse CreateInternalServerErrorResponse(string source, string message,
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError)
        {
            return new WrapperResponse(source, httpStatusCode, message);
        }

        internal static WrapperResponse CreateNotFoundErrorResponse(string source, string message,
            HttpStatusCode httpStatusCode = HttpStatusCode.NotFound)
        {
            return new WrapperResponse(source, httpStatusCode, message);
        }

        internal static WrapperResponse CreateErrorResponse(string source, string message,
            HttpStatusCode httpStatusCode = HttpStatusCode.BadRequest)
        {
            return new WrapperResponse(source, httpStatusCode, message);
        }

        internal static WrapperResponse CreateSuccessResponse(string source, object result, string? message = null,
            HttpStatusCode httpStatusCode = HttpStatusCode.OK)
        {
            return new WrapperResponse(source, httpStatusCode, message, result);
        }

        internal static WrapperResponse CreateNoContentResponse(string source, object result, string? message = null,
            HttpStatusCode httpStatusCode = HttpStatusCode.NoContent)
        {
            return new WrapperResponse(source, httpStatusCode, message, result);
        }

        internal static WrapperResponse CreateSuccessfulCreatedResponse(string source, object result,
            string? message = null, HttpStatusCode httpStatusCode = HttpStatusCode.Created)
        {
            return new WrapperResponse(source, httpStatusCode, message, result);
        }

        internal static WrapperResponse CreateUnauthorizedResponse(string source, string message,
            HttpStatusCode httpStatusCode = HttpStatusCode.Unauthorized)
        {
            return new WrapperResponse(source, httpStatusCode, message);
        }

        internal static WrapperResponse CreateRateLimitResponse(string source, string message, HttpStatusCode httpStatusCode = HttpStatusCode.TooManyRequests)
        {
            return new WrapperResponse(source, httpStatusCode, message);
        }
    }
}
