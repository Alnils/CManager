namespace CManager.Domain.Models;

public abstract class ResponseResult
{
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
}
