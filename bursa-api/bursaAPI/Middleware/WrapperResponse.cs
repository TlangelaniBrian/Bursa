using System.Net;
using System.Text.Json.Serialization;

namespace bursaAPI.Middleware
{
    public class WrapperResponse
    {
        #region Properties
        [JsonPropertyName("code")]
        [JsonPropertyOrder(1)]
        public int StatusCode { get; }

        [JsonPropertyName("message")]
        [JsonPropertyOrder(2)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; }

        [JsonPropertyName("result")]
        [JsonPropertyOrder(3)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

        public object? Result { get; set; } = null;
        [JsonPropertyName("source")]
        [JsonPropertyOrder(4)]
        public string Source { get; set; }
        #endregion

        #region Constructors
        public WrapperResponse(string source, HttpStatusCode statusCode, string? message = null, object? result = null)
        {
            StatusCode = (int)statusCode;
            Message = message;
            Result = result;
            Source = source;
        }
        #endregion
    }
}
