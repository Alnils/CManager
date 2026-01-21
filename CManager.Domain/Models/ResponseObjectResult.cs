namespace CManager.Domain.Models;

public abstract class ResponseObjectResult<T> : ResponseResult
{
    public T? Result { get; set; }
}
