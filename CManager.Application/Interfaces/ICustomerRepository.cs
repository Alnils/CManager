using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Interfaces
{
    public interface ICustomerRepository : 
        IAdd<IEnumerable<Customer>, CustomerResult>,
        IGet<IEnumerable<Customer>, CustomerObjectResult<Customer>>,
        IGetById<string, CustomerObjectResult<Customer>>,
        IGetByEmail<string, CustomerObjectResult<Customer>>,
        IExists<Customer, bool>
    {

    }
}
