using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
