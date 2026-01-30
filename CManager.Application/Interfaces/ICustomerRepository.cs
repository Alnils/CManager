using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Interfaces
{
    public interface ICustomerRepository :
        IAdd<IEnumerable<Customer>, CustomerResult>,
        IGet<Customer, CustomerObjectResult<Customer>>,
        IGetById<string, CustomerObjectResult<Customer>>,
        IGetByEmail<string, CustomerObjectResult<Customer>>,
        IGetAll<CustomerObjectResult<IEnumerable<Customer>>>,
        IExists<Customer, bool>,
        IUpdate<Customer, CustomerResult>,
        IDelete<string, CustomerResult>;
}
