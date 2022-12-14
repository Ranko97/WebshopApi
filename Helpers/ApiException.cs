using System.Runtime.Serialization;

namespace Webshop.Helpers;

class ApiException : Exception
{
    public ApiException()
    {
    }

    public ApiException(string? message) : base(message)
    {
    }

    public ApiException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}