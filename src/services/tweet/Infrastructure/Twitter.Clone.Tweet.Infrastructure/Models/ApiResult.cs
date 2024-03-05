namespace Twitter.Clone.Tweet.Infrastructure;

using System.Text.Json;
using System.Text.Json.Serialization;

public class ApiResult<T> : ApiResult
{
    public static ApiResult<T> Success(T? result)
    {
        return new ApiResult<T>
        {
            Data = result,
            Successful = true
        };
    }
 
    public T? Data { get; set; }
}

public class ApiResult
{
    public bool Successful { get; set; }
 
    public ErrorDetails? Error { get; set; }

    public static ApiResult Success()
    {
        return new ApiResult
        {
            Successful = true
        };
    }

    public static ApiResult Fail(string code, string message)
    {
        return new ApiResult
        {
            Error = new ErrorDetails
            {
                ErrorCode = code,
                Message = message
            },
            Successful = false
        };
    } 

    public override string ToString()
    {
        return JsonSerializer.Serialize(this,
            new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });
    }
}

public class ErrorDetails
{ 
    public string? ErrorCode { get; set; } 
    public string? Message { get; set; }
}