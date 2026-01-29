using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Interfaces
{
    public interface ICustomerRepository : 
        IAdd<Customer, CustomerResult>,
        IGet<Customer, CustomerObjectResult<Customer>>,
        IGetById<string, CustomerObjectResult<Customer>>,
        IGetByEmail<string, CustomerObjectResult<Customer>>,
        IExists<Customer, bool>
    {

    }
}
