using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Domain.Models;

public sealed class CustomerObjectResult<T>(bool success, string message, T? data) : CustomerResult(success, message)
{
    public T? Result { get; set; } = data;
}
