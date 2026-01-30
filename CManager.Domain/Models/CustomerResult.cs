namespace CManager.Domain.Models;

public class CustomerResult(bool success, string message)
{
    public bool IsSuccess { get; set; } = success;
    public string? Message { get; set; } = message;
}
