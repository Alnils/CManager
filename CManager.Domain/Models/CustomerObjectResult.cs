using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Domain.Models;

public sealed class CustomerObjectResult<T> : CustomerResult
{
    public T? Result { get; set; }
}
