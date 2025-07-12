using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Core.Controllers
{
    class BaseController
    {
        public BaseController()
        {
        }
        protected void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
        protected void HandleError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        protected void ValidateModel(object model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model), "Model cannot be null");
            }
        }
        protected void SetResponse<T>(T data, string message = null)
        {
            Console.WriteLine($"Response Data: {data}, Message: {message}");
        }
        protected void SetErrorResponse(string errorMessage)
        {
            Console.WriteLine($"Error Response: {errorMessage}");
        }
        protected void SetNotFoundResponse(string message)
        {
            Console.WriteLine($"Not Found Response: {message}");
        }
        protected void SetBadRequestResponse(string message)
        {
            Console.WriteLine($"Bad Request Response: {message}");
        }
        protected void SetSuccessResponse(string message)
        {
            Console.WriteLine($"Success Response: {message}");
        }
        protected void SetCreatedResponse(string message)
        {
            Console.WriteLine($"Created Response: {message}");
        }
        protected void SetNoContentResponse()
        {
            Console.WriteLine("No Content Response");
        }
        protected void SetUnauthorizedResponse(string message)
        {
            Console.WriteLine($"Unauthorized Response: {message}");
        }
        }
}
