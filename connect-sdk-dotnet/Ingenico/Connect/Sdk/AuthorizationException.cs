using System.Collections.Generic;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the GlobalCollect platform when authorization failed.
    /// </summary>
    public class ValidationException : ApiException
    {

        public ValidationException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the GlobalCollect platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ValidationException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
